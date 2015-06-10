using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using classLib;
using dataLib;

namespace RcvPayment {
    public partial class CustList : RcvPayment.MyForm {
        #region Properties
        private AppSettings aset;
        private dbClassDataContext dc;
        private BindingSource bsrc;
        public NewPayment myParent { get; set; }
        public string selectedAccount { get; set; }
        public string selectedName { get; set; }
        #endregion

        #region Constructors
        public CustList(NewPayment caller ) {
            InitializeComponent();
            init();
            myParent = caller;
        }

        public CustList() {
            InitializeComponent();
            init();
        }

        private void init() {
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
            selectedAccount = "";
            selectedName = "";
        }
        #endregion

        #region Initializers
        private void CustList_Load(object sender, EventArgs e) {
            LoadGrid();
        }

        private void LoadGrid() {
            IQueryable<CRAccount> q = from itm in dc.CRAccounts
                    orderby itm.AccountNoInt
                    select itm ;

            bsrc = new BindingSource();
            bsrc.DataSource = q;
            CustGrid.DataSource = bsrc;
        }
        #endregion

        #region Events
        /// <summary>
        /// User selected one row.  Send back to NewPayments window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e) {
            if ( myParent != null ) {
                myParent.ItemAccount = selectedAccount;
                myParent.ItemName = selectedName;
            }
        }

        // Search Text box changed.
        private void textBoxTrak1_TextChanged(object sender, EventArgs e) {
            string inp;
            inp = textBoxTrak1.Text.Trim().ToLower() ;
            IQueryable<CRAccount> q;

            if ( inp.Length > 0 ) {
                q = from itm in dc.CRAccounts
                    where itm.AccountName.Contains(inp)
                    orderby itm.AccountNoInt
                    select itm;
            } else {
                q = from itm in dc.CRAccounts
                    orderby itm.AccountNoInt
                    select itm;
            }
            bsrc.DataSource = q;
        }

        private void CustGrid_Click(object sender, EventArgs e) {
            // User selected row, 
            foreach ( DataGridViewRow r in CustGrid.SelectedRows ) {
                selectedAccount = r.Cells["accountNoDataGridViewTextBoxColumn"].Value.ToString();
                selectedName = r.Cells["accountNameDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void CustGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            CustGrid_Click(sender, e);
            btnSelect_Click(sender, e);
            myParent.BringToFront();
        }
        #endregion
    }
}
