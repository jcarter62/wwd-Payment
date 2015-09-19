namespace RcvPayment.ca {
    partial class Apply {
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apply));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panDetail = new classLib.PanelTrak(this.components);
            this.gridDetail = new Telerik.WinControls.UI.RadGridView();
            this.cRDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDetail = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panMaster = new classLib.PanelTrak(this.components);
            this.rpb = new Telerik.WinControls.UI.RadProgressBar();
            this.gridMaster = new Telerik.WinControls.UI.RadGridView();
            this.cRMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            this.lblMaster = new System.Windows.Forms.Label();
            this.cmenu = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.cmenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.cmenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.cmResetLayout = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuManager1 = new Telerik.WinControls.UI.RadContextMenuManager();
            this.timeCheck = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.panDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDetailBindingSource)).BeginInit();
            this.panMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(348, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(118, 17);
            this.statLabel.Text = "toolStripStatusLabel1";
            // 
            // panDetail
            // 
            this.panDetail.Controls.Add(this.gridDetail);
            this.panDetail.Controls.Add(this.lblDetail);
            this.panDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDetail.Location = new System.Drawing.Point(0, 293);
            this.panDetail.Name = "panDetail";
            this.panDetail.Size = new System.Drawing.Size(348, 132);
            this.panDetail.TabIndex = 3;
            // 
            // gridDetail
            // 
            this.gridDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetail.Location = new System.Drawing.Point(7, 20);
            // 
            // 
            // 
            this.gridDetail.MasterTemplate.AllowAddNewRow = false;
            this.gridDetail.MasterTemplate.AllowCellContextMenu = false;
            this.gridDetail.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridDetail.MasterTemplate.AllowDeleteRow = false;
            this.gridDetail.MasterTemplate.AllowDragToGroup = false;
            this.gridDetail.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.FieldName = "Type";
            gridViewTextBoxColumn1.HeaderText = "Type";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Type";
            gridViewDecimalColumn1.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn1.FieldName = "Amount";
            gridViewDecimalColumn1.FormatString = "{0:C}";
            gridViewDecimalColumn1.HeaderText = "Amount";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Amount";
            gridViewTextBoxColumn2.FieldName = "Account";
            gridViewTextBoxColumn2.HeaderText = "Account";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Account";
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "Account Name";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Name";
            gridViewTextBoxColumn4.FieldName = "Note";
            gridViewTextBoxColumn4.HeaderText = "Note";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Note";
            this.gridDetail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gridDetail.MasterTemplate.DataSource = this.cRDetailBindingSource;
            this.gridDetail.MasterTemplate.ShowFilteringRow = false;
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.ReadOnly = true;
            this.gridDetail.Size = new System.Drawing.Size(334, 106);
            this.gridDetail.TabIndex = 1;
            this.gridDetail.Text = "radGridView2";
            // 
            // cRDetailBindingSource
            // 
            this.cRDetailBindingSource.DataSource = typeof(dataLib.CRDetail);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(4, 3);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(35, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "label2";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 288);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(348, 5);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panMaster
            // 
            this.panMaster.Controls.Add(this.rpb);
            this.panMaster.Controls.Add(this.gridMaster);
            this.panMaster.Controls.Add(this.lblMaster);
            this.panMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMaster.Location = new System.Drawing.Point(0, 0);
            this.panMaster.Name = "panMaster";
            this.panMaster.Size = new System.Drawing.Size(348, 288);
            this.panMaster.TabIndex = 5;
            // 
            // rpb
            // 
            this.rpb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rpb.Location = new System.Drawing.Point(277, 3);
            this.rpb.Maximum = 10;
            this.rpb.Name = "rpb";
            this.rpb.Size = new System.Drawing.Size(64, 14);
            this.rpb.TabIndex = 2;
            // 
            // gridMaster
            // 
            this.gridMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMaster.BackColor = System.Drawing.SystemColors.Control;
            this.gridMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridMaster.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridMaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridMaster.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridMaster.Location = new System.Drawing.Point(7, 21);
            // 
            // 
            // 
            this.gridMaster.MasterTemplate.AllowAddNewRow = false;
            this.gridMaster.MasterTemplate.AllowCellContextMenu = false;
            this.gridMaster.MasterTemplate.AllowSearchRow = true;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "CDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Created";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "CDate";
            gridViewDateTimeColumn1.Width = 47;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "DeliveryName";
            gridViewTextBoxColumn5.HeaderText = "Name";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "DeliveryName";
            gridViewTextBoxColumn5.Width = 78;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "PayRef";
            gridViewTextBoxColumn6.HeaderText = "Reference";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "PayRef";
            gridViewTextBoxColumn6.Width = 42;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Amount";
            gridViewDecimalColumn2.FormatString = "{0:C}";
            gridViewDecimalColumn2.HeaderText = "Amount";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Amount";
            gridViewDecimalColumn2.Width = 49;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "RcptID";
            gridViewTextBoxColumn7.HeaderText = "Receipt ID";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "RcptID";
            gridViewTextBoxColumn7.Width = 42;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "CUser";
            gridViewTextBoxColumn8.HeaderText = "Created By";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "CUser";
            gridViewTextBoxColumn8.Width = 38;
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "Postmark";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.FormatString = "{0:d}";
            gridViewDateTimeColumn2.HeaderText = "Postmark";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Postmark";
            gridViewDateTimeColumn2.Width = 55;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Note";
            gridViewTextBoxColumn9.HeaderText = "Note";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Note";
            gridViewTextBoxColumn9.Width = 33;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "StateAR";
            gridViewTextBoxColumn10.HeaderText = "AR State";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "StateAR";
            gridViewTextBoxColumn10.Width = 48;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "StateRcv";
            gridViewTextBoxColumn11.HeaderText = "StateRcv";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "StateRcv";
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "Id";
            gridViewTextBoxColumn12.HeaderText = "Id";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "Id";
            this.gridMaster.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.gridMaster.MasterTemplate.DataSource = this.cRMasterBindingSource;
            this.gridMaster.MasterTemplate.EnableFiltering = true;
            this.gridMaster.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridMaster.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.gridMaster.Name = "gridMaster";
            this.radContextMenuManager1.SetRadContextMenu(this.gridMaster, this.cmenu);
            this.gridMaster.ReadOnly = true;
            this.gridMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridMaster.Size = new System.Drawing.Size(334, 261);
            this.gridMaster.TabIndex = 1;
            this.gridMaster.Text = "radGridView1";
            this.gridMaster.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.gridMaster_CurrentRowChanged);
            // 
            // cRMasterBindingSource
            // 
            this.cRMasterBindingSource.DataSource = typeof(dataLib.CRMaster);
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.Location = new System.Drawing.Point(4, 4);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(35, 13);
            this.lblMaster.TabIndex = 0;
            this.lblMaster.Text = "label1";
            // 
            // cmenu
            // 
            this.cmenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cmenuItem1,
            this.cmenuItem2,
            this.radMenuSeparatorItem1,
            this.cmResetLayout});
            // 
            // cmenuItem1
            // 
            this.cmenuItem1.AccessibleDescription = "Select Master Record";
            this.cmenuItem1.AccessibleName = "Select Master Record";
            this.cmenuItem1.Name = "cmenuItem1";
            this.cmenuItem1.Text = "Select Master Record";
            // 
            // cmenuItem2
            // 
            this.cmenuItem2.AccessibleDescription = "Un-Select Master Record";
            this.cmenuItem2.AccessibleName = "cmenuItem2";
            this.cmenuItem2.Name = "cmenuItem2";
            this.cmenuItem2.Text = "Un-Select Master Record";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            // 
            // cmResetLayout
            // 
            this.cmResetLayout.AccessibleDescription = "Reset Grid Layout";
            this.cmResetLayout.AccessibleName = "Reset Grid Layout";
            this.cmResetLayout.Name = "cmResetLayout";
            this.cmResetLayout.Text = "Reset Grid Layout";
            // 
            // timeCheck
            // 
            this.timeCheck.Interval = 1000;
            this.timeCheck.Tick += new System.EventHandler(this.timeCheck_Tick);
            // 
            // Apply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(348, 447);
            this.Controls.Add(this.panMaster);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panDetail);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apply";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Apply_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panDetail.ResumeLayout(false);
            this.panDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDetailBindingSource)).EndInit();
            this.panMaster.ResumeLayout(false);
            this.panMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RadMenuItem1_Click(object sender, System.EventArgs e) {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private classLib.PanelTrak panDetail;
        private System.Windows.Forms.Splitter splitter1;
        private classLib.PanelTrak panMaster;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblMaster;
        private Telerik.WinControls.UI.RadGridView gridDetail;
        private Telerik.WinControls.UI.RadGridView gridMaster;
        private System.Windows.Forms.BindingSource cRMasterBindingSource;
        private Telerik.WinControls.UI.RadContextMenu cmenu;
        private Telerik.WinControls.UI.RadMenuItem cmenuItem1;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
        private Telerik.WinControls.UI.RadContextMenuManager radContextMenuManager1;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem cmenuItem2;
        private System.Windows.Forms.Timer timeCheck;
        private Telerik.WinControls.UI.RadProgressBar rpb;
        private System.Windows.Forms.BindingSource cRDetailBindingSource;
        private Telerik.WinControls.UI.RadMenuItem cmResetLayout;
    }
}
