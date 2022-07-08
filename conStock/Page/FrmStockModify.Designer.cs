namespace conStock.Page
{
    partial class FrmStockModify
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockModify));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocalInvoice = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxWh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblRawMaterial = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRawMaterialPrice = new System.Windows.Forms.TextBox();
            this.lblMaterialPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFreightPrice = new System.Windows.Forms.TextBox();
            this.lblFreightPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lblFreightAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaterialAmount = new System.Windows.Forms.Label();
            this.txtRawMaterialAmt = new System.Windows.Forms.TextBox();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.txtIojpno = new System.Windows.Forms.TextBox();
            this.txtMarks4 = new System.Windows.Forms.TextBox();
            this.txtMarks3 = new System.Windows.Forms.TextBox();
            this.txtMarks2 = new System.Windows.Forms.TextBox();
            this.txtMarks1 = new System.Windows.Forms.TextBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtPoDate = new System.Windows.Forms.TextBox();
            this.lblPo = new System.Windows.Forms.Label();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IOJPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BUYERITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPOT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAPVND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IO_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.IOQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IOREQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIOPRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIOAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PORDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GUMDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.CUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DREF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GridList = new DevExpress.XtraGrid.GridControl();
            this.gridDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DIOJPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIO_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DREF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIVREF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DBUYERITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DDEPOT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DNAPVND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIOQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIOREQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DFIOPRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DFIOAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DPORDNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DGUMDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DCUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DDREF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.pnlSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2017, 1032);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.cbxCompany);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.btnPrint);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnQuery);
            this.pnlMain.Controls.Add(this.txtLocalInvoice);
            this.pnlMain.Controls.Add(this.dateTimePicker2);
            this.pnlMain.Controls.Add(this.dateTimePicker1);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.cbxItem);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.cbxCust);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.cbxWh);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(2011, 104);
            this.pnlMain.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Location = new System.Drawing.Point(1169, 54);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 44);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(1169, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "SAVE IN";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnQuery.Location = new System.Drawing.Point(1045, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 44);
            this.btnQuery.TabIndex = 20;
            this.btnQuery.Text = "Search";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtLocalInvoice
            // 
            this.txtLocalInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalInvoice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalInvoice.Location = new System.Drawing.Point(339, 60);
            this.txtLocalInvoice.Name = "txtLocalInvoice";
            this.txtLocalInvoice.Size = new System.Drawing.Size(163, 25);
            this.txtLocalInvoice.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(884, 60);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 25);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(883, 16);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 25);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(783, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Query Day";
            // 
            // cbxItem
            // 
            this.cbxItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(571, 60);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(207, 26);
            this.cbxItem.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "ITEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Local Invoice";
            // 
            // cbxCust
            // 
            this.cbxCust.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(570, 16);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(207, 26);
            this.cbxCust.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buyer";
            // 
            // cbxWh
            // 
            this.cbxWh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWh.FormattingEnabled = true;
            this.cbxWh.Location = new System.Drawing.Point(339, 16);
            this.cbxWh.Name = "cbxWh";
            this.cbxWh.Size = new System.Drawing.Size(163, 26);
            this.cbxWh.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Warehouse";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Grid, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GridList, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2011, 916);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pnlSub, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 768);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(2005, 145);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.lblFreight, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblRawMaterial, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1606, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(394, 135);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFreight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFreight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreight.Location = new System.Drawing.Point(4, 1);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(130, 66);
            this.lblFreight.TabIndex = 2;
            this.lblFreight.Text = "Freight Surcharge";
            this.lblFreight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRawMaterial
            // 
            this.lblRawMaterial.AutoSize = true;
            this.lblRawMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawMaterial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterial.Location = new System.Drawing.Point(4, 68);
            this.lblRawMaterial.Name = "lblRawMaterial";
            this.lblRawMaterial.Size = new System.Drawing.Size(130, 66);
            this.lblRawMaterial.TabIndex = 6;
            this.lblRawMaterial.Text = "Raw Material";
            this.lblRawMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.txtRawMaterialPrice, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblMaterialPrice, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(141, 71);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(111, 60);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // txtRawMaterialPrice
            // 
            this.txtRawMaterialPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawMaterialPrice.BackColor = System.Drawing.Color.Salmon;
            this.txtRawMaterialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRawMaterialPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawMaterialPrice.ForeColor = System.Drawing.Color.Blue;
            this.txtRawMaterialPrice.Location = new System.Drawing.Point(3, 33);
            this.txtRawMaterialPrice.Name = "txtRawMaterialPrice";
            this.txtRawMaterialPrice.Size = new System.Drawing.Size(105, 27);
            this.txtRawMaterialPrice.TabIndex = 8;
            this.txtRawMaterialPrice.Text = "0";
            this.txtRawMaterialPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRawMaterialPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRawMaterialPrice_KeyPress);
            this.txtRawMaterialPrice.Leave += new System.EventHandler(this.txtRawMaterialPrice_Leave);
            // 
            // lblMaterialPrice
            // 
            this.lblMaterialPrice.AutoSize = true;
            this.lblMaterialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialPrice.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialPrice.Location = new System.Drawing.Point(3, 0);
            this.lblMaterialPrice.Name = "lblMaterialPrice";
            this.lblMaterialPrice.Size = new System.Drawing.Size(105, 30);
            this.lblMaterialPrice.TabIndex = 9;
            this.lblMaterialPrice.Text = "Price";
            this.lblMaterialPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.txtFreightPrice, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblFreightPrice, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(141, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(111, 60);
            this.tableLayoutPanel7.TabIndex = 11;
            // 
            // txtFreightPrice
            // 
            this.txtFreightPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFreightPrice.BackColor = System.Drawing.Color.Salmon;
            this.txtFreightPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreightPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreightPrice.ForeColor = System.Drawing.Color.Blue;
            this.txtFreightPrice.Location = new System.Drawing.Point(3, 33);
            this.txtFreightPrice.Name = "txtFreightPrice";
            this.txtFreightPrice.Size = new System.Drawing.Size(105, 27);
            this.txtFreightPrice.TabIndex = 7;
            this.txtFreightPrice.Text = "0";
            this.txtFreightPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFreightPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreightPrice_KeyPress);
            this.txtFreightPrice.Leave += new System.EventHandler(this.txtFreightPrice_Leave);
            // 
            // lblFreightPrice
            // 
            this.lblFreightPrice.AutoSize = true;
            this.lblFreightPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFreightPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFreightPrice.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreightPrice.Location = new System.Drawing.Point(3, 0);
            this.lblFreightPrice.Name = "lblFreightPrice";
            this.lblFreightPrice.Size = new System.Drawing.Size(105, 30);
            this.lblFreightPrice.TabIndex = 8;
            this.lblFreightPrice.Text = "Price";
            this.lblFreightPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.txtFreight, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblFreightAmount, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(259, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(131, 60);
            this.tableLayoutPanel8.TabIndex = 12;
            // 
            // txtFreight
            // 
            this.txtFreight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFreight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtFreight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreight.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreight.ForeColor = System.Drawing.Color.Blue;
            this.txtFreight.Location = new System.Drawing.Point(3, 33);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(125, 27);
            this.txtFreight.TabIndex = 5;
            this.txtFreight.Text = "0";
            this.txtFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFreight.Leave += new System.EventHandler(this.txtFreight_Leave);
            // 
            // lblFreightAmount
            // 
            this.lblFreightAmount.AutoSize = true;
            this.lblFreightAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFreightAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFreightAmount.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreightAmount.Location = new System.Drawing.Point(3, 0);
            this.lblFreightAmount.Name = "lblFreightAmount";
            this.lblFreightAmount.Size = new System.Drawing.Size(125, 30);
            this.lblFreightAmount.TabIndex = 6;
            this.lblFreightAmount.Text = "Amount";
            this.lblFreightAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.lblMaterialAmount, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtRawMaterialAmt, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(259, 71);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(131, 60);
            this.tableLayoutPanel9.TabIndex = 13;
            // 
            // lblMaterialAmount
            // 
            this.lblMaterialAmount.AutoSize = true;
            this.lblMaterialAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialAmount.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialAmount.Location = new System.Drawing.Point(3, 0);
            this.lblMaterialAmount.Name = "lblMaterialAmount";
            this.lblMaterialAmount.Size = new System.Drawing.Size(125, 30);
            this.lblMaterialAmount.TabIndex = 0;
            this.lblMaterialAmount.Text = "Amount";
            this.lblMaterialAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRawMaterialAmt
            // 
            this.txtRawMaterialAmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawMaterialAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtRawMaterialAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRawMaterialAmt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawMaterialAmt.ForeColor = System.Drawing.Color.Blue;
            this.txtRawMaterialAmt.Location = new System.Drawing.Point(3, 33);
            this.txtRawMaterialAmt.Name = "txtRawMaterialAmt";
            this.txtRawMaterialAmt.Size = new System.Drawing.Size(125, 27);
            this.txtRawMaterialAmt.TabIndex = 9;
            this.txtRawMaterialAmt.Text = "0";
            this.txtRawMaterialAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRawMaterialAmt.Leave += new System.EventHandler(this.txtRawMaterialAmt_Leave);
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.txtIojpno);
            this.pnlSub.Controls.Add(this.txtMarks4);
            this.pnlSub.Controls.Add(this.txtMarks3);
            this.pnlSub.Controls.Add(this.txtMarks2);
            this.pnlSub.Controls.Add(this.txtMarks1);
            this.pnlSub.Controls.Add(this.lblMarks);
            this.pnlSub.Controls.Add(this.txtPoDate);
            this.pnlSub.Controls.Add(this.lblPo);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSub.Location = new System.Drawing.Point(5, 5);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(1593, 135);
            this.pnlSub.TabIndex = 4;
            // 
            // txtIojpno
            // 
            this.txtIojpno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIojpno.Enabled = false;
            this.txtIojpno.Location = new System.Drawing.Point(488, 43);
            this.txtIojpno.Name = "txtIojpno";
            this.txtIojpno.Size = new System.Drawing.Size(135, 25);
            this.txtIojpno.TabIndex = 5;
            // 
            // txtMarks4
            // 
            this.txtMarks4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarks4.Location = new System.Drawing.Point(640, 99);
            this.txtMarks4.Name = "txtMarks4";
            this.txtMarks4.Size = new System.Drawing.Size(285, 25);
            this.txtMarks4.TabIndex = 4;
            // 
            // txtMarks3
            // 
            this.txtMarks3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarks3.Location = new System.Drawing.Point(640, 71);
            this.txtMarks3.Name = "txtMarks3";
            this.txtMarks3.Size = new System.Drawing.Size(285, 25);
            this.txtMarks3.TabIndex = 3;
            // 
            // txtMarks2
            // 
            this.txtMarks2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarks2.Location = new System.Drawing.Point(640, 43);
            this.txtMarks2.Name = "txtMarks2";
            this.txtMarks2.Size = new System.Drawing.Size(285, 25);
            this.txtMarks2.TabIndex = 3;
            // 
            // txtMarks1
            // 
            this.txtMarks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarks1.Location = new System.Drawing.Point(640, 16);
            this.txtMarks1.Name = "txtMarks1";
            this.txtMarks1.Size = new System.Drawing.Size(285, 25);
            this.txtMarks1.TabIndex = 3;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(484, 14);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(139, 20);
            this.lblMarks.TabIndex = 2;
            this.lblMarks.Text = "Marks & No.of PKGS Add";
            // 
            // txtPoDate
            // 
            this.txtPoDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoDate.Location = new System.Drawing.Point(138, 16);
            this.txtPoDate.Name = "txtPoDate";
            this.txtPoDate.Size = new System.Drawing.Size(322, 25);
            this.txtPoDate.TabIndex = 1;
            // 
            // lblPo
            // 
            this.lblPo.AutoSize = true;
            this.lblPo.Location = new System.Drawing.Point(3, 16);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(129, 20);
            this.lblPo.TabIndex = 0;
            this.lblPo.Text = "Purchase Order & Date";
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.MainView = this.gridView;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemCheckEdit1});
            this.Grid.Size = new System.Drawing.Size(2005, 530);
            this.Grid.TabIndex = 2;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IOJPNO,
            this.REF3,
            this.REF4,
            this.SUDAT,
            this.ITNBR,
            this.ITDSC,
            this.BUYERITEM,
            this.DEPOT_NO,
            this.WHNAME,
            this.CVCOD,
            this.CVNAS,
            this.NAPVND,
            this.IO_DATE,
            this.IOQTY,
            this.IOREQTY,
            this.FIOPRC,
            this.FIOAMT,
            this.CINO,
            this.PORDNO,
            this.GUMDAT,
            this.CUNIT,
            this.DREF4});
            this.gridView.GridControl = this.Grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_SelectionChanged);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // IOJPNO
            // 
            this.IOJPNO.Caption = "IOJPNO";
            this.IOJPNO.FieldName = "IOJPNO";
            this.IOJPNO.MinWidth = 25;
            this.IOJPNO.Name = "IOJPNO";
            this.IOJPNO.OptionsColumn.AllowEdit = false;
            this.IOJPNO.Width = 34;
            // 
            // REF3
            // 
            this.REF3.Caption = "HH Invoice";
            this.REF3.FieldName = "REF3";
            this.REF3.MinWidth = 25;
            this.REF3.Name = "REF3";
            this.REF3.OptionsColumn.AllowEdit = false;
            this.REF3.Visible = true;
            this.REF3.VisibleIndex = 4;
            this.REF3.Width = 177;
            // 
            // REF4
            // 
            this.REF4.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.REF4.AppearanceCell.Options.UseForeColor = true;
            this.REF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.REF4.AppearanceHeader.Options.UseBackColor = true;
            this.REF4.Caption = "Local Invoice";
            this.REF4.FieldName = "REF4";
            this.REF4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.REF4.MinWidth = 25;
            this.REF4.Name = "REF4";
            this.REF4.OptionsColumn.AllowEdit = false;
            this.REF4.Visible = true;
            this.REF4.VisibleIndex = 3;
            this.REF4.Width = 167;
            // 
            // SUDAT
            // 
            this.SUDAT.AppearanceCell.Options.UseTextOptions = true;
            this.SUDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SUDAT.Caption = "SUDAT";
            this.SUDAT.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.SUDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.SUDAT.FieldName = "SUDAT";
            this.SUDAT.MinWidth = 25;
            this.SUDAT.Name = "SUDAT";
            this.SUDAT.OptionsColumn.AllowEdit = false;
            this.SUDAT.Width = 108;
            // 
            // ITNBR
            // 
            this.ITNBR.Caption = "Item";
            this.ITNBR.FieldName = "ITNBR";
            this.ITNBR.MinWidth = 25;
            this.ITNBR.Name = "ITNBR";
            this.ITNBR.OptionsColumn.AllowEdit = false;
            this.ITNBR.Visible = true;
            this.ITNBR.VisibleIndex = 5;
            this.ITNBR.Width = 131;
            // 
            // ITDSC
            // 
            this.ITDSC.Caption = "Description";
            this.ITDSC.FieldName = "ITDSC";
            this.ITDSC.MinWidth = 25;
            this.ITDSC.Name = "ITDSC";
            this.ITDSC.OptionsColumn.AllowEdit = false;
            this.ITDSC.Visible = true;
            this.ITDSC.VisibleIndex = 6;
            this.ITDSC.Width = 222;
            // 
            // BUYERITEM
            // 
            this.BUYERITEM.Caption = "Part No.";
            this.BUYERITEM.FieldName = "BUYERITEM";
            this.BUYERITEM.MinWidth = 25;
            this.BUYERITEM.Name = "BUYERITEM";
            this.BUYERITEM.OptionsColumn.AllowEdit = false;
            this.BUYERITEM.Visible = true;
            this.BUYERITEM.VisibleIndex = 7;
            this.BUYERITEM.Width = 155;
            // 
            // DEPOT_NO
            // 
            this.DEPOT_NO.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DEPOT_NO.AppearanceCell.Options.UseForeColor = true;
            this.DEPOT_NO.AppearanceCell.Options.UseTextOptions = true;
            this.DEPOT_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEPOT_NO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DEPOT_NO.AppearanceHeader.Options.UseBackColor = true;
            this.DEPOT_NO.Caption = "Wh.";
            this.DEPOT_NO.FieldName = "DEPOT_NO";
            this.DEPOT_NO.MinWidth = 25;
            this.DEPOT_NO.Name = "DEPOT_NO";
            this.DEPOT_NO.OptionsColumn.AllowEdit = false;
            this.DEPOT_NO.Width = 118;
            // 
            // WHNAME
            // 
            this.WHNAME.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.WHNAME.AppearanceCell.Options.UseForeColor = true;
            this.WHNAME.AppearanceCell.Options.UseTextOptions = true;
            this.WHNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WHNAME.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.WHNAME.AppearanceHeader.Options.UseBackColor = true;
            this.WHNAME.Caption = "Wh.";
            this.WHNAME.FieldName = "WHNAME";
            this.WHNAME.MinWidth = 25;
            this.WHNAME.Name = "WHNAME";
            this.WHNAME.OptionsColumn.AllowEdit = false;
            this.WHNAME.Visible = true;
            this.WHNAME.VisibleIndex = 8;
            this.WHNAME.Width = 57;
            // 
            // CVCOD
            // 
            this.CVCOD.Caption = "Buyer";
            this.CVCOD.FieldName = "CVCOD";
            this.CVCOD.MinWidth = 25;
            this.CVCOD.Name = "CVCOD";
            this.CVCOD.OptionsColumn.AllowEdit = false;
            this.CVCOD.Width = 188;
            // 
            // CVNAS
            // 
            this.CVNAS.Caption = "Buyer Name";
            this.CVNAS.FieldName = "CVNAS";
            this.CVNAS.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.CVNAS.MinWidth = 25;
            this.CVNAS.Name = "CVNAS";
            this.CVNAS.OptionsColumn.AllowEdit = false;
            this.CVNAS.Visible = true;
            this.CVNAS.VisibleIndex = 2;
            this.CVNAS.Width = 235;
            // 
            // NAPVND
            // 
            this.NAPVND.Caption = "Delivery Buyer";
            this.NAPVND.FieldName = "NAPVND";
            this.NAPVND.MinWidth = 25;
            this.NAPVND.Name = "NAPVND";
            this.NAPVND.OptionsColumn.AllowEdit = false;
            this.NAPVND.Width = 198;
            // 
            // IO_DATE
            // 
            this.IO_DATE.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IO_DATE.AppearanceCell.ForeColor = System.Drawing.Color.MidnightBlue;
            this.IO_DATE.AppearanceCell.Options.UseBackColor = true;
            this.IO_DATE.AppearanceCell.Options.UseForeColor = true;
            this.IO_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.IO_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IO_DATE.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IO_DATE.AppearanceHeader.Options.UseBackColor = true;
            this.IO_DATE.Caption = "Delivery Date";
            this.IO_DATE.ColumnEdit = this.repositoryItemDateEdit1;
            this.IO_DATE.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.IO_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.IO_DATE.FieldName = "IO_DATE";
            this.IO_DATE.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.IO_DATE.MinWidth = 25;
            this.IO_DATE.Name = "IO_DATE";
            this.IO_DATE.OptionsColumn.AllowEdit = false;
            this.IO_DATE.Visible = true;
            this.IO_DATE.VisibleIndex = 1;
            this.IO_DATE.Width = 110;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // IOQTY
            // 
            this.IOQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IOQTY.AppearanceCell.Options.UseForeColor = true;
            this.IOQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IOQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IOQTY.AppearanceHeader.BackColor = System.Drawing.Color.IndianRed;
            this.IOQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IOQTY.Caption = "Delivery Qty";
            this.IOQTY.DisplayFormat.FormatString = "###,###,###,##0";
            this.IOQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IOQTY.FieldName = "IOQTY";
            this.IOQTY.MinWidth = 25;
            this.IOQTY.Name = "IOQTY";
            this.IOQTY.OptionsColumn.AllowEdit = false;
            this.IOQTY.Visible = true;
            this.IOQTY.VisibleIndex = 9;
            this.IOQTY.Width = 104;
            // 
            // IOREQTY
            // 
            this.IOREQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IOREQTY.AppearanceCell.Options.UseForeColor = true;
            this.IOREQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IOREQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IOREQTY.AppearanceHeader.BackColor = System.Drawing.Color.IndianRed;
            this.IOREQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IOREQTY.Caption = "Delivery B Qty";
            this.IOREQTY.DisplayFormat.FormatString = "###,###,###,##0";
            this.IOREQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IOREQTY.FieldName = "IOREQTY";
            this.IOREQTY.MinWidth = 25;
            this.IOREQTY.Name = "IOREQTY";
            this.IOREQTY.OptionsColumn.AllowEdit = false;
            this.IOREQTY.Visible = true;
            this.IOREQTY.VisibleIndex = 10;
            this.IOREQTY.Width = 112;
            // 
            // FIOPRC
            // 
            this.FIOPRC.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.FIOPRC.AppearanceCell.Options.UseForeColor = true;
            this.FIOPRC.AppearanceCell.Options.UseTextOptions = true;
            this.FIOPRC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FIOPRC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FIOPRC.AppearanceHeader.Options.UseBackColor = true;
            this.FIOPRC.Caption = "Price";
            this.FIOPRC.DisplayFormat.FormatString = "###,###,###,##0.###0";
            this.FIOPRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FIOPRC.FieldName = "FIOPRC";
            this.FIOPRC.MinWidth = 25;
            this.FIOPRC.Name = "FIOPRC";
            this.FIOPRC.OptionsColumn.AllowEdit = false;
            this.FIOPRC.Visible = true;
            this.FIOPRC.VisibleIndex = 11;
            this.FIOPRC.Width = 110;
            // 
            // FIOAMT
            // 
            this.FIOAMT.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.FIOAMT.AppearanceCell.Options.UseForeColor = true;
            this.FIOAMT.AppearanceCell.Options.UseTextOptions = true;
            this.FIOAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FIOAMT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FIOAMT.AppearanceHeader.Options.UseBackColor = true;
            this.FIOAMT.Caption = "Amount";
            this.FIOAMT.DisplayFormat.FormatString = "###,###,###,##0.###0";
            this.FIOAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FIOAMT.FieldName = "FIOAMT";
            this.FIOAMT.MinWidth = 25;
            this.FIOAMT.Name = "FIOAMT";
            this.FIOAMT.OptionsColumn.AllowEdit = false;
            this.FIOAMT.Visible = true;
            this.FIOAMT.VisibleIndex = 12;
            this.FIOAMT.Width = 128;
            // 
            // CINO
            // 
            this.CINO.Caption = "EXPNO";
            this.CINO.FieldName = "CINO";
            this.CINO.MinWidth = 25;
            this.CINO.Name = "CINO";
            this.CINO.OptionsColumn.AllowEdit = false;
            this.CINO.Width = 40;
            // 
            // PORDNO
            // 
            this.PORDNO.Caption = "Pordno";
            this.PORDNO.FieldName = "PORDNO";
            this.PORDNO.MinWidth = 25;
            this.PORDNO.Name = "PORDNO";
            this.PORDNO.OptionsColumn.AllowEdit = false;
            this.PORDNO.Width = 131;
            // 
            // GUMDAT
            // 
            this.GUMDAT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GUMDAT.AppearanceCell.Options.UseForeColor = true;
            this.GUMDAT.AppearanceCell.Options.UseTextOptions = true;
            this.GUMDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GUMDAT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GUMDAT.AppearanceHeader.Options.UseBackColor = true;
            this.GUMDAT.Caption = "Collect Date";
            this.GUMDAT.ColumnEdit = this.repositoryItemDateEdit2;
            this.GUMDAT.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.GUMDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GUMDAT.FieldName = "GUMDAT";
            this.GUMDAT.MinWidth = 25;
            this.GUMDAT.Name = "GUMDAT";
            this.GUMDAT.OptionsColumn.AllowEdit = false;
            this.GUMDAT.Visible = true;
            this.GUMDAT.VisibleIndex = 13;
            this.GUMDAT.Width = 97;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // CUNIT
            // 
            this.CUNIT.AppearanceCell.Options.UseTextOptions = true;
            this.CUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CUNIT.Caption = "Curr.";
            this.CUNIT.FieldName = "CUNIT";
            this.CUNIT.MinWidth = 25;
            this.CUNIT.Name = "CUNIT";
            this.CUNIT.OptionsColumn.AllowEdit = false;
            this.CUNIT.Visible = true;
            this.CUNIT.VisibleIndex = 14;
            this.CUNIT.Width = 48;
            // 
            // DREF4
            // 
            this.DREF4.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DREF4.AppearanceCell.Options.UseForeColor = true;
            this.DREF4.AppearanceCell.Options.UseTextOptions = true;
            this.DREF4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DREF4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DREF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DREF4.AppearanceHeader.Options.UseBackColor = true;
            this.DREF4.AppearanceHeader.Options.UseTextOptions = true;
            this.DREF4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DREF4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DREF4.Caption = "Cost Total";
            this.DREF4.DisplayFormat.FormatString = "###,###,###,##0.#0";
            this.DREF4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DREF4.FieldName = "DREF4";
            this.DREF4.MinWidth = 25;
            this.DREF4.Name = "DREF4";
            this.DREF4.OptionsColumn.AllowEdit = false;
            this.DREF4.Visible = true;
            this.DREF4.VisibleIndex = 15;
            this.DREF4.Width = 94;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "";
            this.repositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // GridList
            // 
            this.GridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridList.Location = new System.Drawing.Point(3, 539);
            this.GridList.MainView = this.gridDetail;
            this.GridList.Name = "GridList";
            this.GridList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEdit3});
            this.GridList.Size = new System.Drawing.Size(2005, 223);
            this.GridList.TabIndex = 3;
            this.GridList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDetail});
            // 
            // gridDetail
            // 
            this.gridDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetail.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridDetail.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridDetail.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetail.AppearancePrint.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridDetail.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridDetail.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridDetail.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridDetail.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DIOJPNO,
            this.DIO_DATE,
            this.DREF3,
            this.DIVREF4,
            this.DITNBR,
            this.DITDSC,
            this.DBUYERITEM,
            this.DDEPOT_NO,
            this.DCVCOD,
            this.DCVNAS,
            this.DNAPVND,
            this.DIOQTY,
            this.DIOREQTY,
            this.DFIOPRC,
            this.DFIOAMT,
            this.DCINO,
            this.DPORDNO,
            this.DGUMDAT,
            this.DCUNIT,
            this.DDREF4});
            this.gridDetail.GridControl = this.GridList;
            this.gridDetail.Name = "gridDetail";
            this.gridDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridDetail.OptionsCustomization.AllowSort = false;
            this.gridDetail.OptionsView.ShowGroupPanel = false;
            this.gridDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridDetail_CellValueChanged);
            // 
            // DIOJPNO
            // 
            this.DIOJPNO.Caption = "SLIP Number";
            this.DIOJPNO.FieldName = "IOJPNO";
            this.DIOJPNO.MinWidth = 25;
            this.DIOJPNO.Name = "DIOJPNO";
            this.DIOJPNO.Width = 94;
            // 
            // DIO_DATE
            // 
            this.DIO_DATE.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DIO_DATE.AppearanceCell.Options.UseBackColor = true;
            this.DIO_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.DIO_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIO_DATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DIO_DATE.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DIO_DATE.AppearanceHeader.Options.UseBackColor = true;
            this.DIO_DATE.Caption = "Delivery Date";
            this.DIO_DATE.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.DIO_DATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DIO_DATE.FieldName = "IO_DATE";
            this.DIO_DATE.MinWidth = 25;
            this.DIO_DATE.Name = "DIO_DATE";
            this.DIO_DATE.OptionsColumn.AllowEdit = false;
            this.DIO_DATE.Visible = true;
            this.DIO_DATE.VisibleIndex = 0;
            this.DIO_DATE.Width = 110;
            // 
            // DREF3
            // 
            this.DREF3.Caption = "(HH)INVOICE";
            this.DREF3.FieldName = "REF3";
            this.DREF3.MinWidth = 25;
            this.DREF3.Name = "DREF3";
            this.DREF3.OptionsColumn.AllowEdit = false;
            this.DREF3.Visible = true;
            this.DREF3.VisibleIndex = 2;
            this.DREF3.Width = 174;
            // 
            // DIVREF4
            // 
            this.DIVREF4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DIVREF4.AppearanceCell.Options.UseBackColor = true;
            this.DIVREF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DIVREF4.AppearanceHeader.Options.UseBackColor = true;
            this.DIVREF4.Caption = "Local Invoice";
            this.DIVREF4.FieldName = "REF4";
            this.DIVREF4.MinWidth = 25;
            this.DIVREF4.Name = "DIVREF4";
            this.DIVREF4.OptionsColumn.AllowEdit = false;
            this.DIVREF4.Visible = true;
            this.DIVREF4.VisibleIndex = 1;
            this.DIVREF4.Width = 169;
            // 
            // DITNBR
            // 
            this.DITNBR.Caption = "ITEM";
            this.DITNBR.FieldName = "ITNBR";
            this.DITNBR.MinWidth = 25;
            this.DITNBR.Name = "DITNBR";
            this.DITNBR.OptionsColumn.AllowEdit = false;
            this.DITNBR.Visible = true;
            this.DITNBR.VisibleIndex = 3;
            this.DITNBR.Width = 165;
            // 
            // DITDSC
            // 
            this.DITDSC.Caption = "Description";
            this.DITDSC.FieldName = "ITDSC";
            this.DITDSC.MinWidth = 25;
            this.DITDSC.Name = "DITDSC";
            this.DITDSC.OptionsColumn.AllowEdit = false;
            this.DITDSC.Visible = true;
            this.DITDSC.VisibleIndex = 4;
            this.DITDSC.Width = 205;
            // 
            // DBUYERITEM
            // 
            this.DBUYERITEM.Caption = "PART NO.";
            this.DBUYERITEM.FieldName = "BUYERITEM";
            this.DBUYERITEM.MinWidth = 25;
            this.DBUYERITEM.Name = "DBUYERITEM";
            this.DBUYERITEM.OptionsColumn.AllowEdit = false;
            this.DBUYERITEM.Visible = true;
            this.DBUYERITEM.VisibleIndex = 5;
            this.DBUYERITEM.Width = 155;
            // 
            // DDEPOT_NO
            // 
            this.DDEPOT_NO.Caption = "WH.";
            this.DDEPOT_NO.FieldName = "DEPOT_NO";
            this.DDEPOT_NO.MinWidth = 25;
            this.DDEPOT_NO.Name = "DDEPOT_NO";
            this.DDEPOT_NO.Width = 94;
            // 
            // DCVCOD
            // 
            this.DCVCOD.Caption = "BUYER";
            this.DCVCOD.FieldName = "CVCOD";
            this.DCVCOD.MinWidth = 25;
            this.DCVCOD.Name = "DCVCOD";
            this.DCVCOD.Width = 94;
            // 
            // DCVNAS
            // 
            this.DCVNAS.Caption = "BUYER NAME";
            this.DCVNAS.FieldName = "CVNAS";
            this.DCVNAS.MinWidth = 25;
            this.DCVNAS.Name = "DCVNAS";
            this.DCVNAS.OptionsColumn.AllowEdit = false;
            this.DCVNAS.Visible = true;
            this.DCVNAS.VisibleIndex = 6;
            this.DCVNAS.Width = 276;
            // 
            // DNAPVND
            // 
            this.DNAPVND.Caption = "SALES BUYER";
            this.DNAPVND.FieldName = "NAPVND";
            this.DNAPVND.MinWidth = 25;
            this.DNAPVND.Name = "DNAPVND";
            this.DNAPVND.Width = 94;
            // 
            // DIOQTY
            // 
            this.DIOQTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DIOQTY.AppearanceCell.Options.UseBackColor = true;
            this.DIOQTY.AppearanceCell.Options.UseTextOptions = true;
            this.DIOQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DIOQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DIOQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DIOQTY.AppearanceHeader.Options.UseBackColor = true;
            this.DIOQTY.Caption = "Delivery Qty.";
            this.DIOQTY.DisplayFormat.FormatString = "{0:#,##0}";
            this.DIOQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIOQTY.FieldName = "IOQTY";
            this.DIOQTY.MinWidth = 25;
            this.DIOQTY.Name = "DIOQTY";
            this.DIOQTY.Visible = true;
            this.DIOQTY.VisibleIndex = 7;
            this.DIOQTY.Width = 118;
            // 
            // DIOREQTY
            // 
            this.DIOREQTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DIOREQTY.AppearanceCell.Options.UseBackColor = true;
            this.DIOREQTY.AppearanceCell.Options.UseTextOptions = true;
            this.DIOREQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DIOREQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DIOREQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DIOREQTY.AppearanceHeader.Options.UseBackColor = true;
            this.DIOREQTY.Caption = "Deli.Box";
            this.DIOREQTY.DisplayFormat.FormatString = "{0:#,##0}";
            this.DIOREQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIOREQTY.FieldName = "IOREQTY";
            this.DIOREQTY.MinWidth = 25;
            this.DIOREQTY.Name = "DIOREQTY";
            this.DIOREQTY.Visible = true;
            this.DIOREQTY.VisibleIndex = 8;
            this.DIOREQTY.Width = 88;
            // 
            // DFIOPRC
            // 
            this.DFIOPRC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DFIOPRC.AppearanceCell.Options.UseBackColor = true;
            this.DFIOPRC.AppearanceCell.Options.UseTextOptions = true;
            this.DFIOPRC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DFIOPRC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DFIOPRC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DFIOPRC.AppearanceHeader.Options.UseBackColor = true;
            this.DFIOPRC.Caption = "Price";
            this.DFIOPRC.DisplayFormat.FormatString = "{0:#,##0.###}";
            this.DFIOPRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DFIOPRC.FieldName = "FIOPRC";
            this.DFIOPRC.MinWidth = 25;
            this.DFIOPRC.Name = "DFIOPRC";
            this.DFIOPRC.Visible = true;
            this.DFIOPRC.VisibleIndex = 9;
            this.DFIOPRC.Width = 91;
            // 
            // DFIOAMT
            // 
            this.DFIOAMT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DFIOAMT.AppearanceCell.Options.UseBackColor = true;
            this.DFIOAMT.AppearanceCell.Options.UseTextOptions = true;
            this.DFIOAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DFIOAMT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DFIOAMT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DFIOAMT.AppearanceHeader.Options.UseBackColor = true;
            this.DFIOAMT.Caption = "Amount";
            this.DFIOAMT.DisplayFormat.FormatString = "{0:#,##0.##}";
            this.DFIOAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DFIOAMT.FieldName = "FIOAMT";
            this.DFIOAMT.MinWidth = 25;
            this.DFIOAMT.Name = "DFIOAMT";
            this.DFIOAMT.Visible = true;
            this.DFIOAMT.VisibleIndex = 10;
            this.DFIOAMT.Width = 100;
            // 
            // DCINO
            // 
            this.DCINO.Caption = "CINO";
            this.DCINO.FieldName = "CINO";
            this.DCINO.MinWidth = 25;
            this.DCINO.Name = "DCINO";
            this.DCINO.Width = 94;
            // 
            // DPORDNO
            // 
            this.DPORDNO.Caption = "PORDNO";
            this.DPORDNO.FieldName = "PORDNO";
            this.DPORDNO.MinWidth = 25;
            this.DPORDNO.Name = "DPORDNO";
            this.DPORDNO.Width = 94;
            // 
            // DGUMDAT
            // 
            this.DGUMDAT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGUMDAT.AppearanceCell.Options.UseBackColor = true;
            this.DGUMDAT.AppearanceCell.Options.UseTextOptions = true;
            this.DGUMDAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DGUMDAT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DGUMDAT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DGUMDAT.AppearanceHeader.Options.UseBackColor = true;
            this.DGUMDAT.Caption = "CollectDay";
            this.DGUMDAT.ColumnEdit = this.repositoryItemDateEdit3;
            this.DGUMDAT.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.DGUMDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DGUMDAT.FieldName = "GUMDAT";
            this.DGUMDAT.MinWidth = 25;
            this.DGUMDAT.Name = "DGUMDAT";
            this.DGUMDAT.Visible = true;
            this.DGUMDAT.VisibleIndex = 11;
            this.DGUMDAT.Width = 141;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.repositoryItemDateEdit3.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.repositoryItemDateEdit3.AppearanceFocused.Options.UseBackColor = true;
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // DCUNIT
            // 
            this.DCUNIT.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCUNIT.AppearanceCell.Options.UseFont = true;
            this.DCUNIT.AppearanceCell.Options.UseTextOptions = true;
            this.DCUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DCUNIT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DCUNIT.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCUNIT.AppearanceHeader.Options.UseFont = true;
            this.DCUNIT.Caption = "Curr.";
            this.DCUNIT.FieldName = "CUNIT";
            this.DCUNIT.MinWidth = 25;
            this.DCUNIT.Name = "DCUNIT";
            this.DCUNIT.OptionsColumn.AllowEdit = false;
            this.DCUNIT.Visible = true;
            this.DCUNIT.VisibleIndex = 12;
            this.DCUNIT.Width = 54;
            // 
            // DDREF4
            // 
            this.DDREF4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DDREF4.AppearanceCell.Options.UseBackColor = true;
            this.DDREF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DDREF4.AppearanceHeader.Options.UseBackColor = true;
            this.DDREF4.Caption = "Cost Total.";
            this.DDREF4.DisplayFormat.FormatString = "{0:#,##0.##}";
            this.DDREF4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DDREF4.FieldName = "DREF4";
            this.DDREF4.MinWidth = 25;
            this.DDREF4.Name = "DDREF4";
            this.DDREF4.OptionsColumn.AllowEdit = false;
            this.DDREF4.Visible = true;
            this.DDREF4.VisibleIndex = 13;
            this.DDREF4.Width = 139;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Company";
            // 
            // cbxCompany
            // 
            this.cbxCompany.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(7, 41);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(207, 25);
            this.cbxCompany.TabIndex = 24;
            this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
            // 
            // FrmStockModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmStockModify";
            this.Size = new System.Drawing.Size(2017, 1032);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxWh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalInvoice;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn IOJPNO;
        private DevExpress.XtraGrid.Columns.GridColumn REF3;
        private DevExpress.XtraGrid.Columns.GridColumn REF4;
        private DevExpress.XtraGrid.Columns.GridColumn SUDAT;
        private DevExpress.XtraGrid.Columns.GridColumn ITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn ITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn BUYERITEM;
        private DevExpress.XtraGrid.Columns.GridColumn DEPOT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn WHNAME;
        private DevExpress.XtraGrid.Columns.GridColumn CVCOD;
        private DevExpress.XtraGrid.Columns.GridColumn CVNAS;
        private DevExpress.XtraGrid.Columns.GridColumn NAPVND;
        private DevExpress.XtraGrid.Columns.GridColumn IO_DATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn IOQTY;
        private DevExpress.XtraGrid.Columns.GridColumn IOREQTY;
        private DevExpress.XtraGrid.Columns.GridColumn FIOPRC;
        private DevExpress.XtraGrid.Columns.GridColumn FIOAMT;
        private DevExpress.XtraGrid.Columns.GridColumn CINO;
        private DevExpress.XtraGrid.Columns.GridColumn PORDNO;
        private DevExpress.XtraGrid.Columns.GridColumn GUMDAT;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn CUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn DREF4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl GridList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblRawMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtRawMaterialPrice;
        private System.Windows.Forms.Label lblMaterialPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtFreightPrice;
        private System.Windows.Forms.Label lblFreightPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lblFreightAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lblMaterialAmount;
        private System.Windows.Forms.TextBox txtRawMaterialAmt;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.TextBox txtMarks4;
        private System.Windows.Forms.TextBox txtMarks3;
        private System.Windows.Forms.TextBox txtMarks2;
        private System.Windows.Forms.TextBox txtMarks1;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtPoDate;
        private System.Windows.Forms.Label lblPo;
        private DevExpress.XtraGrid.Columns.GridColumn DIOJPNO;
        private DevExpress.XtraGrid.Columns.GridColumn DIO_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn DREF3;
        private DevExpress.XtraGrid.Columns.GridColumn DIVREF4;
        private DevExpress.XtraGrid.Columns.GridColumn DITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn DITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn DBUYERITEM;
        private DevExpress.XtraGrid.Columns.GridColumn DDEPOT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn DCVCOD;
        private DevExpress.XtraGrid.Columns.GridColumn DCVNAS;
        private DevExpress.XtraGrid.Columns.GridColumn DNAPVND;
        private DevExpress.XtraGrid.Columns.GridColumn DIOQTY;
        private DevExpress.XtraGrid.Columns.GridColumn DIOREQTY;
        private DevExpress.XtraGrid.Columns.GridColumn DFIOPRC;
        private DevExpress.XtraGrid.Columns.GridColumn DFIOAMT;
        private DevExpress.XtraGrid.Columns.GridColumn DCINO;
        private DevExpress.XtraGrid.Columns.GridColumn DPORDNO;
        private DevExpress.XtraGrid.Columns.GridColumn DGUMDAT;
        private DevExpress.XtraGrid.Columns.GridColumn DCUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn DDREF4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private System.Windows.Forms.TextBox txtIojpno;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Label label6;
    }
}
