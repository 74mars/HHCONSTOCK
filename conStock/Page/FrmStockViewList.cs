using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conStock.Data;
using DevExpress.XtraGrid;
using System.IO;

//using DevExpress.XtraEditors;
//using DevExpress.XtraGrid.Views.BandedGrid;

namespace conStock.Page
{
    public partial class FrmStockViewList : UserControl
    {
        public FrmStockViewList()
        {
            InitializeComponent();
    
        }

        private void SetComboList()
        {
            MainSetting.SetComboBXSetting(cbxWh, "WHNAME", "WHCODE");

            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", cbxStat.SelectedValue.ToString());

            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            Query.QueryParm.Add( "CVCOD", cbxCust.SelectedValue.ToString());

            MainSetting.SetComboBXSetting(cbxItem, "ITDSC", "ITNBR");  // 2022.04.26
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (chktot.CheckState == CheckState.Checked)
            {
                Grid.MainView = bandGridView;
                Grid.DataSource = null;
                MainSetting.ChkCombNull(cbxWh);
                Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
                Grid.DataSource = Query.StockViewListTot();
            }
            else {
                //comboNullchk(cbxCust, cbxItem, null);
                MainSetting.ChkCombNull(cbxCust);
                MainSetting.ChkCombNull(cbxItem);
                MainSetting.ChkCombNull(cbxWh);
                Grid.DataSource = null;
                Grid.MainView = gridView;
                Query.QueryParm = new Dictionary<string, string>() { { "LOCATION", cbxStat.SelectedValue.ToString() } };
                Query.QueryParm.Add("CVCOD", cbxCust.SelectedValue.ToString());
                Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());
                Query.QueryParm.Add("WHCODE", cbxWh.SelectedValue.ToString());
                Grid.DataSource = Query.StockViewList();
            }
            gridView.IndicatorWidth = 30;
            //gridView.Columns["IQTY"].GroupIndex = 0;

            //GridGroupSummaryItem gdGoupSumItem = new GridGroupSummaryItem();
            //gdGoupSumItem.FieldName = "IQTY";
            //gdGoupSumItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //gdGoupSumItem.ShowInGroupColumnFooter = gridView.Columns["IQTY"];
            //gdGoupSumItem.DisplayFormat = "{0;n0}";

            //gridView.GroupSummary.Add(gdGoupSumItem);

        }

        private void SetComBoBX()
        {
            var status = new Dictionary<string, string>();
            status.Add("", "Location All");
            status.Add("SH0", "Bonded Area");
            status.Add("SH1", "ON Passage");
            status.Add("SH2", "IN Warehouse");
            

            cbxStat.DataSource = new BindingSource(status, null);
            cbxStat.DisplayMember = "Value";
            cbxStat.ValueMember = "Key";

            cbxStat.SelectedIndex = 0;

            SetComboList();

            gridView.Appearance.HeaderPanel.Font = new Font("Arial",9, FontStyle.Bold);
            bandGridView.Appearance.HeaderPanel.Font = new Font("Arial", 9, FontStyle.Bold);
            //Grid.MainView = bandGridView;

        }

        private void comboNullchk(System.Windows.Forms.ComboBox cbx1, System.Windows.Forms.ComboBox cbx2, System.Windows.Forms.ComboBox cbx3)
        {
            if (cbx1 != null)
            {
                if (cbx1.SelectedValue == null)
                {
                    cbx1.SelectedIndex = cbx1.Items.Count - 1;
                }
            }

            if (cbx2 != null)
            {
                if (cbx2.SelectedValue == null)
                {
                    cbx2.SelectedIndex = cbx2.Items.Count;
                }
            }


            if (cbx3 != null)
            {
                if (cbx3.SelectedValue == null)
                {
                    cbx3.SelectedIndex = cbx3.Items.Count;
                }
            }
        }

        private void FrmStockViewList_Load(object sender, EventArgs e)
        {
            SetComBoBX();
        }

        private void chktot_CheckedChanged(object sender, EventArgs e)
        {
            //if (chktot.Checked == true) { Grid.MainView = bandGridView; }
            //else { Grid.MainView = gridView; }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount <= 0 && bandGridView.RowCount <= 0)
            {
                return;
            }
            
            MainSetting.GridToExcel(Grid);
            
        }

        private void btnPrt_Click(object sender, EventArgs e)
        {
            gridView.OptionsPrint.PrintHeader = true;
            gridView.OptionsPrint.EnableAppearanceEvenRow = true;
            gridView.OptionsPrint.PrintFooter = true;

            //gridView.ShowPrintPreview();
            gridView.ShowRibbonPrintPreview();
        }
    }
}
