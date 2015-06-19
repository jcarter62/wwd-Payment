namespace RcvPayment {
    partial class PaymentBatches {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentBatches));
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSrc = new System.Windows.Forms.BindingSource(this.components);
            this.panelTrak2 = new classLib.PanelTrak(this.components);
            this.btnPost = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDocs = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDocCount = new System.Windows.Forms.Label();
            this.lblModified = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new classLib.TextBoxTrak(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statGrid = new System.Windows.Forms.ToolStripStatusLabel();
            this.statDetail = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTrak1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSrc)).BeginInit();
            this.panelTrak2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrak1
            // 
            this.panelTrak1.Controls.Add(this.dgv);
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrak1.Location = new System.Drawing.Point(0, 0);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(220, 288);
            this.panelTrak1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idbank,
            this.state,
            this.amount,
            this.qtyDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.cUserDataGridViewTextBoxColumn,
            this.uDateDataGridViewTextBoxColumn,
            this.uUserDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.dataSrc;
            this.dgv.Location = new System.Drawing.Point(3, 25);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(211, 260);
            this.dgv.TabIndex = 0;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            this.dgv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgv_RowStateChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idbank
            // 
            this.idbank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idbank.DataPropertyName = "IDBank";
            this.idbank.HeaderText = "ID";
            this.idbank.Name = "idbank";
            this.idbank.ReadOnly = true;
            this.idbank.Width = 43;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.state.DataPropertyName = "State";
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 57;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amount.DataPropertyName = "Amount";
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 68;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "CDate";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // cUserDataGridViewTextBoxColumn
            // 
            this.cUserDataGridViewTextBoxColumn.DataPropertyName = "CUser";
            this.cUserDataGridViewTextBoxColumn.HeaderText = "CUser";
            this.cUserDataGridViewTextBoxColumn.Name = "cUserDataGridViewTextBoxColumn";
            this.cUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // uDateDataGridViewTextBoxColumn
            // 
            this.uDateDataGridViewTextBoxColumn.DataPropertyName = "UDate";
            this.uDateDataGridViewTextBoxColumn.HeaderText = "UDate";
            this.uDateDataGridViewTextBoxColumn.Name = "uDateDataGridViewTextBoxColumn";
            this.uDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.uDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // uUserDataGridViewTextBoxColumn
            // 
            this.uUserDataGridViewTextBoxColumn.DataPropertyName = "UUser";
            this.uUserDataGridViewTextBoxColumn.HeaderText = "UUser";
            this.uUserDataGridViewTextBoxColumn.Name = "uUserDataGridViewTextBoxColumn";
            this.uUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.uUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataSrc
            // 
            this.dataSrc.DataSource = typeof(dataLib.CRDepBatch);
            // 
            // panelTrak2
            // 
            this.panelTrak2.Controls.Add(this.btnPost);
            this.panelTrak2.Controls.Add(this.btnClose);
            this.panelTrak2.Controls.Add(this.btnDelete);
            this.panelTrak2.Controls.Add(this.btnUpdate);
            this.panelTrak2.Controls.Add(this.btnAdd);
            this.panelTrak2.Controls.Add(this.btnDocs);
            this.panelTrak2.Controls.Add(this.lblAmount);
            this.panelTrak2.Controls.Add(this.lblDocCount);
            this.panelTrak2.Controls.Add(this.lblModified);
            this.panelTrak2.Controls.Add(this.label6);
            this.panelTrak2.Controls.Add(this.lblCreated);
            this.panelTrak2.Controls.Add(this.label4);
            this.panelTrak2.Controls.Add(this.label3);
            this.panelTrak2.Controls.Add(this.label2);
            this.panelTrak2.Controls.Add(this.label1);
            this.panelTrak2.Controls.Add(this.textId);
            this.panelTrak2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTrak2.Location = new System.Drawing.Point(220, 0);
            this.panelTrak2.Name = "panelTrak2";
            this.panelTrak2.Size = new System.Drawing.Size(219, 288);
            this.panelTrak2.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.Location = new System.Drawing.Point(140, 230);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 15;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(162, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(106, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(50, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(4, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnDocs
            // 
            this.btnDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDocs.Location = new System.Drawing.Point(5, 230);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(75, 23);
            this.btnDocs.TabIndex = 10;
            this.btnDocs.Text = "Documents";
            this.btnDocs.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.Location = new System.Drawing.Point(152, 46);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 14);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "123";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDocCount
            // 
            this.lblDocCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocCount.Location = new System.Drawing.Point(152, 32);
            this.lblDocCount.Name = "lblDocCount";
            this.lblDocCount.Size = new System.Drawing.Size(55, 14);
            this.lblDocCount.TabIndex = 8;
            this.lblDocCount.Text = "123";
            this.lblDocCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModified
            // 
            this.lblModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModified.Location = new System.Drawing.Point(7, 121);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(200, 14);
            this.lblModified.TabIndex = 7;
            this.lblModified.Text = "DateTime by User";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(7, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Modified";
            // 
            // lblCreated
            // 
            this.lblCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreated.Location = new System.Drawing.Point(7, 83);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(200, 14);
            this.lblCreated.TabIndex = 5;
            this.lblCreated.Text = "DateTime by User";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Created";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Document Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // textId
            // 
            this.textId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textId.Changed = false;
            this.textId.Cue = null;
            this.textId.Location = new System.Drawing.Point(34, 9);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(173, 20);
            this.textId.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statGrid,
            this.statDetail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(439, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statGrid
            // 
            this.statGrid.Name = "statGrid";
            this.statGrid.Size = new System.Drawing.Size(48, 17);
            this.statGrid.Text = "statGrid";
            // 
            // statDetail
            // 
            this.statDetail.Name = "statDetail";
            this.statDetail.Size = new System.Drawing.Size(56, 17);
            this.statDetail.Text = "statDetail";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(216, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 288);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // PaymentBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(439, 310);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelTrak1);
            this.Controls.Add(this.panelTrak2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentBatches";
            this.Text = "Payment Batches";
            this.Load += new System.EventHandler(this.PaymentBatches_Load);
            this.panelTrak1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSrc)).EndInit();
            this.panelTrak2.ResumeLayout(false);
            this.panelTrak2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private classLib.PanelTrak panelTrak1;
        private classLib.PanelTrak panelTrak2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private classLib.TextBoxTrak textId;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDocCount;
        private System.Windows.Forms.Label lblModified;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbank;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataSrc;
        private System.Windows.Forms.ToolStripStatusLabel statGrid;
        private System.Windows.Forms.ToolStripStatusLabel statDetail;
    }
}
