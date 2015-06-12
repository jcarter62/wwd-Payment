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

namespace RcvPayment {

    public partial class NewPayment : RcvPayment.MyForm {

        #region Properties
        Images statusImages;
        private string currentID;
        private string currentDetailID;
        private AppSettings aset;
        private dbClassDataContext dc;

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

                if (_AppliedAmount == 0.0) {
                    lblAppliedAmount.Text = "-- UnApplied --";
                }
                else {
                    _AppliedAmountMessage = string.Format("Applied Amount: {0}",
                        _AppliedAmount.ToString("C"));
                    lblAppliedAmount.Text = _AppliedAmountMessage;
                }
                // Update the graphic to right side.
                UpdateAppliedGraphic();
            }
        }

        private void UpdateAppliedGraphic() {
            if (ItemsGrid.Rows.Count <= 0) {
                lblAppliedChk.Image = Image.FromFile(statusImages.failImage);
            }
            else {
                if (Math.Abs(unAppliedAmount) < 0.001) {
                    lblAppliedChk.Image = Image.FromFile(statusImages.successImage);
                }
                else {
                    lblAppliedChk.Image = Image.FromFile(statusImages.failImage);
                }
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
            dc = new dbClassDataContext(aset.wmis.connectionString);
            statUpdate("");
        }
        #endregion

        #region Misc
        private void statUpdate(String msg) {
            statLbl.Text = msg;
        }

        private void loadDetail(String id) {
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
            txtAmount.Text = q.Amount.ToString();
            paymentAmount = q.Amount.Value;

            panelDetail.Start(btnSavePayment);
            if (q.Deposited) {
                panelDetail.DisableControls();
            }
            else {
                panelDetail.EnableControls();
            }
            LoadItemsGrid(id);
        }

        private void LoadItemsGrid(string id) {
            var q = from item in dc.CRDetails
                    where item.CRMid == id
                    orderby item.UDate descending
                    select item;

            ItemsGrid.DataSource = q;

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
            Decimal d;
            Decimal.TryParse(txtAmount.Text, out d);
            q.Amount = (double)d;
            paymentAmount = q.Amount.Value;

            try {
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, q);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private double text2double(string text) {
            Decimal d;
            Decimal.TryParse(text, out d);
            return (double)d;
        }

        /// <summary>
        /// Initialize the Item Detail data fields.
        /// </summary>
        private void initItemDetail() {
            txtItmAcct.Text = "";
            txtItmName.Text = "";
            txtItmAmount.Text = "";
            txtItmNote.Text = "";
        }

        private void loadItemDetail(string thisId) {
            var q = (from item in dc.CRDetails
                     where item.Id == thisId
                     select item).First();

            if (q != null) {
                txtItmAcct.Text = q.Account;
                txtItmName.Text = q.Name;
                txtItmAmount.Text = q.Amount.ToString();
                txtItmNote.Text = q.Note;
                cbItmApply2.Text = q.Type;
                currentDetailID = thisId;

                // Start monitoring input objects on this panel.
                panelItem.Start(btnSaveItem );
            }
        }


        #endregion

        #region Initializers
        private void ConnectGrid() {
            // first remove all rows...
            PaymentsGrid.DataSource = null;

            foreach (DataGridViewRow r in PaymentsGrid.Rows) {
                PaymentsGrid.Rows.Remove(r);
            }

            // now connect to real data.
            var q = from item in dc.CRMasters
                    orderby item.RcptID descending
                    select item;

            PaymentsGrid.DataSource = q;
        }

        private void NewPayment_Load(object sender, EventArgs e) {
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
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Let's create a new record.
            string id;
            ReceiptId newId = new ReceiptId();
            CRMaster rec = new CRMaster();
            rec.RcptID = newId.id;
            currentID = rec.Id;

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
            bool ok2del = true;

            // determine if ok to delete.

            if (ok2del) {
                if (userIsOkWithDeletion(currentID)) {
                    deleteCurrentPayment(currentID);
                }
            }
            else {
                tellUserTheyCantDelete(currentID);
            }
        }

        private void tellUserTheyCantDelete(string currentID) {
            MessageBox.Show("Sorry, You can not delete this payment.", "Error", MessageBoxButtons.OK);
        }

        private void deleteCurrentPayment(string curID) {
            // first delete items
            var records = from item in dc.CRDetails
                          where (item.CRMid == curID)
                          select item;

            foreach (var r in records) {
                dc.CRDetails.DeleteOnSubmit(r);
            }

            // then delete the payment
            var payRec = from item in dc.CRMasters
                         where item.Id == curID
                         select item;

            foreach (var r in payRec) {
                dc.CRMasters.DeleteOnSubmit(r);
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
                id = ItemsGrid.SelectedRows[0].Cells[ItemCellId].Value.ToString();
                currentDetailID = id;
                loadItemDetail(id);
            }
        }

        private void ItemsGrid_RowEnter(object sender, DataGridViewCellEventArgs e) {
            // User selected row
            String id;
            int newindex = e.RowIndex;
            id = ItemsGrid.Rows[newindex].Cells[ItemCellId].Value.ToString();
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

            // Even though there are no detail records, we need to calculate
            // payment & applied amounts.
            LoadItemsGrid(currentID);
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
                rec.Amount = text2double(txtAmount.Text);
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
            if (int.TryParse(txtItmAcct.Text, out num)) {
                CustomerInfo ci = new CustomerInfo(num);
                txtItmName.Text = ci.Name;
            }
        }

        /// <summary>
        /// Item Account Double Click.
        /// Open the list of accounts, and allow user to pick
        /// account from this list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtItmAcct_DoubleClick(object sender, EventArgs e) {
            if (!isFormOpen("custlist")) {
                CustList f = new CustList(this);
                f.MdiParent = MdiParent;
                f.Show();
                f.BringToFront();
            }
        }


        #endregion Events

        private void ItemsGrid_Validated(object sender, EventArgs e) {
            // Update the lblAppliedAmount.text

        }
    }
}
