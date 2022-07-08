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
using System.Globalization;

namespace conStock.Page
{
    public partial class FrmStockView : UserControl
    {
        public FrmStockView()
        {
            InitializeComponent();

            SetComboList();
        }

        private void SetComboList()  // 콤보셋팅 -- 공통으로
        {
            MainSetting.SetComboBXSetting(cbxWh, "WHNAME", "WHCODE");
            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", "SH2");
            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            
        }
        private string[] aaa = new string[10];
        private void btnQuery_Click(object sender, EventArgs e)
        {
            MainSetting.ChkCombNull(cbxCust);
            string whcode = ""; string localInvoice = ""; string item = ""; string cust = "";
            if (string.IsNullOrEmpty(cbxWh.SelectedValue.ToString())) {  whcode = "%"; } else {  whcode = cbxWh.SelectedValue.ToString(); }
            if (string.IsNullOrEmpty(dateTimePicker1.Value.ToString("yyyy-MM-dd"))) { return; }
            if (string.IsNullOrEmpty(dateTimePicker2.Value.ToString("yyyy-MM-dd"))) { return; }
            if (string.IsNullOrEmpty(txtLocalInvoice.Text)) {  localInvoice = "%"; } else {  localInvoice = txtLocalInvoice.Text; }
            if (string.IsNullOrEmpty(txtItem.Text)) {  item = "%"; } else {  item = txtItem.Text; }
            if (string.IsNullOrEmpty(cbxCust.SelectedValue.ToString())) {  cust = "%"; } else {  cust = cbxCust.SelectedValue.ToString(); }
            string from = dateTimePicker1.Value.ToString("yyyy-MM-dd").Replace("-","");
            string to = dateTimePicker2.Value.ToString("yyyy-MM-dd").Replace("-", "");
            //Query.QueryParm = new Dictionary<string, string>() { { "SALESCOD", cust } };
            //cust = MainSetting.SetSalesCustQueryString(cust);

            Query.QueryParm = new Dictionary<string, string>() { { "FROM", from } };
            Query.QueryParm.Add("TO", to);
            Query.QueryParm.Add("WHCODE", whcode);
            Query.QueryParm.Add("LOCALINVOICE", localInvoice);
            Query.QueryParm.Add("ITEM", item);
            Query.QueryParm.Add("CUST", cust);


            Grid.DataSource = Query.StockView();

            gridView.IndicatorWidth = 30;
        }

        private void cbxWh_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainSetting.ChkCombNull(cbxCust);
            MainSetting.SetComboBXWhCust(cbxCust, "CVNAS", "CVCOD", cbxWh.SelectedValue.ToString());

        }

        /// <summary>
        /// 실제 거래처의 영업거래처명을 선택했을때 원래 거래처 코드로 조회값 가져오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string cbxcusttext = "";
            //if (cbxCust.SelectedValue.ToString() == null) { cbxcusttext = "%"; } else { cbxcusttext = cbxCust.SelectedValue.ToString(); }
            //if (cbxcusttext == "") { cbxcusttext = "%"; }
            //Query.QueryParm = new Dictionary<string, string>() { { "SALESCOD", cbxcusttext } };
            //MainSetting.SetSalesCustQueryString(cbxcusttext);

            //DataTable dt = Query.SalesCustGet();

            //for (int i = 1; i < dt.Rows.Count + 1; i++)
            //{
            //     if (i == dt.Rows.Count)
            //        {
            //            foreach (DataRow row in dt.Rows)
            //            {
            //                strcvcod = strcvcod + row["CVCOD"].ToString();
            //            }
            //        }
            //     else
            //        {
            //            foreach (DataRow row in dt.Rows)
            //            {
            //                strcvcod = strcvcod + row["CVCOD"].ToString() + ",";
            //            }
            //        }

            //}
            //// 여기 거래처 셋팅하자, this의 form private string 으로

        }

        private void cbxCust_ValueMemberChanged(object sender, EventArgs e)
        {
            string cbxcusttext = "";
            if (cbxCust.SelectedValue.ToString() == null) { cbxcusttext = "%"; } else { cbxcusttext = cbxCust.SelectedValue.ToString(); }
            if (cbxcusttext == "") { cbxcusttext = "%"; }
            Query.QueryParm = new Dictionary<string, string>() { { "SALESCOD", cbxcusttext } };
            MainSetting.SetSalesCustQueryString(cbxcusttext);
        }
    }
}
