using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RcvPayment {
    public partial class MainForm : RcvPayment.MyForm {
        public MainForm() {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            Settings f = new Settings();
            f.MdiParent = this;
            f.Show();
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e) {
            NewPayment f = new NewPayment();
            f.MdiParent = this;
            f.Show();
        }

        private void paymentBatchesToolStripMenuItem_Click(object sender, EventArgs e) {
            PaymentBatches f = new PaymentBatches();
            f.MdiParent = this;
            f.Show();
        }
    }
}
