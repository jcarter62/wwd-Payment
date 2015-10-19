using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using dataLib;
using classLib;
using Telerik.WinControls.UI;
using System.Xml;
using System.IO;
using System.Reflection;

namespace RcvPayment.ca {
    public partial class Apply : RcvPayment.MyForm {
        private string formTitle = "Un-Applied Payments";
        private string formId = "d32003ba-3f10-49fa-a6de-f71a37c187dc";
        private string XmlMasterFile;
        private bool XmlMasterFileLoaded = false;
        private string XmlDetailFile;
        private bool XmlDetailFileLoaded = false;
        private AppSettings aset;
        private DbClassDataContext dc;

        private int MasterIdCol = 0;
        private int MasterRcptIdCol = 0;
        private int MasterStateCol = 0;

        private string CurrentId = "";
        private RadContextMenu cmenuMaster = null;

        #region Constructor 
        public Apply() {
            InitializeComponent();
            LocalInit();
        }

        private void LocalInit() {
            string companyname = GetCompanyName();
            string appdir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appdirPlusCo = System.IO.Path.Combine(appdir, companyname);

            this.Text = formTitle;
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            if (!Directory.Exists(appdir)) {
                Directory.CreateDirectory(appdir);
            }
            if (!Directory.Exists(appdirPlusCo)) {
                Directory.CreateDirectory(appdirPlusCo);
            }

            XmlMasterFile =
                System.IO.Path.Combine(appdir, companyname, "mastergrid." + formId + ".xml");
            XmlDetailFile =
                System.IO.Path.Combine(appdir, companyname, "detailgrid." + formId + ".xml");

            OpenMasterTable();
            SetupContextMenu();
        }

        private void SetupContextMenu() {
            for (var i = 0; i < cmenu.Items.Count(); i++) {
                string txt = cmenu.Items[i].Text.ToLower().Trim();

                if (txt.Equals("select master record")) {
                    cmenu.Items[i].Click += SelectMasterClick;
                }
                else if (txt.Equals("un-select master record")) {
                    cmenu.Items[i].Click += UnSelectMasterClick;
                }
                else if (txt.Equals("reset grid layout")) {
                    cmenu.Items[i].Click += ResetMasterLayout;
                }
                else if (txt.Equals("mark item as posted")) {
                    cmenu.Items[i].Click += MarkItemAsPosted;
                }
                else if (txt.Equals("refresh")) {
                    cmenu.Items[i].Click += RefreshData;
                    //
                }
            }
        }

        private void RefreshData(object sender, EventArgs e) {
            OpenMasterTable(CurrentId);
        }

        private void MarkItemAsPosted(object sender, EventArgs e) {
            // For Mas500 items, allow user to "post" payment.

            // if only one item is selected, then
            // perform post.
            int ItemsSelected = 0;
            string IdSelected = "";

            ItemsSelected = gridMaster.SelectedRows.Count;
            if (ItemsSelected == 1) {
                IdSelected = gridMaster.SelectedRows[0].Cells[MasterIdCol].Value.ToString();
                string thisReceiptId = "";

                try {
                    IQueryable<CRMaster> qm;
                    IQueryable<CRDetail> qd;
                    qm = (from item in dc.CRMasters
                          where item.Id == IdSelected
                          select item);

                    foreach (CRMaster m in qm) {
                        m.StateAR = "posted";
                        thisReceiptId = m.RcptID.ToString();

                        qd = (from dtem in dc.CRDetails
                              where dtem.CRMid == IdSelected
                              select dtem);
                        foreach (CRDetail d in qd) {
                            d.State = "posted";
                        }
                    }

                    var l = new TblLog();
                    l.tblName = "crmaster";
                    l.tblId = IdSelected;
                    l.txt = "ar post";
                    dc.TblLogs.InsertOnSubmit(l);

                    dc.SubmitChanges();

                    // Now let's try to find 
                    var qnext = (from mst in dc.CRMasters
                                 where
                                   ((mst.RcptID.CompareTo(thisReceiptId) <= 0) &&
                                     ((mst.StateAR == "created") || (mst.StateAR == "selected")))
                                 orderby mst.CDate descending
                                 select mst);
                    foreach (var qr in qnext) {
                        thisReceiptId = qr.Id;
                        break;  // only need to look at one.
                    }
                    UpdateDisplay();

                }
                catch (Exception ex) {
                    string msg = "Error in record update: " + ex.Message + "\n" +
                        "ref:201509161400";
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK);
                }
            }
            else {
                string msg;
                msg = "Please select one row you wish to mark as posted.\n" +
                    "ref:201509161419";
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK);
            }
        }

        private void ResetMasterLayout(object sender, EventArgs e) {
            string msg = "In order for the layout to be reset,\n" +
                "this window must be restarted.  Please open this\n" +
                "window after it closes.";
            if (MessageBox.Show(msg, "Information", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
                try {
                    File.Delete(XmlMasterFile);
                    XmlMasterFile = "";
                    Close();
                }
                finally { }
            }
        }

        private void SelectMasterClick(object sender, EventArgs e) {
            string copyBuffer;
            Clipboard.Clear();

            copyBuffer = "id," + CurrentId;
            try {
                Clipboard.SetText(copyBuffer, TextDataFormat.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            timeCheck_Start();

        }

        // User wishes to un-select a record.
        private void UnSelectMasterClick(object sender, EventArgs e) {
            bool ContinueOp = true;
            int selectedCount = 0;
            string id = "";

            // User clicked Un-Select Master Record.
            // Requirements:
            // Only one record can be un-selected Record.StateAR == "selected"
            // Record is in fact "selected", Record.StateAR == "selected"
            // Count how many CrArMst records for the selected id, and
            // confirm that user wishes to delete those records.
            // 

            selectedCount = gridMaster.SelectedRows.Count;
            if (selectedCount <= 0) {
                ContinueOp = false;
            }

            if (ContinueOp) {
                id = gridMaster.SelectedRows[0].Cells[MasterIdCol].Value.ToString();
                string ReceiptId = RecordIsSelected(id);

                if (ReceiptId.Length > 0) {
                    string msg;
                    msg = "Please confirm you wish to unselect Receipt ID: " + ReceiptId;
                    var answer = MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNoCancel);
                    if (answer != DialogResult.Yes) {
                        ContinueOp = false;
                    }
                }

                int LinkCount = 0;
                LinkCount = CountCrArMstLinks(id);
                if (LinkCount > 0) {
                    string msg;
                    msg = "Unselecting will remove " +
                        LinkCount.ToString() +
                        " links to wmis. Continue with Un-Select?";

                    var answer = MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo);
                    if (answer != DialogResult.Yes) {
                        ContinueOp = false;
                    }
                }
            }

            /*
            At this point, we have verified we have one row selected.
            The row selected is in fact "selected".
            The user has confirmed they wish to un-select
            The user is aware of linked rows that will be deleted.
            */
            if (ContinueOp) {
                var changes = dc.GetChangeSet();
                if (changes.Deletes.Count + changes.Inserts.Count + changes.Updates.Count > 0) {
                    string msg;
                    msg = "Something went wrong, please try again: 201509161023";

                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK);
                    ContinueOp = false;
                }
            }

            if (ContinueOp) {
                try {
                    var recs = from lnks in dc.CrArMsts
                               where lnks.CrMid == id
                               select lnks;

                    dc.CrArMsts.DeleteAllOnSubmit(recs);

                    var crm = (from mst in dc.CRMasters
                               where mst.Id == id
                               select mst).First();

                    if (crm == null) {
                        throw new Exception("Can't find CRMaster Record: 201509161152");
                    }
                    crm.StateAR = "created";
                    dc.SubmitChanges();
                    // Perform refresh.
                    OpenMasterTable(id);

                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message + ":201509161153");
                }
            }
        }

        // Open Master Table & make sure id is visible.
        private void OpenMasterTable(string id) {
            OpenMasterTable();

            // http://www.telerik.com/help/winforms/gridview-rows-iterating-rows.html
            // now find the record with id = id.
            // if found, then make sure it is visible.
            foreach (GridViewRowInfo r in gridMaster.Rows) {
                string rowId = r.Cells[MasterIdCol].Value.ToString();
                if (id == rowId) {
                    r.EnsureVisible();
                    break;
                }
            }
        }

        // Check to see if this CrMaster.id is selected
        // and return RcptID if true.
        private string RecordIsSelected(string id) {
            string result = "";
            try {
                var rec = (from m in dc.CRMasters
                           where ((m.Id == id) && (m.StateAR == "selected"))
                           select m).First();

                if (rec != null) {
                    result = rec.RcptID.ToString();
                }
            }
            catch {

            }

            return result;
        }

        // Return number of CrArMst records for a given
        // CrMaster.id 
        private int CountCrArMstLinks(string id) {
            int result = 0;
            var recs = from lnks in dc.CrArMsts
                       where lnks.CrMid == id
                       select lnks.id;

            if (recs != null) {
                result = recs.Count();
            }
            return result;
        }

        private string GetCompanyName() {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyCompanyAttribute assemblyCompany = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0] as AssemblyCompanyAttribute;
            return assemblyCompany.Company;
        }
        #endregion

        #region Periodic Refresh of Grid.

        string initialTimeCheckHash = "";

        private void timeCheck_Start() {
            initialTimeCheckHash = calculateHash();
            timeCheck.Enabled = true;
        }

        private void timeCheck_Stop() {
            timeCheck.Enabled = false;
        }

        private string calculateHash() {
            string records;
            string hashnow;
            var r =
            from m in dc.CRMasters
            from d in dc.CRDetails.Where(d => (m.Id == d.CRMid)).DefaultIfEmpty()
            where (m.StateRcv == "posted") && (m.StateAR != "posted")
            orderby m.Id ascending, d.Id ascending
            select new {
                masterid = m.Id,
                m.StateAR,
                detailid = d.Id,
                d.State
            };

            records = "";
            foreach (var rec in r) {
                records = records +
                    rec.masterid +
                    rec.StateAR +
                    rec.detailid +
                    rec.State;
            }

            r = null;

            hashnow = records.GetHashCode().ToString();
            return hashnow;
        }

        #endregion


        private void OpenMasterTable() {

            // Load layout for user if not loaded.
            if (!XmlMasterFileLoaded) {
                try {
                    if (File.Exists(XmlMasterFile)) {
                        gridMaster.LoadLayout(XmlMasterFile);
                        XmlMasterFileLoaded = true;
                    }
                }
                finally {
                    // do nothing.
                }
            }

            var mst =
            from pmt in dc.CRMasters
            where (pmt.StateRcv == "posted") && (pmt.StateAR != "posted")
            orderby pmt.CDate descending
            select new {
                pmt.CDate,
                pmt.DeliveryName,
                pmt.PayRef,
                pmt.Amount,
                pmt.RcptID,
                pmt.CUser,
                pmt.Postmark,
                pmt.Note,
                pmt.StateAR,
                pmt.StateRcv,
                pmt.Id
            };

            gridMaster.DataSource = mst;
        }

        private void Apply_FormClosing(object sender, FormClosingEventArgs e) {
            SaveLayouts();
        }

        private void SaveLayouts() {
            if (XmlMasterFile.Length > 0) {
                gridMaster.SaveLayout(XmlMasterFile);
            }

            if (XmlDetailFile.Length > 0) {
                gridDetail.SaveLayout(XmlDetailFile);
            }

        }

        private void gridMaster_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e) {
            // 
            try {
                CurrentId = "";
                string msg = "";

                if (gridMaster.DataSource != null) {
                    if (gridMaster.RowCount > 0) {
                        if ((e.CurrentRow != null) && (e.CurrentRow.Index >= 0)) {
                            CurrentId = e.CurrentRow.Cells[MasterIdCol].Value.ToString();
                            msg = "Id: " + CurrentId +
                                ", Receipt ID:" +
                                e.CurrentRow.Cells[MasterRcptIdCol].Value.ToString();
                        }
                    }
                }
                statLabel.Text = msg;
                lblMaster.Text = MasterLabel(CurrentId);
                lblDetail.Text = DetailLabel(CurrentId);

                DisplayDetailRecords(CurrentId);
                if (CurrentId.Length > 0) {
                    UpdateLogWindow(CurrentId);
                    UpdatePaymentDetails(CurrentId);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n(ref: 2015091801)");
            }
        }

        private string DetailLabel(string id) {
            string result = "";

            foreach (GridViewRowInfo r in gridMaster.Rows) {
                string rowId = r.Cells[MasterIdCol].Value.ToString();
                string recId = r.Cells[MasterRcptIdCol].Value.ToString();
                if (id == rowId) {
                    result = "Payment Detail Records for:" +
                        recId +
                        ".";
                    break;
                }
            }
            return result;
        }

        private string MasterLabel(string id) {
            string result = "";

            foreach (GridViewRowInfo r in gridMaster.Rows) {
                string rowId = r.Cells[MasterIdCol].Value.ToString();
                string recId = r.Cells[MasterRcptIdCol].Value.ToString();
                if (id == rowId) {
                    result = "Receipt:" +
                        recId +
                        " Selected.";
                    break;
                }
            }
            return result;
        }

        private void UpdatePaymentDetails(string currentId) {
            Control c = this.ActiveControl;
            string fname = "paymentdetails";
            Form f = null;

            if (isFormOpen(fname)) {
                GetFormPtr(fname, ref f);
                if (f != null) {
                    (f as PaymentDetails).Id = currentId;
                }
                this.BringToFront();
            }
            this.ActiveControl = c;
        }

        private void DisplayDetailRecords(string currentId) {
            var dtl =
            from crd in dc.CRDetails
            where (crd.CRMid == currentId)
            orderby crd.Account, crd.Amount
            select new {
                crd.Type,
                crd.Account,
                crd.Amount,
                crd.Name,
                crd.Note
            };

            gridDetail.DataSource = dtl;

            // Load layout for user.
            if (!XmlDetailFileLoaded) {
                try {
                    if (File.Exists(XmlDetailFile)) {
                        gridDetail.LoadLayout(XmlDetailFile);
                        XmlDetailFileLoaded = true;
                    }
                }
                finally {
                    // do nothing.
                }
            }
        }

        private void UpdateLogWindow(string currID) {
            Form f = null;

            GetFormPtr("logview", ref f);
            if (f != null) {
                misc.LogView lf = f as misc.LogView;
                lf.Id = currID;
            }
        }

        private void UpdateDisplay() {
            OpenMasterTable();
            timeCheck_Start();
        }

        private bool recordsChanged() {
            string hashnow;
            bool result;

            result = false;
            hashnow = calculateHash();
            if (hashnow.CompareTo(initialTimeCheckHash) != 0) {
                timeCheck.Enabled = false;
                result = true;
            }
            return result;
        }
        private void timeCheck_Tick(object sender, EventArgs e) {
            // Check to see if the current record states have changed.
            if (recordsChanged()) {
                UpdateDisplay();
            }

            int curval = rpb.Value1 + 1;
            if (curval > 10) curval = 1;
            rpb.Value1 = curval;
        }

        private void gridMaster_LayoutLoaded(object sender, LayoutLoadedEventArgs e) {
            // figure out where the columns are.
            MasterIdCol = 0;
            MasterRcptIdCol = 0;
            MasterStateCol = 0;
            for (int i = 0; i < gridMaster.ColumnCount; i++) {
                string cname = gridMaster.Columns[i].FieldName.ToLower();
                if (cname.CompareTo("id") == 0) {
                    MasterIdCol = i;
                }
                else if (cname.CompareTo("rcptid") == 0) {
                    MasterRcptIdCol = i;
                }
                else if (cname.CompareTo("statear") == 0) {
                    MasterStateCol = i;
                }
            }

            // conditional formatting for "selected" rows
            ConditionalFormattingObject obj =
                new ConditionalFormattingObject("MyCondition",
                ConditionTypes.Contains, "selected", "", true);
            obj.RowBackColor = Color.Bisque;
            gridMaster.Columns[MasterStateCol].ConditionalFormattingObjectList.Add(obj);

            // Add summary
            // Ref:
            // http://www.telerik.com/help/winforms/gridview-rows-summary-rows.html
            //
            GridViewSummaryItem RcptIDItem = new GridViewSummaryItem();
            RcptIDItem.Name = "RcptID";
            RcptIDItem.Aggregate = GridAggregateFunction.Count;

            GridViewSummaryItem AmountItem = new GridViewSummaryItem();
            AmountItem.Name = "Amount";
            AmountItem.FormatString = "{0:C}";
            AmountItem.Aggregate = GridAggregateFunction.Sum;

            // Now add the summary at bottom.
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem(
                new GridViewSummaryItem[] { RcptIDItem, AmountItem });
            gridMaster.SummaryRowsBottom.Clear();
            gridMaster.SummaryRowsBottom.Add(summaryRowItem);
        }
    }
}
