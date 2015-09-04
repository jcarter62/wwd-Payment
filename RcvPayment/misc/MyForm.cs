using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using classLib;
using System.Diagnostics;
using Microsoft.Win32;

namespace RcvPayment {
    public partial class MyForm : Form {

        public string HelpPage { get; set; }

        public MyForm() {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            PosSize ps = new PosSize(this);
            // If the position is off screen, or not visible, then
            // maximize.
            ps.Restore();
            if (!IsVisible()) {
                MakeWindowVisible();
            }
        }

        private void MakeWindowVisible() {

            if (this.IsMdiContainer) {
                this.Left = 0;
                this.Top = 0;
            }
            else {
                this.Left = this.Parent.ClientRectangle.Left;
                this.Top = this.Parent.ClientRectangle.Top;
                int pwidth = this.Parent.ClientRectangle.Width;
                int pheight = this.Parent.ClientRectangle.Height;

                if (this.Width > pwidth) {
                    this.Width = pwidth - (pwidth / 10);
                }

                if (this.Height > pheight) {
                    this.Height = pheight - (pheight / 10);
                }
            }
        }

        // http://stackoverflow.com/a/987090
        private bool IsVisible() {
            bool result = false;
            Rectangle formRec = new Rectangle(this.Left, this.Top, this.Width, this.Height);

            if (this.IsMdiContainer) {
                Screen[] screens = Screen.AllScreens;
                foreach (Screen s in screens) {
                    if (s.WorkingArea.Contains(formRec)) {
                        result = true;
                    }
                }
            }
            else {
                var mainform = this.Parent.ClientRectangle;
                if (mainform.Contains(formRec)) {
                    result = true;
                }
            }
            return result;
        }

        private void MyForm_Load(object sender, EventArgs e) {
        }

        protected override void OnClosing(CancelEventArgs e) {
            PosSize ps = new PosSize(this);
            ps.Save();
            base.OnClosing(e);
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e) {
        }

        protected bool isFormOpen(string formname) {
            bool result = false;
            string srch = formname.Trim().ToLower();

            if (MdiParent != null) {
                int n = MdiParent.MdiChildren.Count();
                for (int i = 0; i < n; i++) {
                    Form f = MdiParent.MdiChildren[i];
                    if (f.Name.Trim().ToLower().CompareTo(srch) == 0) {
                        result = true;
                        f.BringToFront();
                        break;
                    } // if 
                } // for
            } // if
            return result;
        }

        public void GetFormPtr(string formname, ref Form formptr) {
            string srch = formname.Trim().ToLower();

            if (MdiParent != null) {
                int n = MdiParent.MdiChildren.Count();
                for (int i = 0; i < n; i++) {
                    Form f = MdiParent.MdiChildren[i];
                    if (f.Name.Trim().ToLower().CompareTo(srch) == 0) {
                        formptr = f;
                        break;
                    } // if 
                } // for
            } // if
        }

        // https://msdn.microsoft.com/en-us/library/system.windows.forms.control.helprequested(v=vs.110).aspx
        private void MyForm_HelpRequested(object sender, HelpEventArgs hlpevent) {
            System.IO.FileInfo fi = new System.IO.FileInfo(Application.ExecutablePath);
            string page = fi.DirectoryName + "/help/";

            // When running in dev mode, the directory won't exist,
            // so use the project directory.
            if (!System.IO.Directory.Exists(page)) {
                page = @"C:\local\projects\Payments\help\";
            }

            if (HelpPage != null) {
                if (HelpPage.Length <= 0) {
                    page = page + "home.html";
                }
                else {
                    page = page + HelpPage;
                }
            }
            else {
                page = page + "home.html";
            }

            string browserPath = GetBrowserPath();
            if (browserPath == string.Empty)
                browserPath = "iexplore";
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(browserPath);
            process.StartInfo.Arguments = page;
            process.Start();
        }

        private string GetBrowserPath() {
            string browser = string.Empty;
            RegistryKey key = null;

            try {
                // try location of default browser path in XP
                key = Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\command", false);

                // try location of default browser path in Vista
                if (key == null) {
                    key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http", false); ;
                }

                if (key != null) {
                    //trim off quotes
                    browser = key.GetValue(null).ToString().ToLower().Replace("\"", "");
                    if (!browser.EndsWith("exe")) {
                        //get rid of everything after the ".exe"
                        browser = browser.Substring(0, browser.LastIndexOf(".exe") + 4);
                    }

                    key.Close();
                }
            }
            catch {
                return string.Empty;
            }

            return browser;
        }
    }
}
