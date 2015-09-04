namespace RcvPayment {
    partial class Report1 {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            this.groupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.subTotalPanel = new Telerik.Reporting.Panel();
            this.subTotalLabelTextBox = new Telerik.Reporting.TextBox();
            this.subTotalTextBox = new Telerik.Reporting.TextBox();
            this.groupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.itemsHeaderPanel = new Telerik.Reporting.Panel();
            this.ItemNoHeaderTextBox = new Telerik.Reporting.TextBox();
            this.descriptionHeaderTextBox = new Telerik.Reporting.TextBox();
            this.lineTotalHeaderTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.dataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageHeaderSection = new Telerik.Reporting.PageHeaderSection();
            this.invoiceInfoPanel = new Telerik.Reporting.Panel();
            this.invoiceHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceNumberHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceNrTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateTextBox = new Telerik.Reporting.TextBox();
            this.invoiceTotalHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceTotalTextBox1 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.itemNrTextBox = new Telerik.Reporting.TextBox();
            this.itemDescriptionTextBox = new Telerik.Reporting.TextBox();
            this.lineTotalTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // groupFooterSection
            // 
            this.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.64082705974578857D);
            this.groupFooterSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subTotalPanel});
            this.groupFooterSection.Name = "groupFooterSection";
            this.groupFooterSection.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.groupFooterSection.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // subTotalPanel
            // 
            this.subTotalPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subTotalLabelTextBox,
            this.subTotalTextBox});
            this.subTotalPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0084657669067382812D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.subTotalPanel.Name = "subTotalPanel";
            this.subTotalPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4914155006408691D), Telerik.Reporting.Drawing.Unit.Inch(0.35433068871498108D));
            this.subTotalPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalPanel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalPanel.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalPanel.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2D);
            // 
            // subTotalLabelTextBox
            // 
            this.subTotalLabelTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0000786781311035D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.subTotalLabelTextBox.Name = "subTotalLabelTextBox";
            this.subTotalLabelTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0998420715332031D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.subTotalLabelTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalLabelTextBox.Style.Font.Bold = true;
            this.subTotalLabelTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.subTotalLabelTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.subTotalLabelTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalLabelTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.subTotalLabelTextBox.Value = "Sub Total";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Format = "{0:C2}";
            this.subTotalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.09999942779541D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3914165496826172D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.subTotalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalTextBox.Style.Font.Bold = true;
            this.subTotalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.subTotalTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.subTotalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.subTotalTextBox.Value = "=Sum(Fields.[dAmount])";
            // 
            // groupHeaderSection
            // 
            this.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D);
            this.groupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemsHeaderPanel});
            this.groupHeaderSection.Name = "groupHeaderSection";
            this.groupHeaderSection.PrintOnEveryPage = true;
            this.groupHeaderSection.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.19685038924217224D);
            // 
            // itemsHeaderPanel
            // 
            this.itemsHeaderPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.ItemNoHeaderTextBox,
            this.descriptionHeaderTextBox,
            this.lineTotalHeaderTextBox,
            this.textBox3,
            this.textBox8});
            this.itemsHeaderPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemsHeaderPanel.Name = "itemsHeaderPanel";
            this.itemsHeaderPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4999213218688965D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.itemsHeaderPanel.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.itemsHeaderPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemsHeaderPanel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.itemsHeaderPanel.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            // 
            // ItemNoHeaderTextBox
            // 
            this.ItemNoHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00019709266780409962D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.ItemNoHeaderTextBox.Name = "ItemNoHeaderTextBox";
            this.ItemNoHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.799802839756012D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.ItemNoHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.ItemNoHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.ItemNoHeaderTextBox.Style.Font.Bold = true;
            this.ItemNoHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.ItemNoHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.ItemNoHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.ItemNoHeaderTextBox.Value = "Account";
            // 
            // descriptionHeaderTextBox
            // 
            this.descriptionHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.80007869005203247D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.descriptionHeaderTextBox.Name = "descriptionHeaderTextBox";
            this.descriptionHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999212980270386D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.descriptionHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.descriptionHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.descriptionHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.descriptionHeaderTextBox.Style.Font.Bold = true;
            this.descriptionHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.descriptionHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.descriptionHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.descriptionHeaderTextBox.Value = "Account Name";
            // 
            // lineTotalHeaderTextBox
            // 
            this.lineTotalHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.lineTotalHeaderTextBox.Name = "lineTotalHeaderTextBox";
            this.lineTotalHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999214172363281D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.lineTotalHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.lineTotalHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.lineTotalHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.lineTotalHeaderTextBox.Style.Font.Bold = true;
            this.lineTotalHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.lineTotalHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.lineTotalHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.lineTotalHeaderTextBox.Value = "Amount";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4994869232177734D), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6004337072372437D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.textBox3.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Color = System.Drawing.Color.DimGray;
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "Note";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000789642333984D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79932898283004761D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.textBox8.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.Color = System.Drawing.Color.DimGray;
            this.textBox8.Style.Font.Bold = true;
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "Type";
            // 
            // dataSource1
            // 
            this.dataSource1.ConnectionString = "Data Source=df2a\\sqlexpress;Initial Catalog=testdb;Integrated Security=True";
            this.dataSource1.Name = "dataSource1";
            this.dataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@Param1", System.Data.DbType.String, "= Parameters.Param1.Value")});
            this.dataSource1.ProviderName = "System.Data.SqlClient";
            this.dataSource1.SelectCommand = "SELECT        Id, mDeliveryName, mAmount, mPayRef, mPayType, mPayVia, mnote, dAcc" +
    "ount, dName, dAmount, dnote, mRcptID, mCreatedOn, dType\r\nFROM            v_CrRec" +
    "eipt\r\nWHERE        (Id = @Param1)";
            // 
            // pageHeaderSection
            // 
            this.pageHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.9685826301574707D);
            this.pageHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceInfoPanel});
            this.pageHeaderSection.Name = "pageHeaderSection";
            // 
            // invoiceInfoPanel
            // 
            this.invoiceInfoPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceHeaderTextBox,
            this.invoiceNumberHeaderTextBox,
            this.invoiceNrTextBox,
            this.invoiceDateHeaderTextBox,
            this.invoiceDateTextBox,
            this.invoiceTotalHeaderTextBox,
            this.invoiceTotalTextBox1,
            this.textBox1,
            this.textBox2,
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox10});
            this.invoiceInfoPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceInfoPanel.Name = "invoiceInfoPanel";
            this.invoiceInfoPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4998817443847656D), Telerik.Reporting.Drawing.Unit.Inch(1.9685826301574707D));
            // 
            // invoiceHeaderTextBox
            // 
            this.invoiceHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0000784397125244D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceHeaderTextBox.Name = "invoiceHeaderTextBox";
            this.invoiceHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2596855163574219D), Telerik.Reporting.Drawing.Unit.Inch(0.39397674798965454D));
            this.invoiceHeaderTextBox.Style.Font.Bold = true;
            this.invoiceHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.invoiceHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.invoiceHeaderTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.invoiceHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.invoiceHeaderTextBox.Value = "Payment Receipt";
            // 
            // invoiceNumberHeaderTextBox
            // 
            this.invoiceNumberHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5D), Telerik.Reporting.Drawing.Unit.Inch(0.55236375331878662D));
            this.invoiceNumberHeaderTextBox.Name = "invoiceNumberHeaderTextBox";
            this.invoiceNumberHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999211072921753D), Telerik.Reporting.Drawing.Unit.Inch(0.23582638800144196D));
            this.invoiceNumberHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.invoiceNumberHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceNumberHeaderTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceNumberHeaderTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.invoiceNumberHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceNumberHeaderTextBox.Style.Font.Bold = true;
            this.invoiceNumberHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceNumberHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceNumberHeaderTextBox.Value = "Receipt ID:";
            // 
            // invoiceNrTextBox
            // 
            this.invoiceNrTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0.55236375331878662D));
            this.invoiceNrTextBox.Name = "invoiceNrTextBox";
            this.invoiceNrTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8998420238494873D), Telerik.Reporting.Drawing.Unit.Inch(0.23582650721073151D));
            this.invoiceNrTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceNrTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceNrTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.invoiceNrTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.invoiceNrTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.invoiceNrTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceNrTextBox.Value = "= Fields.mRcptID";
            // 
            // invoiceDateHeaderTextBox
            // 
            this.invoiceDateHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5D), Telerik.Reporting.Drawing.Unit.Inch(0.78826886415481567D));
            this.invoiceDateHeaderTextBox.Name = "invoiceDateHeaderTextBox";
            this.invoiceDateHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999207496643066D), Telerik.Reporting.Drawing.Unit.Inch(0.23574735224246979D));
            this.invoiceDateHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.invoiceDateHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceDateHeaderTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceDateHeaderTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.invoiceDateHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceDateHeaderTextBox.Style.Font.Bold = true;
            this.invoiceDateHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceDateHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceDateHeaderTextBox.Value = "Date:";
            // 
            // invoiceDateTextBox
            // 
            this.invoiceDateTextBox.Format = "{0:d}";
            this.invoiceDateTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0.78826862573623657D));
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8998416662216187D), Telerik.Reporting.Drawing.Unit.Inch(0.23574751615524292D));
            this.invoiceDateTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceDateTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceDateTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.invoiceDateTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.invoiceDateTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.invoiceDateTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceDateTextBox.Value = "= Today()";
            // 
            // invoiceTotalHeaderTextBox
            // 
            this.invoiceTotalHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4994869232177734D), Telerik.Reporting.Drawing.Unit.Inch(1.0240950584411621D));
            this.invoiceTotalHeaderTextBox.Name = "invoiceTotalHeaderTextBox";
            this.invoiceTotalHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1004338264465332D), Telerik.Reporting.Drawing.Unit.Inch(0.23566851019859314D));
            this.invoiceTotalHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.invoiceTotalHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceTotalHeaderTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceTotalHeaderTextBox.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.invoiceTotalHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceTotalHeaderTextBox.Style.Font.Bold = true;
            this.invoiceTotalHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceTotalHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceTotalHeaderTextBox.Value = "Amount:";
            // 
            // invoiceTotalTextBox1
            // 
            this.invoiceTotalTextBox1.Format = "{0:C2}";
            this.invoiceTotalTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(1.0240950584411621D));
            this.invoiceTotalTextBox1.Name = "invoiceTotalTextBox1";
            this.invoiceTotalTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8998417854309082D), Telerik.Reporting.Drawing.Unit.Inch(0.23566867411136627D));
            this.invoiceTotalTextBox1.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceTotalTextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceTotalTextBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.invoiceTotalTextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.invoiceTotalTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.invoiceTotalTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceTotalTextBox1.Value = "= Fields.mAmount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4994869232177734D), Telerik.Reporting.Drawing.Unit.Inch(1.26039457321167D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1004338264465332D), Telerik.Reporting.Drawing.Unit.Inch(0.23566851019859314D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox1.Style.Color = System.Drawing.Color.DimGray;
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Delivered By/Via:";
            // 
            // textBox2
            // 
            this.textBox2.Format = "{0:C2}";
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(1.2598425149917603D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8993293046951294D), Telerik.Reporting.Drawing.Unit.Inch(0.23566867411136627D));
            this.textBox2.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "= Fields.mDeliveryName + \"/\" + Fields.mPayVia";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00031582513474859297D), Telerik.Reporting.Drawing.Unit.Inch(3.9378803194267675E-05D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9996840953826904D), Telerik.Reporting.Drawing.Unit.Inch(1.0999605655670166D));
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top;
            this.textBox5.Value = "Westlands Water District";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5005130767822266D), Telerik.Reporting.Drawing.Unit.Inch(1.4965753555297852D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.09940767288208D), Telerik.Reporting.Drawing.Unit.Inch(0.23566851019859314D));
            this.textBox6.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.textBox6.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox6.Style.Color = System.Drawing.Color.DimGray;
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "Document ID:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(1.4965753555297852D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8993291854858398D), Telerik.Reporting.Drawing.Unit.Inch(0.23582650721073151D));
            this.textBox7.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.Value = "= Fields.mPayRef";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(-4.4408920985006262E-16D), Telerik.Reporting.Drawing.Unit.Inch(1.7327561378479004D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.49932861328125D), Telerik.Reporting.Drawing.Unit.Inch(0.23582650721073151D));
            this.textBox10.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox10.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox10.Value = "= \"Payment Note: \" + Fields.mnote";
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.35448837280273438D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemNrTextBox,
            this.itemDescriptionTextBox,
            this.lineTotalTextBox,
            this.textBox4,
            this.textBox9});
            this.detailSection1.Name = "detailSection1";
            this.detailSection1.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.detailSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detailSection1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            // 
            // itemNrTextBox
            // 
            this.itemNrTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemNrTextBox.Name = "itemNrTextBox";
            this.itemNrTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79149442911148071D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.itemNrTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemNrTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.itemNrTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.itemNrTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.itemNrTextBox.Value = "= Fields.dAccount";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.80007869005203247D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8914159536361694D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.itemDescriptionTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemDescriptionTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.itemDescriptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.itemDescriptionTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.itemDescriptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.itemDescriptionTextBox.Value = "= Fields.dName";
            // 
            // lineTotalTextBox
            // 
            this.lineTotalTextBox.Format = "{0:C2}";
            this.lineTotalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.lineTotalTextBox.Name = "lineTotalTextBox";
            this.lineTotalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998819589614868D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.lineTotalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.lineTotalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.lineTotalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.lineTotalTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.lineTotalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.lineTotalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.lineTotalTextBox.Value = "= Fields.dAmount";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4994869232177734D), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5919287204742432D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.textBox4.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "= Fields.dnote";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000789642333984D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79082357883453369D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.textBox9.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.textBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.textBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.Value = "= Fields.dType";
            // 
            // Report1
            // 
            this.Culture = new System.Globalization.CultureInfo("en-US");
            this.DataSource = this.dataSource1;
            group1.GroupFooter = this.groupFooterSection;
            group1.GroupHeader = this.groupHeaderSection;
            group1.Name = "group";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.groupHeaderSection,
            this.groupFooterSection,
            this.pageHeaderSection,
            this.detailSection1});
            this.Name = "Invoice1";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "Param1";
            reportParameter1.Text = "Param1";
            reportParameter1.Value = "856e091752bb41849a0710d6c71383a7";
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Inch;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.4999608993530273D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dataSource1;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection;
        private Telerik.Reporting.Panel invoiceInfoPanel;
        private Telerik.Reporting.TextBox invoiceHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceNumberHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceNrTextBox;
        private Telerik.Reporting.TextBox invoiceDateHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceDateTextBox;
        private Telerik.Reporting.TextBox invoiceTotalHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceTotalTextBox1;
        private Telerik.Reporting.DetailSection detailSection1;
        private Telerik.Reporting.TextBox itemNrTextBox;
        private Telerik.Reporting.TextBox itemDescriptionTextBox;
        private Telerik.Reporting.TextBox lineTotalTextBox;
        private Telerik.Reporting.GroupHeaderSection groupHeaderSection;
        private Telerik.Reporting.Panel itemsHeaderPanel;
        private Telerik.Reporting.TextBox ItemNoHeaderTextBox;
        private Telerik.Reporting.TextBox descriptionHeaderTextBox;
        private Telerik.Reporting.TextBox lineTotalHeaderTextBox;
        private Telerik.Reporting.GroupFooterSection groupFooterSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.Panel subTotalPanel;
        private Telerik.Reporting.TextBox subTotalLabelTextBox;
        private Telerik.Reporting.TextBox subTotalTextBox;
    }
}