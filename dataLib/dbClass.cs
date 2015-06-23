using System;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;

namespace dataLib {
    partial class CRDepBatch {
    }

    public partial class dbClassDataContext {
    }

    static class shortid {
        public static String newId {
            get { return Guid.NewGuid().ToString().ToLower().Replace("{", "").Replace("}", "").Replace("-", ""); }
        }
    }

    public partial class CRDepBatch {
        partial void OnCreated() {
            init();
        }

        public void init() {
            if (Id == null) {
                Id = shortid.newId;
                Qty = 0;
                Amount = 0.0;
                State = "Created";
            }
        }
    }

    public partial class CRDepItem {
        partial void OnCreated() {
            init();
        }

        public void init() {
            if (Id == null) {
                Id = shortid.newId;
                Amount = 0.0;
                State = "Created";
            }
        }
    }

    public partial class CRDetail {
        partial void OnCreated() {
            init();
        }

        public void init() {
            if (Id == null) {
                Id = shortid.newId;
                Amount = 0.0;
                Account = "";
                Note = "";
                State = "Created";
                Name = "";
            }
        }
    }

    public partial class CRMaster {
        private string _Deposited;

        /// <summary>
        /// Set default values for CRMaster Record
        /// </summary>
        partial void OnCreated() {
            if (Id == null) {
                Id = shortid.newId;
                DeliveryName = "";
                PayRef = "";
                Note = "";
                PayType = "Check";
                PayVia = "USPS";
                Amount = 0.0;
                State = "Created";
            }
        }

        public bool Deposited {
            get {
                depositStatus();
                return ((_Deposited == "Yes") ? true : false);
            }
        }

        private void depositStatus() {
            _Deposited = "No";
            if (State != null) {
                try {
                    if (State.ToString().Trim().ToLower() == "deposited") {
                        _Deposited = "Yes";
                    }
                }
                finally { }
            }
        }
    }

    public partial class CrMasterIds {

    }

    public partial class CRAccount {
        private const string sep = "/";

        public string searchText {
            get {
                string r;
                r = sep + AccountNo.ToString() + sep + this.AccountName.ToString() + sep;
                return r;
            }
        }
    }

    public partial class NAME {

    }

    public partial class v_CrReceipt {

    }

}