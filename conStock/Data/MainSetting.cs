using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraReports.UI;
using conStock.Page;
using Conndb;

namespace conStock.Data
{
    public class MainSetting
    {
        public static string gUserID { get; set; }  // user id
        public static string gUserName { get; set; } // user name
        public static string gWhID { get; set; } // warehouse ID
        public static string gWHName { get; set; } // warehouse name


        #region //법인 CHECK
        public static void DivisionCHK(ComboBox cbx)
        {
            if (cbx.SelectedValue.ToString() == "10")
            {
                Conndb.dbConnInfo.Division = "10";
            }
            else
            {
                Conndb.dbConnInfo.Division = "20";
            }
        }

        #endregion

        #region  // Company COMBOBOX Setting
        public static ComboBox CompanySet(ComboBox cbx)
        {
            var company = new Dictionary<string, string>();

            company.Add("20", "HANHO ECOSTI.Co.Ltd");
            company.Add("10", "HANHO.Co.Ltd");
            
            cbx.DataSource = new BindingSource(company, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";

            //cbx.SelectedIndex = 1;

            return cbx;
        }
        
        #endregion

        #region //Array init
        /// <summary>
        /// Array Initialize
        /// </summary>
        /// <param name="cbx"></param>
        /// <returns></returns>
        public static string[] vArrInit(string[] vArr , int arrCnt)
        {
            for (int i = 0; i < arrCnt; i++)
            {
                vArr[i] = "";
            }
            return vArr;
        }

        #endregion

        #region // combobox null check
        public static ComboBox ChkCombNull(ComboBox cbx)
        {
            if (cbx != null)
            {
                if (cbx.SelectedValue == null)
                {
                    cbx.SelectedIndex = cbx.Items.Count - 1;
                }
            }
            return cbx;
        }
        #endregion

        #region // 마지막날짜 구하기
        public static string vYearMonthLastDay(string yearmonth)
        {
            int yy = int.Parse(yearmonth.Substring(0, 4));
            int mon = int.Parse(yearmonth.Substring(4, 2));
            int LastDay = DateTime.DaysInMonth(yy, mon);
            return LastDay.ToString();
        }
        #endregion

        // combobox warehouse setting
        public static ComboBox SetComboBXWhCust(ComboBox cbx, string disValue, string keyValue, string wh)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();

            if (keyValue == "CVCOD")
            {
                Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", wh } };
                DataTable dataCust = Query.SettingWhCustList();
                if (dataCust == null)
                {
                    dataCust.Columns.Add("CVCOD");
                    dataCust.Columns.Add("CVNAS");
                }
                cbx.DataSource = dataCust;

                dataCust.Rows.Add(new string[] { "", "" });
                cbx.SelectedIndex = dataCust.Rows.Count - 1;
            }

            cbx.DisplayMember = disValue;
            cbx.ValueMember = keyValue;

            return cbx;
        }

        #region  // combobox setting para value에 따라

        public static ComboBox SetComboBXSetting(ComboBox cbx,string disValue, string keyValue)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();
            //DataTable dataCBX;

            if (keyValue == "CVCOD")
            { 
                DataTable dataCust = Query.SettingCustList();
                if (dataCust == null)
                {
                    dataCust.Columns.Add("CVCOD");
                    dataCust.Columns.Add("CVNAS");
                }
                cbx.DataSource = dataCust;
                
                dataCust.Rows.Add(new string[] { "", "" });
                cbx.SelectedIndex = dataCust.Rows.Count - 1;
            }
            else if (keyValue == "ITNBR")
            {
                DataTable dataItem = Query.SettingItemList();
                if (dataItem == null)
                {
                    dataItem.Columns.Add("ITNBR");
                    dataItem.Columns.Add("ITDSC");
                }
                cbx.DataSource = dataItem;
                
                dataItem.Rows.Add(new string[] { "", "" });
                cbx.SelectedIndex = dataItem.Rows.Count - 1;
            }
            else if (keyValue == "WHCODE")
            {
                DataTable datawh = Query.SettingWarehouseLocList();
                if (datawh == null)
                {
                    datawh.Columns.Add("WHCODE");
                    datawh.Columns.Add("WHNAME");
                }
                cbx.DataSource = datawh;

                //datawh.Rows.Add(new string[] { "", "" });
                cbx.SelectedIndex = 0;
            }
            else if (keyValue == "INVOICE")
            {
                DataTable datainvoice = Query.SettingInvoiceList();
                if (datainvoice == null)
                {
                    datainvoice.Columns.Add("INVOICE");
                    datainvoice.Columns.Add("INVOICENAME");
                }
                cbx.DataSource = datainvoice;

                datainvoice.Rows.Add(new string[] { "", "" });
                cbx.SelectedIndex = datainvoice.Rows.Count - 1;
            }
            else
            {

            }
            cbx.DisplayMember = disValue;
            cbx.ValueMember = keyValue;

            return cbx;
        }

        #endregion

        #region    // Tora의 경우 영업 거래처에 따라 조회 및 comboSetting함 Query String Setting.
        public static string SetSalesCustQueryString(string QueryCust)
        {
            string strSalescvcod = ""; 
            DataTable dt = Query.SalesCustGet();

            if (dt.Rows.Count == 0) { return "%"; }

            foreach (DataRow row in dt.Rows)
            {
                strSalescvcod = strSalescvcod + "'" + row["CVCOD"].ToString() + "',";
                
            }

            //for (int i = 0; i < dt.Rows.Count + 1; i++)
            //{
            //    if (i == dt.Rows.Count)
            //    {
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            strSalescvcod = strSalescvcod + row["CVCOD"].ToString();
            //        }
            //    }
            //    else
            //    {
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            strSalescvcod = strSalescvcod + row["CVCOD"].ToString() + ",";
            //        }
            //    }

            //}
            // 여기 거래처 셋팅하자, this의 form private string 으로
            int cnt = strSalescvcod.Length;
            strSalescvcod = strSalescvcod.Substring(0, cnt - 1);
            return strSalescvcod;
        }
        #endregion

        #region // DATA Format Check
        public static bool isDateCheck(string date)
        {
            return Regex.IsMatch(date, @"^(19|20)\d{2}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[0-1])$");
        }

        #endregion

        #region //gridcontrol excel export
        //Dev GridControl Excel Export
        public static void GridToExcel(GridControl Grid )
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Excel (2003)(.xls)|*.xls|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = saveDialog.FileName;
                string fileExtension = new FileInfo(exportFilePath).Extension;
                switch (fileExtension)
                {
                    case ".xls":
                        Grid.ExportToXls(exportFilePath);
                        break;
                    case ".xlsx":
                        Grid.ExportToXlsx(exportFilePath);
                        break;
                    case ".rtf":
                        Grid.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        Grid.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        Grid.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        Grid.ExportToMht(exportFilePath);
                        break;
                    default:
                        break;

                }
                if (File.Exists(exportFilePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(exportFilePath);
                    }
                    catch
                    {
                        String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region //특정 문자열로 채우기
        //특정 문자열로 채우기
        public static string StringStrFull(int str, char fullStr, int strCnt)
        {
            string reStr = str.ToString().PadLeft(strCnt , fullStr);
            return reStr;
        }
        #endregion

        #region //Invoice Print
        public static void vInvoicePrint(string vInvoice, string vLinvoice, string vOutDate, string vIojpno)
        {
            string sql = "";
            try
            {
                sql = "select a.*, b.*, c.*, (b.addr1||b.addr2) as addr, " + vInvoice + " as inv , (select distinct sudat from imhist_loc where iogbn = 'O02' and ref3 = " + vInvoice + ") as sudat ";
                sql = sql + "from (select b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as partno, cvcod as pcvcod,ref4, io_date, depot_out as pdepot_out, fioprc, ";
                sql = sql + "d.itemamt, d.itemprc, d.freightamt, d.freightprc, d.rawamt, d.rawprc, d.totamt as totamt, d.loading as ploading, d.carrier as pcarrier, d.onboard, d.pickdate, d.po_a_date, d.marks1, d.marks2, d.marks3, d.marks4, d.lcissue1, d.lcissue2, d.lcissue3, ";
                sql = sql + " sum(ioqty) as ioqty, sum(ioreqty) as ioreqty, sum(fioamt) as fioamt, sum(nvl(dref4,0)) as dref4, sum(nvl(fioamt,0) + nvl(dref4,0)) as ptotamt  from imhist_loc a join itemas b on a.itnbr = b.itnbr ";
                sql = sql + string.Format(" left join STOCK_LOCALINVOICE_INFO d on a.ref4 = d.locinvoice where ref4 = {0} ", vLinvoice);
                //sql = sql + string.Format("where io_date in ({0}) and ref4 = {1} and iojpno = {2} ",vOutDate, vLinvoice, vIojpno);
                sql = sql + " group by b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod), cvcod, ref4, io_date, depot_out, fioprc, ";
                sql = sql + " d.itemamt, d.itemprc, d.freightamt, d.freightprc, d.rawamt, d.rawprc, d.totamt, d.loading, d.carrier, d.onboard, d.pickdate, d.po_a_date, d.marks1, d.marks2, d.marks3, d.marks4, d.lcissue1, d.lcissue2, d.lcissue3) a ";
                sql = sql + " join inv_company  b on b.eff_date <= a.io_date and b.end_date >= a.io_date and a.pdepot_out = b.use_wh ";
                sql = sql + " join inv_buyer_info c on a.pcvcod = c.cvcod and a.pdepot_out = c.use_wh and c.eff_date <= a.io_date and c.end_date >= a.io_date ";

                DataSet dtPrt = Query.PrtInvoiceGet(sql);

                //dtPrt = Query.PrtInvoiceGet(sql);

                ToraInvoice report = new ToraInvoice(dtPrt);
                ReportPrintTool printTool = new ReportPrintTool(report);
                //printTool.Print();
                printTool.ShowPreview();
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region // Grid DAY Check
        //public static string GridDayChk(string iodate)
        //{

        //}


        #endregion

        #region // Quarter 가져오기
        public static string GetQuarter(DateTime date)
        {
            if (date.Month >= 4 && date.Month <= 6)
                return "Q2\n (04/01/" + date.Year.ToString() + "~06/30/" + date.Year.ToString() + ")";
            else if (date.Month >= 7 && date.Month <= 9)
                return "Q3\n (07/01/" + date.Year.ToString() + "~09/30/" + date.Year.ToString() + ")";
            else if (date.Month >= 10 && date.Month <= 12)
                return "Q4\n (10/01/" + date.Year.ToString() + "~12/31/" + date.Year.ToString() + ")";
            else
                return "Q1\n (01/01/" + date.Year.ToString() + "~03/31/" + date.Year.ToString() + ")";
        }


        #endregion

    }
}
