using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classLib {
    public partial class ComboBoxTrak : ComboBox {

        private Boolean monitoring = false;
        private String initialhash;
        private Boolean haschanged;
        private String compareText;

        public Boolean Changed {
            get { return haschanged; }
            set { haschanged = value; }
        }

        public ComboBoxTrak() {
            InitializeComponent();
            myInit();
        }

        public ComboBoxTrak(IContainer container) {
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
            compareText = this.Text;
            initialhash = compareText.GetHashCode().ToString();
            Changed = false;
            monitoring = true;
        }


    }
}
