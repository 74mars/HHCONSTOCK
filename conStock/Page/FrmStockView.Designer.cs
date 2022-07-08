namespace conStock.Page
{
    partial class FrmStockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxWh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalInvoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IO_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REF4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REF3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BUYERITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IOQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IOREQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIOPRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FIOAMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GUMDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlQuery, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Grid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1665, 1003);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.Color.LightGray;
            this.pnlQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuery.Controls.Add(this.txtItem);
            this.pnlQuery.Controls.Add(this.label5);
            this.pnlQuery.Controls.Add(this.cbxWh);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.txtLocalInvoice);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.dateTimePicker2);
            this.pnlQuery.Controls.Add(this.dateTimePicker1);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuery.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlQuery.Location = new System.Drawing.Point(3, 3);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1659, 104);
            this.pnlQuery.TabIndex = 0;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(777, 59);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(376, 27);
            this.txtItem.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Local Invoice";
            // 
            // cbxWh
            // 
            this.cbxWh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWh.FormattingEnabled = true;
            this.cbxWh.Location = new System.Drawing.Point(137, 8);
            this.cbxWh.Name = "cbxWh";
            this.cbxWh.Size = new System.Drawing.Size(234, 27);
            this.cbxWh.TabIndex = 8;
            this.cbxWh.SelectedIndexChanged += new System.EventHandler(this.cbxWh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Warehouse";
            // 
            // txtLocalInvoice
            // 
            this.txtLocalInvoice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalInvoice.Location = new System.Drawing.Point(137, 61);
            this.txtLocalInvoice.Name = "txtLocalInvoice";
            this.txtLocalInvoice.Size = new System.Drawing.Size(234, 27);
            this.txtLocalInvoice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buyer";
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnQuery.Location = new System.Drawing.Point(1203, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 50);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Search";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(506, 56);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 13);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query Day";
            // 
            // Grid
            // 
            this.Grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 113);
            this.Grid.MainView = this.gridView;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1659, 887);
            this.Grid.TabIndex = 3;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.MistyRose;
            this.gridView.Appearance.EvenRow.BackColor2 = System.Drawing.Color.MistyRose;
            this.gridView.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.gridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IO_DATE,
            this.REF4,
            this.REF3,
            this.ITNBR,
            this.BUYERITEM,
            this.ITDSC,
            this.IOQTY,
            this.IOREQTY,
            this.FIOPRC,
            this.FIOAMT,
            this.CUNIT,
            this.GUMDAT,
            this.CVCOD,
            this.CVNAS});
            this.gridView.GridControl = this.Grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // IO_DATE
            // 
            this.IO_DATE.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.IO_DATE.AppearanceCell.Options.UseForeColor = true;
            this.IO_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.IO_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IO_DATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IO_DATE.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IO_DATE.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IO_DATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IO_DATE.AppearanceHeader.Options.UseBackColor = true;
            this.IO_DATE.AppearanceHeader.Options.UseFont = true;
            this.IO_DATE.Caption = "Delivery Day";
            this.IO_DATE.FieldName = "IO_DATE";
            this.IO_DATE.MinWidth = 25;
            this.IO_DATE.Name = "IO_DATE";
            this.IO_DATE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.IO_DATE.Visible = true;
            this.IO_DATE.VisibleIndex = 0;
            this.IO_DATE.Width = 114;
            // 
            // REF4
            // 
            this.REF4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REF4.AppearanceCell.ForeColor = System.Drawing.Color.IndianRed;
            this.REF4.AppearanceCell.Options.UseFont = true;
            this.REF4.AppearanceCell.Options.UseForeColor = true;
            this.REF4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.REF4.AppearanceHeader.Options.UseBackColor = true;
            this.REF4.Caption = "Local Invoice";
            this.REF4.FieldName = "REF4";
            this.REF4.MinWidth = 25;
            this.REF4.Name = "REF4";
            this.REF4.Visible = true;
            this.REF4.VisibleIndex = 1;
            this.REF4.Width = 223;
            // 
            // REF3
            // 
            this.REF3.Caption = "Invoice";
            this.REF3.FieldName = "REF3";
            this.REF3.MinWidth = 25;
            this.REF3.Name = "REF3";
            this.REF3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.REF3.Visible = true;
            this.REF3.VisibleIndex = 2;
            this.REF3.Width = 200;
            // 
            // ITNBR
            // 
            this.ITNBR.Caption = "ITEM";
            this.ITNBR.FieldName = "ITNBR";
            this.ITNBR.MinWidth = 25;
            this.ITNBR.Name = "ITNBR";
            this.ITNBR.Width = 267;
            // 
            // BUYERITEM
            // 
            this.BUYERITEM.Caption = "Part No.";
            this.BUYERITEM.FieldName = "BUYERITEM";
            this.BUYERITEM.MinWidth = 25;
            this.BUYERITEM.Name = "BUYERITEM";
            this.BUYERITEM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.BUYERITEM.Visible = true;
            this.BUYERITEM.VisibleIndex = 3;
            this.BUYERITEM.Width = 187;
            // 
            // ITDSC
            // 
            this.ITDSC.Caption = "Description";
            this.ITDSC.FieldName = "ITDSC";
            this.ITDSC.MinWidth = 25;
            this.ITDSC.Name = "ITDSC";
            this.ITDSC.Visible = true;
            this.ITDSC.VisibleIndex = 4;
            this.ITDSC.Width = 213;
            // 
            // IOQTY
            // 
            this.IOQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOQTY.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.IOQTY.AppearanceCell.Options.UseFont = true;
            this.IOQTY.AppearanceCell.Options.UseForeColor = true;
            this.IOQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IOQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IOQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.IOQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IOQTY.AppearanceHeader.Options.UseFont = true;
            this.IOQTY.Caption = "Delivery Qty";
            this.IOQTY.DisplayFormat.FormatString = "###,###,###";
            this.IOQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IOQTY.FieldName = "IOQTY";
            this.IOQTY.MinWidth = 25;
            this.IOQTY.Name = "IOQTY";
            this.IOQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IOQTY", "{0:###,###,###}")});
            this.IOQTY.Visible = true;
            this.IOQTY.VisibleIndex = 5;
            this.IOQTY.Width = 106;
            // 
            // IOREQTY
            // 
            this.IOREQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOREQTY.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.IOREQTY.AppearanceCell.Options.UseFont = true;
            this.IOREQTY.AppearanceCell.Options.UseForeColor = true;
            this.IOREQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IOREQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IOREQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.IOREQTY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOREQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IOREQTY.AppearanceHeader.Options.UseFont = true;
            this.IOREQTY.Caption = "Deliv box Qty.";
            this.IOREQTY.DisplayFormat.FormatString = "###,###,###";
            this.IOREQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IOREQTY.FieldName = "IOREQTY";
            this.IOREQTY.MinWidth = 25;
            this.IOREQTY.Name = "IOREQTY";
            this.IOREQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IOREQTY", "{0:###,###,###}")});
            this.IOREQTY.Visible = true;
            this.IOREQTY.VisibleIndex = 6;
            this.IOREQTY.Width = 112;
            // 
            // FIOPRC
            // 
            this.FIOPRC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FIOPRC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIOPRC.AppearanceCell.ForeColor = System.Drawing.Color.DarkRed;
            this.FIOPRC.AppearanceCell.Options.UseBackColor = true;
            this.FIOPRC.AppearanceCell.Options.UseFont = true;
            this.FIOPRC.AppearanceCell.Options.UseForeColor = true;
            this.FIOPRC.AppearanceCell.Options.UseTextOptions = true;
            this.FIOPRC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FIOPRC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FIOPRC.AppearanceHeader.Options.UseBackColor = true;
            this.FIOPRC.Caption = "Price";
            this.FIOPRC.DisplayFormat.FormatString = "###,###,###.####";
            this.FIOPRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FIOPRC.FieldName = "FIOPRC";
            this.FIOPRC.MinWidth = 25;
            this.FIOPRC.Name = "FIOPRC";
            this.FIOPRC.Visible = true;
            this.FIOPRC.VisibleIndex = 7;
            this.FIOPRC.Width = 79;
            // 
            // FIOAMT
            // 
            this.FIOAMT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FIOAMT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIOAMT.AppearanceCell.ForeColor = System.Drawing.Color.DarkRed;
            this.FIOAMT.AppearanceCell.Options.UseBackColor = true;
            this.FIOAMT.AppearanceCell.Options.UseFont = true;
            this.FIOAMT.AppearanceCell.Options.UseForeColor = true;
            this.FIOAMT.AppearanceCell.Options.UseTextOptions = true;
            this.FIOAMT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FIOAMT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FIOAMT.AppearanceHeader.Options.UseBackColor = true;
            this.FIOAMT.Caption = "Amount";
            this.FIOAMT.DisplayFormat.FormatString = "#,###,###,###,###.####";
            this.FIOAMT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.FIOAMT.FieldName = "FIOAMT";
            this.FIOAMT.MinWidth = 25;
            this.FIOAMT.Name = "FIOAMT";
            this.FIOAMT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FIOAMT", "{0:#,###,###,###,###.####}")});
            this.FIOAMT.Visible = true;
            this.FIOAMT.VisibleIndex = 8;
            this.FIOAMT.Width = 102;
            // 
            // CUNIT
            // 
            this.CUNIT.AppearanceCell.Options.UseTextOptions = true;
            this.CUNIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CUNIT.Caption = "Curr";
            this.CUNIT.FieldName = "CUNIT";
            this.CUNIT.MinWidth = 25;
            this.CUNIT.Name = "CUNIT";
            this.CUNIT.Visible = true;
            this.CUNIT.VisibleIndex = 9;
            this.CUNIT.Width = 49;
            // 
            // GUMDAT
            // 
            this.GUMDAT.Caption = "Correct Day";
            this.GUMDAT.FieldName = "GUMDAT";
            this.GUMDAT.MinWidth = 25;
            this.GUMDAT.Name = "GUMDAT";
            this.GUMDAT.Width = 107;
            // 
            // CVCOD
            // 
            this.CVCOD.Caption = "Buyer";
            this.CVCOD.FieldName = "CVCOD";
            this.CVCOD.MinWidth = 25;
            this.CVCOD.Name = "CVCOD";
            this.CVCOD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.CVCOD.Width = 103;
            // 
            // CVNAS
            // 
            this.CVNAS.Caption = "Buyer Name";
            this.CVNAS.FieldName = "CVNAS";
            this.CVNAS.MinWidth = 25;
            this.CVNAS.Name = "CVNAS";
            this.CVNAS.Visible = true;
            this.CVNAS.VisibleIndex = 10;
            this.CVNAS.Width = 254;
            // 
            // cbxCust
            // 
            this.cbxCust.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(781, 17);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(376, 27);
            this.cbxCust.TabIndex = 3;
            this.cbxCust.SelectedIndexChanged += new System.EventHandler(this.cbxCust_SelectedIndexChanged);
            this.cbxCust.ValueMemberChanged += new System.EventHandler(this.cbxCust_ValueMemberChanged);
            // 
            // FrmStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxCust);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmStockView";
            this.Size = new System.Drawing.Size(1665, 1003);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn IO_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn REF4;
        private DevExpress.XtraGrid.Columns.GridColumn REF3;
        private DevExpress.XtraGrid.Columns.GridColumn ITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn ITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn IOQTY;
        private DevExpress.XtraGrid.Columns.GridColumn IOREQTY;
        private DevExpress.XtraGrid.Columns.GridColumn FIOAMT;
        private DevExpress.XtraGrid.Columns.GridColumn CUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn GUMDAT;
        private DevExpress.XtraGrid.Columns.GridColumn CVCOD;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn BUYERITEM;
        private DevExpress.XtraGrid.Columns.GridColumn FIOPRC;
        private System.Windows.Forms.ComboBox cbxWh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn CVNAS;
        private System.Windows.Forms.TextBox txtItem;
    }
}
