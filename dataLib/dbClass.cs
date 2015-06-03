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
            if (this.Id == null) {
                this.Id = shortid.newId;
            }
        }
    }

    public partial class CRMaster {
        private string _Deposited;

        /// <summary>
        /// Set default values for CRMaster Record
        /// </summary>
        partial void OnCreated() {
            if (this.Id == null) {
                this.Id = shortid.newId;
                this.DeliveryName = "";
                this.PayRef = "";
                this.Note = "";
                this.PayType = "Check";
                this.Amount = 0.0;
                this.State = "Created";
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
            if (this.State != null) {
                try {
                    if (this.State.ToString().Trim().ToLower() == "deposited") {
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
