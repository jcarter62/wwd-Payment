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

            this.Text = formTitle;
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
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
            copyBuffer = "id," + CurrentId;
            Clipboard.Clear();
            Clipboard.SetText(copyBuffer);

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
                    OpenMasterTable();
                    // Find this record again.


                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message + ":201509161153");
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

            //            gridMaster.DataSource = null;
            //            gridMaster.Rows.Clear();

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

            // Load layout for user.
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
                        if (e.CurrentRow != null) {
                            CurrentId = e.CurrentRow.Cells[MasterIdCol].Value.ToString();
                            msg = "Id: " + CurrentId +
                                ", Receipt ID:" +
                                e.CurrentRow.Cells[MasterRcptIdCol].Value.ToString();
                        }
                    }
                }
                statLabel.Text = msg;

                if (CurrentId.Length > 0) {
                    DisplayDetailRecords(CurrentId);
                    UpdateLogWindow(CurrentId);
                    UpdatePaymentDetails(CurrentId);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n(ref: 2015091801)");
            }
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
    }
}
