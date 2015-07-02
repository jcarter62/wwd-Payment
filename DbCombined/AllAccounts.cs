using System.Linq;
using System.Data.Linq;
using System.Data;
using classLib;
using dataLib;
using System;
using System.Collections.Generic;

namespace DbCombined {
    public class AllAccounts {
        private classLib.AppSettings aset;
        private dataLib.m500ClassDataContext mc;
        private dataLib.DbClassDataContext dc;
        private string srchStr;
        public string Search {
            get { return srchStr; }
            set {
                srchStr = value;
                ApplySearch();
            }
        }

        public DataTable Data { get; set; }

        public AllAccounts() {
            Init();
        }

        private void Init() {
            this.Data = new DataTable();
            this.aset = new AppSettings();
            this.mc = new m500ClassDataContext(aset.mas500.connectionString);
            this.dc = new DbClassDataContext(aset.wmis.connectionString);
            this.srchStr = "";
            InitTable();
            LoadAccounts();
        }

        private void LoadAccounts() {
            IQueryable<AccountRecord> l1;
            IQueryable<AccountRecord> l2;

            // Wipe data if exists.
            if (Data.Rows.Count > 0) {
                Data.Rows.Clear();
            }

            if (Search.Length > 0) {
                l1 = (from r in dc.NAMEs
                      where (r.FullName.Contains(Search) ||
                      r.NAME_ID.ToString().Contains(Search))
                      select new AccountRecord {
                          Id = r.NAME_ID.ToString(),
                          Name = r.FullName,
                          Source = "wmis",
                          Key = r.NAME_ID
                      });

                l2 = (from m in mc.tarCustomers
                      where m.CompanyID == "WWD" &&
                      (m.CustID.Contains(Search) ||
                        m.CustName.Contains(Search))
                      select new AccountRecord {
                          Id = m.CustID,
                          Name = m.CustName,
                          Source = "mas500",
                          Key = m.CustKey
                      });
            }
            else {
                l1 = (from r in dc.NAMEs
                      select new AccountRecord {
                          Id = r.NAME_ID.ToString(),
                          Name = r.FullName,
                          Source = "wmis",
                          Key = r.NAME_ID
                      });

                l2 = (from m in mc.tarCustomers
                      where m.CompanyID == "WWD"
                      select new AccountRecord {
                          Id = m.CustID,
                          Name = m.CustName,
                          Source = "mas500",
                          Key = m.CustKey
                      });

            }

            InsertRecords(l1);
            InsertRecords(l2);
            // At this point, data contains the accounts from both lists.
        }

        private void ApplySearch() {
            if (Data != null) {
                LoadAccounts();
            }
        }

        private void InsertRecords(IQueryable<AccountRecord> ListOfAccounts) {
            foreach (var r in ListOfAccounts) {
                Data.Rows.Add(r.Id, r.Name, r.Source, r.Key);
            }
        }

        private void InitTable() {
            Data.Columns.Add("Id", typeof(string));
            Data.Columns.Add("Name", typeof(string));
            Data.Columns.Add("Source", typeof(string));
            Data.Columns.Add("Key", typeof(int));
        }
    }
    // Ref: http://sharp-csharp.blogspot.com/2012/02/how-to-create-in-memory-dataset-or.html
    // 

#pragma warning disable JustCode_CSharp_TypeFileNameMismatch // Types not matching file names
    public class AccountRecord
#pragma warning restore JustCode_CSharp_TypeFileNameMismatch // Types not matching file names
    {
        public string Id;
        public string Name;
        public string Source;
        public int Key;
    }
}
