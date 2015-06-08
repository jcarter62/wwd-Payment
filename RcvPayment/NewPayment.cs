﻿using System;
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
        string currentID;
        string currentDetailID;
        AppSettings aset;
        dbClassDataContext dc;

        public NewPayment() {
            InitializeComponent();
            currentID = "";
            currentDetailID = "";
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
            statUpdate("");
        }

        private void statUpdate(String msg) {
            statLbl.Text = msg;
        }

        private void ConnectGrid() {
            var q = from item in dc.CRMasters
                    orderby item.RcptID descending
                    select item;

            PaymentsGrid.DataSource = q;
        }

        private void NewPayment_Load(object sender, EventArgs e) {
            ConnectGrid();
        }


        private void PaymentsGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            // user clicked a cell
            // Let's populate right pane with data.
            // Load txtReceiptId.text with id
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) {
                return;
            }
            else {
                String id = PaymentsGrid.SelectedRows[0].Cells["Id"].Value.ToString();
                currentID = id;
                loadDetail(id);
                timer1.Enabled = true;
                currentDetailID = "";
            }
        }

        private void ItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            // user clicked a cell
            // Let's populate Item Detail with data.
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) {
                return;
            }
            else {
                String id;
                id = ItemsGrid.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                currentDetailID = id;
                loadItemDetail(id);
            }
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
        }

        private void PaymentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnPrint_Click(object sender, EventArgs e) {
            String yesno = "no";
            if (txtRecFrom.Changed)
                yesno = "yes";
            MessageBox.Show("RecFrom Changed = " + yesno);
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
        }

        private void btnSavePayment_Click_1(object sender, EventArgs e) {
            SaveThisPayment();
            panelDetail.Start(btnSavePayment);
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

            try {
                dc.SubmitChanges();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Let's create a new record.
            ReceiptId newId = new ReceiptId();
            CRMaster rec = new CRMaster();
            rec.RcptID = newId.id;

            dc.CRMasters.InsertOnSubmit(rec);

            try {
                dc.SubmitChanges();
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            // Add a new record
            currentDetailID = ShortGuid.newId;
            CRDetail r = new CRDetail();
            r.Id = currentDetailID;
            r.init();
            r.CRMid = currentID;

            try {
                dc.CRDetails.InsertOnSubmit(r);
                dc.SubmitChanges();
            } 
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            updateDetailGrid(currentDetailID);
            loadItemDetail(currentDetailID);
        }

        private void loadItemDetail(string thisId) {
            var q = (from item in dc.CRDetails
                     where item.Id == thisId
                     select item).First();

            if ( q != null ) {
                txtItmAcct.Text = q.Account;
                txtItmName.Text = "Name goes Here";
                txtItmAmount.Text = q.Amount.ToString();
                txtItmNote.Text = q.Note;
                currentDetailID = thisId;
            }
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

        private void btnSaveItem_Click(object sender, EventArgs e) {
            string thisId = currentDetailID;

            // check to see if this is a new record, without user clicking the Add.
            if ( thisId.Length <= 0 ) {
                CRDetail rec = new CRDetail();
                rec.Account = txtItmAcct.Text;
                rec.Amount = text2double(txtAmount.Text);
                rec.Note = txtItmNote.Text;
                rec.Type = cbItmApply2.Text;
                currentDetailID = rec.Id;
                thisId = currentDetailID;

                try {
                    dc.CRDetails.InsertOnSubmit(rec);
                    dc.SubmitChanges();
                }
                catch (Exception Ex) {
                    Console.WriteLine(Ex.Message);
                }
            } else {
                var q = (from item in dc.CRDetails
                         where item.Id == thisId
                         select item).Single();


                if (q != null) {
                    try {
                        q.Account = txtItmAcct.Text;
                        q.Amount = text2double(txtItmAmount.Text);
                        q.Note = txtItmNote.Text;
                        q.Type = cbItmApply2.Text;
                        dc.SubmitChanges();
                    }
                    catch (Exception Ex) {
                        Console.WriteLine(Ex.Message);
                    }
                }
            }
            updateDetailGrid(thisId);
            loadItemDetail(currentDetailID);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e) {
            // Delete selected Item.
            if (currentDetailID.Trim().Length > 0 ) {
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
            if ( id.Length > 0 ) {
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
                if ( rowIndex != -1 ) {
                    ItemsGrid.Rows[rowIndex].Selected = true;
                }
            }
        }

        private double text2double(string text) {
            Decimal d;
            Decimal.TryParse(text, out d);
            return (double)d;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
