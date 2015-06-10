namespace RcvPayment {
    partial class CustList {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustList));
            this.cRAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panCtr = new System.Windows.Forms.Panel();
            this.CustGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoIntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panBot = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panTop = new System.Windows.Forms.Panel();
            this.textBoxTrak1 = new classLib.TextBoxTrak(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cRAccountBindingSource)).BeginInit();
            this.panCtr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).BeginInit();
            this.panBot.SuspendLayout();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cRAccountBindingSource
            // 
            this.cRAccountBindingSource.DataSource = typeof(dataLib.CRAccount);
            // 
            // panCtr
            // 
            this.panCtr.Controls.Add(this.CustGrid);
            this.panCtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCtr.Location = new System.Drawing.Point(0, 33);
            this.panCtr.Name = "panCtr";
            this.panCtr.Size = new System.Drawing.Size(234, 226);
            this.panCtr.TabIndex = 2;
            // 
            // CustGrid
            // 
            this.CustGrid.AllowUserToAddRows = false;
            this.CustGrid.AllowUserToDeleteRows = false;
            this.CustGrid.AutoGenerateColumns = false;
            this.CustGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.accountNoIntDataGridViewTextBoxColumn});
            this.CustGrid.DataSource = this.cRAccountBindingSource;
            this.CustGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustGrid.Location = new System.Drawing.Point(0, 0);
            this.CustGrid.MultiSelect = false;
            this.CustGrid.Name = "CustGrid";
            this.CustGrid.ReadOnly = true;
            this.CustGrid.RowHeadersVisible = false;
            this.CustGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustGrid.Size = new System.Drawing.Size(234, 226);
            this.CustGrid.TabIndex = 0;
            this.CustGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustGrid_CellDoubleClick);
            this.CustGrid.Click += new System.EventHandler(this.CustGrid_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "Acct#";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoIntDataGridViewTextBoxColumn
            // 
            this.accountNoIntDataGridViewTextBoxColumn.DataPropertyName = "AccountNoInt";
            this.accountNoIntDataGridViewTextBoxColumn.HeaderText = "AccountNoInt";
            this.accountNoIntDataGridViewTextBoxColumn.Name = "accountNoIntDataGridViewTextBoxColumn";
            this.accountNoIntDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNoIntDataGridViewTextBoxColumn.Visible = false;
            // 
            // panBot
            // 
            this.panBot.Controls.Add(this.btnSelect);
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 259);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(234, 37);
            this.panBot.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(147, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.textBoxTrak1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(234, 33);
            this.panTop.TabIndex = 0;
            // 
            // textBoxTrak1
            // 
            this.textBoxTrak1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrak1.Changed = false;
            this.textBoxTrak1.Cue = null;
            this.textBoxTrak1.Location = new System.Drawing.Point(12, 6);
            this.textBoxTrak1.Name = "textBoxTrak1";
            this.textBoxTrak1.Size = new System.Drawing.Size(210, 20);
            this.textBoxTrak1.TabIndex = 0;
            this.textBoxTrak1.TextChanged += new System.EventHandler(this.textBoxTrak1_TextChanged);
            // 
            // CustList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(234, 296);
            this.Controls.Add(this.panCtr);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.panTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustList";
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.CustList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRAccountBindingSource)).EndInit();
            this.panCtr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).EndInit();
            this.panBot.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.Panel panCtr;
        private classLib.TextBoxTrak textBoxTrak1;
        private System.Windows.Forms.DataGridView CustGrid;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoIntDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cRAccountBindingSource;
    }
}
