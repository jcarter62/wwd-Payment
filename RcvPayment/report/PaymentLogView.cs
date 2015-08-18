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
    public partial class PaymentLogView : RcvPayment.MyForm {
        AppSettings aset;
        DbClassDataContext dc;

        public DateTime DateFrom {get;set;}
        public DateTime DateTo {get;set;}

        public PaymentLogView() {
            InitializeComponent();
            DateFrom = BeginOfDay(DateTime.Now);
            DateTo = EndOfDay(DateTime.Now);

            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
        }

        private DateTime EndOfDay(DateTime now) {
            return now.Date.AddDays(1).AddTicks(-1);
        }

        private DateTime BeginOfDay(DateTime now) {
            return now.Date;
        }


        public void DisplayReport(DateTime date0, DateTime date2) {

            aset = new AppSettings();
            var rpt = new PaymentLog(aset.wmis.connectionString, date0, date2);

            rview.ReportSource = rpt;
            rview.RefreshReport();
        }

        public void DisplayReport(DateTime TodaysDate) {
            DateFrom = BeginOfDay(TodaysDate);
            DateTo = EndOfDay(TodaysDate);
            DisplayReport(DateFrom, DateTo);
        }

        private void BtnUpdate_Click(object sender, EventArgs e) {
            DateTime dt = PMDate.Value;
            DateFrom = BeginOfDay(dt);
            DateTo = EndOfDay(dt);

            DisplayReport(DateFrom, DateTo);
        }
    }
}
