using System;


namespace dataLib {
    public partial class dbClassDataContext {
    }

    static class shortid {
        public static String newId {
            get { return Guid.NewGuid().ToString().ToLower().Replace("{", "").Replace("}", "").Replace("-", ""); }
        }
    }

    public partial class CRDetail {
        partial void OnCreated() {

        }

        public void init() {
            if (Id == null) {
                Id = shortid.newId;
            }

            Amount = 0.0;
            Account = "";
            Note = "";
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
}
