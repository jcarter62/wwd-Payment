namespace RcvPayment.Ca {
    partial class UnApplied {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnApplied));
            this.panButtons = new classLib.PanelTrak(this.components);
            this.btnMark = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panDetail = new classLib.PanelTrak(this.components);
            this.gridDetail = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRMidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDetail = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panMaster = new classLib.PanelTrak(this.components);
            this.gridMaster = new System.Windows.Forms.DataGridView();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stateGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDetailBindingSource)).BeginInit();
            this.panMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnMark);
            this.panButtons.Controls.Add(this.btnDetail);
            this.panButtons.Controls.Add(this.btnLoad);
            this.panButtons.Controls.Add(this.btnImport);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(0, 328);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(320, 32);
            this.panButtons.TabIndex = 2;
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(152, 6);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(53, 23);
            this.btnMark.TabIndex = 3;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(93, 6);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(53, 23);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Pending";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(242, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import ABP";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(320, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(39, 17);
            this.statLabel.Text = "Status";
            // 
            // panDetail
            // 
            this.panDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDetail.Controls.Add(this.gridDetail);
            this.panDetail.Controls.Add(this.lblDetail);
            this.panDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDetail.Location = new System.Drawing.Point(0, 177);
            this.panDetail.Name = "panDetail";
            this.panDetail.Size = new System.Drawing.Size(320, 151);
            this.panDetail.TabIndex = 4;
            // 
            // gridDetail
            // 
            this.gridDetail.AllowUserToAddRows = false;
            this.gridDetail.AllowUserToDeleteRows = false;
            this.gridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetail.AutoGenerateColumns = false;
            this.gridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.accountDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.sessionIdDataGridViewTextBoxColumn1,
            this.cRMidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1,
            this.cDateDataGridViewTextBoxColumn1,
            this.cUserDataGridViewTextBoxColumn1,
            this.uDateDataGridViewTextBoxColumn1,
            this.uUserDataGridViewTextBoxColumn1});
            this.gridDetail.DataSource = this.cRDetailBindingSource;
            this.gridDetail.Location = new System.Drawing.Point(4, 17);
            this.gridDetail.MultiSelect = false;
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.ReadOnly = true;
            this.gridDetail.RowHeadersVisible = false;
            this.gridDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetail.Size = new System.Drawing.Size(311, 129);
            this.gridDetail.TabIndex = 1;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 56;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn1.Width = 68;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountDataGridViewTextBoxColumn.Width = 72;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 57;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // sessionIdDataGridViewTextBoxColumn1
            // 
            this.sessionIdDataGridViewTextBoxColumn1.DataPropertyName = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn1.HeaderText = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn1.Name = "sessionIdDataGridViewTextBoxColumn1";
            this.sessionIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sessionIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cRMidDataGridViewTextBoxColumn
            // 
            this.cRMidDataGridViewTextBoxColumn.DataPropertyName = "CRMid";
            this.cRMidDataGridViewTextBoxColumn.HeaderText = "CRMid";
            this.cRMidDataGridViewTextBoxColumn.Name = "cRMidDataGridViewTextBoxColumn";
            this.cRMidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRMidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cDateDataGridViewTextBoxColumn1
            // 
            this.cDateDataGridViewTextBoxColumn1.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn1.HeaderText = "CDate";
            this.cDateDataGridViewTextBoxColumn1.Name = "cDateDataGridViewTextBoxColumn1";
            this.cDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cUserDataGridViewTextBoxColumn1
            // 
            this.cUserDataGridViewTextBoxColumn1.DataPropertyName = "CUser";
            this.cUserDataGridViewTextBoxColumn1.HeaderText = "CUser";
            this.cUserDataGridViewTextBoxColumn1.Name = "cUserDataGridViewTextBoxColumn1";
            this.cUserDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cUserDataGridViewTextBoxColumn1.Visible = false;
            // 
            // uDateDataGridViewTextBoxColumn1
            // 
            this.uDateDataGridViewTextBoxColumn1.DataPropertyName = "UDate";
            this.uDateDataGridViewTextBoxColumn1.HeaderText = "UDate";
            this.uDateDataGridViewTextBoxColumn1.Name = "uDateDataGridViewTextBoxColumn1";
            this.uDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.uDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // uUserDataGridViewTextBoxColumn1
            // 
            this.uUserDataGridViewTextBoxColumn1.DataPropertyName = "UUser";
            this.uUserDataGridViewTextBoxColumn1.HeaderText = "UUser";
            this.uUserDataGridViewTextBoxColumn1.Name = "uUserDataGridViewTextBoxColumn1";
            this.uUserDataGridViewTextBoxColumn1.ReadOnly = true;
            this.uUserDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cRDetailBindingSource
            // 
            this.cRDetailBindingSource.DataSource = typeof(dataLib.CRDetail);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(12, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(121, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Payment Detail Records";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 172);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(320, 5);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panMaster
            // 
            this.panMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMaster.Controls.Add(this.gridMaster);
            this.panMaster.Controls.Add(this.label1);
            this.panMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMaster.Location = new System.Drawing.Point(0, 0);
            this.panMaster.Name = "panMaster";
            this.panMaster.Size = new System.Drawing.Size(320, 172);
            this.panMaster.TabIndex = 6;
            // 
            // gridMaster
            // 
            this.gridMaster.AllowUserToAddRows = false;
            this.gridMaster.AllowUserToDeleteRows = false;
            this.gridMaster.AllowUserToOrderColumns = true;
            this.gridMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMaster.AutoGenerateColumns = false;
            this.gridMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDateDataGridViewTextBoxColumn,
            this.deliveryNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.rcptIDDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.depositedDataGridViewCheckBoxColumn,
            this.stateGADataGridViewTextBoxColumn,
            this.stateARDataGridViewTextBoxColumn,
            this.sessionIdDataGridViewTextBoxColumn,
            this.payTypeDataGridViewTextBoxColumn,
            this.payRefDataGridViewTextBoxColumn,
            this.payViaDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.cUserDataGridViewTextBoxColumn,
            this.uDateDataGridViewTextBoxColumn,
            this.uUserDataGridViewTextBoxColumn});
            this.gridMaster.DataSource = this.cRMasterBindingSource;
            this.gridMaster.Location = new System.Drawing.Point(4, 17);
            this.gridMaster.MultiSelect = false;
            this.gridMaster.Name = "gridMaster";
            this.gridMaster.ReadOnly = true;
            this.gridMaster.RowHeadersVisible = false;
            this.gridMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMaster.Size = new System.Drawing.Size(311, 150);
            this.gridMaster.TabIndex = 1;
            this.gridMaster.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMaster_RowEnter);
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "Created";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Width = 69;
            // 
            // deliveryNameDataGridViewTextBoxColumn
            // 
            this.deliveryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deliveryNameDataGridViewTextBoxColumn.DataPropertyName = "DeliveryName";
            this.deliveryNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.deliveryNameDataGridViewTextBoxColumn.Name = "deliveryNameDataGridViewTextBoxColumn";
            this.deliveryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryNameDataGridViewTextBoxColumn.Width = 60;
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
            // rcptIDDataGridViewTextBoxColumn
            // 
            this.rcptIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rcptIDDataGridViewTextBoxColumn.DataPropertyName = "RcptID";
            this.rcptIDDataGridViewTextBoxColumn.HeaderText = "Receipt ID";
            this.rcptIDDataGridViewTextBoxColumn.Name = "rcptIDDataGridViewTextBoxColumn";
            this.rcptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rcptIDDataGridViewTextBoxColumn.Width = 83;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // depositedDataGridViewCheckBoxColumn
            // 
            this.depositedDataGridViewCheckBoxColumn.DataPropertyName = "Deposited";
            this.depositedDataGridViewCheckBoxColumn.HeaderText = "Deposited";
            this.depositedDataGridViewCheckBoxColumn.Name = "depositedDataGridViewCheckBoxColumn";
            this.depositedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.depositedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // stateGADataGridViewTextBoxColumn
            // 
            this.stateGADataGridViewTextBoxColumn.DataPropertyName = "StateGA";
            this.stateGADataGridViewTextBoxColumn.HeaderText = "StateGA";
            this.stateGADataGridViewTextBoxColumn.Name = "stateGADataGridViewTextBoxColumn";
            this.stateGADataGridViewTextBoxColumn.ReadOnly = true;
            this.stateGADataGridViewTextBoxColumn.Visible = false;
            // 
            // stateARDataGridViewTextBoxColumn
            // 
            this.stateARDataGridViewTextBoxColumn.DataPropertyName = "StateAR";
            this.stateARDataGridViewTextBoxColumn.HeaderText = "StateAR";
            this.stateARDataGridViewTextBoxColumn.Name = "stateARDataGridViewTextBoxColumn";
            this.stateARDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateARDataGridViewTextBoxColumn.Visible = false;
            // 
            // sessionIdDataGridViewTextBoxColumn
            // 
            this.sessionIdDataGridViewTextBoxColumn.DataPropertyName = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn.HeaderText = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn.Name = "sessionIdDataGridViewTextBoxColumn";
            this.sessionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // payTypeDataGridViewTextBoxColumn
            // 
            this.payTypeDataGridViewTextBoxColumn.DataPropertyName = "PayType";
            this.payTypeDataGridViewTextBoxColumn.HeaderText = "PayType";
            this.payTypeDataGridViewTextBoxColumn.Name = "payTypeDataGridViewTextBoxColumn";
            this.payTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.payTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // payRefDataGridViewTextBoxColumn
            // 
            this.payRefDataGridViewTextBoxColumn.DataPropertyName = "PayRef";
            this.payRefDataGridViewTextBoxColumn.HeaderText = "PayRef";
            this.payRefDataGridViewTextBoxColumn.Name = "payRefDataGridViewTextBoxColumn";
            this.payRefDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRefDataGridViewTextBoxColumn.Visible = false;
            // 
            // payViaDataGridViewTextBoxColumn
            // 
            this.payViaDataGridViewTextBoxColumn.DataPropertyName = "PayVia";
            this.payViaDataGridViewTextBoxColumn.HeaderText = "PayVia";
            this.payViaDataGridViewTextBoxColumn.Name = "payViaDataGridViewTextBoxColumn";
            this.payViaDataGridViewTextBoxColumn.ReadOnly = true;
            this.payViaDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Visible = false;
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
            // cRMasterBindingSource
            // 
            this.cRMasterBindingSource.DataSource = typeof(dataLib.CRMaster);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Master Records";
            // 
            // UnApplied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(320, 382);
            this.Controls.Add(this.panMaster);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panDetail);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnApplied";
            this.Text = "Un-Applied Payments";
            this.panButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panDetail.ResumeLayout(false);
            this.panDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDetailBindingSource)).EndInit();
            this.panMaster.ResumeLayout(false);
            this.panMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private classLib.PanelTrak panButtons;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private classLib.PanelTrak panDetail;
        private System.Windows.Forms.DataGridView gridDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Splitter splitter1;
        private classLib.PanelTrak panMaster;
        private System.Windows.Forms.DataGridView gridMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRMidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource cRDetailBindingSource;
        private System.Windows.Forms.BindingSource cRMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn depositedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uUserDataGridViewTextBoxColumn;
    }
}
