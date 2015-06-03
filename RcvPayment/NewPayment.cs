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
        AppSettings aset;
        dbClassDataContext dc;

        public NewPayment() {
            InitializeComponent();
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
                loadDetail(id);
                timer1.Enabled = true;
            }
        }

        private void loadDetail(String id) {
            var q = (from item in dc.CRMasters
                     where item.Id == id
                     select item ).First();

            txtReceiptId.Text = q.RcptID;
            txtTimeStamp.Text = q.CDate.ToString();
            txtRecBy.Text = q.CUser; // cells["cUser"].Value.ToString();
            txtRecFrom.Text = q.DeliveryName; // cells["DeliveryName"].Value.ToString();
            cbPayType.Text = q.PayType; // cells["PayType"].Value.ToString();
            txtRef.Text = q.PayRef; // cells["PayRef"].Value.ToString();
            cbVia.Text = q.DeliveryName; // cells["DeliveryName"].Value.ToString();
            txtNote.Text = q.Note; // cells["Note"].Value.ToString();
            txtAmount.Text = q.Amount.ToString(); // cells["Amount"].Value.ToString();

            panelDetail.Start(btnSavePayment);
            if (q.Deposited) {
                panelDetail.DisableControls();
            }
            else {
                panelDetail.EnableControls();
            }
        }

        private void PaymentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            String yesno = "no";
            if (txtRecFrom.Changed)
                yesno = "yes";
            MessageBox.Show("RecFrom Changed = " + yesno );
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
            var q = from item in dc.CRMasters
                    where item.Id == txtReceiptId.Text
                    select item;

            foreach (CRMaster rec in q) {
                rec.DeliveryName = txtRecFrom.Text;
                rec.PayRef = txtRef.Text;
                rec.Note = txtNote.Text;
                rec.PayType = cbPayType.Text;
                Decimal d;
                Decimal.TryParse(txtAmount.Text, out d);
                rec.Amount = (double)d;
            }

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

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
