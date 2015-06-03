using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classLib {
    public partial class TextBoxTrak:TextBox  {

        private Boolean monitoring = false;
        private String initialhash;
        private String initialText;
        private Boolean haschanged ;

        public Boolean Changed {
            get { return haschanged; }
            set { haschanged = value; }
        }

        public TextBoxTrak() {
            InitializeComponent();
            myInit();
        }

        public TextBoxTrak(IContainer container) {
            container.Add(this);
            InitializeComponent();
            myInit();
        }

        void myInit() {
            TextChanged += myChange;
        }

        void myChange(object sender, EventArgs e) {
            if (monitoring) {
                String curHash;
                curHash = this.Text.GetHashCode().ToString();
                if (initialhash.CompareTo(curHash) == 0)
                    Changed = false;
                else
                    Changed = true;
            }
        }

        public void Start() {
            initialText = this.Text;
            initialhash = initialText.GetHashCode().ToString();
            Changed = false;
            monitoring = true;
        }

        public override string ToString() {
            string result;

            result = this.Name.ToString() + ", initialText=";
            result = result + (initialText == null ? "null" : initialText.ToString());
            result = result + ", currentText=";
            result = result + (this.Text == null ? "null" : this.Text.ToString());
            result = result + ", Changed=";
            result = result + (this.Changed ? "yes" : "no");

            return result;
        }
    }
}
