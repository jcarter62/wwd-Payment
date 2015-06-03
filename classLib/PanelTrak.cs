using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classLib {
    public partial class PanelTrak : Panel {
        Button Button2Update;

        public PanelTrak() {
            InitializeComponent();
            myInit();
        }

        public PanelTrak(IContainer container) {
            container.Add(this);
            InitializeComponent();
            myInit();
        }

        private void myInit() {
            Button2Update = null;
        }

        // Disable all input type controls, not allowing 
        // the user to change the contents.
        public void DisableControls() {
            EnableDisable(this, false);
        }

        public void EnableControls() {
            EnableDisable(this, true);
        }

        private void EnableDisable(Control control, bool p) {
            foreach (Control ctrl in control.Controls) {
                if (ctrl.HasChildren) {
                    EnableDisable(ctrl, p);
                }

                if (ctrl is TextBox) {
                    ((TextBox)ctrl).Enabled = p;
                }
                if (ctrl is TextBoxTrak) {
                    ((TextBoxTrak)ctrl).Enabled = p;
                }
                if (ctrl is ComboBox) {
                    ((ComboBox)ctrl).Enabled = p;
                }
                if (ctrl is CheckBox) {
                    ((CheckBox)ctrl).Enabled = p;
                }
            }
        }

        // Determine if any of the TextBoxTrak controls text 
        // have changed since init.
        public Boolean HasDataChanged() {
            Boolean result = false;

            foreach (Control ctrl in this.Controls) {
                if (ctrl.GetType() == typeof(TextBoxTrak)) {
                    if (((TextBoxTrak)ctrl).Changed) {
                        result = true;
                    }
                }
            }
            if (Button2Update != null) {
                Button2Update.Enabled = result;
            }
            return result;
        }

        // Start monitoring text fields
        //
        public void Start() {
            foreach (Control ctrl in this.Controls) {
                if (ctrl.GetType() == typeof(TextBoxTrak)) {
                    ((TextBoxTrak)ctrl).Start();
                }
            }
        }

        public void Start(Button btn) {
            if (btn != null) {
                Button2Update = btn;
            }
            Start();
        }

        public String StatusString() {
            String result = "";
            foreach (Control ctrl in this.Controls) {
                if (ctrl.GetType() == typeof(TextBoxTrak)) {
                    result = result + ((TextBoxTrak)ctrl).ToString() + "\n";
                }
            }
            return result;
        }
    }
}
