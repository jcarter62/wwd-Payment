using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using classLib;
using dataLib;

namespace SimpleTest {
    public partial class mainform : Form {
        AppSettings aset;
        dbClassDataContext dc;
        string id;

        public mainform() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);

            loadGrid();
            id = "";
        }

        private void loadGrid() {
            // first remove all rows...

            dbGrid.DataSource = null;

            foreach (DataGridViewRow r in dbGrid.Rows) {
                dbGrid.Rows.Remove(r);
            }

            // now connect to real data.
            var q = from item in dc.CRMasters
                    orderby item.RcptID descending
                    select item;

            dbGrid.DataSource = q;

        }

        private void button1_Click(object sender, EventArgs e) {
            string id;
            id = dbGrid.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString();

            MessageBox.Show("Selected: " + id, "Info", MessageBoxButtons.OK);
            openReport(id);
        }

        private void openReport(string id) {
            ShowReceipt f = new ShowReceipt(id);
            f.Show();

//            Report1 rpt = new Report1(dc.Connection.ConnectionString, id);

        }


    }
}
