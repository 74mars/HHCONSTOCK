namespace conStock.Page
{
    partial class FrmDeliveryMonthList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryMonthList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridD = new DevExpress.XtraGrid.GridControl();
            this.gridViewD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DIO_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DREF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DREF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DBUYERITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DDEPOT_OUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DWHNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIOQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIOREQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DFIOPRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DFIOAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DDREF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTOTAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.txtLocalInvoice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxWh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.GridM = new DevExpress.XtraGrid.GridControl();
            this.gridViewM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BUYERITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEPOT_OUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WHNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JAN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FEB_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.APR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAY_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JUN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JUL_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AUG_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SEPT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OCT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOV_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEC_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewD)).BeginInit();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewM)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GridD, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlQuery, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridM, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.82022F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.17978F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1796, 964);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GridD
            // 
            this.GridD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridD.Location = new System.Drawing.Point(3, 487);
            this.GridD.MainView = this.gridViewD;
            this.GridD.Name = "GridD";
            this.GridD.Size = new System.Drawing.Size(1790, 474);
            this.GridD.TabIndex = 2;
            this.GridD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewD});
            // 
            // gridViewD
            // 
            this.gridViewD.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewD.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewD.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewD.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewD.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DIO_DATE,
            this.DCVCOD,
            this.DCVNAS,
            this.DREF3,
            this.DREF4,
            this.DITNBR,
            this.DITDSC,
            this.DBUYERITEM,
            this.DDEPOT_OUT,
            this.DWHNAME,
            this.DIOQTY,
            this.DIOREQTY,
            this.DCUNIT,
            this.DFIOPRC,
            this.DFIOAMT,
            this.DDREF4,
            this.DTOTAMT});
            this.gridViewD.GridControl = this.GridD;
            this.gridViewD.Name = "gridViewD";
            this.gridViewD.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewD.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewD.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewD.OptionsBehavior.Editable = false;
            this.gridViewD.OptionsBehavior.ReadOnly = true;
            this.gridViewD.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewD.OptionsSelection.MultiSelect = true;
            this.gridViewD.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridViewD.OptionsView.ShowFooter = true;
            this.gridViewD.OptionsView.ShowGroupedColumns = true;
            this.gridViewD.OptionsView.ShowGroupPanel = false;
            // 
            // DIO_DATE
            // 
            this.DIO_DATE.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.DIO_DATE.AppearanceCell.Options.UseForeColor = true;
            this.DIO_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.DIO_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIO_DATE.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.DIO_DATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DIO_DATE.AppearanceHeader.Options.UseBackColor = true;
            this.DIO_DATE.AppearanceHeader.Options.UseFont = true;
            this.DIO_DATE.Caption = "Delivery Day";
            this.DIO_DATE.FieldName = "IO_DATE";
            this.DIO_DATE.MinWidth = 25;
            this.DIO_DATE.Name = "DIO_DATE";
            this.DIO_DATE.Visible = true;
            this.DIO_DATE.VisibleIndex = 0;
            this.DIO_DATE.Width = 109;
            // 
            // DCVCOD
            // 
            this.DCVCOD.Caption = "buyer";
            this.DCVCOD.FieldName = "CVCOD";
            this.DCVCOD.MinWidth = 25;
            this.DCVCOD.Name = "DCVCOD";
            this.DCVCOD.Width = 94;
            // 
            // DCVNAS
            // 
            this.DCVNAS.Caption = "Buyer";
            this.DCVNAS.FieldName = "CVNAS";
            this.DCVNAS.MinWidth = 25;
            this.DCVNAS.Name = "DCVNAS";
            this.DCVNAS.Visible = true;
            this.DCVNAS.VisibleIndex = 1;
            this.DCVNAS.Width = 199;
            // 
            // DREF3
            // 
            this.DREF3.Caption = "Invoice";
            this.DREF3.FieldName = "REF3";
            this.DREF3.MinWidth = 25;
            this.DREF3.Name = "DREF3";
            this.DREF3.Visible = true;
            this.DREF3.VisibleIndex = 2;
            this.DREF3.Width = 142;
            // 
            // DREF4
            // 
            this.DREF4.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.DREF4.AppearanceCell.Options.UseForeColor = true;
            this.DREF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DREF4.AppearanceHeader.Options.UseBackColor = true;
            this.DREF4.Caption = "Local Invoice";
            this.DREF4.FieldName = "REF4";
            this.DREF4.MinWidth = 25;
            this.DREF4.Name = "DREF4";
            this.DREF4.Visible = true;
            this.DREF4.VisibleIndex = 3;
            this.DREF4.Width = 153;
            // 
            // DITNBR
            // 
            this.DITNBR.Caption = "ITEM";
            this.DITNBR.FieldName = "ITNBR";
            this.DITNBR.MinWidth = 25;
            this.DITNBR.Name = "DITNBR";
            this.DITNBR.Visible = true;
            this.DITNBR.VisibleIndex = 4;
            this.DITNBR.Width = 145;
            // 
            // DITDSC
            // 
            this.DITDSC.Caption = "Description";
            this.DITDSC.FieldName = "ITDSC";
            this.DITDSC.MinWidth = 25;
            this.DITDSC.Name = "DITDSC";
            this.DITDSC.Visible = true;
            this.DITDSC.VisibleIndex = 5;
            this.DITDSC.Width = 153;
            // 
            // DBUYERITEM
            // 
            this.DBUYERITEM.Caption = "Part No.";
            this.DBUYERITEM.FieldName = "BUYERITEM";
            this.DBUYERITEM.MinWidth = 25;
            this.DBUYERITEM.Name = "DBUYERITEM";
            this.DBUYERITEM.Visible = true;
            this.DBUYERITEM.VisibleIndex = 6;
            this.DBUYERITEM.Width = 176;
            // 
            // DDEPOT_OUT
            // 
            this.DDEPOT_OUT.Caption = "Warehouse";
            this.DDEPOT_OUT.FieldName = "DEPOT_OUT";
            this.DDEPOT_OUT.MinWidth = 25;
            this.DDEPOT_OUT.Name = "DDEPOT_OUT";
            this.DDEPOT_OUT.Width = 94;
            // 
            // DWHNAME
            // 
            this.DWHNAME.AppearanceCell.Options.UseTextOptions = true;
            this.DWHNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DWHNAME.Caption = "WH.";
            this.DWHNAME.FieldName = "WHNAME";
            this.DWHNAME.MinWidth = 25;
            this.DWHNAME.Name = "DWHNAME";
            this.DWHNAME.Visible = true;
            this.DWHNAME.VisibleIndex = 7;
            this.DWHNAME.Width = 56;
            // 
            // DIOQTY
            // 
            this.DIOQTY.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.DIOQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DIOQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DIOQTY.AppearanceCell.Options.UseBackColor = true;
            this.DIOQTY.AppearanceCell.Options.UseFont = true;
            this.DIOQTY.AppearanceCell.Options.UseForeColor = true;
            this.DIOQTY.AppearanceCell.Options.UseTextOptions = true;
            this.DIOQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DIOQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DIOQTY.AppearanceHeader.Options.UseBackColor = true;
            this.DIOQTY.Caption = "Delivery Qty";
            this.DIOQTY.DisplayFormat.FormatString = "###,###,##0";
            this.DIOQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIOQTY.FieldName = "IOQTY";
            this.DIOQTY.MinWidth = 25;
            this.DIOQTY.Name = "DIOQTY";
            this.DIOQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IOQTY", "{0:###,###,##0}")});
            this.DIOQTY.Visible = true;
            this.DIOQTY.VisibleIndex = 8;
            this.DIOQTY.Width = 103;
            // 
            // DIOREQTY
            // 
            this.DIOREQTY.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.DIOREQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DIOREQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DIOREQTY.AppearanceCell.Options.UseBackColor = true;
            this.DIOREQTY.AppearanceCell.Options.UseFont = true;
            this.DIOREQTY.AppearanceCell.Options.UseForeColor = true;
            this.DIOREQTY.AppearanceCell.Options.UseTextOptions = true;
            this.DIOREQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DIOREQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DIOREQTY.AppearanceHeader.Options.UseBackColor = true;
            this.DIOREQTY.Caption = "Del.Box.Qty";
            this.DIOREQTY.DisplayFormat.FormatString = "###,###,##0";
            this.DIOREQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIOREQTY.FieldName = "IOREQTY";
            this.DIOREQTY.MinWidth = 25;
            this.DIOREQTY.Name = "DIOREQTY";
            this.DIOREQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IOREQTY", "{0:###,###,##0}")});
            this.DIOREQTY.Visible = true;
            this.DIOREQTY.VisibleIndex = 9;
            this.DIOREQTY.Width = 94;
            // 
            // DCUNIT
            // 
            this.DCUNIT.AppearanceCell.Options.UseTextOptions = true;
            this.DCUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DCUNIT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DCUNIT.AppearanceHeader.Options.UseBackColor = true;
            this.DCUNIT.Caption = "Curr.";
            this.DCUNIT.FieldName = "CUNIT";
            this.DCUNIT.MinWidth = 25;
            this.DCUNIT.Name = "DCUNIT";
            this.DCUNIT.Visible = true;
            this.DCUNIT.VisibleIndex = 10;
            this.DCUNIT.Width = 51;
            // 
            // DFIOPRC
            // 
            this.DFIOPRC.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.DFIOPRC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DFIOPRC.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DFIOPRC.AppearanceCell.Options.UseBackColor = true;
            this.DFIOPRC.AppearanceCell.Options.UseFont = true;
            this.DFIOPRC.AppearanceCell.Options.UseForeColor = true;
            this.DFIOPRC.AppearanceCell.Options.UseTextOptions = true;
            this.DFIOPRC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DFIOPRC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DFIOPRC.AppearanceHeader.Options.UseBackColor = true;
            this.DFIOPRC.Caption = "Price";
            this.DFIOPRC.DisplayFormat.FormatString = "###,###,##0.####";
            this.DFIOPRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DFIOPRC.FieldName = "FIOPRC";
            this.DFIOPRC.MinWidth = 25;
            this.DFIOPRC.Name = "DFIOPRC";
            this.DFIOPRC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "FIOPRC", "AVG={0:###,###,##0.####}")});
            this.DFIOPRC.Visible = true;
            this.DFIOPRC.VisibleIndex = 11;
            this.DFIOPRC.Width = 87;
            // 
            // DFIOAMT
            // 
            this.DFIOAMT.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.DFIOAMT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DFIOAMT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DFIOAMT.AppearanceCell.Options.UseBackColor = true;
            this.DFIOAMT.AppearanceCell.Options.UseFont = true;
            this.DFIOAMT.AppearanceCell.Options.UseForeColor = true;
            this.DFIOAMT.AppearanceCell.Options.UseTextOptions = true;
            this.DFIOAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DFIOAMT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DFIOAMT.AppearanceHeader.Options.UseBackColor = true;
            this.DFIOAMT.Caption = "MATERIAL";
            this.DFIOAMT.DisplayFormat.FormatString = "###,###,##0.####";
            this.DFIOAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DFIOAMT.FieldName = "FIOAMT";
            this.DFIOAMT.MinWidth = 25;
            this.DFIOAMT.Name = "DFIOAMT";
            this.DFIOAMT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FIOAMT", "{0:###,###,##0.####}")});
            this.DFIOAMT.Visible = true;
            this.DFIOAMT.VisibleIndex = 12;
            this.DFIOAMT.Width = 94;
            // 
            // DDREF4
            // 
            this.DDREF4.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DDREF4.AppearanceCell.Options.UseForeColor = true;
            this.DDREF4.AppearanceCell.Options.UseTextOptions = true;
            this.DDREF4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DDREF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DDREF4.AppearanceHeader.Options.UseBackColor = true;
            this.DDREF4.Caption = "FREIGHT";
            this.DDREF4.DisplayFormat.FormatString = "###,###,##0.##";
            this.DDREF4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DDREF4.FieldName = "DREF4";
            this.DDREF4.MinWidth = 25;
            this.DDREF4.Name = "DDREF4";
            this.DDREF4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DREF4", "{0:###,###,##0.##}")});
            this.DDREF4.Visible = true;
            this.DDREF4.VisibleIndex = 13;
            this.DDREF4.Width = 85;
            // 
            // DTOTAMT
            // 
            this.DTOTAMT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DTOTAMT.AppearanceCell.Options.UseForeColor = true;
            this.DTOTAMT.AppearanceCell.Options.UseTextOptions = true;
            this.DTOTAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DTOTAMT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DTOTAMT.AppearanceHeader.Options.UseBackColor = true;
            this.DTOTAMT.AppearanceHeader.Options.UseTextOptions = true;
            this.DTOTAMT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DTOTAMT.Caption = "TOT AMOUNT";
            this.DTOTAMT.DisplayFormat.FormatString = "###,###,##0.####";
            this.DTOTAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DTOTAMT.FieldName = "TOTAMT";
            this.DTOTAMT.MinWidth = 25;
            this.DTOTAMT.Name = "DTOTAMT";
            this.DTOTAMT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAMT", "{0:###,###,##0.####}")});
            this.DTOTAMT.Visible = true;
            this.DTOTAMT.VisibleIndex = 14;
            this.DTOTAMT.Width = 123;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.Color.LightGray;
            this.pnlQuery.Controls.Add(this.txtLocalInvoice);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Controls.Add(this.cbxWh);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.dateTimePicker2);
            this.pnlQuery.Controls.Add(this.dateTimePicker1);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Controls.Add(this.cbxCust);
            this.pnlQuery.Controls.Add(this.txtItem);
            this.pnlQuery.Controls.Add(this.label5);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuery.Location = new System.Drawing.Point(3, 3);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1790, 104);
            this.pnlQuery.TabIndex = 0;
            // 
            // txtLocalInvoice
            // 
            this.txtLocalInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalInvoice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalInvoice.Location = new System.Drawing.Point(142, 63);
            this.txtLocalInvoice.Name = "txtLocalInvoice";
            this.txtLocalInvoice.Size = new System.Drawing.Size(234, 27);
            this.txtLocalInvoice.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buyer";
            // 
            // cbxWh
            // 
            this.cbxWh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWh.FormattingEnabled = true;
            this.cbxWh.Location = new System.Drawing.Point(142, 16);
            this.cbxWh.Name = "cbxWh";
            this.cbxWh.Size = new System.Drawing.Size(234, 27);
            this.cbxWh.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Warehouse";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(511, 58);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 15);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 28);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Query Day";
            // 
            // cbxCust
            // 
            this.cbxCust.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(786, 19);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(376, 27);
            this.cbxCust.TabIndex = 14;
            // 
            // txtItem
            // 
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(786, 61);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(376, 27);
            this.txtItem.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Local Invoice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item";
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnQuery.Location = new System.Drawing.Point(1208, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 50);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "Search";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // GridM
            // 
            this.GridM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridM.Location = new System.Drawing.Point(3, 113);
            this.GridM.MainView = this.gridViewM;
            this.GridM.Name = "GridM";
            this.GridM.Size = new System.Drawing.Size(1790, 368);
            this.GridM.TabIndex = 1;
            this.GridM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewM});
            // 
            // gridViewM
            // 
            this.gridViewM.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewM.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CVCOD,
            this.CVNAS,
            this.ITNBR,
            this.ITDSC,
            this.BUYERITEM,
            this.DEPOT_OUT,
            this.WHNAME,
            this.CUNIT,
            this.JAN_QTY,
            this.FEB_QTY,
            this.MAR_QTY,
            this.APR_QTY,
            this.MAY_QTY,
            this.JUN_QTY,
            this.JUL_QTY,
            this.AUG_QTY,
            this.SEPT_QTY,
            this.OCT_QTY,
            this.NOV_QTY,
            this.DEC_QTY,
            this.TOTQTY});
            this.gridViewM.GridControl = this.GridM;
            this.gridViewM.Name = "gridViewM";
            this.gridViewM.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewM.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewM.OptionsBehavior.Editable = false;
            this.gridViewM.OptionsBehavior.ReadOnly = true;
            this.gridViewM.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewM.OptionsSelection.MultiSelect = true;
            this.gridViewM.OptionsView.ShowFooter = true;
            this.gridViewM.OptionsView.ShowGroupedColumns = true;
            this.gridViewM.OptionsView.ShowGroupPanel = false;
            this.gridViewM.DoubleClick += new System.EventHandler(this.gridViewM_DoubleClick);
            // 
            // CVCOD
            // 
            this.CVCOD.Caption = "buyer";
            this.CVCOD.FieldName = "CVCOD";
            this.CVCOD.MinWidth = 25;
            this.CVCOD.Name = "CVCOD";
            this.CVCOD.Width = 94;
            // 
            // CVNAS
            // 
            this.CVNAS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CVNAS.AppearanceCell.Options.UseBackColor = true;
            this.CVNAS.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CVNAS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CVNAS.AppearanceHeader.Options.UseBackColor = true;
            this.CVNAS.AppearanceHeader.Options.UseFont = true;
            this.CVNAS.Caption = "Buyer";
            this.CVNAS.FieldName = "CVNAS";
            this.CVNAS.MinWidth = 25;
            this.CVNAS.Name = "CVNAS";
            this.CVNAS.Visible = true;
            this.CVNAS.VisibleIndex = 0;
            this.CVNAS.Width = 210;
            // 
            // ITNBR
            // 
            this.ITNBR.Caption = "ITEM";
            this.ITNBR.FieldName = "ITNBR";
            this.ITNBR.MinWidth = 25;
            this.ITNBR.Name = "ITNBR";
            this.ITNBR.Visible = true;
            this.ITNBR.VisibleIndex = 1;
            this.ITNBR.Width = 183;
            // 
            // ITDSC
            // 
            this.ITDSC.Caption = "Description";
            this.ITDSC.FieldName = "ITDSC";
            this.ITDSC.MinWidth = 25;
            this.ITDSC.Name = "ITDSC";
            this.ITDSC.Visible = true;
            this.ITDSC.VisibleIndex = 2;
            this.ITDSC.Width = 171;
            // 
            // BUYERITEM
            // 
            this.BUYERITEM.Caption = "Part No.";
            this.BUYERITEM.FieldName = "BUYERITEM";
            this.BUYERITEM.MinWidth = 25;
            this.BUYERITEM.Name = "BUYERITEM";
            this.BUYERITEM.Visible = true;
            this.BUYERITEM.VisibleIndex = 3;
            this.BUYERITEM.Width = 146;
            // 
            // DEPOT_OUT
            // 
            this.DEPOT_OUT.Caption = "warehouse";
            this.DEPOT_OUT.FieldName = "DEPOT_OUT";
            this.DEPOT_OUT.MinWidth = 25;
            this.DEPOT_OUT.Name = "DEPOT_OUT";
            this.DEPOT_OUT.Width = 94;
            // 
            // WHNAME
            // 
            this.WHNAME.AppearanceCell.Options.UseTextOptions = true;
            this.WHNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WHNAME.Caption = "WH.";
            this.WHNAME.FieldName = "WHNAME";
            this.WHNAME.MinWidth = 25;
            this.WHNAME.Name = "WHNAME";
            this.WHNAME.Visible = true;
            this.WHNAME.VisibleIndex = 4;
            this.WHNAME.Width = 48;
            // 
            // CUNIT
            // 
            this.CUNIT.AppearanceCell.Options.UseTextOptions = true;
            this.CUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CUNIT.Caption = "Curr.";
            this.CUNIT.FieldName = "CUNIT";
            this.CUNIT.MinWidth = 25;
            this.CUNIT.Name = "CUNIT";
            this.CUNIT.Visible = true;
            this.CUNIT.VisibleIndex = 5;
            this.CUNIT.Width = 46;
            // 
            // JAN_QTY
            // 
            this.JAN_QTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.JAN_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.JAN_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JAN_QTY.AppearanceCell.Options.UseBackColor = true;
            this.JAN_QTY.AppearanceCell.Options.UseFont = true;
            this.JAN_QTY.AppearanceCell.Options.UseForeColor = true;
            this.JAN_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.JAN_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JAN_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JAN_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.JAN_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.JAN_QTY.AppearanceHeader.Options.UseFont = true;
            this.JAN_QTY.Caption = "JAN.";
            this.JAN_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.JAN_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JAN_QTY.FieldName = "JAN_QTY";
            this.JAN_QTY.MinWidth = 25;
            this.JAN_QTY.Name = "JAN_QTY";
            this.JAN_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JAN_QTY", "{0:###,###,##0}")});
            this.JAN_QTY.Visible = true;
            this.JAN_QTY.VisibleIndex = 6;
            this.JAN_QTY.Width = 70;
            // 
            // FEB_QTY
            // 
            this.FEB_QTY.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.FEB_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.FEB_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FEB_QTY.AppearanceCell.Options.UseBackColor = true;
            this.FEB_QTY.AppearanceCell.Options.UseFont = true;
            this.FEB_QTY.AppearanceCell.Options.UseForeColor = true;
            this.FEB_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.FEB_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FEB_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FEB_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.FEB_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.FEB_QTY.AppearanceHeader.Options.UseFont = true;
            this.FEB_QTY.Caption = "FEB.";
            this.FEB_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.FEB_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FEB_QTY.FieldName = "FEB_QTY";
            this.FEB_QTY.MinWidth = 25;
            this.FEB_QTY.Name = "FEB_QTY";
            this.FEB_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FEB_QTY", "{0:###,###,##0}")});
            this.FEB_QTY.Visible = true;
            this.FEB_QTY.VisibleIndex = 7;
            this.FEB_QTY.Width = 70;
            // 
            // MAR_QTY
            // 
            this.MAR_QTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MAR_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.MAR_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MAR_QTY.AppearanceCell.Options.UseBackColor = true;
            this.MAR_QTY.AppearanceCell.Options.UseFont = true;
            this.MAR_QTY.AppearanceCell.Options.UseForeColor = true;
            this.MAR_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.MAR_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MAR_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MAR_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.MAR_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.MAR_QTY.AppearanceHeader.Options.UseFont = true;
            this.MAR_QTY.Caption = "MAR.";
            this.MAR_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.MAR_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MAR_QTY.FieldName = "MAR_QTY";
            this.MAR_QTY.MinWidth = 25;
            this.MAR_QTY.Name = "MAR_QTY";
            this.MAR_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MAR_QTY", "{0:###,###,##0}")});
            this.MAR_QTY.Visible = true;
            this.MAR_QTY.VisibleIndex = 8;
            this.MAR_QTY.Width = 70;
            // 
            // APR_QTY
            // 
            this.APR_QTY.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.APR_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.APR_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.APR_QTY.AppearanceCell.Options.UseBackColor = true;
            this.APR_QTY.AppearanceCell.Options.UseFont = true;
            this.APR_QTY.AppearanceCell.Options.UseForeColor = true;
            this.APR_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.APR_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.APR_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.APR_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.APR_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.APR_QTY.AppearanceHeader.Options.UseFont = true;
            this.APR_QTY.Caption = "APR.";
            this.APR_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.APR_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.APR_QTY.FieldName = "APR_QTY";
            this.APR_QTY.MinWidth = 25;
            this.APR_QTY.Name = "APR_QTY";
            this.APR_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "APR_QTY", "{0:###,###,##0}")});
            this.APR_QTY.Visible = true;
            this.APR_QTY.VisibleIndex = 9;
            this.APR_QTY.Width = 70;
            // 
            // MAY_QTY
            // 
            this.MAY_QTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MAY_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.MAY_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MAY_QTY.AppearanceCell.Options.UseBackColor = true;
            this.MAY_QTY.AppearanceCell.Options.UseFont = true;
            this.MAY_QTY.AppearanceCell.Options.UseForeColor = true;
            this.MAY_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.MAY_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MAY_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MAY_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.MAY_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.MAY_QTY.AppearanceHeader.Options.UseFont = true;
            this.MAY_QTY.Caption = "MAY.";
            this.MAY_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.MAY_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MAY_QTY.FieldName = "MAY_QTY";
            this.MAY_QTY.MinWidth = 25;
            this.MAY_QTY.Name = "MAY_QTY";
            this.MAY_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MAY_QTY", "{0:###,###,##0}")});
            this.MAY_QTY.Visible = true;
            this.MAY_QTY.VisibleIndex = 10;
            this.MAY_QTY.Width = 70;
            // 
            // JUN_QTY
            // 
            this.JUN_QTY.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.JUN_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.JUN_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JUN_QTY.AppearanceCell.Options.UseBackColor = true;
            this.JUN_QTY.AppearanceCell.Options.UseFont = true;
            this.JUN_QTY.AppearanceCell.Options.UseForeColor = true;
            this.JUN_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.JUN_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JUN_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JUN_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.JUN_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.JUN_QTY.AppearanceHeader.Options.UseFont = true;
            this.JUN_QTY.Caption = "JUN.";
            this.JUN_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.JUN_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JUN_QTY.FieldName = "JUN_QTY";
            this.JUN_QTY.MinWidth = 25;
            this.JUN_QTY.Name = "JUN_QTY";
            this.JUN_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JUN_QTY", "{0:###,###,##0}")});
            this.JUN_QTY.Visible = true;
            this.JUN_QTY.VisibleIndex = 11;
            this.JUN_QTY.Width = 70;
            // 
            // JUL_QTY
            // 
            this.JUL_QTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.JUL_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.JUL_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.JUL_QTY.AppearanceCell.Options.UseBackColor = true;
            this.JUL_QTY.AppearanceCell.Options.UseFont = true;
            this.JUL_QTY.AppearanceCell.Options.UseForeColor = true;
            this.JUL_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.JUL_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JUL_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JUL_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.JUL_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.JUL_QTY.AppearanceHeader.Options.UseFont = true;
            this.JUL_QTY.Caption = "JUL.";
            this.JUL_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.JUL_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JUL_QTY.FieldName = "JUL_QTY";
            this.JUL_QTY.MinWidth = 25;
            this.JUL_QTY.Name = "JUL_QTY";
            this.JUL_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JUL_QTY", "{0:###,###,##0}")});
            this.JUL_QTY.Visible = true;
            this.JUL_QTY.VisibleIndex = 12;
            this.JUL_QTY.Width = 70;
            // 
            // AUG_QTY
            // 
            this.AUG_QTY.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.AUG_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.AUG_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AUG_QTY.AppearanceCell.Options.UseBackColor = true;
            this.AUG_QTY.AppearanceCell.Options.UseFont = true;
            this.AUG_QTY.AppearanceCell.Options.UseForeColor = true;
            this.AUG_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.AUG_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AUG_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AUG_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.AUG_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.AUG_QTY.AppearanceHeader.Options.UseFont = true;
            this.AUG_QTY.Caption = "AUG.";
            this.AUG_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.AUG_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.AUG_QTY.FieldName = "AUG_QTY";
            this.AUG_QTY.MinWidth = 25;
            this.AUG_QTY.Name = "AUG_QTY";
            this.AUG_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AUG_QTY", "{0:###,###,##0}")});
            this.AUG_QTY.Visible = true;
            this.AUG_QTY.VisibleIndex = 13;
            this.AUG_QTY.Width = 70;
            // 
            // SEPT_QTY
            // 
            this.SEPT_QTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SEPT_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SEPT_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SEPT_QTY.AppearanceCell.Options.UseBackColor = true;
            this.SEPT_QTY.AppearanceCell.Options.UseFont = true;
            this.SEPT_QTY.AppearanceCell.Options.UseForeColor = true;
            this.SEPT_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.SEPT_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SEPT_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SEPT_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SEPT_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.SEPT_QTY.AppearanceHeader.Options.UseFont = true;
            this.SEPT_QTY.Caption = "SEPT.";
            this.SEPT_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.SEPT_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SEPT_QTY.FieldName = "SEPT_QTY";
            this.SEPT_QTY.MinWidth = 25;
            this.SEPT_QTY.Name = "SEPT_QTY";
            this.SEPT_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SEPT_QTY", "{0:###,###,##0}")});
            this.SEPT_QTY.Visible = true;
            this.SEPT_QTY.VisibleIndex = 14;
            this.SEPT_QTY.Width = 70;
            // 
            // OCT_QTY
            // 
            this.OCT_QTY.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.OCT_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.OCT_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OCT_QTY.AppearanceCell.Options.UseBackColor = true;
            this.OCT_QTY.AppearanceCell.Options.UseFont = true;
            this.OCT_QTY.AppearanceCell.Options.UseForeColor = true;
            this.OCT_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.OCT_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OCT_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OCT_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.OCT_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.OCT_QTY.AppearanceHeader.Options.UseFont = true;
            this.OCT_QTY.Caption = "OCT.";
            this.OCT_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.OCT_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.OCT_QTY.FieldName = "OCT_QTY";
            this.OCT_QTY.MinWidth = 25;
            this.OCT_QTY.Name = "OCT_QTY";
            this.OCT_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OCT_QTY", "{0:###,###,##0}")});
            this.OCT_QTY.Visible = true;
            this.OCT_QTY.VisibleIndex = 15;
            this.OCT_QTY.Width = 70;
            // 
            // NOV_QTY
            // 
            this.NOV_QTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NOV_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NOV_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NOV_QTY.AppearanceCell.Options.UseBackColor = true;
            this.NOV_QTY.AppearanceCell.Options.UseFont = true;
            this.NOV_QTY.AppearanceCell.Options.UseForeColor = true;
            this.NOV_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.NOV_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NOV_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NOV_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.NOV_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.NOV_QTY.AppearanceHeader.Options.UseFont = true;
            this.NOV_QTY.Caption = "NOV.";
            this.NOV_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.NOV_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NOV_QTY.FieldName = "NOV_QTY";
            this.NOV_QTY.MinWidth = 25;
            this.NOV_QTY.Name = "NOV_QTY";
            this.NOV_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOV_QTY", "{0:###,###,##0}")});
            this.NOV_QTY.Visible = true;
            this.NOV_QTY.VisibleIndex = 16;
            this.NOV_QTY.Width = 70;
            // 
            // DEC_QTY
            // 
            this.DEC_QTY.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.DEC_QTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DEC_QTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DEC_QTY.AppearanceCell.Options.UseBackColor = true;
            this.DEC_QTY.AppearanceCell.Options.UseFont = true;
            this.DEC_QTY.AppearanceCell.Options.UseForeColor = true;
            this.DEC_QTY.AppearanceCell.Options.UseTextOptions = true;
            this.DEC_QTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DEC_QTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DEC_QTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DEC_QTY.AppearanceHeader.Options.UseBackColor = true;
            this.DEC_QTY.AppearanceHeader.Options.UseFont = true;
            this.DEC_QTY.Caption = "DEC.";
            this.DEC_QTY.DisplayFormat.FormatString = "###,###,##0";
            this.DEC_QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DEC_QTY.FieldName = "DEC_QTY";
            this.DEC_QTY.MinWidth = 25;
            this.DEC_QTY.Name = "DEC_QTY";
            this.DEC_QTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DEC_QTY", "{0:###,###,##0}")});
            this.DEC_QTY.Visible = true;
            this.DEC_QTY.VisibleIndex = 17;
            this.DEC_QTY.Width = 71;
            // 
            // TOTQTY
            // 
            this.TOTQTY.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.TOTQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.TOTQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TOTQTY.AppearanceCell.Options.UseBackColor = true;
            this.TOTQTY.AppearanceCell.Options.UseFont = true;
            this.TOTQTY.AppearanceCell.Options.UseForeColor = true;
            this.TOTQTY.AppearanceCell.Options.UseTextOptions = true;
            this.TOTQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TOTQTY.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.TOTQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.TOTQTY.AppearanceHeader.Options.UseBackColor = true;
            this.TOTQTY.AppearanceHeader.Options.UseFont = true;
            this.TOTQTY.Caption = "Total Qty.";
            this.TOTQTY.DisplayFormat.FormatString = "###,###,##0";
            this.TOTQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TOTQTY.FieldName = "TOTQTY";
            this.TOTQTY.MinWidth = 25;
            this.TOTQTY.Name = "TOTQTY";
            this.TOTQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTQTY", "{0:###,###,##0}")});
            this.TOTQTY.Visible = true;
            this.TOTQTY.VisibleIndex = 18;
            this.TOTQTY.Width = 125;
            // 
            // FrmDeliveryMonthList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmDeliveryMonthList";
            this.Size = new System.Drawing.Size(1796, 964);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewD)).EndInit();
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlQuery;
        private DevExpress.XtraGrid.GridControl GridM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewM;
        private DevExpress.XtraGrid.GridControl GridD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewD;
        private System.Windows.Forms.ComboBox cbxWh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalInvoice;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn DIO_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn DCVCOD;
        private DevExpress.XtraGrid.Columns.GridColumn DCVNAS;
        private DevExpress.XtraGrid.Columns.GridColumn DREF3;
        private DevExpress.XtraGrid.Columns.GridColumn DREF4;
        private DevExpress.XtraGrid.Columns.GridColumn DITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn DITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn DBUYERITEM;
        private DevExpress.XtraGrid.Columns.GridColumn DDEPOT_OUT;
        private DevExpress.XtraGrid.Columns.GridColumn DWHNAME;
        private DevExpress.XtraGrid.Columns.GridColumn DIOQTY;
        private DevExpress.XtraGrid.Columns.GridColumn DIOREQTY;
        private DevExpress.XtraGrid.Columns.GridColumn DCUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn DFIOPRC;
        private DevExpress.XtraGrid.Columns.GridColumn DFIOAMT;
        private DevExpress.XtraGrid.Columns.GridColumn CVCOD;
        private DevExpress.XtraGrid.Columns.GridColumn CVNAS;
        private DevExpress.XtraGrid.Columns.GridColumn ITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn ITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn BUYERITEM;
        private DevExpress.XtraGrid.Columns.GridColumn DEPOT_OUT;
        private DevExpress.XtraGrid.Columns.GridColumn WHNAME;
        private DevExpress.XtraGrid.Columns.GridColumn CUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn JAN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn FEB_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn MAR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn APR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn MAY_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn JUN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn JUL_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn AUG_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn SEPT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn OCT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn NOV_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn DEC_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn TOTQTY;
        private DevExpress.XtraGrid.Columns.GridColumn DDREF4;
        private DevExpress.XtraGrid.Columns.GridColumn DTOTAMT;
    }
}
