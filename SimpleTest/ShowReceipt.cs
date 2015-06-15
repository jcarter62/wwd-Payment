using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classLib;
using dataLib;

namespace SimpleTest {
    public partial class ShowReceipt : Form {
        AppSettings aset;
        dbClassDataContext dc;

        public ShowReceipt(string id) {
            InitializeComponent();

            openReport(id);
        }

        private void openReport(string id) {
            aset = new AppSettings();
            Report1 rpt = new Report1(aset.wmis.connectionString, id);

            reportViewer1.ReportSource = rpt;
            reportViewer1.RefreshReport();
        }
    }
}
