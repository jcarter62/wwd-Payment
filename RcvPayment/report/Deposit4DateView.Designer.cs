namespace RcvPayment.report {
    partial class Deposit4DateView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit4DateView));
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.PMDate = new System.Windows.Forms.DateTimePicker();
            this.BtnClose = new System.Windows.Forms.Button();
            this.rview = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panelTrak1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrak1
            // 
            this.panelTrak1.Controls.Add(this.BtnUpdate);
            this.panelTrak1.Controls.Add(this.PMDate);
            this.panelTrak1.Controls.Add(this.BtnClose);
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTrak1.Location = new System.Drawing.Point(0, 336);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(553, 30);
            this.panelTrak1.TabIndex = 2;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(136, 6);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(78, 20);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // PMDate
            // 
            this.PMDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PMDate.Location = new System.Drawing.Point(12, 6);
            this.PMDate.Name = "PMDate";
            this.PMDate.Size = new System.Drawing.Size(108, 20);
            this.PMDate.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(475, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // rview
            // 
            this.rview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rview.Location = new System.Drawing.Point(0, 0);
            this.rview.Name = "rview";
            this.rview.Size = new System.Drawing.Size(553, 336);
            this.rview.TabIndex = 3;
            // 
            // Deposit4DateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 366);
            this.Controls.Add(this.rview);
            this.Controls.Add(this.panelTrak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposit4DateView";
            this.Text = "Payments for Deposit Date";
            this.panelTrak1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private classLib.PanelTrak panelTrak1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DateTimePicker PMDate;
        private System.Windows.Forms.Button BtnClose;
        private Telerik.ReportViewer.WinForms.ReportViewer rview;
    }
}
