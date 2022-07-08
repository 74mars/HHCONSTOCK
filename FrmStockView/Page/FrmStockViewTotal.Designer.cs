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
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.invoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itnbr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itdsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ispec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jbqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ibqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.obqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cvcod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cvnas = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.gridView;
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1720, 708);
            this.Grid.TabIndex = 0;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.invoice,
            this.itnbr,
            this.itdsc,
            this.ispec,
            this.jbqty,
            this.jqty,
            this.ibqty,
            this.obqty,
            this.oqty,
            this.cvcod,
            this.cvnas});
            this.gridView.GridControl = this.Grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.AllowCellMerge = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            // 
            // invoice
            // 
            this.invoice.Caption = "Invoice NO(HanHo)";
            this.invoice.FieldName = "invoice";
            this.invoice.MinWidth = 25;
            this.invoice.Name = "invoice";
            this.invoice.Visible = true;
            this.invoice.VisibleIndex = 0;
            this.invoice.Width = 207;
            // 
            // itnbr
            // 
            this.itnbr.Caption = "Item Code";
            this.itnbr.FieldName = "itnbr";
            this.itnbr.MinWidth = 25;
            this.itnbr.Name = "itnbr";
            this.itnbr.Width = 116;
            // 
            // itdsc
            // 
            this.itdsc.Caption = "Item Name";
            this.itdsc.FieldName = "itdsc";
            this.itdsc.MinWidth = 25;
            this.itdsc.Name = "itdsc";
            this.itdsc.Visible = true;
            this.itdsc.VisibleIndex = 1;
            this.itdsc.Width = 261;
            // 
            // ispec
            // 
            this.ispec.Caption = "Item Spec.";
            this.ispec.FieldName = "ispec";
            this.ispec.MinWidth = 25;
            this.ispec.Name = "ispec";
            this.ispec.Width = 267;
            // 
            // jbqty
            // 
            this.jbqty.Caption = "Stock B Qty.";
            this.jbqty.FieldName = "jbqty";
            this.jbqty.MinWidth = 25;
            this.jbqty.Name = "jbqty";
            this.jbqty.Visible = true;
            this.jbqty.VisibleIndex = 3;
            this.jbqty.Width = 149;
            // 
            // jqty
            // 
            this.jqty.Caption = "Stock Qty";
            this.jqty.FieldName = "jqty";
            this.jqty.MinWidth = 25;
            this.jqty.Name = "jqty";
            this.jqty.Visible = true;
            this.jqty.VisibleIndex = 4;
            this.jqty.Width = 149;
            // 
            // ibqty
            // 
            this.ibqty.Caption = "In B Qty.";
            this.ibqty.FieldName = "ibqty";
            this.ibqty.MinWidth = 25;
            this.ibqty.Name = "ibqty";
            this.ibqty.Visible = true;
            this.ibqty.VisibleIndex = 5;
            this.ibqty.Width = 143;
            // 
            // obqty
            // 
            this.obqty.Caption = "Out B Qty";
            this.obqty.FieldName = "obqty";
            this.obqty.MinWidth = 25;
            this.obqty.Name = "obqty";
            this.obqty.Visible = true;
            this.obqty.VisibleIndex = 6;
            this.obqty.Width = 150;
            // 
            // oqty
            // 
            this.oqty.Caption = "Out Qty.";
            this.oqty.FieldName = "oqty";
            this.oqty.MinWidth = 25;
            this.oqty.Name = "oqty";
            this.oqty.Visible = true;
            this.oqty.VisibleIndex = 7;
            this.oqty.Width = 156;
            // 
            // cvcod
            // 
            this.cvcod.Caption = "Client";
            this.cvcod.FieldName = "cvcod";
            this.cvcod.MinWidth = 25;
            this.cvcod.Name = "cvcod";
            this.cvcod.Width = 107;
            // 
            // cvnas
            // 
            this.cvnas.Caption = "Client Name";
            this.cvnas.FieldName = "cvnas";
            this.cvnas.MinWidth = 25;
            this.cvnas.Name = "cvnas";
            this.cvnas.Visible = true;
            this.cvnas.VisibleIndex = 8;
            this.cvnas.Width = 236;
            // 
            // FrmStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmStockView";
            this.Size = new System.Drawing.Size(1720, 708);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn invoice;
        private DevExpress.XtraGrid.Columns.GridColumn itnbr;
        private DevExpress.XtraGrid.Columns.GridColumn itdsc;
        private DevExpress.XtraGrid.Columns.GridColumn ispec;
        private DevExpress.XtraGrid.Columns.GridColumn jbqty;
        private DevExpress.XtraGrid.Columns.GridColumn jqty;
        private DevExpress.XtraGrid.Columns.GridColumn ibqty;
        private DevExpress.XtraGrid.Columns.GridColumn obqty;
        private DevExpress.XtraGrid.Columns.GridColumn oqty;
        private DevExpress.XtraGrid.Columns.GridColumn cvcod;
        private DevExpress.XtraGrid.Columns.GridColumn cvnas;
    }
}
