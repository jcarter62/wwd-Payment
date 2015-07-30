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

namespace RcvPayment {
    /// <summary>
    /// 
    /// </summary>
    public partial class BatchDocs : MyForm {
        AppSettings aset;
        DbClassDataContext dc;
        public PaymentBatches MyParent { get; set; }

        #region properties
        private string _BatchId;
        public string BatchId {
            get {
                return _BatchId;
            }
            set {
                _BatchId = value;
                textBatchId.Text = BatchIdDescription();
                loadPendingGrid();
                loadSelectedGrid();
            }
        }
        private bool allowChanges = false;

        private string BatchIdDescription() {
            string result = "";
            try {
                var q = (from item in dc.CRDepBatches
                         where (item.Id.CompareTo(BatchId) == 0)
                         select item).First();

                allowChanges = (q.State == "posted")? false : true;
                result = q.IDBank;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        #endregion

        #region Init
        public BatchDocs() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            MyParent = null;
            DragDropInit();
        }

        private void BatchDocs_Load(object sender, EventArgs e) {
            statLabel.Text = "";
            dgvPend.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvPend.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgvSel.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvSel.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        #endregion

        #region Private Methods

        // (leftoj)
        private void loadPendingGrid() {
            var q = from m in dc.CRMasters
                    join sel in dc.CRDepItems on m.Id equals sel.CRMid into selRec
                    from x in selRec.DefaultIfEmpty()
                    where (m.StateGA.ToLower() == "created") && (x.Id == null)
                    orderby m.CDate
                    select m;

            dgvPend.DataSource = q;
            /* 
            Calculate total pending, and display somewhere at bottom.
            */
            double total = 0.0;
            string lbl;
            foreach (var itm in q) {
                total += itm.Amount.Value;
            }
            lbl = string.Format("Pending Total Amount: {0}", total.ToString("C"));

            lblPendingTotal.Text = lbl;

            panLeft.Enabled = allowChanges;
        }

        private void loadSelectedGrid() {
            double total = 0.0;
            if (BatchId != "") {
                var q = from item in dc.CRDepItems
                        where (item.IDBatch == BatchId)
                        orderby item.PayRef
                        select item;

                dgvSel.DataSource = q;

                foreach (var itm in q) {
                    total += itm.Amount.Value;
                }
            }

            lblSelectedTotal.Text = string.Format("Selected Amount: {0}", total.ToString("C"));
            panRight.Enabled = allowChanges;
        }
        #endregion

        #region DragDrop
        private DragDropInfo ddInfoPending;
        private DragDropInfo ddInfoSelected;

        private void DragDropInit() {
            ddInfoPending = new DragDropInfo("dgvPend");
            ddInfoSelected = new DragDropInfo("dgvSelected");
        }

        private void dgvPend_MouseDown(object sender, MouseEventArgs e) {
            int dragIndex;
            Rectangle dragBoxFromMouseDown;
            dragIndex = dgvPend.HitTest(e.X, e.Y).RowIndex;
            if (dragIndex != -1) {
                Size dragSize = SystemInformation.DragSize;
                ddInfoPending.StartRegion = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                if (UserSelectedMultiRows(dgvPend)) {
                    ddInfoPending.IdList = ListOfSelectedIds(dgvPend, "iddgvPend");
                    ddInfoPending.IsAList = true;
                }
                else {
                    ddInfoPending.Id = dgvPend.Rows[dragIndex].Cells["iddgvPend"].Value.ToString();
                    ddInfoPending.IsAList = false;
                }
                dgvPend.DoDragDrop(ddInfoPending, DragDropEffects.Copy);
            }
            else {
                ddInfoPending.Id = "";
                ddInfoPending.StartRegion = Rectangle.Empty;
            }
        }

        private List<string> ListOfSelectedIds(DataGridView grid, string v) {
            var lst = new List<string>();
            foreach (DataGridViewRow row in grid.SelectedRows) {
                lst.Add(row.Cells[v].Value.ToString());
            }
            return lst;
        }

        private bool UserSelectedMultiRows(DataGridView gridview) {
            bool result = false;
            try {
                if (gridview.SelectedRows.Count > 1)
                    result = true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        private void dgvPend_MouseMove(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                if (ddInfoPending.StartRegion != Rectangle.Empty) {
                    // If the mouse moves outside the rectangle, start the drag.
                    if (!ddInfoPending.StartRegion.Contains(e.X, e.Y)) {
                        // Proceed with the drag and drop, passing in the list item.   
                        DragDropEffects dropEffect = dgvPend.DoDragDrop(ddInfoPending, DragDropEffects.Copy);
                        statLabel.Text = "Dragging...";
                    }
                }
            }
        }

        private void dgvSel_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void dgvSel_DragDrop(object sender, DragEventArgs e) {
            DragDropInfo droppedObj;
            string droppedId;

            if (e.Data.GetDataPresent(typeof(DragDropInfo))) {
                droppedObj = (DragDropInfo)e.Data.GetData(typeof(DragDropInfo));
                if (droppedObj.Source == "dgvPend") {
                    if (e.Effect == DragDropEffects.Copy) {
                        if (droppedObj.IsAList) {
                            foreach (string s in droppedObj.IdList) {
                                AddMasterToItems(s);
                            }
                            statLabel.Text = "Drop Id=Multiple";
                        }
                        else {
                            AddMasterToItems(droppedObj.Id);
                            statLabel.Text = "Drop Id=" + droppedObj.Id;
                        }
                    }
                }
            }
        }

        private void dgvSel_MouseDown(object sender, MouseEventArgs e) {
            int dragIndex;
            dragIndex = dgvSel.HitTest(e.X, e.Y).RowIndex;
            if (dragIndex != -1) {
                Size dragSize = SystemInformation.DragSize;
                ddInfoSelected.StartRegion = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                if (UserSelectedMultiRows(dgvSel)) {
                    ddInfoSelected.IdList = ListOfSelectedIds(dgvSel, "iddgvSel");
                    ddInfoSelected.IsAList = true;
                }
                else {
                    ddInfoSelected.Id = dgvSel.Rows[dragIndex].Cells["iddgvSel"].Value.ToString();
                    ddInfoSelected.IsAList = false;
                }
                dgvPend.DoDragDrop(ddInfoSelected, DragDropEffects.Copy);
                Console.WriteLine(ddInfoSelected.ToString("mouse down"));
            }
            else {
                ddInfoSelected.Id = "";
                ddInfoSelected.StartRegion = Rectangle.Empty;
            }
        }

        private void dgvSel_MouseMove(object sender, MouseEventArgs e) {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                if (ddInfoSelected.StartRegion != Rectangle.Empty) {
                    // If the mouse moves outside the rectangle, start the drag.
                    if (!ddInfoSelected.StartRegion.Contains(e.X, e.Y)) {
                        // Proceed with the drag and drop, passing in the list item.                    
                        DragDropEffects dropEffect = dgvPend.DoDragDrop(ddInfoSelected, DragDropEffects.Copy);
                        statLabel.Text = "Dragging...";
                        Console.WriteLine(ddInfoSelected.ToString("mouse move"));
                    }
                }
            }
        }

        private void dgvPend_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void dgvPend_DragDrop(object sender, DragEventArgs e) {
            DragDropInfo droppedObj;
            string droppedId;

            if (e.Data.GetDataPresent(typeof(DragDropInfo))) {
                droppedObj = (DragDropInfo)e.Data.GetData(typeof(DragDropInfo));
                Console.WriteLine(droppedObj.ToString("Drop"));
                if (droppedObj.Source == "dgvSelected") {
                    if (e.Effect == DragDropEffects.Copy) {
                        if (droppedObj.IsAList) {
                            foreach (string s in droppedObj.IdList) {
                                RemoveMasterIdFromItems(s);
                            }
                            statLabel.Text = "Remove Id=Multiple";
                        }
                        else {
                            RemoveMasterIdFromItems(droppedObj.Id);
                            statLabel.Text = "Remove Id=" + droppedObj.Id;
                        }
                    }
                }
            }
        }

        #region DragDrop Misc
        private void AddMasterToItems(string Id) {
            if (!IdInSelectionAlready(Id)) {
                InsertIdIntoSelection(Id);
                UpdateGrids();
            }
        }

        private void RemoveMasterIdFromItems(string Id) {
            if (IdInSelectionAlready(Id)) {
                RemoveIdFromSelection(Id);
                UpdateGrids();
            }
        }

        private void RemoveIdFromSelection(string id) {
            try {
                // Find record
                CRDepItem src = (from item in dc.CRDepItems
                                 where (item.Id == id)
                                 select item).First();


                if (src != null) {
                    CRMaster mst = (from m in dc.CRMasters
                                    where (m.Id == src.CRMid)
                                    select m).First();

                    if (mst != null) {
                        mst.StateGA = "created";
                    }

                    dc.CRDepItems.DeleteOnSubmit(src);
                    dc.SubmitChanges();
                    dc.Refresh(RefreshMode.OverwriteCurrentValues, mst);
                    dc.Refresh(RefreshMode.OverwriteCurrentValues, dc.CRDepItems );

                    // Update CRDepBatch Record with 
                    // new totals.
                    UpdateCRBatchTotals();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateGrids() {
            loadPendingGrid();
            loadSelectedGrid();
        }

        private void InsertIdIntoSelection(string id) {
            try {
                // Get CRMaster record for this id
                var src = (from item in dc.CRMasters
                           where (item.Id == id)
                           select item).First();

                if (src != null) {
                    // Update master record state.
                    src.StateGA = "selected";
                    // Insert new record into selections
                    CRDepItem dst = new CRDepItem();
                    dst.IDBatch = BatchId;
                    dst.CRMid = src.Id;
                    dst.Amount = src.Amount;
                    dst.PayRef = src.PayRef;
                    dst.PayType = src.PayType;
                    dst.State = "selected";
                    dc.CRDepItems.InsertOnSubmit(dst);
                    dc.SubmitChanges();
                    dc.Refresh(RefreshMode.OverwriteCurrentValues, dst);

                    // Update CRDepBatch Record with 
                    // new totals.
                    UpdateCRBatchTotals();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateCRBatchTotals() {
            double BatchAmount = 0.0;
            int BatchQty = 0;

            // Calculate Totals
            var items = (from item in dc.CRDepItems
                         where item.IDBatch == BatchId
                         select item);

            foreach (var rec in items) {
                BatchAmount += rec.Amount.Value;
                BatchQty += 1;
            }

            // Update/Save Totals to Batch Record.
            var BatchRecord = (from r in dc.CRDepBatches
                               where r.Id == BatchId
                               select r).First();

            if (BatchRecord != null) {
                BatchRecord.Qty = BatchQty;
                BatchRecord.Amount = BatchAmount;
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, BatchRecord);
                if (MyParent != null)
                    MyParent.UpdateDetailAmounts();
            }
        }

        private bool IdInSelectionAlready(string id) {
            bool result = false;
            try {
                var RecCount = (from item in dc.CRDepItems
                                where (item.IDBatch == BatchId) &&
                                ((item.CRMid == id) || (item.Id == id))
                                select item).Count();

                if (RecCount > 0) {
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        #endregion DragDrop Misc

        #endregion DragDrop

        private void BatchDocs_FormClosing(object sender, FormClosingEventArgs e) {
            if (MyParent != null) {
                MyParent.ReturningFromDocuments();
            }

        }
    }
    // (leftoj): https://msdn.microsoft.com/en-us/library/bb397895.aspx
}
