using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using dataLib;
using classLib;

namespace RcvPayment {
    public partial class ShowReceipt : RcvPayment.MyForm {
        AppSettings aset;
        public string Id { get; set; }

        public ShowReceipt() {
            InitializeComponent();
            aset = new AppSettings();
        }

        public void DisplayReport(string id ) {
            Id = id;
            aset = new AppSettings();

            aset = new AppSettings();
            Report1 rpt = new Report1(aset.wmis.connectionString, Id);

            rview.ReportSource = rpt;
            rview.RefreshReport();
        }

        private void ShowReceipt_Load(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e) {
            // Email report
            rview.ExportReport("PDF", null);
        }
    }
}
