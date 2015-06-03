using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using classLib;

namespace RcvPayment {
    public partial class Settings : RcvPayment.MyForm {
        AppSettings aset;
        Images statusImages;

        public Settings() {
            InitializeComponent();
            aset = new AppSettings();
            statusImages = new Images();
        }

        private void Settings_Load(object sender, EventArgs e) {
            loadfields();
        }

        private void loadfields() {
            aset.Load();

            textWhostname.Text = aset.wmis.Hostname;
            textWdbname.Text = aset.wmis.Database;
            textWusername.Text = aset.wmis.Username;
            textWpassword.Text = aset.wmis.Password;
            checkBoxWwinauth.Checked = aset.wmis.WindowsAuth;

            textMhostname.Text = aset.mas500.Hostname;
            textMdbname.Text = aset.mas500.Database;
            textMusername.Text = aset.mas500.Username;
            textMpassword.Text = aset.mas500.Password;
            checkBoxMwinauth.Checked = aset.mas500.WindowsAuth;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            aset.wmis.Hostname = textWhostname.Text;
            aset.wmis.Database = textWdbname.Text;
            aset.wmis.Username = textWusername.Text;
            aset.wmis.Password = textWpassword.Text;
            aset.wmis.WindowsAuth = checkBoxWwinauth.Checked;

            aset.mas500.Hostname = textMhostname.Text;
            aset.mas500.Database = textMdbname.Text;
            aset.mas500.Username = textMusername.Text;
            aset.mas500.Password = textMpassword.Text;
            aset.mas500.WindowsAuth = checkBoxMwinauth.Checked;

            aset.Save();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnWtest_Click(object sender, EventArgs e) {
            if (aset.wmis.Test()) {
                wmisImage.Image = Image.FromFile(statusImages.successImage);
            }
            else {
                wmisImage.Image = Image.FromFile(statusImages.failImage);
            }
        }

        private void btnMtest_Click(object sender, EventArgs e) {
            if (aset.mas500.Test()) {
                mas500Image.Image = Image.FromFile(statusImages.successImage);
            }
            else {
                mas500Image.Image = Image.FromFile(statusImages.failImage);
            }
        }
    }
}
