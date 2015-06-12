using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using dataLib;
using classLib;

namespace RcvPayment {
    public partial class ShowReceipt : RcvPayment.MyForm {
        AppSettings aset;
        dbClassDataContext dc;
        public string Id { get; set; }

        public ShowReceipt() {
            InitializeComponent();
            aset = new AppSettings();
            dc = new dbClassDataContext(aset.wmis.connectionString);
        }

        public void DisplayReport(string id ) {
            Id = id;
            DisplayReport();
        }

        public void DisplayReport() {
            SetDataSources();
        }

        private void SetDataSources() {
            var q = from item in dc.CRMasters
                     where item.Id == Id
                     select item;

            BindingSource master = new BindingSource();
            master.DataSource = q;
            this.CRMasterBindingSource = master;


        }

        private void ShowReceipt_Load(object sender, EventArgs e) {

            //            this.rpt.RefreshReport();

        }
    }
}
