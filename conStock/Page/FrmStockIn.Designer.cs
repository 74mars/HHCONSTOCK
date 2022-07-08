namespace conStock.Page
{
    partial class FrmStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockIn));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.cbxInvoice = new System.Windows.Forms.ComboBox();
            this.cbxWh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cbxStat = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ARRDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.CVNAS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SHIPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INVOICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITDSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BUNBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CVCOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EXPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCompany = new System.Windows.Forms.ComboBox();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1629, 1048);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.Color.LightGray;
            this.pnlQuery.Controls.Add(this.txtInvoice);
            this.pnlQuery.Controls.Add(this.cbxCompany);
            this.pnlQuery.Controls.Add(this.label7);
            this.pnlQuery.Controls.Add(this.dateTimePicker2);
            this.pnlQuery.Controls.Add(this.cbxInvoice);
            this.pnlQuery.Controls.Add(this.cbxWh);
            this.pnlQuery.Controls.Add(this.label6);
            this.pnlQuery.Controls.Add(this.label5);
            this.pnlQuery.Controls.Add(this.btnCancel);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnSave);
            this.pnlQuery.Controls.Add(this.cbxStat);
            this.pnlQuery.Controls.Add(this.cbxItem);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuery.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlQuery.Location = new System.Drawing.Point(3, 3);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1623, 104);
            this.pnlQuery.TabIndex = 1;
            // 
            // cbxInvoice
            // 
            this.cbxInvoice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInvoice.FormattingEnabled = true;
            this.cbxInvoice.Location = new System.Drawing.Point(469, 59);
            this.cbxInvoice.Name = "cbxInvoice";
            this.cbxInvoice.Size = new System.Drawing.Size(182, 25);
            this.cbxInvoice.TabIndex = 14;
            this.cbxInvoice.Visible = false;
            // 
            // cbxWh
            // 
            this.cbxWh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWh.FormattingEnabled = true;
            this.cbxWh.Location = new System.Drawing.Point(114, 58);
            this.cbxWh.Name = "cbxWh";
            this.cbxWh.Size = new System.Drawing.Size(237, 25);
            this.cbxWh.TabIndex = 13;
            this.cbxWh.SelectedIndexChanged += new System.EventHandler(this.cbxWh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Warehouse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(961, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Arrive date Set";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(1279, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 44);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Invoice No";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(1154, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE IN";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxStat
            // 
            this.cbxStat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStat.FormattingEnabled = true;
            this.cbxStat.Location = new System.Drawing.Point(469, 16);
            this.cbxStat.Name = "cbxStat";
            this.cbxStat.Size = new System.Drawing.Size(182, 25);
            this.cbxStat.TabIndex = 2;
            this.cbxStat.SelectedIndexChanged += new System.EventHandler(this.cbxStat_SelectedIndexChanged);
            // 
            // cbxItem
            // 
            this.cbxItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(723, 60);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(221, 25);
            this.cbxItem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(662, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buyer";
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.ImageOptions.Image")));
            this.btnQuery.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnQuery.Location = new System.Drawing.Point(1153, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 44);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Search";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Status";
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 113);
            this.Grid.MainView = this.gridView;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemDateEdit1});
            this.Grid.Size = new System.Drawing.Size(1623, 932);
            this.Grid.TabIndex = 2;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ARRDATE,
            this.CVNAS,
            this.STATUS,
            this.STATNAME,
            this.SHIPDATE,
            this.INVOICE,
            this.ITNBR,
            this.ITDSC,
            this.BUNBR,
            this.IBQTY,
            this.IQTY,
            this.CVCOD,
            this.EXPNO,
            this.CINO});
            this.gridView.GridControl = this.Grid;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView.OptionsSelection.InvertSelection = true;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_SelectionChanged);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            this.gridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_MouseUp);
            this.gridView.Click += new System.EventHandler(this.gridView_Click);
            // 
            // ARRDATE
            // 
            this.ARRDATE.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ARRDATE.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ARRDATE.AppearanceCell.BorderColor = System.Drawing.Color.Maroon;
            this.ARRDATE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARRDATE.AppearanceCell.Options.UseBackColor = true;
            this.ARRDATE.AppearanceCell.Options.UseBorderColor = true;
            this.ARRDATE.AppearanceCell.Options.UseFont = true;
            this.ARRDATE.AppearanceCell.Options.UseTextOptions = true;
            this.ARRDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ARRDATE.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ARRDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARRDATE.AppearanceHeader.Options.UseBackColor = true;
            this.ARRDATE.AppearanceHeader.Options.UseFont = true;
            this.ARRDATE.Caption = "Arrive Date";
            this.ARRDATE.ColumnEdit = this.repositoryItemDateEdit1;
            this.ARRDATE.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.ARRDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ARRDATE.FieldName = "ARRDATE";
            this.ARRDATE.MinWidth = 25;
            this.ARRDATE.Name = "ARRDATE";
            this.ARRDATE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ARRDATE.Visible = true;
            this.ARRDATE.VisibleIndex = 3;
            this.ARRDATE.Width = 104;
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
            // CVNAS
            // 
            this.CVNAS.AppearanceCell.Options.UseTextOptions = true;
            this.CVNAS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.CVNAS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CVNAS.Caption = "Customer Name";
            this.CVNAS.FieldName = "CVNAS";
            this.CVNAS.MinWidth = 25;
            this.CVNAS.Name = "CVNAS";
            this.CVNAS.OptionsColumn.AllowEdit = false;
            this.CVNAS.Visible = true;
            this.CVNAS.VisibleIndex = 2;
            this.CVNAS.Width = 259;
            // 
            // STATUS
            // 
            this.STATUS.AppearanceCell.Options.UseTextOptions = true;
            this.STATUS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STATUS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STATUS.Caption = "Stat";
            this.STATUS.FieldName = "STATUS";
            this.STATUS.MinWidth = 25;
            this.STATUS.Name = "STATUS";
            this.STATUS.OptionsColumn.AllowEdit = false;
            this.STATUS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.STATUS.Width = 81;
            // 
            // STATNAME
            // 
            this.STATNAME.Caption = "STATUS.";
            this.STATNAME.FieldName = "STATNAME";
            this.STATNAME.MinWidth = 25;
            this.STATNAME.Name = "STATNAME";
            this.STATNAME.OptionsColumn.AllowEdit = false;
            this.STATNAME.Visible = true;
            this.STATNAME.VisibleIndex = 4;
            this.STATNAME.Width = 126;
            // 
            // SHIPDATE
            // 
            this.SHIPDATE.AppearanceCell.Options.UseTextOptions = true;
            this.SHIPDATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SHIPDATE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SHIPDATE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHIPDATE.AppearanceHeader.Options.UseFont = true;
            this.SHIPDATE.Caption = "Ship.Date";
            this.SHIPDATE.FieldName = "SHIPDATE";
            this.SHIPDATE.MinWidth = 25;
            this.SHIPDATE.Name = "SHIPDATE";
            this.SHIPDATE.OptionsColumn.AllowEdit = false;
            this.SHIPDATE.Visible = true;
            this.SHIPDATE.VisibleIndex = 1;
            this.SHIPDATE.Width = 101;
            // 
            // INVOICE
            // 
            this.INVOICE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INVOICE.AppearanceCell.Options.UseFont = true;
            this.INVOICE.Caption = "Invoice";
            this.INVOICE.FieldName = "INVOICE";
            this.INVOICE.MinWidth = 25;
            this.INVOICE.Name = "INVOICE";
            this.INVOICE.OptionsColumn.AllowEdit = false;
            this.INVOICE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.INVOICE.Visible = true;
            this.INVOICE.VisibleIndex = 5;
            this.INVOICE.Width = 167;
            // 
            // ITNBR
            // 
            this.ITNBR.Caption = "ITEM";
            this.ITNBR.FieldName = "ITNBR";
            this.ITNBR.MinWidth = 25;
            this.ITNBR.Name = "ITNBR";
            this.ITNBR.OptionsColumn.AllowEdit = false;
            this.ITNBR.Visible = true;
            this.ITNBR.VisibleIndex = 6;
            this.ITNBR.Width = 139;
            // 
            // ITDSC
            // 
            this.ITDSC.Caption = "Description";
            this.ITDSC.FieldName = "ITDSC";
            this.ITDSC.MinWidth = 25;
            this.ITDSC.Name = "ITDSC";
            this.ITDSC.Visible = true;
            this.ITDSC.VisibleIndex = 7;
            this.ITDSC.Width = 210;
            // 
            // BUNBR
            // 
            this.BUNBR.Caption = "Part No.";
            this.BUNBR.FieldName = "BUNBR";
            this.BUNBR.MinWidth = 25;
            this.BUNBR.Name = "BUNBR";
            this.BUNBR.OptionsColumn.AllowEdit = false;
            this.BUNBR.Visible = true;
            this.BUNBR.VisibleIndex = 8;
            this.BUNBR.Width = 206;
            // 
            // IBQTY
            // 
            this.IBQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.IBQTY.AppearanceCell.Options.UseFont = true;
            this.IBQTY.AppearanceCell.Options.UseForeColor = true;
            this.IBQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IBQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IBQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IBQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.IBQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IBQTY.Caption = "Box.Qty";
            this.IBQTY.DisplayFormat.FormatString = "{0:#,###}";
            this.IBQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.IBQTY.FieldName = "IBQTY";
            this.IBQTY.MinWidth = 25;
            this.IBQTY.Name = "IBQTY";
            this.IBQTY.OptionsColumn.AllowEdit = false;
            this.IBQTY.Visible = true;
            this.IBQTY.VisibleIndex = 9;
            this.IBQTY.Width = 111;
            // 
            // IQTY
            // 
            this.IQTY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQTY.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IQTY.AppearanceCell.Options.UseFont = true;
            this.IQTY.AppearanceCell.Options.UseForeColor = true;
            this.IQTY.AppearanceCell.Options.UseTextOptions = true;
            this.IQTY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IQTY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IQTY.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IQTY.AppearanceHeader.Options.UseBackColor = true;
            this.IQTY.Caption = "In Qty";
            this.IQTY.DisplayFormat.FormatString = "{0:#,###}";
            this.IQTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.IQTY.FieldName = "IQTY";
            this.IQTY.MinWidth = 25;
            this.IQTY.Name = "IQTY";
            this.IQTY.OptionsColumn.AllowEdit = false;
            this.IQTY.Visible = true;
            this.IQTY.VisibleIndex = 10;
            this.IQTY.Width = 105;
            // 
            // CVCOD
            // 
            this.CVCOD.Caption = "Customer";
            this.CVCOD.FieldName = "CVCOD";
            this.CVCOD.MinWidth = 25;
            this.CVCOD.Name = "CVCOD";
            this.CVCOD.OptionsColumn.AllowEdit = false;
            this.CVCOD.Width = 94;
            // 
            // EXPNO
            // 
            this.EXPNO.Caption = "expno";
            this.EXPNO.FieldName = "EXPNO";
            this.EXPNO.MinWidth = 25;
            this.EXPNO.Name = "EXPNO";
            this.EXPNO.OptionsColumn.AllowEdit = false;
            this.EXPNO.Width = 94;
            // 
            // CINO
            // 
            this.CINO.Caption = "cino";
            this.CINO.FieldName = "CINO";
            this.CINO.MinWidth = 25;
            this.CINO.Name = "CINO";
            this.CINO.OptionsColumn.AllowEdit = false;
            this.CINO.Width = 95;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // cbxCust
            // 
            this.cbxCust.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(727, 20);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(220, 25);
            this.cbxCust.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.Wheat;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(964, 47);
            this.dateTimePicker2.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 25);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Company";
            // 
            // cbxCompany
            // 
            this.cbxCompany.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.Location = new System.Drawing.Point(114, 15);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(237, 25);
            this.cbxCompany.TabIndex = 16;
            this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(469, 58);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(181, 25);
            this.txtInvoice.TabIndex = 17;
            // 
            // FrmStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxCust);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmStockIn";
            this.Size = new System.Drawing.Size(1629, 1048);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.ComboBox cbxStat;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn INVOICE;
        private DevExpress.XtraGrid.Columns.GridColumn ITNBR;
        private DevExpress.XtraGrid.Columns.GridColumn ITDSC;
        private DevExpress.XtraGrid.Columns.GridColumn IBQTY;
        private DevExpress.XtraGrid.Columns.GridColumn IQTY;
        private DevExpress.XtraGrid.Columns.GridColumn CVCOD;
        private DevExpress.XtraGrid.Columns.GridColumn CVNAS;
        private DevExpress.XtraGrid.Columns.GridColumn EXPNO;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn CINO;
        private DevExpress.XtraGrid.Columns.GridColumn STATNAME;
        private DevExpress.XtraGrid.Columns.GridColumn SHIPDATE;
        private DevExpress.XtraGrid.Columns.GridColumn BUNBR;
        private DevExpress.XtraGrid.Columns.GridColumn ARRDATE;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxWh;
        private System.Windows.Forms.ComboBox cbxInvoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.ComboBox cbxCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvoice;
    }
}
