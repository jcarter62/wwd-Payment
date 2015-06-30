﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using classLib;
using dataLib;
using System.Data.Linq;
using System.Linq;

namespace RcvPayment {
    public partial class PaymentBatches : RcvPayment.MyForm {
        AppSettings aset;
        DbClassDataContext dc;

        // CurrentId is the guid of the batch record.
        // the user does not see this normally.
        private string _CurrentId;
        public string CurrentId {
            get {
                return _CurrentId;
            }
            private set {
                _CurrentId = value;
                DisplayBatchDetails();
                UpdateStatusStrip();
            }
        }


        public PaymentBatches() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            CurrentId = "";
            InitStatusLabels();
        }

        private void PaymentBatches_Load(object sender, EventArgs e) {
            ConnectGrid();
        }

        private void ConnectGrid() {
            try {
                // first remove all rows...
                dgv.DataSource = null;
                foreach (DataGridViewRow r in dgv.Rows) {
                    dgv.Rows.Remove(r);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            // now connect to real data.
            var q = from item in dc.CRDepBatches
                    orderby item.IDBank descending
                    select item;

            dgv.DataSource = q;
        }

        private void btnAdd_click(object sender, EventArgs e) {
            string id;
            id = CreateNewBatch();
            CurrentId = id;
            FindBatch();
        }

        private void DisplayBatchDetails(bool forceReload = false) {
            try {
                var q = (from item in dc.CRDepBatches
                         where item.Id == CurrentId
                         select item).FirstOrDefault();

                if (forceReload) {
                    dc.Refresh(RefreshMode.OverwriteCurrentValues, q);
                }

                if (q != null) {
                    textId.Text = q.IDBank;
                    lblDocCount.Text = int2StringFmt(q.Qty, "D3");
                    lblAmount.Text = double2StringFtm(q.Amount, "");
                    lblCreated.Text = DatetimeByUser(q.CUser, q.CDate, "g"); // "g" == (1)
                    lblModified.Text = DatetimeByUser(q.UUser, q.UDate, "g");
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private string DatetimeByUser(string cUser, DateTime? cDate, string fmt) {
            string result = "";

            if (cDate.HasValue) {
                result = result + cDate.Value.ToString(fmt);
            }
            result = result + " by " + cUser;

            return result;
        }

        private string double2StringFtm(double? amount, string v) {
            double n;
            string result;
            n = (amount.HasValue ? amount.Value : 0.0);
            result = n.ToString("C2");
            return result;
        }

        private string int2StringFmt(int? qty, string v) {
            int i;
            string result;
            i = (qty.HasValue ? qty.Value : 0);
            result = i.ToString(v);
            return result;
        }

        private string CreateNewBatch() {
            string result;
            CRDepBatch r = new CRDepBatch();
            r.IDBank = GenerateNewBankId();
            result = r.Id;
            Console.WriteLine("CreateNewBatch: Result 1 : {0}", result);

            dc.CRDepBatches.InsertOnSubmit(r);
            try {
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, r);
                ConnectGrid();
                CurrentId = r.Id;
                Console.WriteLine("CreateNewBatch: CurrentId 2 : {0}", CurrentId);
                FindBatch();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        private string GenerateNewBankId() {
            string result;
            string baseid = "";
            int num = 0;
            DateTime curDate = DateTime.Now;
            string testid;

            baseid = "DT" + curDate.ToString("yyyyMMdd");
            do {
                num = num + 1;
                testid = baseid + num.ToString("D3");
            } while (BankIdExists(testid));

            result = testid;

            return result;
        }

        private bool BankIdExists(string proposedId) {
            bool result = true;

            var q = (from item in dc.CRDepBatches
                     where item.IDBank == proposedId
                     select item).Count();

            result = (q == 0 ? false : true);

            return result;
        }

        private void FindBatch() {
            string rowid = "";
            int rownum = -1;

            foreach (DataGridViewRow row in dgv.Rows) {
                rowid = row.Cells["id"].Value.ToString();
                if (rowid == CurrentId) {
                    rownum = row.Index;
                    break;
                }
            }

            if (rownum > 0) {
                // we found it!
                dgv.Rows[rownum].Selected = true;
                dgv.FirstDisplayedScrollingRowIndex = rownum;
            }
        }

        private void userSelectedRow() {
            DisplayBatchDetails();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e) {
            int newindex;
            if (dgv.SelectedRows.Count > 0) {
                newindex = e.RowIndex;
                CurrentId = dgv.Rows[newindex].Cells["id"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            var records = from item in dc.CRDepBatches
                          where item.Id == CurrentId
                          select item;

            foreach (var q in records) {
                q.IDBank = textId.Text.Trim();
            }

            try {
                dc.SubmitChanges();
                dc.Refresh(RefreshMode.OverwriteCurrentValues, records);
                ConnectGrid();
                FindBatch();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        #region Diagnostics
        private string GridId { get; set; }
        private string DetlId { get; set; }

        private void InitStatusLabels() {
            statDetail.Text = "";
            statGrid.Text = "";
        }

        private void UpdateStatusStrip() {
            string idOfGridSelected = "";


            if (dgv.SelectedRows.Count > 0) {
                idOfGridSelected = dgv.SelectedRows[0].Cells["id"].Value.ToString();
            }

            statDetail.Text = CurrentId;
            statGrid.Text = idOfGridSelected;
        }

        #endregion Diagnostics

        private void dgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e) {
        }

        private void btnDelete_Click(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
        }

        private void btnDocs_Click(object sender, EventArgs e) {
            if (CurrentId != "") {
                var f = new BatchDocs();
                f.MdiParent = this.MdiParent;
                f.Show();
                f.BatchId = CurrentId;
                f.MyParent = this;
                this.DisableControls();
            }
        }

        public void ReturningFromDocuments() {
            this.EnableControls();
        }

        private void dgv_DoubleClick(object sender, EventArgs e) {
            btnDocs_Click(sender, e);
        }

        private void DisableControls() {
            panLeft.DisableControls();
            panRight.DisableControls();
        }

        private void EnableControls() {
            panLeft.EnableControls();
            panRight.EnableControls();
        }

        public void UpdateDetailAmounts() {
            DisplayBatchDetails(forceReload: true);
        }

        private void btnPost_Click(object sender, EventArgs e) {
            // User wishes to post a batch
            if (BatchIsOkToPost()) {
                PostThisBatch();
            }
        }

        private void PostThisBatch() {
            string poststring = "posted";
            // Note, since there is only 1 submitchanges(), we don't
            // need to explicly create a transaction.
            //
            // 1. First update the main batch record, changing the state.
            // 2. Next change the CRMaster Records to show posted status.
            // 3. Next update the batch item records, to posted.
            // 4. Next update CRDetail Records if any to show posted status.

            try {
                // (1)
                CRDepBatch batchRec = (from item in dc.CRDepBatches
                                       where item.Id == CurrentId
                                       select item).First();

                batchRec.State = poststring;

                IQueryable<CRDepItem> itemRecs = (from item in dc.CRDepItems
                                                  where item.IDBatch == CurrentId
                                                  select item);

                foreach (CRDepItem oneitem in itemRecs) {
                    // (2)
                    oneitem.State = poststring;

                    CRMaster mst = (from r in dc.CRMasters
                                    where r.Id == oneitem.CRMid
                                    select r).First();

                    if (mst != null) {
                        // (3)
                        mst.StateGA = poststring;
                        IQueryable<CRDetail> detailRecords = from d in dc.CRDetails
                                                             where d.CRMid == mst.Id
                                                             select d;
                        if (detailRecords != null) {
                            foreach (var oneDetail in detailRecords) {
                                // (4)
                                oneDetail.State = poststring;
                            }
                        }
                    }
                }

                dc.SubmitChanges();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        // ref: http://weblogs.asp.net/scottgu/linq-to-sql-part-4-updating-our-database

        private bool BatchIsOkToPost() {
            bool result = true;
            CRDepBatch batchRec = (from item in dc.CRDepBatches
                                   where item.Id == CurrentId
                                   select item).First();

            if (batchRec.State == "posted") result = false;

            return result;
        }
    }
    // ref:
    // (1) https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.100).aspx#GeneralDateShortTime
    // (2) https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.rowstatechanged(v=vs.100).aspx
}