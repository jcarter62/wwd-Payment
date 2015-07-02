namespace RcvPayment {
    partial class UnpaidList {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnpaidList));
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.gridAccounts = new System.Windows.Forms.DataGridView();
            this.textSearch = new classLib.TextBoxTrak(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTrak2 = new classLib.PanelTrak(this.components);
            this.gridCharges = new System.Windows.Forms.DataGridView();
            this.labelLoading = new System.Windows.Forms.Label();
            this.panelTrak1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
            this.panelTrak2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCharges)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrak1
            // 
            this.panelTrak1.Controls.Add(this.gridAccounts);
            this.panelTrak1.Controls.Add(this.textSearch);
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTrak1.Location = new System.Drawing.Point(0, 0);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(146, 276);
            this.panelTrak1.TabIndex = 0;
            // 
            // gridAccounts
            // 
            this.gridAccounts.AllowUserToAddRows = false;
            this.gridAccounts.AllowUserToDeleteRows = false;
            this.gridAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccounts.Location = new System.Drawing.Point(4, 29);
            this.gridAccounts.MultiSelect = false;
            this.gridAccounts.Name = "gridAccounts";
            this.gridAccounts.ReadOnly = true;
            this.gridAccounts.RowHeadersVisible = false;
            this.gridAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccounts.Size = new System.Drawing.Size(139, 244);
            this.gridAccounts.TabIndex = 1;
            this.gridAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAccounts_CellClick);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Changed = false;
            this.textSearch.Cue = null;
            this.textSearch.Location = new System.Drawing.Point(3, 4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(140, 20);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(146, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 276);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelTrak2
            // 
            this.panelTrak2.Controls.Add(this.gridCharges);
            this.panelTrak2.Controls.Add(this.labelLoading);
            this.panelTrak2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrak2.Location = new System.Drawing.Point(151, 0);
            this.panelTrak2.Name = "panelTrak2";
            this.panelTrak2.Size = new System.Drawing.Size(341, 276);
            this.panelTrak2.TabIndex = 2;
            // 
            // gridCharges
            // 
            this.gridCharges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCharges.Location = new System.Drawing.Point(5, 4);
            this.gridCharges.Name = "gridCharges";
            this.gridCharges.RowHeadersVisible = false;
            this.gridCharges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCharges.Size = new System.Drawing.Size(332, 269);
            this.gridCharges.TabIndex = 0;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(6, 87);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(331, 35);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "... Loading ...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnpaidList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(492, 276);
            this.Controls.Add(this.panelTrak2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelTrak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnpaidList";
            this.Text = "Unpaid List for Account";
            this.panelTrak1.ResumeLayout(false);
            this.panelTrak1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
            this.panelTrak2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCharges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private classLib.PanelTrak panelTrak1;
        private System.Windows.Forms.DataGridView gridAccounts;
        private classLib.TextBoxTrak textSearch;
        private System.Windows.Forms.Splitter splitter1;
        private classLib.PanelTrak panelTrak2;
        private System.Windows.Forms.DataGridView gridCharges;
        private System.Windows.Forms.Label labelLoading;
    }
}
