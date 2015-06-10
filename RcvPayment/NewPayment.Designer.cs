namespace RcvPayment {
    partial class NewPayment {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PaymentsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RcptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposited = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.depositedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cRMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.txtItmNote = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbItmApply2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtItmAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItmName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItmAcct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDetail = new classLib.PanelTrak(this.components);
            this.txtNote = new classLib.TextBoxTrak(this.components);
            this.txtAmount = new classLib.TextBoxTrak(this.components);
            this.txtRef = new classLib.TextBoxTrak(this.components);
            this.cbPayType = new classLib.ComboBoxTrak(this.components);
            this.txtRecFrom = new classLib.TextBoxTrak(this.components);
            this.btnSavePayment = new System.Windows.Forms.Button();
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
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblAppliedAmount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDetailBindingSource)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.PaymentsGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 501);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(282, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLbl
            // 
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(39, 17);
            this.statLbl.Text = "Status";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkShowAll);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 42);
            this.panel5.TabIndex = 2;
            // 
            // chkShowAll
            // 
            this.chkShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.Location = new System.Drawing.Point(199, 15);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(67, 17);
            this.chkShowAll.TabIndex = 1;
            this.chkShowAll.Text = "Show All";
            this.chkShowAll.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnMod);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 459);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 42);
            this.panel4.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(154, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(79, 9);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(69, 26);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Modify";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PaymentsGrid
            // 
            this.PaymentsGrid.AllowUserToAddRows = false;
            this.PaymentsGrid.AllowUserToDeleteRows = false;
            this.PaymentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentsGrid.AutoGenerateColumns = false;
            this.PaymentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RcptID,
            this.Amount,
            this.Deposited,
            this.depositedDataGridViewCheckBoxColumn});
            this.PaymentsGrid.DataSource = this.cRMasterBindingSource;
            this.PaymentsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PaymentsGrid.Location = new System.Drawing.Point(0, 41);
            this.PaymentsGrid.MultiSelect = false;
            this.PaymentsGrid.Name = "PaymentsGrid";
            this.PaymentsGrid.ReadOnly = true;
            this.PaymentsGrid.RowHeadersVisible = false;
            this.PaymentsGrid.RowHeadersWidth = 25;
            this.PaymentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentsGrid.Size = new System.Drawing.Size(282, 393);
            this.PaymentsGrid.TabIndex = 0;
            this.PaymentsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentsGrid_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 50;
            // 
            // RcptID
            // 
            this.RcptID.DataPropertyName = "RcptID";
            this.RcptID.HeaderText = "RcptID";
            this.RcptID.Name = "RcptID";
            this.RcptID.ReadOnly = true;
            this.RcptID.Width = 80;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Deposited
            // 
            this.Deposited.DataPropertyName = "Deposited";
            this.Deposited.HeaderText = "Dep";
            this.Deposited.Name = "Deposited";
            this.Deposited.ReadOnly = true;
            this.Deposited.ToolTipText = "Deposited";
            this.Deposited.Width = 25;
            // 
            // depositedDataGridViewCheckBoxColumn
            // 
            this.depositedDataGridViewCheckBoxColumn.DataPropertyName = "Deposited";
            this.depositedDataGridViewCheckBoxColumn.HeaderText = "Deposited";
            this.depositedDataGridViewCheckBoxColumn.Name = "depositedDataGridViewCheckBoxColumn";
            this.depositedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cRMasterBindingSource
            // 
            this.cRMasterBindingSource.DataSource = typeof(dataLib.CRMaster);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAppliedAmount);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(282, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(239, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 26);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(282, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 459);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnAddItem);
            this.panel7.Controls.Add(this.btnDeleteItem);
            this.panel7.Controls.Add(this.btnSaveItem);
            this.panel7.Controls.Add(this.txtItmNote);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.cbItmApply2);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.txtItmAmount);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtItmName);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.txtItmAcct);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(285, 211);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(314, 109);
            this.panel7.TabIndex = 2;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.Location = new System.Drawing.Point(11, 79);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "&Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.Location = new System.Drawing.Point(235, 77);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(69, 26);
            this.btnDeleteItem.TabIndex = 7;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveItem.Location = new System.Drawing.Point(162, 77);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(69, 26);
            this.btnSaveItem.TabIndex = 6;
            this.btnSaveItem.Text = "&Save";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // txtItmNote
            // 
            this.txtItmNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItmNote.Location = new System.Drawing.Point(47, 51);
            this.txtItmNote.Name = "txtItmNote";
            this.txtItmNote.Size = new System.Drawing.Size(257, 20);
            this.txtItmNote.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Note:";
            // 
            // cbItmApply2
            // 
            this.cbItmApply2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbItmApply2.FormattingEnabled = true;
            this.cbItmApply2.Items.AddRange(new object[] {
            "Water",
            "LnBase",
            "Assess",
            "Other"});
            this.cbItmApply2.Location = new System.Drawing.Point(206, 28);
            this.cbItmApply2.Name = "cbItmApply2";
            this.cbItmApply2.Size = new System.Drawing.Size(96, 21);
            this.cbItmApply2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Apply To:";
            // 
            // txtItmAmount
            // 
            this.txtItmAmount.Location = new System.Drawing.Point(59, 28);
            this.txtItmAmount.Name = "txtItmAmount";
            this.txtItmAmount.Size = new System.Drawing.Size(87, 20);
            this.txtItmAmount.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Amount:";
            // 
            // txtItmName
            // 
            this.txtItmName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItmName.Location = new System.Drawing.Point(190, 5);
            this.txtItmName.Name = "txtItmName";
            this.txtItmName.Size = new System.Drawing.Size(114, 20);
            this.txtItmName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Name:";
            // 
            // txtItmAcct
            // 
            this.txtItmAcct.Location = new System.Drawing.Point(59, 5);
            this.txtItmAcct.Name = "txtItmAcct";
            this.txtItmAcct.Size = new System.Drawing.Size(87, 20);
            this.txtItmAcct.TabIndex = 0;
            this.txtItmAcct.TextChanged += new System.EventHandler(this.txtItmAcct_TextChanged);
            this.txtItmAcct.DoubleClick += new System.EventHandler(this.txtItmAcct_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Account:";
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.AllowUserToAddRows = false;
            this.ItemsGrid.AllowUserToDeleteRows = false;
            this.ItemsGrid.AutoGenerateColumns = false;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.ItemsGrid.DataSource = this.cRDetailBindingSource;
            this.ItemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGrid.Location = new System.Drawing.Point(285, 320);
            this.ItemsGrid.MultiSelect = false;
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.ReadOnly = true;
            this.ItemsGrid.RowHeadersVisible = false;
            this.ItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGrid.ShowEditingIcon = false;
            this.ItemsGrid.Size = new System.Drawing.Size(314, 139);
            this.ItemsGrid.TabIndex = 23;
            this.ItemsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGrid_CellClick);
            this.ItemsGrid.Validated += new System.EventHandler(this.ItemsGrid_Validated);
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRDetailBindingSource
            // 
            this.cRDetailBindingSource.DataSource = typeof(dataLib.CRDetail);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.btnPrint);
            this.panelDetail.Controls.Add(this.txtNote);
            this.panelDetail.Controls.Add(this.txtAmount);
            this.panelDetail.Controls.Add(this.txtRef);
            this.panelDetail.Controls.Add(this.cbPayType);
            this.panelDetail.Controls.Add(this.txtRecFrom);
            this.panelDetail.Controls.Add(this.btnSavePayment);
            this.panelDetail.Controls.Add(this.label9);
            this.panelDetail.Controls.Add(this.cbVia);
            this.panelDetail.Controls.Add(this.label8);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.txtRecBy);
            this.panelDetail.Controls.Add(this.txtTimeStamp);
            this.panelDetail.Controls.Add(this.txtReceiptId);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.Location = new System.Drawing.Point(285, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(314, 211);
            this.panelDetail.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Changed = false;
            this.txtNote.Cue = "Any Special Notes about this Payment";
            this.txtNote.Location = new System.Drawing.Point(46, 158);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(257, 20);
            this.txtNote.TabIndex = 54;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Changed = false;
            this.txtAmount.Cue = "Payment Amount $$$";
            this.txtAmount.Location = new System.Drawing.Point(91, 114);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(212, 20);
            this.txtAmount.TabIndex = 53;
            // 
            // txtRef
            // 
            this.txtRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRef.Changed = false;
            this.txtRef.Cue = "Check Number";
            this.txtRef.Location = new System.Drawing.Point(205, 93);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(98, 20);
            this.txtRef.TabIndex = 52;
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
            this.cbPayType.Location = new System.Drawing.Point(91, 93);
            this.cbPayType.Name = "cbPayType";
            this.cbPayType.Size = new System.Drawing.Size(75, 21);
            this.cbPayType.TabIndex = 51;
            // 
            // txtRecFrom
            // 
            this.txtRecFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecFrom.Changed = false;
            this.txtRecFrom.Cue = "Delivery Person\'s Name";
            this.txtRecFrom.Location = new System.Drawing.Point(91, 72);
            this.txtRecFrom.Name = "txtRecFrom";
            this.txtRecFrom.Size = new System.Drawing.Size(212, 20);
            this.txtRecFrom.TabIndex = 50;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePayment.Location = new System.Drawing.Point(235, 179);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(68, 26);
            this.btnSavePayment.TabIndex = 49;
            this.btnSavePayment.Text = "Save";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 48;
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
            this.cbVia.Location = new System.Drawing.Point(91, 135);
            this.cbVia.Name = "cbVia";
            this.cbVia.Size = new System.Drawing.Size(212, 21);
            this.cbVia.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Arrived Via:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Payment Amt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ref:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Payment Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Received From:";
            // 
            // txtRecBy
            // 
            this.txtRecBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecBy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRecBy.Location = new System.Drawing.Point(91, 50);
            this.txtRecBy.Name = "txtRecBy";
            this.txtRecBy.Size = new System.Drawing.Size(212, 20);
            this.txtRecBy.TabIndex = 15;
            // 
            // txtTimeStamp
            // 
            this.txtTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeStamp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTimeStamp.Location = new System.Drawing.Point(91, 29);
            this.txtTimeStamp.Name = "txtTimeStamp";
            this.txtTimeStamp.Size = new System.Drawing.Size(212, 20);
            this.txtTimeStamp.TabIndex = 14;
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiptId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtReceiptId.Location = new System.Drawing.Point(91, 6);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(212, 20);
            this.txtReceiptId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Received By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time Stamp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Receipt ID:";
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataSource = typeof(classLib.Payments);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(10, 179);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 26);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblAppliedAmount
            // 
            this.lblAppliedAmount.Location = new System.Drawing.Point(10, 9);
            this.lblAppliedAmount.Name = "lblAppliedAmount";
            this.lblAppliedAmount.Size = new System.Drawing.Size(209, 24);
            this.lblAppliedAmount.TabIndex = 38;
            this.lblAppliedAmount.Text = "Applied Amount: $12345.00";
            this.lblAppliedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(599, 501);
            this.Controls.Add(this.ItemsGrid);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPayment";
            this.Text = "Payment Entry/Review";
            this.Load += new System.EventHandler(this.NewPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDetailBindingSource)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PaymentsGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.TextBox txtItmNote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbItmApply2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtItmAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItmName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtItmAcct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private System.Windows.Forms.BindingSource cRMasterBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statLbl;
        private classLib.PanelTrak panelDetail;
        private classLib.TextBoxTrak txtNote;
        private classLib.TextBoxTrak txtAmount;
        private classLib.TextBoxTrak txtRef;
        private classLib.ComboBoxTrak cbPayType;
        private classLib.TextBoxTrak txtRecFrom;
        private System.Windows.Forms.Button btnSavePayment;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource cRDetailBindingSource;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RcptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deposited;
        private System.Windows.Forms.DataGridViewCheckBoxColumn depositedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAppliedAmount;
        private System.Windows.Forms.Button btnPrint;
    }
}
