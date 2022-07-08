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

namespace conStock.Page
{
    public partial class FrmDeliveryMonthList : UserControl
    {
        public FrmDeliveryMonthList()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")), 1, 1);
            SetComboList();
        }

        #region //combo setting

        private void SetComboList()
        {
            MainSetting.SetComboBXSetting(cbxWh, "WHNAME", "WHCODE");

            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", "%");

            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            Query.QueryParm.Add("CVCOD", cbxCust.SelectedValue.ToString());

        }
        #endregion

        #region // Refresh Query

        private void QueryRefresh()
        {
            string delFrom = ""; string delTo = ""; string cvcod = "%"; string itnbr = "%"; string localinvoice = "%"; string whcode = "%";
            delFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd").Replace("-", "");
            delTo = dateTimePicker2.Value.ToString("yyyy-MM-dd").Replace("-", "");
            MainSetting.ChkCombNull(cbxCust);
            if (cbxCust.SelectedValue.ToString() != "")
            {
                cvcod = cbxCust.SelectedValue.ToString();
            }
            MainSetting.ChkCombNull(cbxWh);
            if (cbxWh.SelectedValue.ToString() != "")
            {
                whcode = cbxWh.SelectedValue.ToString();
            }

            if (txtLocalInvoice.Text != "") { localinvoice = txtLocalInvoice.Text; }
            if (txtItem.Text != "") { itnbr = txtItem.Text; }

            Query.QueryParm = new Dictionary<string, string>() { { "DELIVERYFROM", delFrom } };
            Query.QueryParm.Add("DELIVERYTO", delTo);
            Query.QueryParm.Add("CVCOD", cvcod);
            Query.QueryParm.Add("OUTCURSOR", "DeliveryMstList");
            Query.QueryParm.Add("LOCALINVOICE", localinvoice);
            Query.QueryParm.Add("ITNBR", itnbr);
            Query.QueryParm.Add("WHCODE", whcode);

            GridM.DataSource = Query.StockDeliveryMonthM2();
            //GridM.DataSource = Query.StockDeliveryMonthM(delFrom, delTo);
            GridD.DataSource = null;
        }
        #endregion

        #region // sub Refresh Query
        private void SubQueryRefresh()
        {
            //Query.QueryParm = new Dictionary<string, string>() { { "CVCOD", gridViewM.GetRowCellValue(gridViewM.FocusedRowHandle, gridViewM.Columns["CVCOD"]).ToString() } };
            Query.QueryParm.Add("CVCOD", gridViewM.GetRowCellValue(gridViewM.FocusedRowHandle, gridViewM.Columns["CVCOD"]).ToString());
            Query.QueryParm.Add("ITNBR",gridViewM.GetRowCellValue(gridViewM.FocusedRowHandle, gridViewM.Columns["ITNBR"]).ToString());
            

            GridD.DataSource = Query.StockDeliveryMonthD();
        }
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("yyyy") != dateTimePicker2.Value.ToString("yyyy"))
            {
                MessageBox.Show("If the years are different, the monthly data is summed up, and when searching for details, it is searched based on the start month.", "CAUTION");
            }
            if (dateTimePicker1.Value.ToString("MM") != "01")
            {
                MessageBox.Show("If the start month of the inquiry date is not January Even if the quantity before the start month is 0, the data for the month is searched for detailed inquiry.", "NOTICE");
            }
            QueryRefresh();
        }

        private void gridViewM_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewM.RowCount <= 0)
            {
                return;
            }
            string qryDays = "";
            int ColIdx = gridViewM.FocusedColumn.ColumnHandle;

            if (ColIdx == 20)
            {
                Query.QueryParm = new Dictionary<string, string>() { { "DFROM", dateTimePicker1.Value.ToString("yyyy-MM-dd").Replace("-", "") } };
                Query.QueryParm.Add("DTO", dateTimePicker2.Value.ToString("yyyy-MM-dd").Replace("-", ""));

                SubQueryRefresh();
            }
            else if (ColIdx >= 8 && ColIdx < 20)
            {
                int mon = ColIdx - 7;
                char Pad = '0';
                qryDays = dateTimePicker1.Value.ToString("yyyy") + mon.ToString().PadLeft(2, Pad);
                Query.QueryParm = new Dictionary<string, string>() { { "DFROM", qryDays + "01" } };
                qryDays = dateTimePicker1.Value.ToString("yyyy") + mon.ToString().PadLeft(2, Pad) + MainSetting.vYearMonthLastDay(qryDays);
                Query.QueryParm.Add("DTO", qryDays);

                SubQueryRefresh();
            }
            else
            {
                return;
            }
            #region 
            //SubQueryRefresh();
            //switch (gridViewM.FocusedColumn.FieldName.ToString()) { 
            //        case "JAN_QTY":
            //            qryDays = dateTimePicker1.Value.ToString("yyyy") + "01";
            //            break;
            //        case "FEB_QTY":
            //            qryDays = dateTimePicker1.Value.ToString("yyyy") + "02";
            //            break;
            //        case "MAR_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "APR_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "MAY_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "JUN_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "JUL_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "AUG_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "SEPT_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "OCT_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "NOV_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "DEC_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;
            //        case "TOT_QTY":
            //            qryDays = DateTime.Now.Year.ToString() + "0";
            //            break;

            //}
            #endregion
        }
    }
}
