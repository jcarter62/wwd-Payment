namespace RcvPayment {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    public partial class Report1 : Telerik.Reporting.Report {
        public Report1() {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public Report1(string dataSrc, string id) {
            InitializeComponent();

            this.dataSource1.ConnectionString = dataSrc;
            this.ReportParameters["Param1"].Value = id;
        }

    }
}