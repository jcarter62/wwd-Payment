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
        private AppSettings aset;
        
        public CustomerInfo(int AcctNo) {
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
            this.AccountNo = AcctNo;
        }

        public string Name { get; set; }

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
    }
}
