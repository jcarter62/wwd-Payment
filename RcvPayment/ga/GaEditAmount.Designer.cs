namespace RcvPayment {
    partial class GaEditAmount {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaEditAmount));
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTrak2 = new classLib.PanelTrak(this.components);
            this.labelText = new System.Windows.Forms.Label();
            this.panelTrak3 = new classLib.PanelTrak(this.components);
            this.txtAmount = new classLib.TextBoxTrak(this.components);
            this.lblAmount = new System.Windows.Forms.Label();
            this.panelTrak1.SuspendLayout();
            this.panelTrak2.SuspendLayout();
            this.panelTrak3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrak1
            // 
            this.panelTrak1.Controls.Add(this.btnSave);
            this.panelTrak1.Controls.Add(this.btnClose);
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTrak1.Location = new System.Drawing.Point(0, 122);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(299, 30);
            this.panelTrak1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(222, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // panelTrak2
            // 
            this.panelTrak2.Controls.Add(this.labelText);
            this.panelTrak2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrak2.Location = new System.Drawing.Point(0, 0);
            this.panelTrak2.Name = "panelTrak2";
            this.panelTrak2.Size = new System.Drawing.Size(299, 30);
            this.panelTrak2.TabIndex = 1;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(35, 13);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "label1";
            // 
            // panelTrak3
            // 
            this.panelTrak3.Controls.Add(this.txtAmount);
            this.panelTrak3.Controls.Add(this.lblAmount);
            this.panelTrak3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrak3.Location = new System.Drawing.Point(0, 30);
            this.panelTrak3.Name = "panelTrak3";
            this.panelTrak3.Size = new System.Drawing.Size(299, 92);
            this.panelTrak3.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Changed = false;
            this.txtAmount.Cue = null;
            this.txtAmount.Location = new System.Drawing.Point(108, 18);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(171, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 21);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Payment Amount:";
            // 
            // GaEditAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(299, 152);
            this.Controls.Add(this.panelTrak3);
            this.Controls.Add(this.panelTrak2);
            this.Controls.Add(this.panelTrak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GaEditAmount";
            this.Text = "Edit Amount";
            this.panelTrak1.ResumeLayout(false);
            this.panelTrak2.ResumeLayout(false);
            this.panelTrak2.PerformLayout();
            this.panelTrak3.ResumeLayout(false);
            this.panelTrak3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private classLib.PanelTrak panelTrak1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private classLib.PanelTrak panelTrak2;
        private System.Windows.Forms.Label labelText;
        private classLib.PanelTrak panelTrak3;
        private classLib.TextBoxTrak txtAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}
