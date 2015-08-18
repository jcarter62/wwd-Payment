using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataLib;

namespace classLib {

    /// <summary>
    /// CustomerInfo, class that provides customer information, given
    /// customer number as input.
    /// </summary>
    public class CustomerInfo {
        private DbClassDataContext dc;
        private m500ClassDataContext mc;
        private AppSettings aset;

        public CustomerInfo(int AcctNo) {
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            this.AccountNo = AcctNo;
        }

        public CustomerInfo(string acctNoS) {
            aset = new AppSettings();
            mc = new m500ClassDataContext(aset.mas500.connectionString);
            this.AccountNoS = acctNoS;
        }

        public string Name { get; set; }

        #region wmis
        private int _AccountNo;
        public int AccountNo {
            get {
                return _AccountNo;
            }
            set {
                _AccountNo = value;
                findAccount(value);
            }
        }

        private void findAccount(int value) {
            var q = (from n in dc.NAMEs
                     where n.NAME_ID == AccountNo
                     select n).FirstOrDefault();

            if (q == null) {
                Name = "Not Found";
            }
            else {
                Name = q.FullName;
            }
        }
        #endregion wmis

        #region mas500
        private string accountNoS;
        public string AccountNoS {
            get {
                return accountNoS;
            }
            set {
                accountNoS = value;
                Findmas500Account(accountNoS);
            }
        }

        private void Findmas500Account(string id) {
            var q = (from n in mc.tarCustomers
                     where n.CustID == id
                     select n).FirstOrDefault();

            if (q == null) {
                Name = "Not Found";
            }
            else {
                Name = q.CustName;
            }
        }
        #endregion mas500

    }
}
