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
using System.Collections;
using DbCombined;
using System.Threading.Tasks;

namespace RcvPayment {
    public partial class UnpaidList : RcvPayment.MyForm {
        private string initialTitle;
        private NewPayment myParent = null;
        private string account;
        public string Account {
            get { return account; }
            set {
                account = value;
                this.Text = initialTitle.Trim() + " " + account;

                // Save this account to an int.
                int accountInt;
                int.TryParse(account, out accountInt);
                AccountKey = accountInt;

                LoadOutstandingData();
            }
        }
        public int AccountKey { get; set; }
        public CustomerType custType { get; set; }

        private AppSettings aset;
        private AllAccounts dbcombined;
        private OutstandingCharges dbCharges;

        #region Constructors / Init
        public UnpaidList(NewPayment caller) {
            InitializeComponent();
            Init();
            myParent = caller;
        }

        public UnpaidList() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            initialTitle = this.Text;
            aset = new AppSettings();
            dbcombined = new AllAccounts();
            dbCharges = new OutstandingCharges();
            InitGridAccounts();
        }

        private void InitGridAccounts() {
            gridAccounts.AutoGenerateColumns = true;
            gridAccounts.DataSource = dbcombined.Data;
            SetColumns(gridAccounts);
        }

        private void SetColumns(DataGridView grid) {
            string columnName;
            FontFamily ff = DataGridView.DefaultFont.FontFamily;
            float fsize = DataGridView.DefaultFont.Size;
            var defFont = new Font(ff, fsize * (float)0.75);
            if (grid.Name == "gridAccounts") {
                foreach (DataGridViewColumn c in grid.Columns) {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    c.DefaultCellStyle.Font = defFont;
                    columnName = c.Name.ToLower();
                    if (columnName == "id") {
                        c.HeaderText = "Acct";
                        c.Visible = true;
                    }
                    else if (columnName == "name") {
                        c.HeaderText = "Account Name";
                        c.Visible = true;
                    }
                    else if (columnName == "source") {
                        c.HeaderText = "Data Source";
                        c.Visible = true;
                    }
                    else {
                        c.Visible = false;
                    }
                }
            }
            else {
                foreach (DataGridViewColumn c in grid.Columns) {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    c.DefaultCellStyle.Font = defFont;
                    columnName = c.Name.ToLower();
                    if (columnName == "trantype") {
                        c.HeaderText = "Type";
                        c.Visible = true;
                    }
                    else if (columnName == "description") {
                        c.HeaderText = "Parcel";
                        c.Visible = true;
                    }
                    else if (columnName == "duedate") {
                        c.HeaderText = "Due Date";
                        c.Visible = true;
                    }
                    else if (columnName == "amount") {
                        c.HeaderText = "Amount";
                        c.Visible = true;
                        c.DefaultCellStyle.Format = "C2";
                    }
                    else if (columnName == "account") {
                        c.HeaderText = "Account";
                        c.Visible = true;
                    }
                    else if (columnName == "invoice") {
                        c.HeaderText = "Invoice No";
                        c.Visible = true;
                    }
                    else {
                        c.Visible = false;
                    }
                }
            }

        }
        #endregion Constructors / Init

        private void textSearch_TextChanged(object sender, EventArgs e) {
            string srch = textSearch.Text.Trim();

            if (srch.Length <= 0) {
                ClearFilter();
            }
            else {
                SetFilter(srch);
            }
        }

        private void SetFilter(string srch) {
            dbcombined.Search = srch.ToLower();
        }

        private void ClearFilter() {
            dbcombined.Search = "";
        }

        private void LoadOutstandingData() {
            ShowLoading(true);
            gridCharges.AutoGenerateColumns = true;
            dbCharges.CustType = custType;
            dbCharges.AccountKey = AccountKey;
            gridCharges.DataSource = dbCharges.Data;
            SetColumns(gridCharges);
            ShowLoading(false);
        }

        private void ShowLoading(bool v) {
            if (v) {
                gridCharges.Visible = false;
                labelLoading.Text = "... Loading ...";
                labelLoading.Visible = true;
                labelLoading.Invalidate();
                labelLoading.Update();
            }
            else {
                labelLoading.Visible = false;
                gridCharges.Visible = true;
            }
        }


        /// <summary>
        /// User selected an Account on left grid.  Load the details for this
        /// account in right grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridAccounts_CellClick(object sender, DataGridViewCellEventArgs e) {
            //
            int id;
            int newindex;
            string custTypeStr;
            string acctStr;
            if (gridAccounts.SelectedRows.Count > 0) {
                newindex = e.RowIndex;
                acctStr = gridAccounts.Rows[newindex].Cells["Key"].Value.ToString();
                custTypeStr = gridAccounts.Rows[newindex].Cells["Source"].Value.ToString();
                int.TryParse(acctStr, out id);
                custType = custTypeStr.Equals("wmis") ?
                    CustomerType.Wmis : CustomerType.Mas500;

                // setting this property, will load the charges grid.
                Account = id.ToString();
            }
        }
    }
}
