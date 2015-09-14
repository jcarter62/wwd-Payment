using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using classLib;
using dataLib;
using System.Globalization;

namespace RcvPayment {

    public partial class NewPayment : RcvPayment.MyForm {

        #region Properties
        Images statusImages;
        private string currentID;
        private string currentDetailID;
        private bool WeCanPostItem = false;
        private AppSettings aset;
        private DbClassDataContext dc;

        private double _AppliedAmount;
        private string _AppliedAmountMessage;

        private double paymentAmount;
        private double unAppliedAmount;
        private double AppliedAmount {
            get {
                return _AppliedAmount;
            }
            set {
                _AppliedAmount = value;

                // Update the graphic to right side.
                UpdateAppliedGraphic();
            }
        }

        private int itemsGridIdCol = 0;
        private bool PaymentPosted = false;

        // Update graphic, and message to left.
        private void UpdateAppliedGraphic() {
            Image i;

            WeCanPostItem = false;
            if (Math.Abs(_AppliedAmount) < 0.001) {
                lblAppliedAmount.Text = "-- UnApplied --";
                WeCanPostItem = true;
            }
            else {
                string msg;
                bool isApplied = false;

                isApplied = (Math.Abs(unAppliedAmount) < 0.01);

                if (isApplied) {
                    msg = "Applied.";
                    i = Image.FromFile(statusImages.successImage);
                    WeCanPostItem = true;
                }
                else {
                    if (unAppliedAmount < 0.00) {
                        msg = string.Format("Over Applied by {0}", (-1.0 * unAppliedAmount).ToString("C"));
                    }
                    else {
                        msg = string.Format("Under Applied by {0}", unAppliedAmount.ToString("C"));
                    }
                    i = Image.FromFile(statusImages.failImage);
                }

                _AppliedAmountMessage = msg;
                lblAppliedAmount.Text = _AppliedAmountMessage;
                lblAppliedChk.Image = i;

            }
        }

        public string ItemAccount {
            set {
                txtItmAcct.Text = value;
            }
        }

        public string ItemName {
            set {
                txtItmName.Text = value;
            }
        }
        #endregion

        #region Constructors
        public NewPayment() {
            InitializeComponent();
            statusImages = new Images();
            currentID = "";
            currentDetailID = "";
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            statUpdate("");
        }
        #endregion

        #region Misc
        private void statUpdate(String msg) {
            statLbl.Text = msg;
        }

        private void loadDetail(String id) {
            if (id.Length <= 0) {
                txtReceiptId.Text = "";
                txtTimeStamp.Text = "";
                txtRecBy.Text = "";
                txtRecFrom.Text = "";
                cbPayType.Text = "";
                txtRef.Text = "";
                cbVia.Text = "";
                txtNote.Text = "";
                txtAmount.Text = "";
                txtPM.Text = "";
                panelDetail.Start(btnSavePayment);
            }
            else {
                try {
                    var q = (from item in dc.CRMasters
                             where item.Id == id
                             select item).First();

                    txtReceiptId.Text = q.RcptID;
                    txtTimeStamp.Text = q.CDate.ToString();
                    txtRecBy.Text = q.CUser;
                    txtRecFrom.Text = q.DeliveryName;
                    cbPayType.Text = q.PayType;
                    txtRef.Text = q.PayRef;
                    cbVia.Text = q.PayVia;
                    txtNote.Text = q.Note;
                    txtAmount.Text = q.Amount.Value.ToString("C");
                    paymentAmount = q.Amount.Value;
                    txtPM.Text = q.Postmark.ToString();

                    PaymentPosted = q.ReceivePost;

                    panelDetail.Start(btnSavePayment);
                    if (PaymentPosted) {
                        panelDetail.DisableControls();
                    }
                    else {
                        panelDetail.EnableControls();
                    }
                    LoadItemsGrid(id);
                }
                catch {

                }
            }
        }

        private void LoadItemsGrid(string id) {
            var q = from item in dc.CRDetails
                    where item.CRMid == id
                    orderby item.UDate descending
                    select item;

            ItemsGrid.DataSource = q;
            if (PaymentPosted) {
                ItemsGrid.Enabled = false;
            }
            else {
                ItemsGrid.Enabled = true;
            }

            // Determine what is the id column number
            itemsGridIdCol = -1;

            for (int c = 0; c < ItemsGrid.ColumnCount; c++) {
                string colname = ItemsGrid.Columns[c].DataPropertyName.ToLower();
                if (colname == "id") {
                    itemsGridIdCol = c;
                }
            }

            // 
            double sumDtl = 0.0;
            var qsum = (from item in dc.CRDetails
                        where item.CRMid == id
                        select item.Amount);

            foreach (var i in qsum) {
                float num;
                float.TryParse(i.Value.ToString(), out num);
                sumDtl += num;
            }

            AppliedAmount = sumDtl;
            unAppliedAmount = paymentAmount - sumDtl;
        }

        private void SaveThisPayment() {
            // Save this record.
            var q = (from item in dc.CRMasters
                     where item.Id == currentID
                     select item).First();

            q.DeliveryName = txtRecFrom.Text;
            q.PayRef = txtRef.Text;
            q.Note = txtNote.Text;
            q.PayType = cbPayType.Text;
            q.PayVia = cbVia.Text;
            q.Amount = text2double(txtAmount.Text);
            paymentAmount = q.Amount.Value;

            {
                DateTime dt;
                DateTime.TryParse(txtPM.Text, out dt);
                q.Postmark = dt;
            }

            try {
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, q);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private double text2double(string text) {
            double d;
            d = (double)decimal.Parse(text, NumberStyles.Currency);
            return d;
        }

        /// <summary>
        /// Initialize the Item Detail data fields.
        /// </summary>
        private void initItemDetail() {
            txtItmAcct.Text = "";
            txtItmName.Text = "";
            txtItmAmount.Text = "";
            txtItmNote.Text = "";
            panelItem.Start(btnSaveItem);
        }

        private void loadItemDetail(string thisId) {
            if (thisId.Length <= 0) {
                txtItmAcct.Text = "";
                txtItmName.Text = "";
                txtItmAmount.Text = "";
                txtItmNote.Text = "";
                cbItmApply2.Text = "";
                currentDetailID = "";
            }
            else {
                try {
                    var q = (from item in dc.CRDetails
                             where item.Id == thisId
                             select item).First();

                    if (q != null) {
                        txtItmAcct.Text = q.Account;
                        txtItmName.Text = q.Name;
                        txtItmAmount.Text = q.Amount.Value.ToString("C");
                        txtItmNote.Text = q.Note;
                        cbItmApply2.Text = q.Type;
                        currentDetailID = thisId;

                        // Start monitoring input objects on this panel.
                        if (PaymentPosted) {
                            panelItem.DisableControls();
                        }
                        else {
                            panelItem.EnableControls();
                            panelItem.Start(btnSaveItem);
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        #endregion

        #region Initializers
        private void ConnectGrid() {
            // first remove all rows...
            PaymentsGrid.DataSource = null;
            PaymentsGrid.Rows.Clear();

            // now connect to real data.
            IOrderedQueryable<CRMaster> q;
            if (!chkShowAll.Checked) {
                q = from item in dc.CRMasters
                    where item.StateRcv == "created"
                    orderby item.RcptID descending
                    select item;
            }
            else {
                q = from item in dc.CRMasters
                        //                    where item.StateGA == "created"
                    orderby item.RcptID descending
                    select item;
            }
            PaymentsGrid.DataSource = q;
        }

        private void NewPayment_Load(object sender, EventArgs e) {
            btnDelete.Enabled = CurrentUserIsWmisAdmin();
            ConnectGrid();
        }
        #endregion

        #region Events

        #region Payments Grid Events
        private void PaymentsGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id;
            // user clicked a cell
            // Let's populate right pane with data.
            // Load txtReceiptId.text with id
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) {
                return;
            }
            else {
                id = PaymentsGrid.SelectedRows[0].Cells["Id"].Value.ToString();
            }

            userSelectedPaymentRow(id);
        }

        private void PaymentsGrid_RowEnter(object sender, DataGridViewCellEventArgs e) {
            string id;
            int newindex;
            if (PaymentsGrid.SelectedRows.Count > 0) {
                newindex = e.RowIndex;
                id = PaymentsGrid.Rows[newindex].Cells["Id"].Value.ToString();
                userSelectedPaymentRow(id);
            }
        }

        private void userSelectedPaymentRow(string id) {
            currentID = id;
            loadDetail(id);
            timer1.Enabled = true;
            currentDetailID = "";
            // wipe item detail
            initItemDetail();
            UpdateLogWindow(currentID);
            UpdateDetailWindow(currentID);
        }

        private void UpdateDetailWindow(string currentID) {
            string fname = "paymentdetails";
            Form f = null;

            if (isFormOpen(fname)) {
                GetFormPtr(fname, ref f);
                if (f != null) {
                    (f as PaymentDetails).Id = currentID;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Let's create a new record.
            ReceiptId newId = new ReceiptId();
            CRMaster rec = new CRMaster();
            rec.RcptID = newId.id;
            currentID = rec.Id;

            if (aset.UseTimeStampAsPM == "Yes") {
                rec.Postmark = DateTime.Now;
            }

            dc.CRMasters.InsertOnSubmit(rec);

            try {
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, rec);
                ConnectGrid();
                findPayment(currentID);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void findPayment(string id) {
            string rowid = "";
            int rownum = -1;

            // PaymentsGrid.SelectedRows[0].Cells["Id"].Value.ToString();

            foreach (DataGridViewRow row in PaymentsGrid.Rows) {
                rowid = row.Cells["Id"].Value.ToString();
                if (rowid == id) {
                    rownum = row.Index;
                    break;
                }
            }

            if (rownum >= 0) {
                // we found it !
                PaymentsGrid.FirstDisplayedScrollingRowIndex = rownum;
                // simulate select.
                userSelectedPaymentRow(rowid);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            bool ok2del = false;
            string msg = "";
            bool err = false;

            if (PaymentsGrid.Rows.Count <= 0) {
                msg = "No Records to delete!";
                err = true;
            }

            if ((!err) && (PaymentsGrid.SelectedRows.Count <= 0)) {
                msg = "No Records Selected!";
                err = true;
            }

            if ((!err) && (currentID.Trim().Length <= 0)) {
                msg = "CurrentID is blank, Nothing to delete!";
                err = true;
            }

            if (err) {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK);
            }
            else {
                // determine if ok to delete.
                ok2del = IsOk2Delete(currentID);
                // 

                if (ok2del) {
                    if (userIsOkWithDeletion(currentID)) {
                        deleteCurrentPayment(currentID);
                    }
                }
                else {
                    tellUserTheyCantDelete(currentID);
                }
            }
        }

        private bool IsOk2Delete(string currentID) {
            bool result = false;
            if (CurrentUserIsWmisAdmin()) {
                result = true;
            }
            return result;
        }

        private bool CurrentUserIsWmisAdmin() {
            bool result = false;
            NtGroups grp = new NtGroups();
            string thisuser = grp.CurrentUser.ToLower();

            var records = from user in dc.USERTABLEs
                          where (user.nt_username.ToLower() == thisuser)
                          select user;

            foreach (var r in records) {
                if (r.AdminRights == 1) {
                    result = true;
                }
            }
            return result;
        }

        private void tellUserTheyCantDelete(string currentID) {
            MessageBox.Show("Sorry, You can not delete this payment.", "Error", MessageBoxButtons.OK);
        }

        private void deleteCurrentPayment(string curID) {
            bool MoreThan1Rec = false;

            // then delete the payment
            var payRec = from item in dc.CRMasters
                         where item.Id == curID
                         select item;

            foreach (var r in payRec) {
                dc.CRMasters.DeleteOnSubmit(r);

                // first delete items
                var records = from item in dc.CRDetails
                              where (item.CRMid == curID)
                              select item;

                foreach (var dtl in records) {

                    dc.CRDetails.DeleteOnSubmit(dtl);
                }
            }

            try {
                dc.SubmitChanges();
                ConnectGrid();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }

        private bool userIsOkWithDeletion(string currentID) {
            return (MessageBox.Show("Are You Sure ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes);
        }

        #endregion Payments Grid Events

        #region Items Grid Events
        const string ItemCellId = "idDataGridViewTextBoxColumn";

        private void ItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            // user clicked a cell
            // Let's populate Item Detail with data.
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) {
                return;
            }
            else {
                String id;
                id = ItemsGrid.SelectedRows[0].Cells[itemsGridIdCol].Value.ToString();
                currentDetailID = id;
                loadItemDetail(id);
            }
        }

        private void ItemsGrid_RowEnter(object sender, DataGridViewCellEventArgs e) {
            // User selected row
            String id;
            int newindex = e.RowIndex;
            id = ItemsGrid.Rows[newindex].Cells[itemsGridIdCol].Value.ToString();
            currentDetailID = id;
            loadItemDetail(id);
        }

        #endregion Items Grid Events

        #region Other Events.
        private void btnPrint_Click(object sender, EventArgs e) {
            if (!isFormOpen("showreceipt")) {
                ShowReceipt f = new ShowReceipt();
                f.MdiParent = MdiParent;
                f.Show();
                f.BringToFront();
                // 
                f.DisplayReport(currentID);
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e) {
            // Save this record.
            var q = (from item in dc.CRMasters
                     where item.Id == txtReceiptId.Text
                     select item).First();

            q.DeliveryName = txtRecFrom.Text;
            q.PayRef = txtRef.Text;
            q.Note = txtNote.Text;
            q.PayType = cbPayType.Text;
            Decimal d;
            Decimal.TryParse(txtAmount.Text, out d);
            q.Amount = (double)d;
            try {
                dc.SubmitChanges();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            panelDetail.HasDataChanged();
            panelItem.HasDataChanged();
            UpdateAppliedGraphic();
        }

        private void btnSavePayment_Click_1(object sender, EventArgs e) {
            SaveThisPayment();
            panelDetail.Start(btnSavePayment);

            // Reload list of payments, and find the currentID
            // for selection.
            ConnectGrid();
            FindPaymentRecord(currentID);

            // Even though there are no detail records, we need to calculate
            // payment & applied amounts.
            LoadItemsGrid(currentID);
        }

        private void FindPaymentRecord(string currentID) {
            // Let's see if we can find the ID by row.
            int selRow = 0;
            string id;
            for (int i = 0; (i < PaymentsGrid.Rows.Count) && (selRow == 0); i++) {
                id = PaymentsGrid.Rows[i].Cells["Id"].Value.ToString();
                if (id.CompareTo(currentID) == 0) {
                    selRow = i;
                    PaymentsGrid.Rows[i].Selected = true;
                }
            }
            if (selRow != 0) {
                PaymentsGrid.FirstDisplayedScrollingRowIndex = PaymentsGrid.Rows[selRow].Index;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            // Add a new record
            currentDetailID = ShortGuid.newId;
            CRDetail r = new CRDetail();
            r.Id = currentDetailID;
            r.init();
            r.CRMid = currentID;
            //
            // set amount = unapplied amount.
            // 
            r.Amount = unAppliedAmount;

            try {
                dc.CRDetails.InsertOnSubmit(r);
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, r);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            updateDetailGrid(currentDetailID);
            loadItemDetail(currentDetailID);
        }

        private void btnSaveItem_Click(object sender, EventArgs e) {
            string thisId = currentDetailID;

            // check to see if this is a new record, without user clicking the Add.
            if (thisId.Length <= 0) {
                CRDetail rec = new CRDetail();
                rec.Account = txtItmAcct.Text;
                rec.Name = txtItmName.Text;
                rec.Amount = text2double(txtItmAmount.Text);
                rec.Note = txtItmNote.Text;
                rec.Type = cbItmApply2.Text;
                currentDetailID = rec.Id;
                thisId = currentDetailID;

                try {
                    dc.CRDetails.InsertOnSubmit(rec);
                    dc.SubmitChanges();
                    dc.Refresh(RefreshMode.OverwriteCurrentValues, rec);
                }
                catch (Exception Ex) {
                    Console.WriteLine(Ex.Message);
                }
            }
            else {
                var records = from item in dc.CRDetails
                              where item.Id == thisId
                              select item;

                // there should be 0 or 1 records, since thisId is a guid.
                foreach (var q in records) {
                    if (q != null) {
                        try {
                            q.Account = txtItmAcct.Text;
                            q.Name = txtItmName.Text;
                            q.Amount = text2double(txtItmAmount.Text);
                            q.Note = txtItmNote.Text;
                            q.Type = cbItmApply2.Text;
                            dc.SubmitChanges();
                            dc.Refresh(RefreshMode.OverwriteCurrentValues, q);
                        }
                        catch (Exception Ex) {
                            Console.WriteLine(Ex.Message);
                        }
                    }
                }
            }
            updateDetailGrid(thisId);
            loadItemDetail(currentDetailID);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e) {
            // Delete selected Item.
            if (currentDetailID.Trim().Length > 0) {
                var q = (from item in dc.CRDetails
                         where item.Id == currentDetailID
                         select item).FirstOrDefault();

                if (q != null) {
                    try {
                        dc.CRDetails.DeleteOnSubmit(q);
                        dc.SubmitChanges();
                        updateDetailGrid(currentDetailID);
                        initItemDetail();
                    }
                    catch (Exception Ex) {
                        Console.WriteLine(Ex.Message);
                    } // try
                } // if ... q != null
            } // if ...length > 0
        } // method

        #endregion Other Events.

        // ref: http://stackoverflow.com/questions/10179223/find-a-row-in-datagridview-based-on-column-and-value
        // ref: http://stackoverflow.com/questions/6265228/selecting-a-row-in-datagridview-programmatically
        /// <summary>
        /// UpdateDetailGrid: Update the list of items for this payment.
        /// If the parameter is non empty, then also re-position to this 
        /// row.
        /// </summary>
        /// <param name="id">ID of CRDetail Record</param>
        private void updateDetailGrid(string id) {
            // Reload detail grid
            LoadItemsGrid(currentID);
            // reposition cursor (select row by id)
            if (id.Length > 0) {
                int rowIndex = -1;
                string searchValue = id;
                if (ItemsGrid.Rows.Count > 1) {
                    foreach (DataGridViewRow row in ItemsGrid.Rows) {
                        if (row.Cells["idDataGridViewTextBoxColumn"].Value.ToString().Equals(searchValue)) {
                            rowIndex = row.Index;

                            break;
                        }
                    }
                }
                if (rowIndex != -1) {
                    ItemsGrid.Rows[rowIndex].Selected = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtItmAcct_TextChanged(object sender, EventArgs e) {
            int num;
            string result = "";

            // try to find in wmis
            if (int.TryParse(txtItmAcct.Text, out num)) {
                CustomerInfo ci = new CustomerInfo(num);
                if (ci.Name.ToLower() != "not found")
                    result = ci.Name;
            }

            // if not found, then try to find in mas500
            if (result.Length <= 0) {
                CustomerInfo ci = new CustomerInfo(txtItmAcct.Text);
                result = ci.Name;
            }

            txtItmName.Text = result;
        }

        /// <summary>
        /// Item Account Double Click.
        /// Open the list of accounts, and allow user to pick
        /// account from this list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtItmAcct_DoubleClick(object sender, EventArgs e) {
            OpenUnpaidList();
        }

        /// <summary>
        /// Item Amount Double Click.
        /// Open the list of accounts & Charges, and allow user to pick
        /// Rows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtItmAmount_DoubleClick(object sender, EventArgs e) {
            OpenUnpaidList();
        }

        private void OpenUnpaidList() {
            // First check to make sure we have a Receipt Record CRMaster
            // 
            if (currentID.Length > 0) {
                if (!isFormOpen("unpaidlist")) {
                    UnpaidList f = new UnpaidList(this);
                    f.MdiParent = MdiParent;
                    f.Show();
                    f.BringToFront();
                }
            }
        }

        #endregion Events

        private void ItemsGrid_Validated(object sender, EventArgs e) {
            // Update the lblAppliedAmount.text

        }

        private void textSearch_TextChanged(object sender, EventArgs e) {
            string inp;

            inp = textSearch.Text.Trim().ToLower();
            IQueryable<CRMaster> q;
            const string Sep = " / ";

            if (inp.Length > 0) {
                q = from item in dc.CRMasters
                    where (
                    (chkShowAll.Checked ||
                      (!chkShowAll.Checked && (item.StateRcv == "created"))
                    ) &&
                    (item.DeliveryName.ToLower().Contains(inp) ||
                      item.Note.ToLower().Contains(inp) ||
                      item.PayRef.ToLower().Contains(inp) ||
                      item.RcptID.ToLower().Contains(inp))
                    )
                    orderby item.RcptID descending
                    select item;
            }
            else {
                if (!chkShowAll.Checked) {
                    q = from item in dc.CRMasters
                        where item.StateRcv == "created"
                        orderby item.RcptID descending
                        select item;


                }
                else {
                    q = from item in dc.CRMasters
                            //                    where item.StateGA == "created"
                        orderby item.RcptID descending
                        select item;
                }
            }
            PaymentsGrid.DataSource = q;
        }

        private void ItemsGrid_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void ItemsGrid_DragDrop(object sender, DragEventArgs e) {
            DragDropInfo droppedObj;
            string droppedId;

            if (e.Data.GetDataPresent(typeof(DragDropInfo))) {
                droppedObj = (DragDropInfo)e.Data.GetData(typeof(DragDropInfo));
                if (droppedObj.Source == "ddUnpaid") {
                    if (e.Effect == DragDropEffects.Copy) {
                        var lst = (List<UnpaidDataRecord>)droppedObj.Obj;
                        foreach (var r in lst) {
                            AddDetailRecord(r);
                        }

                        try {
                            dc.SubmitChanges();
                            dc.Refresh(RefreshMode.OverwriteCurrentValues);
                        }
                        catch (Exception Ex) {
                            Console.WriteLine(Ex.Message);
                        }
                        updateDetailGrid(currentDetailID);
                        loadItemDetail(currentDetailID);
                    }
                }
            }
        }

        // TODO: lookup account name
        private void AddDetailRecord(UnpaidDataRecord r) {
            CRDetail rec = new CRDetail();
            int num;
            rec.CRMid = currentID;
            rec.Account = r.Account.ToString();
            if (int.TryParse(r.Account.Value.ToString(), out num)) {
                CustomerInfo ci = new CustomerInfo(num);
                rec.Name = ci.Name;
            }
            if (r.Account.Value == 0) {
                rec.Account = r.SAccount;
                CustomerInfo ci = new CustomerInfo(r.SAccount);
                rec.Name = ci.Name;
            }
            rec.Amount = r.Amount;
            rec.Note = string.Format("Inv:{0}, {1}", r.Invoice.ToString(), r.Description);
            rec.Type = r.TranType;
            currentDetailID = rec.Id;
            dc.CRDetails.InsertOnSubmit(rec);
        }

        private void btnPost_Click(object sender, EventArgs e) {
            if (btnSavePayment.Enabled) {
                MessageBox.Show("Please Save Payment before Posting.", "Warning", MessageBoxButtons.OK);
            }
            else {
                if (!WeCanPostItem) {
                    MessageBox.Show(
                        "Out of Balance, please resolve and then post.",
                        "Warning",
                        MessageBoxButtons.OK);
                }
                else {
                    PostThisPayment();
                    ReloadGrids();
                }
            }
        }

        private void ReloadGrids() {
            ConnectGrid();
            if (PaymentsGrid.RowCount > 0) {
                string id;
                PaymentsGrid.Rows[0].Selected = true;
                id = PaymentsGrid.SelectedRows[0].Cells["Id"].Value.ToString();
                userSelectedPaymentRow(id);
            }
            else {
                userSelectedPaymentRow("");
                ItemsGrid.Rows.Clear();
            }
        }

        private void PostThisPayment() {
            if (currentID.Length > 0) {
                // Save this record.
                var q = (from item in dc.CRMasters
                         where item.Id == currentID
                         select item).First();

                if (q.StateRcv != "posted") {
                    q.StateRcv = "posted";
                    q.StateAR = "created";
                    q.StateGA = "created";

                    var l = new TblLog();
                    l.tblName = "crmaster";
                    l.tblId = currentID;
                    l.txt = "receiving post";

                    var act = new CRMasterActivity();
                    var nt = new NtGroups();
                    act.CrMid = currentID;
                    act.Dept = "receiving";
                    act.Operation = "post";
                    act.Person = nt.CurrentUser;
                    act.TimeStamp = DateTime.Now;

                    try {
                        dc.TblLogs.InsertOnSubmit(l);
                        dc.CRMasterActivities.InsertOnSubmit(act);
                        dc.SubmitChanges();
                        dc.Refresh(RefreshMode.OverwriteCurrentValues, q);
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void chkShowAll_CheckStateChanged(object sender, EventArgs e) {
            // User changed this, so reload grid
            ReloadGrids();
        }

        private void menuLog_Click(object sender, EventArgs e) {
            // First check to make sure we have a Receipt Record CRMaster
            // 
            if (currentID.Length > 0) {
                if (!isFormOpen("logview")) {
                    misc.LogView f = new misc.LogView();
                    f.MdiParent = MdiParent;
                    f.Show();
                    f.Id = currentID;
                    f.BringToFront();
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
    }
}
