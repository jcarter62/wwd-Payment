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
        int masterStateARIdCol;
        Color defaultRowColor = Color.White;

        int detailIdCol;
        int detailAmountCol;
        int detailAccountCol;

        #region Constructor
        public UnApplied() {
            InitializeComponent();
            localInit();
            //            DragDropInit();
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

            /*
                        var mst = (from pmt in dc.CRMasters
                                   where pmt.StateAR == "created" ||
                                   pmt.StateAR == "selected"
                                   orderby pmt.CDate descending
                                   select pmt);
            */
            var mst =
            from pmt in dc.CRMasters
            from log in dc.TblLogs.Where(log => ((pmt.Id == log.tblId) && (log.txt == "receiving post"))).DefaultIfEmpty()
            where (pmt.StateRcv == "posted") && (pmt.StateAR != "posted")
            orderby pmt.CDate descending
            select new {
                pmt.Id,
                pmt.RcptID,
                pmt.CDate,
                pmt.Postmark,
                pmt.DeliveryName,
                pmt.PayRef,
                pmt.Note,
                pmt.Amount,
                logid = log.id,
                postdate = log.cdate,
                postuser = log.cuser,
                log.txt,
                pmt.StateAR
            };

            WipeColumns(gridMaster);
            foreach (var rec in mst) {
                //        grid object, field name, header text
                AddColumn(gridMaster, "CDate", "Created");
                AddColumn(gridMaster, "DeliveryName", "Name");
                AddColumn(gridMaster, "PayRef", "Check/Ref");
                AddColumn(gridMaster, "Amount", "Amount", IsCurrency: true);
                AddColumn(gridMaster, "RcptID", "Receipt ID");
                AddColumn(gridMaster, "postdate", "Rcv Post At");
                AddColumn(gridMaster, "postuser", "By");
                AddColumn(gridMaster, "Note", "Notes");
                AddColumn(gridMaster, "Id", "Id", hidden: true);
                AddColumn(gridMaster, "StateAR", "State");
                break;
            }

            defaultRowColor = gridMaster.DefaultCellStyle.BackColor;
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
                else if (colname == "statear") {
                    masterStateARIdCol = c;
                }
            }
        }

        private void AddColumn(DataGridView grid, string colName, string colTitle,
                               bool hidden = false, bool IsCurrency = false) {
            var cellStyle = new DataGridViewCellStyle();
            DataGridViewColumn c = new DataGridViewTextBoxColumn();  // new DataGridViewColumn();
            c.Resizable = DataGridViewTriState.True;
            c.DividerWidth = 1;
            c.DataPropertyName = colName;
            c.HeaderText = colTitle;
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            if (hidden) {
                c.Visible = false;
            }
            if (IsCurrency) {
                cellStyle.Format = "C2";
                cellStyle.NullValue = null;
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            c.DefaultCellStyle = cellStyle;
            grid.Columns.Add(c);
        }

        private void WipeColumns(DataGridView grid) {
            grid.Columns.Clear();
        }

        private void LoadDetailRecords() {
            gridDetail.DataSource = null;
            gridDetail.Rows.Clear();

            var detail = (
            from dtl in dc.CRDetails
            from n in dc.NAMEs.Where(n => dtl.Account == n.NAME_ID.ToString()).DefaultIfEmpty()
            where dtl.CRMid == currentMasterId
            orderby dtl.Account descending, dtl.Amount ascending
            select new {
                dtl.Type,
                dtl.Amount,
                dtl.Account,
                dtl.State,
                dtl.Id,
                n.FullName,
                dtl.Note
            });


            WipeColumns(gridDetail);
            foreach (var rec in detail) {
                //        grid object, field name, header text
                AddColumn(gridDetail, "Type", "Type");
                AddColumn(gridDetail, "Amount", "Amount", IsCurrency: true);
                AddColumn(gridDetail, "Account", "Account");
                AddColumn(gridDetail, "FullName", "Account Name");
                AddColumn(gridDetail, "State", "State");
                AddColumn(gridDetail, "Note", "Notes");
                AddColumn(gridDetail, "Id", "Id", hidden: true);
                break;
            }

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
            timeCheck_Stop();
        }


        private void MasterSelected() {
            if (currentMasterRow >= 0) {
                lblDetail.Text = string.Format("Payment Detail Records for {0}",
                    gridMaster.Rows[currentMasterRow].Cells[masterRcptIDCol].Value);
                copyBuffer = "id," + currentMasterId;
                statLabel.Text = copyBuffer;

                UpdateDetailWindow(currentMasterId);
            }
            else {
                lblDetail.Text = "Payment Detail Records";
            }
        }
        #endregion Row Selection Activity

        #region Drag Drop

        private string copyBuffer;
        private DragDropInfo ddDetail;
        private DragDropInfo ddMaster;

        #region Detail Grid

        private void DragDropInit() {
            ddDetail = new DragDropInfo("gridDetail");
            ddMaster = new DragDropInfo("gridMaster");
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

        #region Context Menus
        private void SelectMasterRecordsClick(object sender, EventArgs e) {
            // User clicked Select Master Records.
            string copyBuffer;
            copyBuffer = EnumerateSelectedMasterRecords(gridMaster.SelectedRows);
            if ((copyBuffer != null) && (copyBuffer.Length > 0)) {
                Clipboard.Clear();
                Clipboard.SetText(copyBuffer);
                statLabel.Text = copyBuffer;
                timeCheck_Start();
            }
        }

        // Create list of selected record ids, in form "id,guid1,guid2,...".
        private string EnumerateSelectedMasterRecords(DataGridViewSelectedRowCollection selectedRows) {
            string result = "";
            string sep = ",";
            foreach (DataGridViewRow r in selectedRows) {
                result = result + r.Cells[masterIdCol].Value.ToString() + sep;
            }
            result = "id" + sep + result;
            return result;
        }
        #endregion Context Menus

        private void SelectDetailRecordsClick(object sender, EventArgs e) {
            // User clicked Select Detail Records.
            string copyBuffer;
            copyBuffer = EnumerateSelectedDetailRecords(gridDetail.SelectedRows);
            if ((copyBuffer != null) && (copyBuffer.Length > 0)) {
                Clipboard.Clear();
                Clipboard.SetText(copyBuffer);
                statLabel.Text = copyBuffer;
                timeCheck_Start();
            }
        }

        private string EnumerateSelectedDetailRecords(DataGridViewSelectedRowCollection selectedRows) {
            string result = "";
            string sep = ",";
            foreach (DataGridViewRow r in selectedRows) {
                result = result + r.Cells[detailIdCol].Value.ToString() + sep;
            }
            result = "id" + sep + result;
            return result;
        }

        // Show Selected Rows differently
        // ref: http://stackoverflow.com/a/19380320
        private void gridMaster_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            // masterStateARIdCol = c;

            foreach (DataGridViewRow r in gridMaster.Rows) {
                if (r.Cells[masterStateARIdCol].Value.ToString() == "selected") {
                    r.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
                else {
                    r.DefaultCellStyle.BackColor = defaultRowColor;
                }
            }
        }

        string initialTimeCheckHash = "";
        int timestate;

        private void timeCheck_Start() {
            timestate = 0;
            initialTimeCheckHash = calculateHash();
            timeCheck.Enabled = true;
        }

        private void timeCheck_Stop() {
            timeCheck.Enabled = false;
        }

        private string calculateHash() {
            string records;
            string hashnow;
            var r =
            from m in dc.CRMasters
            from d in dc.CRDetails.Where(d => (m.Id == d.CRMid)).DefaultIfEmpty()
            where (m.StateRcv == "posted") && (m.StateAR != "posted")
            orderby m.Id ascending, d.Id ascending
            select new {
                masterid = m.Id,
                m.StateAR,
                detailid = d.Id,
                d.State
            };

            records = "";
            foreach (var rec in r) {
                records = records +
                    rec.masterid +
                    rec.StateAR +
                    rec.detailid +
                    rec.State;
            }

            r = null;

            hashnow = records.GetHashCode().ToString();
            return hashnow;
        }

        private void timeCheck_Tick(object sender, EventArgs e) {

            // Check to see if the current record states have changed.
            if (recordsChanged()) {
                UpdateDisplay();
            }

            timestate++;
            if ( timestate > 8) timestate = 0;

            string x;
            switch (timestate)
            {
                case 0:
                    x = "|";
                    break;
                case 1:
                    x = "/";
                    break;
                case 2:
                    x = "-";
                    break;
                case 3:
                    x = "\\";
                    break;
                case 4: 
                    x = "|";
                    break;
                case 5:
                    x = "/";
                    break;
                case 6:
                    x = "-";
                    break;
                case 7:
                    x = "\\";
                    break;
                case 8:
                    x = "|";
                    break;
                default:
                    x = " ";
                    break;
            }
            timeLbl.Text = x;
            timeLbl.Refresh();
        }

        private void UpdateDisplay() {
            OpenMasterTable();
            timeCheck_Start();
        }

        private bool recordsChanged() {
            string hashnow;
            bool result;

            result = false;
            hashnow = calculateHash();
            if (hashnow.CompareTo(initialTimeCheckHash) != 0) {
                timeCheck.Enabled = false;
                result = true;
            }
            return result;
        }

        private void gridDetail_RowEnter(object sender, DataGridViewCellEventArgs e) {
            timeCheck_Stop();
        }

        private void UpdateDetailWindow(string currentID) {
            string fname = "paymentdetails";
            Form f = null;

            if (isFormOpen(fname)) {
                GetFormPtr(fname, ref f);
                if (f != null) {
                    (f as PaymentDetails).Id = currentID;
                }
            }
        }
    }
}

