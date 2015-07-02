using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data;
using classLib;
using dataLib;

namespace DbCombined {
    public enum CustomerType { Wmis, Mas500 }

    public class OutstandingCharges {
        private readonly string sessionId = ShortGuid.newId;
        public DataTable Data { get; set; }
        public CustomerType CustType { get; set; }
        private AppSettings aset;
        private m500ClassDataContext mc;
        private DbClassDataContext dc;
        private int accountKey;
        public int AccountKey {

            get { return accountKey; }
            set {
                accountKey = value;
                SetAccount();
            }
        }

        public OutstandingCharges() {
            Init();
        }

        ~OutstandingCharges() {
            DeleteWorkTableRecords(sessionId);
        }

        private void DeleteWorkTableRecords(string sessionId) {
            if ((dc != null) && (sessionId != null)) {
                string cmd;
                cmd = string.Format("delete CROutstanding where session = '{0}'", sessionId);
                dc.ExecuteCommand(cmd, "");
            }
        }

        private void Init() {
            Data = new DataTable();
            aset = new AppSettings();
            mc = new m500ClassDataContext(aset.mas500.connectionString);
            dc = new DbClassDataContext(aset.wmis.connectionString);
            InitDataTable();
        }

        private void InitDataTable() {
            Data.Columns.Add("ItemGroup", typeof(int));
            Data.Columns.Add("TranType", typeof(string));
            Data.Columns.Add("Description", typeof(string));
            Data.Columns.Add("DueDate", typeof(DateTime));
            Data.Columns.Add("Amount", typeof(float));
            Data.Columns.Add("Account", typeof(int));
            Data.Columns.Add("Invoice", typeof(int));
        }

        private void loadMas500Data() {

        }

        private void loadWmisData() {
            // Wipe data if exists.
            if (Data.Rows.Count > 0) {
                Data.Rows.Clear();
            }

            int rows;
            rows = dc.sp_Outstanding(AccountKey, sessionId);

            IQueryable<CROutstanding> q = from r in dc.CROutstandings
                    where r.Session == sessionId
                    select r;

            foreach (var r in q) {
                Data.Rows.Add(r.ItemGroup, r.TranType, r.Description,
                              r.DueDate, r.Amount, r.Account, r.Invoice );
            }
            // At this point, data contains the accounts from both lists.

        }

        private void SetAccount() {
            if (CustType == CustomerType.Wmis) {
                loadWmisData();
            }
            else {
                loadMas500Data();
            }
        }
    }
}
