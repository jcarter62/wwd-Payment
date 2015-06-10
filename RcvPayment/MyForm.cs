﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using classLib;

namespace RcvPayment {
    public partial class MyForm : Form {

        public MyForm() {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void MyForm_Load(object sender, EventArgs e) {
            PosSize ps = new PosSize(this);
            ps.Restore();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e) {
            PosSize ps = new PosSize(this);
            ps.Save();
        }

        protected bool isFormOpen(string formname) {
            bool result = false;
            string srch = formname.Trim().ToLower();

            if (MdiParent != null) {
                int n = MdiParent.MdiChildren.Count();
                for ( int i = 0; i < n; i++) {
                    Form f = MdiParent.MdiChildren[i];
                    if ( f.Name.Trim().ToLower().CompareTo(srch) == 0) {
                        result = true;
                        f.BringToFront();
                        break;
                    } // if 
                } // for
            } // if
            return result;
        }
    }
}
