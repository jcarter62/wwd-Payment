﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dataLib;
using classLib;

namespace RcvPayment {
    public partial class MainForm : RcvPayment.MyForm {
        public enum StatusTypes { DB, Misc }
        public enum AuthTypes { Authorized, NotAuthorized, Administrator }

        public MainForm() {
            InitializeComponent();
        }

        private void AuthorizationMessageToUser(string msg) {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK);
        }

        private bool IsAdmin(NtGroups g) {
            bool result = false;
            if (g.IsInGroup("administrators") || g.IsInGroup("domain admins"))
                result = true;
            return result;
        }

        private AuthTypes CheckAuth() {
            AuthTypes result = AuthTypes.Authorized;

            NtGroups g = new NtGroups();
            AppSettings aset = new AppSettings();
            if (aset.NTGroup.Trim().Length > 0) {
                if (IsAdmin(g)) {
                    result = AuthTypes.Administrator;
                }
                else
                if (!g.IsInGroup(aset.NTGroup)) {
                    result = AuthTypes.NotAuthorized;
                }
            }

            return result;
        }

        public void UpdateMessage(StatusTypes type, string Msg) {
            switch (type) {
                case StatusTypes.DB:
                    statusDB.Text = Msg;
                    break;
                case StatusTypes.Misc:
                    statusMisc.Text = Msg;
                    break;
                default:
                    break;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new Settings();
            f.MdiParent = this;
            f.Show();
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new NewPayment();
            f.MdiParent = this;
            f.Show();
        }

        private void paymentBatchesToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new PaymentBatches();
            f.MdiParent = this;
            f.Show();
        }

        private void generateTestDataToolStripMenuItem_Click(object sender, EventArgs e) {
            var aset = new AppSettings();
            var sd = new SampleData(aset.wmis.connectionString);
            sd.CreateData(100);
            MessageBox.Show("Sample Data has been created.", "Information", MessageBoxButtons.OK);
        }

        private void unAppliedPaymentsToolStripMenuItem_Click(object sender, EventArgs e) {
            var f = new Ca.UnApplied();
            f.MdiParent = this;
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            AppSettings aset = new AppSettings();
            AuthTypes authtype = CheckAuth();

            if (authtype == AuthTypes.NotAuthorized) {
                string msg = "You are not authorized to use this application.\n" +
                             "Membership in the security group (" + aset.NTGroup + "), is required " +
                             "to access this application. ";
                AuthorizationMessageToUser(msg);
                Close();
            }

            string statmsg = aset.wmis.Hostname + ":" + aset.wmis.Database;
            UpdateMessage(StatusTypes.DB, statmsg);
            UpdateMessage(StatusTypes.Misc, "");

            // If this is an administrator, then allow test data generation
            if (authtype != AuthTypes.Administrator)
                generateTestDataToolStripMenuItem.Visible = false;

        }

        private void viewPaymentDetailToolStripMenuItem_Click(object sender, EventArgs e) {
            // Open PaymentDetails if not already open.
            string frm = "paymentdetails";
            bool isopn = false;
            int n;

            n = this.MdiChildren.Count();
            for ( int i = 0; i < n; i++)
            {
                Form f = MdiChildren[i];
                if (f.Name.Trim().ToLower().CompareTo(frm) == 0) {
                    isopn = true;
                    f.BringToFront();
                    break;
                } // if 
            }
            if ( ! isopn )
            {
                PaymentDetails f = new PaymentDetails();
                f.MdiParent = this;
                f.Show();
                f.BringToFront();
            } 
        }
    }
}
