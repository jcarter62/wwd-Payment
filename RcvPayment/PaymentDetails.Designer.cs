namespace RcvPayment {
    partial class PaymentDetails {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentDetails));
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.panelTrak2 = new classLib.PanelTrak(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.panelMain = new classLib.PanelTrak(this.components);
            this.txtPM = new classLib.TextBoxTrak(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.txtNote = new classLib.TextBoxTrak(this.components);
            this.txtAmount = new classLib.TextBoxTrak(this.components);
            this.txtRef = new classLib.TextBoxTrak(this.components);
            this.cbPayType = new classLib.ComboBoxTrak(this.components);
            this.txtRecFrom = new classLib.TextBoxTrak(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbVia = new classLib.ComboBoxTrak(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecBy = new System.Windows.Forms.TextBox();
            this.txtTimeStamp = new System.Windows.Forms.TextBox();
            this.txtReceiptId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelDetail = new classLib.PanelTrak(this.components);
            this.dgDetail = new System.Windows.Forms.DataGridView();
            this.panelTrak2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrak1
            // 
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrak1.Location = new System.Drawing.Point(0, 0);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(327, 30);
            this.panelTrak1.TabIndex = 0;
            // 
            // panelTrak2
            // 
            this.panelTrak2.Controls.Add(this.btnPrint);
            this.panelTrak2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTrak2.Location = new System.Drawing.Point(0, 425);
            this.panelTrak2.Name = "panelTrak2";
            this.panelTrak2.Size = new System.Drawing.Size(327, 30);
            this.panelTrak2.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Location = new System.Drawing.Point(9, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 23);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtPM);
            this.panelMain.Controls.Add(this.label16);
            this.panelMain.Controls.Add(this.txtNote);
            this.panelMain.Controls.Add(this.txtAmount);
            this.panelMain.Controls.Add(this.txtRef);
            this.panelMain.Controls.Add(this.cbPayType);
            this.panelMain.Controls.Add(this.txtRecFrom);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.cbVia);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtRecBy);
            this.panelMain.Controls.Add(this.txtTimeStamp);
            this.panelMain.Controls.Add(this.txtReceiptId);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(327, 200);
            this.panelMain.TabIndex = 2;
            // 
            // txtPM
            // 
            this.txtPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPM.Changed = false;
            this.txtPM.Cue = "Post Mark Date";
            this.txtPM.Location = new System.Drawing.Point(92, 68);
            this.txtPM.Name = "txtPM";
            this.txtPM.Size = new System.Drawing.Size(221, 20);
            this.txtPM.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Post Mark Date:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Changed = false;
            this.txtNote.Cue = "Any Special Notes about this Payment";
            this.txtNote.Location = new System.Drawing.Point(47, 175);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(266, 20);
            this.txtNote.TabIndex = 63;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Changed = false;
            this.txtAmount.Cue = "Payment Amount $$$";
            this.txtAmount.Location = new System.Drawing.Point(92, 131);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(221, 20);
            this.txtAmount.TabIndex = 61;
            // 
            // txtRef
            // 
            this.txtRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRef.Changed = false;
            this.txtRef.Cue = "Check Number";
            this.txtRef.Location = new System.Drawing.Point(206, 110);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(107, 20);
            this.txtRef.TabIndex = 60;
            // 
            // cbPayType
            // 
            this.cbPayType.Changed = false;
            this.cbPayType.Cue = null;
            this.cbPayType.FormattingEnabled = true;
            this.cbPayType.Items.AddRange(new object[] {
            "Check",
            "Cash",
            "Wire",
            "Other"});
            this.cbPayType.Location = new System.Drawing.Point(92, 110);
            this.cbPayType.Name = "cbPayType";
            this.cbPayType.Size = new System.Drawing.Size(75, 21);
            this.cbPayType.TabIndex = 59;
            // 
            // txtRecFrom
            // 
            this.txtRecFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecFrom.Changed = false;
            this.txtRecFrom.Cue = "Delivery Person\'s Name";
            this.txtRecFrom.Location = new System.Drawing.Point(92, 89);
            this.txtRecFrom.Name = "txtRecFrom";
            this.txtRecFrom.Size = new System.Drawing.Size(221, 20);
            this.txtRecFrom.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Note:";
            // 
            // cbVia
            // 
            this.cbVia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVia.Changed = false;
            this.cbVia.Cue = "Delivery Company";
            this.cbVia.FormattingEnabled = true;
            this.cbVia.Items.AddRange(new object[] {
            "USPS",
            "Person",
            "UPS",
            "Fedex",
            "Other"});
            this.cbVia.Location = new System.Drawing.Point(92, 152);
            this.cbVia.Name = "cbVia";
            this.cbVia.Size = new System.Drawing.Size(221, 21);
            this.cbVia.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Arrived Via:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Payment Amt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Ref:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Payment Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Received From:";
            // 
            // txtRecBy
            // 
            this.txtRecBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecBy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRecBy.Location = new System.Drawing.Point(92, 47);
            this.txtRecBy.Name = "txtRecBy";
            this.txtRecBy.Size = new System.Drawing.Size(221, 20);
            this.txtRecBy.TabIndex = 66;
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeStamp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTimeStamp.Location = new System.Drawing.Point(92, 26);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(221, 20);
            this.txtTimeStamp.TabIndex = 65;
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiptId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtReceiptId.Location = new System.Drawing.Point(92, 5);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(221, 20);
            this.txtReceiptId.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Received By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Time Stamp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Receipt ID:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 230);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(327, 5);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dgDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 235);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(327, 190);
            this.panelDetail.TabIndex = 5;
            // 
            // dgDetail
            // 
            this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.Location = new System.Drawing.Point(0, 0);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(327, 190);
            this.dgDetail.TabIndex = 0;
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(327, 455);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTrak2);
            this.Controls.Add(this.panelTrak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentDetails";
            this.Load += new System.EventHandler(this.PaymentDetails_Load);
            this.panelTrak2.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private classLib.PanelTrak panelTrak1;
        private classLib.PanelTrak panelTrak2;
        private classLib.PanelTrak panelMain;
        private System.Windows.Forms.Splitter splitter1;
        private classLib.PanelTrak panelDetail;
        private classLib.TextBoxTrak txtPM;
        private System.Windows.Forms.Label label16;
        private classLib.TextBoxTrak txtNote;
        private classLib.TextBoxTrak txtAmount;
        private classLib.TextBoxTrak txtRef;
        private classLib.ComboBoxTrak cbPayType;
        private classLib.TextBoxTrak txtRecFrom;
        private System.Windows.Forms.Label label9;
        private classLib.ComboBoxTrak cbVia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecBy;
        private System.Windows.Forms.TextBox txtTimeStamp;
        private System.Windows.Forms.TextBox txtReceiptId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDetail;
        private System.Windows.Forms.Button btnPrint;
    }
}
