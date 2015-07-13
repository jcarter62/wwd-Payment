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
        int detailAmountCol;
        int detailAccountCol;

        #region Constructor
        public UnApplied() {
            InitializeComponent();
            localInit();
            DragDropInit();
        }

        private void localInit() {
            masterIdCol = 0;
            masterRcptIDCol = 0;
            detailIdCol = 0;
            detailAmountCol = 0;
            detailAccountCol = 0;


            currentMasterId = null;
            currentMasterRow = -1;

            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            OpenMasterTable();
        }
        #endregion

        #region Data Stuff
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

        private void LoadDetailRecords() {
            gridDetail.DataSource = null;

            foreach (DataGridViewRow r in gridDetail.Rows) {
                gridDetail.Rows.Remove(r);
            }

            var detail = (from dtl in dc.CRDetails
                          where dtl.CRMid == currentMasterId
                          orderby dtl.Account descending, dtl.Amount ascending
                          select dtl);

            gridDetail.DataSource = detail;

            // Determine column for Id field.
            detailIdCol = 0;
            for (int c = 0; c < gridDetail.ColumnCount; c++) {
                string colname = gridDetail.Columns[c].DataPropertyName.ToLower();
                if (colname == "id") {
                    detailIdCol = c;
                }
                else if (colname == "amount") {
                    detailAmountCol = c;
                }
                else if (colname == "account") {
                    detailAccountCol = c;
                }
            }
        }
        #endregion Data Stuff

        #region Row Selection Activity
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
                LoadDetailRecords();
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
        #endregion Row Selection Activity

        #region Drag Drop

        #region Detail Grid

        private DragDropInfo ddDetail;
        private string copyBuffer;

        private void DragDropInit() {
            ddDetail = new DragDropInfo("gridDetail");
            copyBuffer = "";
        }

        private void gridDetail_MouseDown(object sender, MouseEventArgs e) {
            //
            int dragIndex;
            dragIndex = gridDetail.HitTest(e.X, e.Y).RowIndex;
            if (dragIndex != -1) {
                Size dragSize = SystemInformation.DragSize;
                ddDetail.StartRegion = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                ddDetail.Id = gridDetail.Rows[dragIndex].Cells[detailIdCol].Value.ToString();
                ddDetail.IsAList = false;
                //                copyBuffer = DetailCopyInfo(dragIndex);
                copyBuffer = GetSelectedRecords(gridDetail.SelectedRows);
                if ((copyBuffer != null) && (copyBuffer.Length > 0)) {
                    gridDetail.DoDragDrop(ddDetail, DragDropEffects.Copy);
                    Clipboard.Clear();
                    Clipboard.SetText(copyBuffer);
                    statLabel.Text = copyBuffer;
                }
            }
            else {
                ddDetail.Id = "";
                ddDetail.StartRegion = Rectangle.Empty;
                statLabel.Text = "";
            }

        }

        // Create list of record IDs to paste into wmis.
        private string GetSelectedRecords(DataGridViewSelectedRowCollection selectedRows) {
            string result = "";
            string sep = ",";
            foreach (DataGridViewRow r in selectedRows) {
                result = result + r.Cells[detailIdCol].Value.ToString() + sep;
            }
            result = "id" + sep + result;
            return result;
        }

        private string DetailCopyInfo(int index) {
            string result = "";
            string sep = ",";
            string id = gridDetail.Rows[index].Cells[detailIdCol].Value.ToString();
            //            string account = gridDetail.Rows[index].Cells[detailAccountCol].Value.ToString();
            //            string amount = gridDetail.Rows[index].Cells[detailAmountCol].Value.ToString();

            result = "id" + sep + id;
            return result;
        }


        private void gridDetail_MouseMove(object sender, MouseEventArgs e) {
            //Console.WriteLine(ShowDragLocation(ddDetail, e.X, e.Y));
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                if (ddDetail.StartRegion != Rectangle.Empty) {
                    // If the mouse moves outside the rectangle, start the drag.
                    if (!ddDetail.StartRegion.Contains(e.X, e.Y)) {
                        // Proceed with the drag and drop, passing in the list item.   
                        DragDropEffects dropEffect = gridDetail.DoDragDrop(ddDetail, DragDropEffects.Copy);
                        // statLabel.Text = "Dragging...";
                        statLabel.Text = "Dragging: " + copyBuffer;
                    }
                }
            }

        }

        private string ShowDragLocation(DragDropInfo ddInfo, int x, int y) {
            string result = "";

            if (ddInfo != null) {
                result = string.Format("Start Region: x={0} y={1}, Mouse Position: x={2} y={3}",
                                ddInfo.StartRegion.X, ddInfo.StartRegion.Y, x, y);
            }
            else {
                result = string.Format("Drag Drop Info = null, Mouse Position: x={0} y={1}", x, y);
            }
            return result;
        }

        #endregion Detail Grid

        #endregion Drag Drop

    }
}

