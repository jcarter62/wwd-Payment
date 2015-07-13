using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dataLib;
using classLib;

namespace RcvPayment {
    public partial class MainForm : RcvPayment.MyForm {
        public MainForm() {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new Settings();
            f.MdiParent = this;
            f.Show();
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new NewPayment();
            f.MdiParent = this;
            f.Show();
        }

        private void paymentBatchesToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new PaymentBatches();
            f.MdiParent = this;
            f.Show();
        }

        private void generateTestDataToolStripMenuItem_Click(object sender, EventArgs e) {
            var aset = new AppSettings();
            var sd = new SampleData(aset.wmis.connectionString);
            sd.CreateData(100);
            MessageBox.Show("Sample Data has been created.", "Information", MessageBoxButtons.OK );
        }

        private void unAppliedPaymentsToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new Ca.UnApplied();
            f.MdiParent = this;
            f.Show();
        }
    }
}
