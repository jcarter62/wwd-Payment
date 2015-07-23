using classLib;
using dataLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Processing;


namespace RcvPayment.report {
    public partial class DepositBatchView : RcvPayment.MyForm {
        AppSettings aset;
        DbClassDataContext dc;

        public string Id { get; set; }

        public DepositBatchView() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
        }

        public void DisplayReport(string id) {
            Id = id;
            aset = new AppSettings();
            var rpt = new DepositBatch(aset.wmis.connectionString, Id);

            rview.ReportSource = rpt;
            rview.RefreshReport();
        }
    }
}
