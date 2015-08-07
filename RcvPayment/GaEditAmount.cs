using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using dataLib;
using classLib;

namespace RcvPayment {

    /// <summary>
    /// Allow General Accounting to change the amount stored in CRMaster.
    /// 
    /// If this payment has been posted to AR, then General Accounting will
    /// need to notify Customer Accounting of this change by hand (in person).
    /// 
    /// If this payment has NOT been posted to AR, then we will simply update
    /// the amount in CRMaster, and then the correct amount will be applied
    /// to AR.
    /// </summary>
    public partial class GaEditAmount : RcvPayment.MyForm {

        public string AmountStr { get; set; }
        public string Id {
            get {
                return pId;
            }
            set {
                pId = value;
                setId();
            }
        }

        private DbClassDataContext dc;
        private AppSettings aset;
        private string pId;

        public GaEditAmount() {
            InitializeComponent();
            MyInit();
        }

        private void MyInit() {
            pId = "";
            AmountStr = "";
            aset = new AppSettings();
            dc = new DbClassDataContext(aset.wmis.connectionString);
        }

        private void setId() {
            var payment = (from r in dc.CRMasters
                          where r.Id == pId
                          select r).FirstOrDefault();

            if ( payment != null )
            {
                AmountStr = payment.Amount.Value.ToString();
            }

            UpdateVisibleAmount();
        }

        private void UpdateVisibleAmount() {
            txtAmount.Text = AmountStr;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (pId.Length > 0 )
            {
                var payment = (from r in dc.CRMasters
                               where r.Id == pId
                               select r).FirstOrDefault();

                if (payment != null) {
                    double dbl;
                    double.TryParse(txtAmount.Text, out dbl);
                    payment.Amount = dbl;
                    dc.SubmitChanges();
                }
            }

        }
    }
}
