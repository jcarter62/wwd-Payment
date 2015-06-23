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
        }

        private void BatchDocs_Load(object sender, EventArgs e) {
            statLabel.Text = "";
        }
        #endregion

        #region Private Methods
        private void loadPendingGrid() {
            var q = from item in dc.CRMasters
//                    where ( item.Deposited == false ) && (item.State == "Created")
                    orderby item.CDate 
                    select item;

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

        private void dgvPend_MouseDown(object sender, MouseEventArgs e) {
            Console.WriteLine("Mouse Down");
            dragIndex = dgvPend.HitTest(e.X, e.Y).RowIndex;
            if ( dragIndex != -1 ) {
                dragEffect = DragDropEffects.Copy;
                Size dragSize = SystemInformation.DragSize;

                dragId = dgvPend.Rows[dragIndex].Cells["iddgvPend"].Value.ToString();
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                
                dgvPend.DoDragDrop(new object(), dragEffect);
                statLabel.Text = "Mouse Down: " + dragId;
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
                    DragDropEffects dropEffect = dgvPend.DoDragDrop(new object(), DragDropEffects.Copy);
                    statLabel.Text = "Mouse Move: " + dragId;
                }
            }
        }

        private void dgvSel_DragOver(object sender, DragEventArgs e) {
            Console.WriteLine("Drag Over");
            e.Effect = DragDropEffects.Copy;
        }

        private void dgvSel_DragDrop(object sender, DragEventArgs e) {
            Console.WriteLine("Drag Drop");
            if ( e.Data.GetDataPresent( typeof(DataGridViewRow )) ) {
                if ( e.Effect == DragDropEffects.Copy ) {
                    statLabel.Text = "Drag Drop: " + dragId;
                    MessageBox.Show("Drop : " + dragId);
                }
            }
        }
        #endregion DragDrop
    }
}
