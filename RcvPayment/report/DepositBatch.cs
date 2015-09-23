namespace RcvPayment.report {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for DepositBatch.
    /// </summary>
    public partial class DepositBatch : Telerik.Reporting.Report {
        public DepositBatch() {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

        }

        /*
                public DepositBatch(string dataSrc, string id) {
                    InitializeComponent();

                    this.dataSource1.ConnectionString = dataSrc;
                    this.ReportParameters["Param1"].Value = id;
                }
        */

        public DepositBatch(string dataSrc, string id, string ordering = "RcptID") {
            InitializeComponent();

            this.dataSource1.ConnectionString = dataSrc;
            if (ordering.ToLower().CompareTo("amount") == 0) {
                string sql;
                sql = this.dataSource1.SelectCommand.ToString();
                sql = sql + " order by PaymentAmount, RcptID ";
                this.dataSource1.SelectCommand = sql;
            }
            else {
                string sql;
                sql = this.dataSource1.SelectCommand.ToString();
                sql = sql + " order by RcptID ";
                this.dataSource1.SelectCommand = sql;
            }

            this.ReportParameters["Param1"].Value = id;
        }


    }
}