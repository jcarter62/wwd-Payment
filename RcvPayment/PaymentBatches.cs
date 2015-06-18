using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using classLib;
using dataLib;
using System.Data.Linq;
using System.Linq;

namespace RcvPayment {
    public partial class PaymentBatches : RcvPayment.MyForm {
        AppSettings aset;
        dbClassDataContext dc;

        public PaymentBatches() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
        }

        private void ConnectGrid() {
            // first remove all rows...
            dgv.DataSource = null;

            foreach (DataGridViewRow r in dgv.Rows) {
                dgv.Rows.Remove(r);
            }

            // now connect to real data.
            var q = from item in dc.CRDepBatchs
                    orderby item.IDBank descending
                    select item;

            dgv.DataSource = q;
        }

    }
}
