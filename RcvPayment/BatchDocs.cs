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

namespace RcvPayment {
    public partial class BatchDocs : RcvPayment.MyForm {
        AppSettings aset;
        dbClassDataContext dc;

        #region properties
        private string _BatchId;
        public string BatchId {
            get {
                return _BatchId;
            }
            set {
                _BatchId = value;
                textBatchId.Text = BatchIdDescription();
                loadPendingGrid();
                loadSelectedGrid();
            }
        }

        private string BatchIdDescription() {
            string result = "";
            try {
                var q = (from item in dc.CRDepBatches
                         where (item.Id.CompareTo(BatchId) == 0)
                         select item).First();

                result = q.IDBank;
            }
            catch ( Exception ex ) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        #endregion

        #region Init
        public BatchDocs() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
        }

        private void BatchDocs_Load(object sender, EventArgs e) {
            statLabel.Text = "";
        }
        #endregion

        #region Private Methods
        private void loadPendingGrid() {
            var q = from item in dc.CRMasters
//                    where ( item.Deposited == false ) && (item.State == "Created")
                    orderby item.CDate 
                    select item;

            dgvPend.DataSource = q;

            /* 
            Calculate total pending, and display somewhere at bottom.
            */

        }

        private void loadSelectedGrid() {
            if (BatchId != "") {
                var q = from item in dc.CRDepItems
                        where (item.IDBatch == BatchId)
                        orderby item.PayRef
                        select item;

                dgvSel.DataSource = q;
            }
        }
        #endregion

    }
}
