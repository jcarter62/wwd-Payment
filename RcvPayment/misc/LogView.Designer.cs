namespace RcvPayment.misc {
    partial class LogView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.panelTrak2 = new classLib.PanelTrak(this.components);
            this.labelPayment = new System.Windows.Forms.Label();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.panelTrak2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrak1
            // 
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTrak1.Location = new System.Drawing.Point(0, 291);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(319, 29);
            this.panelTrak1.TabIndex = 0;
            // 
            // panelTrak2
            // 
            this.panelTrak2.Controls.Add(this.labelPayment);
            this.panelTrak2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrak2.Location = new System.Drawing.Point(0, 0);
            this.panelTrak2.Name = "panelTrak2";
            this.panelTrak2.Size = new System.Drawing.Size(319, 29);
            this.panelTrak2.TabIndex = 1;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(3, 9);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(35, 13);
            this.labelPayment.TabIndex = 0;
            this.labelPayment.Text = "label1";
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AllowUserToOrderColumns = true;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV.Location = new System.Drawing.Point(0, 29);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.Size = new System.Drawing.Size(319, 262);
            this.dataGV.TabIndex = 2;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(319, 320);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.panelTrak2);
            this.Controls.Add(this.panelTrak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogView";
            this.Text = "Payment Log";
            this.panelTrak2.ResumeLayout(false);
            this.panelTrak2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private classLib.PanelTrak panelTrak1;
        private classLib.PanelTrak panelTrak2;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.DataGridView dataGV;
    }
}
