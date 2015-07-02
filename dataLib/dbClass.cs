using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;

namespace dataLib {
    partial class DbClassDataContext {
    }

    public partial class DbClassDataContext {
    }

    static class Shortid {
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
                Id = Shortid.newId;
                Qty = 0;
                Amount = 0.0;
                State = "created";
            }
        }
    }

    public partial class CRDepItem {
        partial void OnCreated() {
            init();
        }

        public void init() {
            if (Id == null) {
                Id = Shortid.newId;
                Amount = 0.0;
                State = "created";
            }
        }
    }

    public partial class CRDetail {
        partial void OnCreated() {
            init();
        }

        public void init() {
            if (Id == null) {
                Id = Shortid.newId;
                Amount = 0.0;
                Account = "";
                Note = "";
                State = "created";
                Name = "";
            }
        }
    }

    public partial class CRMaster {
        private string deposited;

        /// <summary>
        /// Set default values for CRMaster Record
        /// </summary>
        partial void OnCreated() {
            if (Id == null) {
                Id = Shortid.newId;
                DeliveryName = "";
                PayRef = "";
                Note = "";
                PayType = "Check";
                PayVia = "USPS";
                Amount = 0.0;
                StateAR = "created";
                StateGA = "created";
            }
        }

        public bool Deposited {
            get {
                DepositStatus();
                return ((deposited == "Yes") ? true : false);
            }
        }

        private void DepositStatus() {
            deposited = "No";
            if (StateGA != null) {
                try {
                    if (StateGA.ToString().Trim().ToLower() == "posted") {
                        deposited = "Yes";
                    }
                }
                finally { }
            }
        }

        public string DisplayInNewPayments {
            get {
                return ((StateGA == "created") ? "yes" : "no");
            }
        }
    }

    public partial class CrMasterIds {

    }

    public partial class CRAccount {
        private const string Sep = "/";

        public string SearchText {
            get {
                string r;
                r = Sep + AccountNo.ToString() + Sep + this.AccountName.ToString() + Sep;
                return r;
            }
        }
    }

    public partial class NAME {

    }

    public partial class v_CrReceipt {

    }

}