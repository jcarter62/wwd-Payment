namespace RcvPayment {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Deposit4Date.
    /// </summary>
    public partial class Deposit4Date : Telerik.Reporting.Report {
        public Deposit4Date() {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public Deposit4Date(string dataSrc, DateTime datefrom, DateTime dateto) {
            InitializeComponent();

            this.ds.ConnectionString = dataSrc;
            this.ReportParameters["datefrom"].Value = datefrom;
            this.ReportParameters["dateto"].Value = dateto;
        }

    }
}