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
    public partial class BatchDocs : RcvPayment.MyForm {
        AppSettings aset;
        dbClassDataContext dc;

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

        private string BatchIdDescription() {
            string result = "";
            try {
                var q = (from item in dc.CRDepBatches
                         where (item.Id.CompareTo(BatchId) == 0)
                         select item).First();

                result = q.IDBank;
            }
            catch ( Exception ex ) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        #endregion

        #region Init
        public BatchDocs() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
            DragDropInit();
        }

        private void BatchDocs_Load(object sender, EventArgs e) {
            statLabel.Text = "";
        }
        #endregion

        #region Private Methods

        // (leftoj)
        private void loadPendingGrid() {
            var q = from m in dc.CRMasters
                    join sel in dc.CRDepItems on m.Id equals sel.CRMid into selRec
                    from x in selRec.DefaultIfEmpty()
                    where (m.State != "Deposited") && (x.Id == null)
                    orderby m.CDate
                    select m;


            dgvPend.DataSource = q;

            /* 
            Calculate total pending, and display somewhere at bottom.
            */

        }

        private void loadSelectedGrid() {
            if (BatchId != "") {
                var q = from item in dc.CRDepItems
                        where (item.IDBatch == BatchId)
                        orderby item.PayRef
                        select item;

                dgvSel.DataSource = q;
            }
        }
        #endregion

        #region DragDrop
        private int dragIndex;
        private DragDropEffects dragEffect;
        private Rectangle dragBoxFromMouseDown;
        private string dragId = "";
        private DragDropInfo ddInfo;

        private void DragDropInit() {
            ddInfo = new DragDropInfo("dgvPend");
        }

        private void dgvPend_MouseDown(object sender, MouseEventArgs e) {
            dragIndex = dgvPend.HitTest(e.X, e.Y).RowIndex;
            if ( dragIndex != -1 ) {
                dragEffect = DragDropEffects.Copy;
                Size dragSize = SystemInformation.DragSize;
                ddInfo.id = dgvPend.Rows[dragIndex].Cells["iddgvPend"].Value.ToString();
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                dgvPend.DoDragDrop(ddInfo, dragEffect);
            } else {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void dgvPend_MouseMove(object sender, MouseEventArgs e) {
            Console.WriteLine("Mouse Move");
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y)) {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvPend.DoDragDrop(ddInfo, DragDropEffects.Copy);
                    statLabel.Text = "Dragging...";
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
                if ( droppedObj.source == "dgvPend" ) {
                    if (e.Effect == DragDropEffects.Copy) {
                        droppedId = droppedObj.id;
                        AddMasterToItems(droppedId);
                        statLabel.Text = "Drop Id=" + droppedId;
                    }
                }
            }
        }

        private void AddMasterToItems(string Id) {
            if ( ! IdInSelectionAlready(Id) ) {
                InsertIdIntoSelection(Id);
                UpdateGrids();
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
                           where ( item.Id == id )
                           select item).First();

                if ( src != null ) {
                    CRDepItem dst = new CRDepItem();
                    dst.IDBatch = BatchId;
                    dst.CRMid = src.Id;
                    dst.Amount = src.Amount;
                    dst.PayRef = src.PayRef;
                    dst.PayType = src.PayType;
                    dc.CRDepItems.InsertOnSubmit(dst);
                    dc.SubmitChanges();
                    dc.Refresh(RefreshMode.OverwriteCurrentValues, dst);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private bool IdInSelectionAlready(string id) {
            bool result = false;
            try {
                var RecCount = (from item in dc.CRDepItems
                         where (item.IDBatch == BatchId) && (item.CRMid == id)
                         select item).Count();

                if (RecCount > 0 ) {
                    result = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        #endregion DragDrop
    }
    // (leftoj): https://msdn.microsoft.com/en-us/library/bb397895.aspx

}
