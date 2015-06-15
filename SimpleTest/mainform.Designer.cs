namespace SimpleTest {
    partial class mainform {
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
            this.button1 = new System.Windows.Forms.Button();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.rcptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbGrid
            // 
            this.dbGrid.AllowUserToAddRows = false;
            this.dbGrid.AllowUserToDeleteRows = false;
            this.dbGrid.AutoGenerateColumns = false;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rcptIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.payTypeDataGridViewTextBoxColumn,
            this.payRefDataGridViewTextBoxColumn,
            this.payViaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dbGrid.DataSource = this.cRMasterBindingSource;
            this.dbGrid.Location = new System.Drawing.Point(13, 23);
            this.dbGrid.MultiSelect = false;
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.ReadOnly = true;
            this.dbGrid.RowHeadersVisible = false;
            this.dbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGrid.Size = new System.Drawing.Size(386, 251);
            this.dbGrid.TabIndex = 1;
            // 
            // rcptIDDataGridViewTextBoxColumn
            // 
            this.rcptIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rcptIDDataGridViewTextBoxColumn.DataPropertyName = "RcptID";
            this.rcptIDDataGridViewTextBoxColumn.HeaderText = "RcptID";
            this.rcptIDDataGridViewTextBoxColumn.Name = "rcptIDDataGridViewTextBoxColumn";
            this.rcptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rcptIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 68;
            // 
            // payTypeDataGridViewTextBoxColumn
            // 
            this.payTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.payTypeDataGridViewTextBoxColumn.DataPropertyName = "PayType";
            this.payTypeDataGridViewTextBoxColumn.HeaderText = "PayType";
            this.payTypeDataGridViewTextBoxColumn.Name = "payTypeDataGridViewTextBoxColumn";
            this.payTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.payTypeDataGridViewTextBoxColumn.Width = 74;
            // 
            // payRefDataGridViewTextBoxColumn
            // 
            this.payRefDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.payRefDataGridViewTextBoxColumn.DataPropertyName = "PayRef";
            this.payRefDataGridViewTextBoxColumn.HeaderText = "PayRef";
            this.payRefDataGridViewTextBoxColumn.Name = "payRefDataGridViewTextBoxColumn";
            this.payRefDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRefDataGridViewTextBoxColumn.Width = 67;
            // 
            // payViaDataGridViewTextBoxColumn
            // 
            this.payViaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.payViaDataGridViewTextBoxColumn.DataPropertyName = "PayVia";
            this.payViaDataGridViewTextBoxColumn.HeaderText = "PayVia";
            this.payViaDataGridViewTextBoxColumn.Name = "payViaDataGridViewTextBoxColumn";
            this.payViaDataGridViewTextBoxColumn.ReadOnly = true;
            this.payViaDataGridViewTextBoxColumn.Width = 65;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // cRMasterBindingSource
            // 
            this.cRMasterBindingSource.DataSource = typeof(dataLib.CRMaster);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 315);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.button1);
            this.Name = "mainform";
            this.Text = "mainform";
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.BindingSource cRMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}