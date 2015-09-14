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
    public partial class PaymentDetails : RcvPayment.MyForm {
        private DbClassDataContext dc;
        private AppSettings aset;

        private string pId;
        public string Id {
            get { return pId; }
            set {
                pId = value;
                loadDetail();
            }
        }

        public PaymentDetails() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            this.Text = "Payment Details View";
        }

        private void loadDetail() {
            var qRecs = (from item in dc.CRMasters
                         where item.Id == pId
                         select item);

            foreach (var q in qRecs) {
                txtReceiptId.Text = q.RcptID;
                txtTimeStamp.Text = q.CDate.ToString();
                txtRecBy.Text = q.CUser;
                txtRecFrom.Text = q.DeliveryName;
                cbPayType.Text = q.PayType;
                txtRef.Text = q.PayRef;
                cbVia.Text = q.PayVia;
                txtNote.Text = q.Note;
                txtAmount.Text = q.Amount.Value.ToString("C");
                txtPM.Text = q.Postmark.ToString();

                LoadItemsGrid();
                break; // do only once.
            }

            panelMain.DisableControls();
            panelDetail.DisableControls();
        }

        private void LoadItemsGrid() {
            dgDetail.DataSource = null;
            dgDetail.Rows.Clear();

            var detail = (
            from dtl in dc.CRDetails
            from n in dc.NAMEs.Where(n => dtl.Account == n.NAME_ID.ToString()).DefaultIfEmpty()
            where dtl.CRMid == pId
            orderby dtl.Account descending, dtl.Amount ascending
            select new {
                dtl.Account,
                dtl.Type,
                dtl.Amount,
                n.FullName,
                dtl.Note
            });
            
            dgDetail.Columns.Clear();
            dgDetail.Rows.Clear();

            foreach (var rec in detail) {
                //        grid object, field name, header text
                AddColumn(dgDetail, "Account", "Account");
                AddColumn(dgDetail, "Amount", "Amount", IsCurrency: true);
                AddColumn(dgDetail, "Type", "Type");
                AddColumn(dgDetail, "Note", "Notes");
                AddColumn(dgDetail, "FullName", "Account Name");
                break;
            }

            dgDetail.DataSource = detail;
        }

        private void AddColumn(DataGridView grid, string colName, string colTitle,
                               bool hidden = false, bool IsCurrency = false) {
            var cellStyle = new DataGridViewCellStyle();
            DataGridViewColumn c = new DataGridViewTextBoxColumn();  // new DataGridViewColumn();
            c.Resizable = DataGridViewTriState.True;
            c.DividerWidth = 1;
            c.DataPropertyName = colName;
            c.HeaderText = colTitle;
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (hidden) {
                c.Visible = false;
            }
            if (IsCurrency) {
                cellStyle.Format = "C2";
                cellStyle.NullValue = null;
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            c.DefaultCellStyle = cellStyle;
            grid.Columns.Add(c);
        }

        private void btnPrint_Click(object sender, EventArgs e) {
            if (!isFormOpen("showreceipt")) {
                ShowReceipt f = new ShowReceipt();
                f.MdiParent = MdiParent;
                f.Show();
                f.BringToFront();
                // 
                f.DisplayReport(pId);
            }
        }

        private void PaymentDetails_Load(object sender, EventArgs e) {
            //
        }
    }
}
