using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using dataLib;
using classLib;

namespace RcvPayment.Ca {
    public partial class UnApplied : RcvPayment.MyForm {
        AppSettings aset;
        DbClassDataContext dc;
        string currentMasterId;
        int currentMasterRow;
        int masterIdCol;
        int masterRcptIDCol;
        int detailIdCol;

        public UnApplied() {
            InitializeComponent();
            localInit();
        }

        private void localInit() {
            masterIdCol = 0;
            masterRcptIDCol = 0;
            detailIdCol = 0;

            currentMasterId = null;
            currentMasterRow = -1;

            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            OpenMasterTable();
        }

        private void OpenMasterTable() {
            gridMaster.DataSource = null;

            foreach (DataGridViewRow r in gridMaster.Rows) {
                gridMaster.Rows.Remove(r);
            }

            var mst = (from pmt in dc.CRMasters
                       where pmt.StateAR == "created" ||
                       pmt.StateAR == "selected"
                       orderby pmt.CDate descending
                       select pmt);

            gridMaster.DataSource = mst;

            // Determine column for Id field.
            masterIdCol = 0;
            masterRcptIDCol = 0;
            for (int c = 0; c < gridMaster.ColumnCount; c++) {
                string colname = gridMaster.Columns[c].DataPropertyName.ToLower();
                if (colname == "id") {
                    masterIdCol = c;
                }
                else if (colname == "rcptid") {
                    masterRcptIDCol = c;
                }
            }
        }

        // User has changed to another row, and this fires before the row has changed.
        private void gridMaster_RowEnter(object sender, DataGridViewCellEventArgs e) {
            string id;
            int newindex;
            if (gridMaster.SelectedRows.Count > 0) {
                newindex = e.RowIndex;
                id = gridMaster.Rows[newindex].Cells[masterIdCol].Value.ToString();
                currentMasterId = id;
                currentMasterRow = newindex;
                MasterSelected();
            }
        }

        private void MasterSelected() {
            if (currentMasterRow >= 0) {
                lblDetail.Text = string.Format("Payment Detail Records for {0}",
                    gridMaster.Rows[currentMasterRow].Cells[masterRcptIDCol].Value);
            }
            else {
                lblDetail.Text = "Payment Detail Records";
            }
        }
    }
}
