namespace RcvPayment {
    partial class BatchDocs {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchDocs));
            this.cRMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRDepItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panLeft = new classLib.PanelTrak(this.components);
            this.panelTrak1 = new classLib.PanelTrak(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvPend = new System.Windows.Forms.DataGridView();
            this.cDatedgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRefdgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountdgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositeddgvPend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iddgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIddgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNamedgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcptIDdgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypedgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payViadgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notedgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserdgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDatedgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUserdgvPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPendingTotal = new System.Windows.Forms.Label();
            this.panelTrak4 = new classLib.PanelTrak(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panRight = new classLib.PanelTrak(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSelectedTotal = new System.Windows.Forms.Label();
            this.dgvSel = new System.Windows.Forms.DataGridView();
            this.payRefdgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountdgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBatchdgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRMiddgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypedgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statedgvSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTrak3 = new classLib.PanelTrak(this.components);
            this.textBatchId = new classLib.TextBoxTrak(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panBot = new System.Windows.Forms.Panel();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDepItemBindingSource)).BeginInit();
            this.panLeft.SuspendLayout();
            this.panelTrak1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPend)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTrak4.SuspendLayout();
            this.panRight.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSel)).BeginInit();
            this.panelTrak3.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cRMasterBindingSource
            // 
            this.cRMasterBindingSource.DataSource = typeof(dataLib.CRMaster);
            // 
            // cRDepItemBindingSource
            // 
            this.cRDepItemBindingSource.DataSource = typeof(dataLib.CRDepItem);
            // 
            // panLeft
            // 
            this.panLeft.Controls.Add(this.panelTrak1);
            this.panLeft.Controls.Add(this.dgvPend);
            this.panLeft.Controls.Add(this.panel1);
            this.panLeft.Controls.Add(this.panelTrak4);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLeft.Location = new System.Drawing.Point(0, 0);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(211, 285);
            this.panLeft.TabIndex = 2;
            // 
            // panelTrak1
            // 
            this.panelTrak1.Controls.Add(this.btnEdit);
            this.panelTrak1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTrak1.Location = new System.Drawing.Point(0, 231);
            this.panelTrak1.Name = "panelTrak1";
            this.panelTrak1.Size = new System.Drawing.Size(211, 30);
            this.panelTrak1.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(120, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit Amount";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvPend
            // 
            this.dgvPend.AllowDrop = true;
            this.dgvPend.AllowUserToAddRows = false;
            this.dgvPend.AllowUserToDeleteRows = false;
            this.dgvPend.AutoGenerateColumns = false;
            this.dgvPend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDatedgvPend,
            this.payRefdgvPend,
            this.amountdgvPend,
            this.depositeddgvPend,
            this.iddgvPend,
            this.sessionIddgvPend,
            this.deliveryNamedgvPend,
            this.rcptIDdgvPend,
            this.payTypedgvPend,
            this.payViadgvPend,
            this.notedgvPend,
            this.cUserdgvPend,
            this.uDatedgvPend,
            this.uUserdgvPend});
            this.dgvPend.DataSource = this.cRMasterBindingSource;
            this.dgvPend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPend.Location = new System.Drawing.Point(0, 27);
            this.dgvPend.Name = "dgvPend";
            this.dgvPend.ReadOnly = true;
            this.dgvPend.RowHeadersVisible = false;
            this.dgvPend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPend.Size = new System.Drawing.Size(211, 234);
            this.dgvPend.TabIndex = 7;
            this.dgvPend.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPend_CellContentClick);
            this.dgvPend.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvPend_DragDrop);
            this.dgvPend.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvPend_DragOver);
            this.dgvPend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPend_MouseDown);
            this.dgvPend.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPend_MouseMove);
            // 
            // cDatedgvPend
            // 
            this.cDatedgvPend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cDatedgvPend.DataPropertyName = "CDate";
            this.cDatedgvPend.HeaderText = "Created";
            this.cDatedgvPend.Name = "cDatedgvPend";
            this.cDatedgvPend.ReadOnly = true;
            this.cDatedgvPend.Width = 69;
            // 
            // payRefdgvPend
            // 
            this.payRefdgvPend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.payRefdgvPend.DataPropertyName = "PayRef";
            this.payRefdgvPend.HeaderText = "Pay Ref";
            this.payRefdgvPend.Name = "payRefdgvPend";
            this.payRefdgvPend.ReadOnly = true;
            this.payRefdgvPend.Width = 70;
            // 
            // amountdgvPend
            // 
            this.amountdgvPend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountdgvPend.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountdgvPend.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountdgvPend.HeaderText = "Amount";
            this.amountdgvPend.Name = "amountdgvPend";
            this.amountdgvPend.ReadOnly = true;
            this.amountdgvPend.Width = 68;
            // 
            // depositeddgvPend
            // 
            this.depositeddgvPend.DataPropertyName = "Deposited";
            this.depositeddgvPend.HeaderText = "Deposited";
            this.depositeddgvPend.Name = "depositeddgvPend";
            this.depositeddgvPend.ReadOnly = true;
            this.depositeddgvPend.Visible = false;
            // 
            // iddgvPend
            // 
            this.iddgvPend.DataPropertyName = "Id";
            this.iddgvPend.HeaderText = "Id";
            this.iddgvPend.Name = "iddgvPend";
            this.iddgvPend.ReadOnly = true;
            this.iddgvPend.Visible = false;
            // 
            // sessionIddgvPend
            // 
            this.sessionIddgvPend.DataPropertyName = "SessionId";
            this.sessionIddgvPend.HeaderText = "SessionId";
            this.sessionIddgvPend.Name = "sessionIddgvPend";
            this.sessionIddgvPend.ReadOnly = true;
            this.sessionIddgvPend.Visible = false;
            // 
            // deliveryNamedgvPend
            // 
            this.deliveryNamedgvPend.DataPropertyName = "DeliveryName";
            this.deliveryNamedgvPend.HeaderText = "DeliveryName";
            this.deliveryNamedgvPend.Name = "deliveryNamedgvPend";
            this.deliveryNamedgvPend.ReadOnly = true;
            this.deliveryNamedgvPend.Visible = false;
            // 
            // rcptIDdgvPend
            // 
            this.rcptIDdgvPend.DataPropertyName = "RcptID";
            this.rcptIDdgvPend.HeaderText = "RcptID";
            this.rcptIDdgvPend.Name = "rcptIDdgvPend";
            this.rcptIDdgvPend.ReadOnly = true;
            this.rcptIDdgvPend.Visible = false;
            // 
            // payTypedgvPend
            // 
            this.payTypedgvPend.DataPropertyName = "PayType";
            this.payTypedgvPend.HeaderText = "PayType";
            this.payTypedgvPend.Name = "payTypedgvPend";
            this.payTypedgvPend.ReadOnly = true;
            this.payTypedgvPend.Visible = false;
            // 
            // payViadgvPend
            // 
            this.payViadgvPend.DataPropertyName = "PayVia";
            this.payViadgvPend.HeaderText = "PayVia";
            this.payViadgvPend.Name = "payViadgvPend";
            this.payViadgvPend.ReadOnly = true;
            this.payViadgvPend.Visible = false;
            // 
            // notedgvPend
            // 
            this.notedgvPend.DataPropertyName = "Note";
            this.notedgvPend.HeaderText = "Note";
            this.notedgvPend.Name = "notedgvPend";
            this.notedgvPend.ReadOnly = true;
            this.notedgvPend.Visible = false;
            // 
            // cUserdgvPend
            // 
            this.cUserdgvPend.DataPropertyName = "CUser";
            this.cUserdgvPend.HeaderText = "CUser";
            this.cUserdgvPend.Name = "cUserdgvPend";
            this.cUserdgvPend.ReadOnly = true;
            this.cUserdgvPend.Visible = false;
            // 
            // uDatedgvPend
            // 
            this.uDatedgvPend.DataPropertyName = "UDate";
            this.uDatedgvPend.HeaderText = "UDate";
            this.uDatedgvPend.Name = "uDatedgvPend";
            this.uDatedgvPend.ReadOnly = true;
            this.uDatedgvPend.Visible = false;
            // 
            // uUserdgvPend
            // 
            this.uUserdgvPend.DataPropertyName = "UUser";
            this.uUserdgvPend.HeaderText = "UUser";
            this.uUserdgvPend.Name = "uUserdgvPend";
            this.uUserdgvPend.ReadOnly = true;
            this.uUserdgvPend.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPendingTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 24);
            this.panel1.TabIndex = 8;
            // 
            // lblPendingTotal
            // 
            this.lblPendingTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingTotal.Location = new System.Drawing.Point(6, 3);
            this.lblPendingTotal.Name = "lblPendingTotal";
            this.lblPendingTotal.Size = new System.Drawing.Size(199, 18);
            this.lblPendingTotal.TabIndex = 0;
            this.lblPendingTotal.Text = "Pending Total Amount: $12345.00";
            this.lblPendingTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTrak4
            // 
            this.panelTrak4.Controls.Add(this.label1);
            this.panelTrak4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrak4.Location = new System.Drawing.Point(0, 0);
            this.panelTrak4.Name = "panelTrak4";
            this.panelTrak4.Size = new System.Drawing.Size(211, 27);
            this.panelTrak4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pending Payments for Deposit";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(211, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 285);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // panRight
            // 
            this.panRight.Controls.Add(this.panel2);
            this.panRight.Controls.Add(this.dgvSel);
            this.panRight.Controls.Add(this.panelTrak3);
            this.panRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRight.Location = new System.Drawing.Point(221, 0);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(225, 285);
            this.panRight.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSelectedTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 24);
            this.panel2.TabIndex = 2;
            // 
            // lblSelectedTotal
            // 
            this.lblSelectedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedTotal.Location = new System.Drawing.Point(3, 3);
            this.lblSelectedTotal.Name = "lblSelectedTotal";
            this.lblSelectedTotal.Size = new System.Drawing.Size(217, 18);
            this.lblSelectedTotal.TabIndex = 1;
            this.lblSelectedTotal.Text = "Selected Total Amount: $12345.00";
            this.lblSelectedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSel
            // 
            this.dgvSel.AllowDrop = true;
            this.dgvSel.AllowUserToAddRows = false;
            this.dgvSel.AllowUserToDeleteRows = false;
            this.dgvSel.AutoGenerateColumns = false;
            this.dgvSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payRefdgvSel,
            this.amountdgvSel,
            this.iddgvSel,
            this.iDBatchdgvSel,
            this.cRMiddgvSel,
            this.payTypedgvSel,
            this.statedgvSel});
            this.dgvSel.DataSource = this.cRDepItemBindingSource;
            this.dgvSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSel.Location = new System.Drawing.Point(0, 27);
            this.dgvSel.Name = "dgvSel";
            this.dgvSel.ReadOnly = true;
            this.dgvSel.RowHeadersVisible = false;
            this.dgvSel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSel.Size = new System.Drawing.Size(225, 258);
            this.dgvSel.TabIndex = 1;
            this.dgvSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSel_CellContentClick);
            this.dgvSel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvSel_DragDrop);
            this.dgvSel.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvSel_DragOver);
            this.dgvSel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSel_MouseDown);
            this.dgvSel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvSel_MouseMove);
            // 
            // payRefdgvSel
            // 
            this.payRefdgvSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.payRefdgvSel.DataPropertyName = "PayRef";
            this.payRefdgvSel.HeaderText = "Pay Ref";
            this.payRefdgvSel.Name = "payRefdgvSel";
            this.payRefdgvSel.ReadOnly = true;
            this.payRefdgvSel.Width = 70;
            // 
            // amountdgvSel
            // 
            this.amountdgvSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountdgvSel.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.amountdgvSel.DefaultCellStyle = dataGridViewCellStyle2;
            this.amountdgvSel.HeaderText = "Amount";
            this.amountdgvSel.Name = "amountdgvSel";
            this.amountdgvSel.ReadOnly = true;
            this.amountdgvSel.Width = 68;
            // 
            // iddgvSel
            // 
            this.iddgvSel.DataPropertyName = "Id";
            this.iddgvSel.HeaderText = "Id";
            this.iddgvSel.Name = "iddgvSel";
            this.iddgvSel.ReadOnly = true;
            this.iddgvSel.Visible = false;
            // 
            // iDBatchdgvSel
            // 
            this.iDBatchdgvSel.DataPropertyName = "IDBatch";
            this.iDBatchdgvSel.HeaderText = "IDBatch";
            this.iDBatchdgvSel.Name = "iDBatchdgvSel";
            this.iDBatchdgvSel.ReadOnly = true;
            this.iDBatchdgvSel.Visible = false;
            // 
            // cRMiddgvSel
            // 
            this.cRMiddgvSel.DataPropertyName = "CRMid";
            this.cRMiddgvSel.HeaderText = "CRMid";
            this.cRMiddgvSel.Name = "cRMiddgvSel";
            this.cRMiddgvSel.ReadOnly = true;
            this.cRMiddgvSel.Visible = false;
            // 
            // payTypedgvSel
            // 
            this.payTypedgvSel.DataPropertyName = "PayType";
            this.payTypedgvSel.HeaderText = "PayType";
            this.payTypedgvSel.Name = "payTypedgvSel";
            this.payTypedgvSel.ReadOnly = true;
            this.payTypedgvSel.Visible = false;
            // 
            // statedgvSel
            // 
            this.statedgvSel.DataPropertyName = "State";
            this.statedgvSel.HeaderText = "State";
            this.statedgvSel.Name = "statedgvSel";
            this.statedgvSel.ReadOnly = true;
            this.statedgvSel.Visible = false;
            // 
            // panelTrak3
            // 
            this.panelTrak3.Controls.Add(this.textBatchId);
            this.panelTrak3.Controls.Add(this.label2);
            this.panelTrak3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrak3.Location = new System.Drawing.Point(0, 0);
            this.panelTrak3.Name = "panelTrak3";
            this.panelTrak3.Size = new System.Drawing.Size(225, 27);
            this.panelTrak3.TabIndex = 0;
            // 
            // textBatchId
            // 
            this.textBatchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBatchId.Changed = false;
            this.textBatchId.Cue = null;
            this.textBatchId.Location = new System.Drawing.Point(109, 4);
            this.textBatchId.Name = "textBatchId";
            this.textBatchId.ReadOnly = true;
            this.textBatchId.Size = new System.Drawing.Size(111, 20);
            this.textBatchId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Records for";
            // 
            // panBot
            // 
            this.panBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBot.Location = new System.Drawing.Point(0, 285);
            this.panBot.Name = "panBot";
            this.panBot.Size = new System.Drawing.Size(446, 5);
            this.panBot.TabIndex = 0;
            // 
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.statStrip.Location = new System.Drawing.Point(0, 290);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(446, 22);
            this.statStrip.TabIndex = 1;
            this.statStrip.Text = "statStrip";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(54, 17);
            this.statLabel.Text = "statLabel";
            // 
            // BatchDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(446, 312);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.panBot);
            this.Controls.Add(this.statStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatchDocs";
            this.Text = "Payment Batch / Documents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatchDocs_FormClosing);
            this.Load += new System.EventHandler(this.BatchDocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDepItemBindingSource)).EndInit();
            this.panLeft.ResumeLayout(false);
            this.panelTrak1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPend)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTrak4.ResumeLayout(false);
            this.panelTrak4.PerformLayout();
            this.panRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSel)).EndInit();
            this.panelTrak3.ResumeLayout(false);
            this.panelTrak3.PerformLayout();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panBot;
        private System.Windows.Forms.StatusStrip statStrip;
        private classLib.PanelTrak panLeft;
        private System.Windows.Forms.DataGridView dgvPend;
        private classLib.PanelTrak panelTrak4;
        private System.Windows.Forms.Label label1;
        private classLib.PanelTrak panRight;
        private System.Windows.Forms.DataGridView dgvSel;
        private classLib.PanelTrak panelTrak3;
        private classLib.TextBoxTrak textBatchId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.BindingSource cRMasterBindingSource;
        private System.Windows.Forms.BindingSource cRDepItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statedgvPend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPendingTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectedTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatedgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRefdgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountdgvPend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn depositeddgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIddgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNamedgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcptIDdgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypedgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn payViadgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn notedgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserdgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDatedgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn uUserdgvPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRefdgvSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountdgvSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddgvSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBatchdgvSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRMiddgvSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypedgvSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn statedgvSel;
        private classLib.PanelTrak panelTrak1;
        private System.Windows.Forms.Button btnEdit;
    }
}
