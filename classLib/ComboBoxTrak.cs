﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace classLib {
    public partial class ComboBoxTrak : ComboBox {

        private Boolean monitoring = false;
        private string initialhash;
        private Boolean haschanged;
        private string compareText;

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
//            DropDownClosed += myChange;
        }

        void myChange(object sender, EventArgs e) {
            if (monitoring) {
                string curHash;
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

        // Watermark TextBox in WinForms - Start
        // ref: http://stackoverflow.com/questions/4902565/watermark-textbox-in-winforms
        private string _cue;

        public string Cue {
            get {
                return _cue;
            }
            set {
                _cue = value;
                UpdateCue();
            }
        }

        private void UpdateCue() {
            if (IsHandleCreated && _cue != null) {
                NativeMethods.SendMessage(Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, _cue);
            }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateCue();
        }

        private static class NativeMethods {
            private const uint ECM_FIRST = 0x1500;
            internal const uint EM_SETCUEBANNER = ECM_FIRST + 1;

            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, string lParam);
        }
        // Watermark TextBox in WinForms - End



    }
}
