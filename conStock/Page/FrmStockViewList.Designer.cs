namespace conStock.Page
{
    partial class FrmStockViewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockViewList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btnPrt = new DevExpress.XtraEditors.SimpleButton();
            this.cbxWh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chktot = new System.Windows.Forms.CheckBox();
            this.cbxStat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.INVOICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEMNANME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JBQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BCIQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.infoBuyer = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.BCVCOD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BCVNAS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BITNBR = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BITEMNAME = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BITDSC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.InfoQty = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CIQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BCIQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.IQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BIQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.JQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.JBQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.TQTYB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandGridView)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1800, 1083);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.Color.LightGray;
            this.pnlQuery.Controls.Add(this.btnPrt);
            this.pnlQuery.Controls.Add(this.cbxWh);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.chktot);
            this.pnlQuery.Controls.Add(this.cbxStat);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Controls.Add(this.btnExcel);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Controls.Add(this.cbxCust);
            this.pnlQuery.Controls.Add(this.cbxItem);
            this.pnlQuery.Controls.Add(this.txtItem);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuery.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlQuery.Location = new System.Drawing.Point(3, 3);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1794, 104);
            this.pnlQuery.TabIndex = 0;
            // 
            // btnPrt
            // 
            this.btnPrt.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrt.Appearance.Options.UseFont = true;
            this.btnPrt.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPrt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrt.ImageOptions.SvgImage")));
            this.btnPrt.Location = new System.Drawing.Point(1192, 11);
            this.btnPrt.Name = "btnPrt";
            this.btnPrt.Size = new System.Drawing.Size(110, 50);
            this.btnPrt.TabIndex = 19;
            this.btnPrt.Text = "Print";
            this.btnPrt.Click += new System.EventHandler(this.btnPrt_Click);
            // 
            // cbxWh
            // 
            this.cbxWh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWh.FormattingEnabled = true;
            this.cbxWh.Location = new System.Drawing.Point(173, 16);
            this.cbxWh.Name = "cbxWh";
            this.cbxWh.Size = new System.Drawing.Size(218, 27);
            this.cbxWh.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Warehouse";
            // 
            // chktot
            // 
            this.chktot.AutoSize = true;
            this.chktot.Location = new System.Drawing.Point(960, 72);
            this.chktot.Name = "chktot";
            this.chktot.Size = new System.Drawing.Size(116, 24);
            this.chktot.TabIndex = 16;
            this.chktot.Text = "Total Summary";
            this.chktot.UseVisualStyleBackColor = true;
            this.chktot.CheckedChanged += new System.EventHandler(this.chktot_CheckedChanged);
            // 
            // cbxStat
            // 
            this.cbxStat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStat.FormattingEnabled = true;
            this.cbxStat.Location = new System.Drawing.Point(173, 64);
            this.cbxStat.Name = "cbxStat";
            this.cbxStat.Size = new System.Drawing.Size(218, 27);
            this.cbxStat.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buyer";
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnExcel.Location = new System.Drawing.Point(1076, 11);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(110, 50);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnQuery.Location = new System.Drawing.Point(960, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 50);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "Search";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location";
            // 
            // cbxCust
            // 
            this.cbxCust.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(517, 16);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(376, 27);
            this.cbxCust.TabIndex = 2;
            // 
            // cbxItem
            // 
            this.cbxItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(517, 64);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(218, 27);
            this.cbxItem.TabIndex = 3;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(741, 64);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(151, 27);
            this.txtItem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item";
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 113);
            this.Grid.MainView = this.gridView;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1794, 967);
            this.Grid.TabIndex = 1;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.bandGridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.INVOICE,
            this.CVCOD,
            this.CVNAS,
            this.ITNBR,
            this.ITEMNANME,
            this.ITDSC,
            this.TQTY,
            this.JQTY,
            this.JBQTY,
            this.CIQTY,
            this.BCIQTY,
            this.IQTY,
            this.IBQTY});
            this.gridView.GridControl = this.Grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView.OptionsPrint.PrintDetails = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupedColumns = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // INVOICE
            // 
            this.INVOICE.Caption = "Invoice";
            this.INVOICE.FieldName = "INVOICE";
            this.INVOICE.MinWidth = 25;
            this.INVOICE.Name = "INVOICE";
            this.INVOICE.Visible = true;
            this.INVOICE.VisibleIndex = 0;
            this.INVOICE.Width = 134;
            // 
            // CVCOD
            // 
            this.CVCOD.Caption = "Buyer";
            this.CVCOD.FieldName = "CVCOD";
            this.CVCOD.MinWidth = 25;
            this.CVCOD.Name = "CVCOD";
            this.CVCOD.Width = 94;
            // 
            // CVNAS
            // 
            this.CVNAS.Caption = "Buyer Name";
            this.CVNAS.FieldName = "CVNAS";
            this.CVNAS.MinWidth = 25;
            this.CVNAS.Name = "CVNAS";
            this.CVNAS.Visible = true;
            this.CVNAS.VisibleIndex = 1;
            this.CVNAS.Width = 178;
            // 
            // ITNBR
            // 
            this.ITNBR.Caption = "ITEM";
            this.ITNBR.FieldName = "ITNBR";
            this.ITNBR.MinWidth = 25;
            this.ITNBR.Name = "ITNBR";
            this.ITNBR.Visible = true;
            this.ITNBR.VisibleIndex = 2;
            this.ITNBR.Width = 182;
            // 
            // ITEMNANME
            // 
            this.ITEMNANME.Caption = "Part No.";
            this.ITEMNANME.FieldName = "ITEMNANME";
            this.ITEMNANME.MinWidth = 25;
            this.ITEMNANME.Name = "ITEMNANME";
            this.ITEMNANME.Visible = true;
            this.ITEMNANME.VisibleIndex = 3;
            this.ITEMNANME.Width = 182;
            // 
            // ITDSC
            // 
            this.ITDSC.Caption = "Description";
            this.ITDSC.FieldName = "ITDSC";
            this.ITDSC.MinWidth = 25;
            this.ITDSC.Name = "ITDSC";
            this.ITDSC.Visible = true;
            this.ITDSC.VisibleIndex = 4;
            this.ITDSC.Width = 181;
            // 
            // TQTY
            // 
            this.TQTY.AppearanceCell.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TQTY.AppearanceCell.ForeColor = System.Drawing.Color.IndianRed;
            this.TQTY.AppearanceCell.Options.UseBackColor = true;
            this.TQTY.AppearanceCell.Options.UseFont = true;
            this.TQTY.AppearanceCell.Options.UseForeColor = true;
            this.TQTY.AppearanceCell.Options.UseTextOptions = true;
            this.TQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TQTY.AppearanceHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TQTY.AppearanceHeader.Options.UseBackColor = true;
            this.TQTY.Caption = "TOTAL QTY";
            this.TQTY.FieldName = "TQTY";
            this.TQTY.MinWidth = 25;
            this.TQTY.Name = "TQTY";
            this.TQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TQTY", "{0:#,##;-0:#,##}")});
            this.TQTY.Visible = true;
            this.TQTY.VisibleIndex = 5;
            this.TQTY.Width = 125;
            // 
            // JQTY
            // 
            this.JQTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JQTY.AppearanceCell.ForeColor = System.Drawing.Color.White;
            this.JQTY.AppearanceCell.Options.UseBackColor = true;
            this.JQTY.AppearanceCell.Options.UseFont = true;
            this.JQTY.AppearanceCell.Options.UseForeColor = true;
            this.JQTY.AppearanceCell.Options.UseTextOptions = true;
            this.JQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JQTY.AppearanceHeader.Options.UseBackColor = true;
            this.JQTY.Caption = "Wharehouse";
            this.JQTY.FieldName = "JQTY";
            this.JQTY.MinWidth = 25;
            this.JQTY.Name = "JQTY";
            this.JQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JQTY", "{0:#,##;-0:#,##}")});
            this.JQTY.Visible = true;
            this.JQTY.VisibleIndex = 6;
            this.JQTY.Width = 151;
            // 
            // JBQTY
            // 
            this.JBQTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JBQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JBQTY.AppearanceCell.ForeColor = System.Drawing.Color.White;
            this.JBQTY.AppearanceCell.Options.UseBackColor = true;
            this.JBQTY.AppearanceCell.Options.UseFont = true;
            this.JBQTY.AppearanceCell.Options.UseForeColor = true;
            this.JBQTY.AppearanceCell.Options.UseTextOptions = true;
            this.JBQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JBQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.JBQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JBQTY.AppearanceHeader.Options.UseBackColor = true;
            this.JBQTY.Caption = "Wharehouse Box";
            this.JBQTY.FieldName = "JBQTY";
            this.JBQTY.MinWidth = 25;
            this.JBQTY.Name = "JBQTY";
            this.JBQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JBQTY", "{0:#,##;-0:#,##}")});
            this.JBQTY.Visible = true;
            this.JBQTY.VisibleIndex = 7;
            this.JBQTY.Width = 124;
            // 
            // CIQTY
            // 
            this.CIQTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CIQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CIQTY.AppearanceCell.Options.UseBackColor = true;
            this.CIQTY.AppearanceCell.Options.UseFont = true;
            this.CIQTY.AppearanceCell.Options.UseForeColor = true;
            this.CIQTY.AppearanceCell.Options.UseTextOptions = true;
            this.CIQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CIQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CIQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CIQTY.AppearanceHeader.Options.UseBackColor = true;
            this.CIQTY.Caption = "Bonded Area";
            this.CIQTY.FieldName = "CIQTY";
            this.CIQTY.MinWidth = 25;
            this.CIQTY.Name = "CIQTY";
            this.CIQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIQTY", "{0:#,##;-0:#,##}")});
            this.CIQTY.Visible = true;
            this.CIQTY.VisibleIndex = 8;
            this.CIQTY.Width = 124;
            // 
            // BCIQTY
            // 
            this.BCIQTY.AppearanceCell.Options.UseTextOptions = true;
            this.BCIQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BCIQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BCIQTY.Caption = "Bonded Area Box";
            this.BCIQTY.FieldName = "BCIQTY";
            this.BCIQTY.MinWidth = 25;
            this.BCIQTY.Name = "BCIQTY";
            this.BCIQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BCIQTY", "{0:#,##;-0:#,##}")});
            this.BCIQTY.Width = 145;
            // 
            // IQTY
            // 
            this.IQTY.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQTY.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.IQTY.AppearanceCell.Options.UseBackColor = true;
            this.IQTY.AppearanceCell.Options.UseFont = true;
            this.IQTY.AppearanceCell.Options.UseForeColor = true;
            this.IQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.IQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IQTY.Caption = "Transfer";
            this.IQTY.FieldName = "IQTY";
            this.IQTY.MinWidth = 25;
            this.IQTY.Name = "IQTY";
            this.IQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IQTY", "{0:#,##;-0:#,##}")});
            this.IQTY.Visible = true;
            this.IQTY.VisibleIndex = 9;
            this.IQTY.Width = 124;
            // 
            // IBQTY
            // 
            this.IBQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IBQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IBQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IBQTY.Caption = "Transfer Box";
            this.IBQTY.FieldName = "IBQTY";
            this.IBQTY.MinWidth = 25;
            this.IBQTY.Name = "IBQTY";
            this.IBQTY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IBQTY", "{0:#,##;-0:#,##}")});
            this.IBQTY.Width = 124;
            // 
            // bandGridView
            // 
            this.bandGridView.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandGridView.Appearance.BandPanel.Options.UseFont = true;
            this.bandGridView.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandGridView.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandGridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.infoBuyer,
            this.InfoQty,
            this.gridBand2,
            this.gridBand3});
            this.bandGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.BCVCOD,
            this.BCVNAS,
            this.BITNBR,
            this.BITEMNAME,
            this.BITDSC,
            this.CIQTYB,
            this.BCIQTYB,
            this.IQTYB,
            this.BIQTYB,
            this.JQTYB,
            this.JBQTYB,
            this.TQTYB});
            this.bandGridView.GridControl = this.Grid;
            this.bandGridView.Name = "bandGridView";
            this.bandGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.bandGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.bandGridView.OptionsBehavior.Editable = false;
            this.bandGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandGridView.OptionsView.ShowFooter = true;
            this.bandGridView.OptionsView.ShowGroupPanel = false;
            // 
            // infoBuyer
            // 
            this.infoBuyer.AppearanceHeader.BackColor = System.Drawing.Color.Silver;
            this.infoBuyer.AppearanceHeader.Options.UseBackColor = true;
            this.infoBuyer.AppearanceHeader.Options.UseTextOptions = true;
            this.infoBuyer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.infoBuyer.Caption = "RelationBuyerInfomation.";
            this.infoBuyer.Columns.Add(this.BCVCOD);
            this.infoBuyer.Columns.Add(this.BCVNAS);
            this.infoBuyer.Columns.Add(this.BITNBR);
            this.infoBuyer.Columns.Add(this.BITEMNAME);
            this.infoBuyer.Columns.Add(this.BITDSC);
            this.infoBuyer.MinWidth = 13;
            this.infoBuyer.Name = "infoBuyer";
            this.infoBuyer.VisibleIndex = 0;
            this.infoBuyer.Width = 970;
            // 
            // BCVCOD
            // 
            this.BCVCOD.Caption = "Buyer";
            this.BCVCOD.FieldName = "CVCOD";
            this.BCVCOD.MinWidth = 33;
            this.BCVCOD.Name = "BCVCOD";
            this.BCVCOD.Width = 52;
            // 
            // BCVNAS
            // 
            this.BCVNAS.Caption = "Buyer Name";
            this.BCVNAS.FieldName = "CVNAS";
            this.BCVNAS.MinWidth = 33;
            this.BCVNAS.Name = "BCVNAS";
            this.BCVNAS.Visible = true;
            this.BCVNAS.Width = 280;
            // 
            // BITNBR
            // 
            this.BITNBR.Caption = "ITEM";
            this.BITNBR.FieldName = "ITNBR";
            this.BITNBR.MinWidth = 33;
            this.BITNBR.Name = "BITNBR";
            this.BITNBR.Visible = true;
            this.BITNBR.Width = 230;
            // 
            // BITEMNAME
            // 
            this.BITEMNAME.Caption = "Buyer Item";
            this.BITEMNAME.FieldName = "ITEMNAME";
            this.BITEMNAME.MinWidth = 33;
            this.BITEMNAME.Name = "BITEMNAME";
            this.BITEMNAME.Visible = true;
            this.BITEMNAME.Width = 230;
            // 
            // BITDSC
            // 
            this.BITDSC.Caption = "Item name(HH)";
            this.BITDSC.FieldName = "ITDSC";
            this.BITDSC.MinWidth = 33;
            this.BITDSC.Name = "BITDSC";
            this.BITDSC.Visible = true;
            this.BITDSC.Width = 230;
            // 
            // InfoQty
            // 
            this.InfoQty.AppearanceHeader.BackColor = System.Drawing.Color.Maroon;
            this.InfoQty.AppearanceHeader.Options.UseBackColor = true;
            this.InfoQty.AppearanceHeader.Options.UseTextOptions = true;
            this.InfoQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.InfoQty.Caption = "Information Moving Qty";
            this.InfoQty.Columns.Add(this.CIQTYB);
            this.InfoQty.Columns.Add(this.BCIQTYB);
            this.InfoQty.Columns.Add(this.IQTYB);
            this.InfoQty.Columns.Add(this.BIQTYB);
            this.InfoQty.Name = "InfoQty";
            this.InfoQty.VisibleIndex = 1;
            this.InfoQty.Width = 283;
            // 
            // CIQTYB
            // 
            this.CIQTYB.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CIQTYB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIQTYB.AppearanceCell.ForeColor = System.Drawing.Color.DarkCyan;
            this.CIQTYB.AppearanceCell.Options.UseBackColor = true;
            this.CIQTYB.AppearanceCell.Options.UseFont = true;
            this.CIQTYB.AppearanceCell.Options.UseForeColor = true;
            this.CIQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.CIQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CIQTYB.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.CIQTYB.AppearanceHeader.Options.UseBackColor = true;
            this.CIQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.CIQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CIQTYB.Caption = "Bonded Area QTY";
            this.CIQTYB.DisplayFormat.FormatString = "###,###,###";
            this.CIQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CIQTYB.FieldName = "CIQTY";
            this.CIQTYB.MinWidth = 33;
            this.CIQTYB.Name = "CIQTYB";
            this.CIQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIQTY", "{0:#,##;-0:#,##}")});
            this.CIQTYB.Visible = true;
            this.CIQTYB.Width = 144;
            // 
            // BCIQTYB
            // 
            this.BCIQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.BCIQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BCIQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.BCIQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BCIQTYB.Caption = "Bonded Area BOX";
            this.BCIQTYB.DisplayFormat.FormatString = "###,###,###";
            this.BCIQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BCIQTYB.FieldName = "BCIQTY";
            this.BCIQTYB.MinWidth = 33;
            this.BCIQTYB.Name = "BCIQTYB";
            this.BCIQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BCIQTY", "{0:#,##;-0:#,##}")});
            this.BCIQTYB.Width = 129;
            // 
            // IQTYB
            // 
            this.IQTYB.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IQTYB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQTYB.AppearanceCell.ForeColor = System.Drawing.Color.DarkCyan;
            this.IQTYB.AppearanceCell.Options.UseBackColor = true;
            this.IQTYB.AppearanceCell.Options.UseFont = true;
            this.IQTYB.AppearanceCell.Options.UseForeColor = true;
            this.IQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.IQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IQTYB.AppearanceHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.IQTYB.AppearanceHeader.Options.UseBackColor = true;
            this.IQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.IQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IQTYB.Caption = "Transfer QTY";
            this.IQTYB.DisplayFormat.FormatString = "###,###,###";
            this.IQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IQTYB.FieldName = "IQTY";
            this.IQTYB.MinWidth = 33;
            this.IQTYB.Name = "IQTYB";
            this.IQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IQTY", "{0:#,##;-0:#,##}")});
            this.IQTYB.Visible = true;
            this.IQTYB.Width = 139;
            // 
            // BIQTYB
            // 
            this.BIQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.BIQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BIQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.BIQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BIQTYB.Caption = "Transfer BOX";
            this.BIQTYB.DisplayFormat.FormatString = "###,###,###";
            this.BIQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BIQTYB.FieldName = "BIQTY";
            this.BIQTYB.MinWidth = 33;
            this.BIQTYB.Name = "BIQTYB";
            this.BIQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BIQTY", "{0:#,##;-0:#,##}")});
            this.BIQTYB.Width = 111;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.Maroon;
            this.gridBand2.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Information Warehouse Qty";
            this.gridBand2.Columns.Add(this.JQTYB);
            this.gridBand2.Columns.Add(this.JBQTYB);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 273;
            // 
            // JQTYB
            // 
            this.JQTYB.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.JQTYB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JQTYB.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JQTYB.AppearanceCell.Options.UseBackColor = true;
            this.JQTYB.AppearanceCell.Options.UseFont = true;
            this.JQTYB.AppearanceCell.Options.UseForeColor = true;
            this.JQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.JQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JQTYB.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JQTYB.AppearanceHeader.Options.UseBackColor = true;
            this.JQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.JQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JQTYB.Caption = "Warehouse QTY";
            this.JQTYB.DisplayFormat.FormatString = "###,###,###";
            this.JQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JQTYB.FieldName = "JQTY";
            this.JQTYB.MinWidth = 33;
            this.JQTYB.Name = "JQTYB";
            this.JQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JQTY", "{0:#,##;-0:#,##}")});
            this.JQTYB.Visible = true;
            this.JQTYB.Width = 133;
            // 
            // JBQTYB
            // 
            this.JBQTYB.AppearanceCell.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.JBQTYB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JBQTYB.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JBQTYB.AppearanceCell.Options.UseBackColor = true;
            this.JBQTYB.AppearanceCell.Options.UseFont = true;
            this.JBQTYB.AppearanceCell.Options.UseForeColor = true;
            this.JBQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.JBQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.JBQTYB.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.JBQTYB.AppearanceHeader.Options.UseBackColor = true;
            this.JBQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.JBQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.JBQTYB.Caption = "Warehouse BOX";
            this.JBQTYB.DisplayFormat.FormatString = "###,###,###";
            this.JBQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JBQTYB.FieldName = "JBQTY";
            this.JBQTYB.MinWidth = 33;
            this.JBQTYB.Name = "JBQTYB";
            this.JBQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JBQTY", "{0:#,##;-0:#,##}")});
            this.JBQTYB.Visible = true;
            this.JBQTYB.Width = 140;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.BackColor = System.Drawing.Color.Maroon;
            this.gridBand3.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Information Total QTY. ";
            this.gridBand3.Columns.Add(this.TQTYB);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 248;
            // 
            // TQTYB
            // 
            this.TQTYB.AppearanceCell.BackColor = System.Drawing.SystemColors.Control;
            this.TQTYB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TQTYB.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TQTYB.AppearanceCell.Options.UseBackColor = true;
            this.TQTYB.AppearanceCell.Options.UseFont = true;
            this.TQTYB.AppearanceCell.Options.UseForeColor = true;
            this.TQTYB.AppearanceCell.Options.UseTextOptions = true;
            this.TQTYB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TQTYB.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TQTYB.AppearanceHeader.Options.UseBackColor = true;
            this.TQTYB.AppearanceHeader.Options.UseTextOptions = true;
            this.TQTYB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TQTYB.Caption = "Total QTY";
            this.TQTYB.DisplayFormat.FormatString = "###,###,###";
            this.TQTYB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TQTYB.FieldName = "TQTY";
            this.TQTYB.MinWidth = 33;
            this.TQTYB.Name = "TQTYB";
            this.TQTYB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TQTY", "{0:#,##;-0:#,##}")});
            this.TQTYB.Visible = true;
            this.TQTYB.Width = 248;
            // 
            // FrmStockViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmStockViewList";
            this.Size = new System.Drawing.Size(1800, 1083);
            this.Load += new System.EventHandler(this.FrmStockViewList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.ComboBox cbxStat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandGridView;
        private System.Windows.Forms.CheckBox chktot;
        private System.Windows.Forms.ComboBox cbxWh;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn CVCOD;
        private DevExpress.XtraGrid.Columns.GridColumn CVNAS;
        private DevExpress.XtraGrid.Columns.GridColumn ITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn ITEMNANME;
        private DevExpress.XtraGrid.Columns.GridColumn ITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn CIQTY;
        private DevExpress.XtraGrid.Columns.GridColumn BCIQTY;
        private DevExpress.XtraGrid.Columns.GridColumn IQTY;
        private DevExpress.XtraGrid.Columns.GridColumn IBQTY;
        private DevExpress.XtraGrid.Columns.GridColumn JQTY;
        private DevExpress.XtraGrid.Columns.GridColumn JBQTY;
        private DevExpress.XtraGrid.Columns.GridColumn TQTY;
        private DevExpress.XtraGrid.Columns.GridColumn INVOICE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BCVCOD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BCVNAS;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BITNBR;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BITEMNAME;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BITDSC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CIQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BCIQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn IQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BIQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn JQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn JBQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TQTYB;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand infoBuyer;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand InfoQty;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnPrt;
    }
}
