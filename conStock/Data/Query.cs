using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conndb;

namespace conStock.Data
{
    public class Query
    {
        public static string FactoryCode { get; set; } = "20";
        public static string UserID { get; set; } = "USER ID";
        public static string PassWord { get; set; } = "";
        
        //public class CustList
        //{
        //    public string CustCode { get; set; }
        //    public string CustName { get; set; }
        //}

        //public static List<CustList> custList = new List<CustList>();

        public static Dictionary<string, string> QueryParm { get; set; }

        #region 사용자 체크 Query / 구문
        public static string UserCheck
        {
            get
            {
                string sQuery = string.Format("select user_id,username,'' as whid, '' as whname from login_t where user_id = '{0}' and passwd = '{1}' and LG_saupj = '{2}'", UserID, PassWord, FactoryCode);
                //string sQuery = string.Format("select user_id from login_t where user_id = '{0}' and passwd = '{1}'  ", UserID, PassWord);
                DataTable dt = dbConnSQL.ExecuteSQLReturnDataTable(sQuery);

                if (dt.Rows.Count == 0)
                {
                    return "0";
                }
                else
                {
                    MainSetting.gUserID = dt.Rows[0][0].ToString();
                    MainSetting.gUserName = dt.Rows[0][1].ToString();
                    MainSetting.gWhID = dt.Rows[0][2].ToString();
                    MainSetting.gWHName = dt.Rows[0][3].ToString();

                    return dt.Rows[0][0].ToString();
                }
                
            }
        }
        #endregion

        #region // Local Invoice duplication Check

        public static bool localinvoiceCheck(string ref4)
        {   
            try
            { 
                string sQuery = string.Format("select count(ref4) cnt from imhist_loc where ref4 = '{0}' and iogbn = 'O02' ", ref4);
                DataTable dt = dbConnSQL.ExecuteSQLReturnDataTable(sQuery);

                if (int.Parse(dt.Rows[0][0].ToString()) > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        #endregion

        public static string stringReturn(string sQuery)
        {
            try
            {
                DataTable dt =  dbConnSQL.ExecuteSQLReturnDataTable(sQuery);

                if (dt.Rows.Count == 0)
                {
                    return " ";
                }
                else
                {
                    return dt.Rows[0][0].ToString();
                }

            }
            catch
            {
                return " ";
            }
        }

        /// <summary>재고 있는 거래처</summary>
        /// <returns></returns>
        /// 
        public static DataTable SettingCustList()
        {
            string sQuery = "";

            try
            {
                sQuery = "SELECT DISTINCT B.CVCOD, A.CVNAS FROM VNDMST A JOIN STOCKMONTH_LOC B ON A.CVCOD = B.CVCOD ";
                sQuery = sQuery + string.Format("WHERE ((NVL(JBQTY,0) <> 0 OR NVL(JQTY,0) <> 0) OR (STATUS like '%{0}%')) and DEPOT_NO like '%{1}' ", string.IsNullOrEmpty(QueryParm["STATUS"])? "%" : QueryParm["STATUS"], string.IsNullOrEmpty(QueryParm["WHCODE"])? "%" : QueryParm["WHCODE"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        public static DataTable SettingWhCustList()
        {
            string sQuery = "";
            try
            {
                sQuery = "select distinct b.salescod as cvcod, FUN_GET_VNDSALENAME(a.cvcod) as cvnas from stockmonth_loc a join vndmst_sub b on a.cvcod = b.cvcod ";
                sQuery = sQuery + string.Format(" and a.depot_no like '{0}%' ", Query.QueryParm["WHCODE"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #region // 위탁창고 Setting
        /// <summary>
        /// 위탁창고 Setting
        /// </summary>
        /// <returns></returns>
        public static DataTable SettingWarehouseLocList()
        {
            string sQuery = "";

            try
            {
                sQuery = "select '%' as whcode, 'Total' as whname from dual ";
                sQuery = sQuery + "union all select rfgub as whcode, rfna1 as whname from reffpf where rfcod = '6G' and rfgub<> '00' ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        public static DataTable SettingInvoiceList()
        {
            string sQuery = "";
            try
            {
                sQuery = "select distinct invoice, invoice as invoicename from stockmonth_loc where ";
                sQuery = sQuery + string.Format("depot_no like '%{0}' and status like '%{1}%' and itnbr like '%{2}%' and cvcod like '%{3}%' ", string.IsNullOrEmpty(QueryParm["WHCODE"])? "%" : QueryParm["WHCODE"], string.IsNullOrEmpty(QueryParm["STATUS"]) ? "%" : QueryParm["STATUS"], string.IsNullOrEmpty(QueryParm["ITNBR"]) ? "%" : QueryParm["ITNBR"], string.IsNullOrEmpty(QueryParm["CVCOD"]) ? "%" : QueryParm["CVCOD"]);
                if (QueryParm["STATUS"] == "SH1")
                {
                    sQuery = sQuery + " and nvl(iqty,0) <> 0 and nvl(jqty,0) = 0 order by invoice";
                }
                else if (QueryParm["STATUS"] == "SH2")
                {
                    sQuery = sQuery + " and nvl(jqty,0) <> 0 order by invoice";
                }
                else
                {
                    sQuery = sQuery + " order by invoice";
                }
                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #region // 품목정보-거래처 있을시 해당 거래처 품목만.
        /// <summary> 품목정보-거래처 있을시 해당 거래처 품목만. xxx </summary>
        /// <returns> Datatable</returns>
        public static DataTable SettingItemList()
        {
            string sQuery = "";
            
            try
            {
                sQuery = "select distinct a.itnbr, b.itdsc from stockmonth_loc a join  itemas b on a.itnbr = b.itnbr ";
                sQuery = sQuery + string.Format("where a.cvcod like '%{0}%' and a.depot_no like '%{1}' and a.status like '%{2}%' ", string.IsNullOrEmpty(QueryParm["CVCOD"])? "%" : QueryParm["CVCOD"], string.IsNullOrEmpty(QueryParm["WHCODE"]) ? "%" : QueryParm["WHCODE"], string.IsNullOrEmpty(QueryParm["STATUS"]) ? "%" : QueryParm["STATUS"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }

        }
        #endregion

        public static DataTable SettingCbxList(string queryStr)
        {
            string sQuery = queryStr;

            try
            {
                sQuery = "select distinct invoice, invoice as inv from stockmonth_loc where status like '%";
                sQuery = sQuery + string.Format("{0}%' and cvcod like '%{1}%' and itnbr like '%{2}%'", string.IsNullOrEmpty(QueryParm["STATUS"]) ? "%" : QueryParm["STATUS"], string.IsNullOrEmpty(QueryParm["CVCOD"]) ? "%" : QueryParm["CVCOD"], string.IsNullOrEmpty(QueryParm["ITNBR"]) ? "%" : QueryParm["ITNBR"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }

        }

        #region FrmStockView Query
        /// <summary> FrmStockView Query </summary>
        /// <returns>Datatable</returns>
        public static DataTable StockView()
        {
            string sQuery = "";

            try
            {
                sQuery = "select to_char(to_date(a.io_date,'YYYYMMDD'),'YYYY-MM-DD') as io_date, a.ref4, a.ref3, a.itnbr, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, b.itdsc,a.ioqty, a.ioreqty,  ";
                sQuery = sQuery + "a.fioprc, a.fioamt, a.cunit, a.gumdat, a.cvcod, c.cvnas   from imhist_loc a join itemas b on a.itnbr = b.itnbr join vndmst c on a.cvcod = c.cvcod ";
                sQuery = sQuery + string.Format(" where a.io_date >= '{0}' and a.io_date <= '{1}' and a.depot_no like '{2}%' and a.cvcod like '%{3}%' and a.itnbr like '%{4}%' and ref4 like '%{5}%' ", QueryParm["FROM"], QueryParm["TO"], QueryParm["WHCODE"], QueryParm["CUST"], QueryParm["ITEM"], QueryParm["LOCALINVOICE"]);
                sQuery = sQuery + " order by io_date, a.ref4 ";
                //sQuery = "select a.invoice, a.itnbr, c.itdsc,c.ispec, decode(a.status,'SH1','On Passage','In Warehouse') as status, a. jbqty, a.jqty, a.ibqty, a.iqty, a.obqty, a.oqty,a.cvcod, b.cvnas ";
                //sQuery = sQuery + "from stockMonth_loc a  join vndmst b on a.cvcod = b.cvcod  join itemas c on a.itnbr = c.itnbr ";
                //sQuery = sQuery + string.Format(" where substr(stock_yymm,1,6) = '{0}'", QueryParm["YY_MM"]); 
                ////sQuery = string.Format("select a.invoice, a.itnbr, c.itdsc,c.ispec, a. jbqty, a.jqty, a.ibqty, a.iqty, a.obqty, a.oqty,a.cvcod, b.cvnas from stockMonth_loc a  join vndmst b on a.cvcod = b.cvcod  join itemas c on a.itnbr = c.itnbr where substr(stock_yymm,1,6) = '{0}'", QueryParm["yy_mm"]);
                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region // StockViewList Query

        public static DataTable StockViewList()
        {
            string sQuery = "";
            try
            {
                sQuery = " select M.invoice, M.cvcod, S2.CVNAS, M.itnbr, FUN_GET_ITMBUY_BUNBR(M.itnbr, M.cvcod) as ITEMNANME, S1.ITDSC, to_char(sum(ciqty),'999,999,999,999') as ciqty, sum(bciqty) as bciqty, to_char(sum(iqty),'999,999,999,999') as iqty, sum(ibqty) as ibqty, to_char(sum(jqty),'999,999,999,999') as jqty , sum(jbqty) as jbqty, to_char(sum (ciqty + iqty + jqty),'999,999,999,999') as tqty ";
                sQuery = sQuery + "  from   vw_exp_stock  M join itemas S1 on M.itnbr = S1.itnbr join vndmst S2 on M.cvcod = S2.cvcod ";
                sQuery = sQuery + string.Format("where  m.cvcod like '%{0}%' and m.itnbr like '%{1}%' and m.status like '%{2}%' AND m.depot_no like '%{3}%'", QueryParm["CVCOD"], QueryParm["ITNBR"], QueryParm["LOCATION"], QueryParm["WHCODE"]);
                sQuery = sQuery + " group by M.invoice, M.cvcod, S2.CVNAS, M.itnbr, S1.ITDSC "; // S1.ISPEC, 
                sQuery = sQuery + " order by M.cvcod, M.invoice, S2.CVNAS, M.itnbr, S1.ITDSC "; // S1.ISPEC, 

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region //StockViewListTot Query
        public static DataTable StockViewListTot()
        {
            string sQuery = "";
            try
            {
                //S1.ISPEC, 
                sQuery = "select M.cvcod, S2.CVNAS, M.itnbr,FUN_GET_ITMBUY_BUNBR(M.itnbr, M.cvcod) as ITEMNAME, S1.ITDSC, to_char(sum(ciqty), '999,999,999') as ciqty,sum(bciqty) as bciqty, to_char(sum(iqty), '999,999,999') as iqty, ";
                sQuery = sQuery + "sum(ibqty) as ibqty, to_char(sum(jqty), '999,999,999') as jqty , sum(jbqty) as jbqty, to_char(sum(ciqty + iqty + jqty), '999,999,999') as tqty ";
                sQuery = sQuery + "  from vw_exp_stock M join itemas S1 on M.itnbr = S1.itnbr join vndmst S2 on M.cvcod = S2.cvcod ";
                sQuery = sQuery + string.Format(" where depot_no LIKE '%{0}%' ", QueryParm["WHCODE"]);
                sQuery = sQuery + " group by M.cvcod, S2.CVNAS, M.itnbr, S1.ITDSC "; // S1.ISPEC, 
                sQuery = sQuery + " order by M.cvcod, S2.CVNAS, M.itnbr, S1.ITDSC "; // S1.ISPEC, 

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region // StockIN Query
        public static DataTable Stockin()
        {
            string sQuery = "";

            try
            {
                string stat = QueryParm["STATUS"].ToString();
                if (stat == "SH2")
                {
                    sQuery = "select to_char(to_date(a.arrdate,'YYYYMMDD'),'YYYY-MM-DD') as arrdate, a.status, decode(a.status,'SH1','On Passage', 'In Warehouse') as statname, to_char(to_date(a.stock_YYMM,'YYYYMMDD'),'YYYY-MM-DD') as shipdate, a.invoice, a.itnbr, b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) bunbr, a.ibqty, a.iqty, a.cvcod, c.cvnas,a.expno, a.cino ";
                }
                else
                {
                    sQuery = "select a.arrdate, a.status, decode(a.status,'SH1','On Passage', 'In Warehouse') as statname, to_char(to_date(a.stock_YYMM,'YYYYMMDD'),'YYYY-MM-DD') as shipdate, a.invoice, a.itnbr, b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) bunbr, a.ibqty, a.iqty, a.cvcod, c.cvnas,a.expno, a.cino ";
                }
                
                sQuery = sQuery + " from stockmonth_loc a join itemas b on a.itnbr = b.itnbr join vndmst c on a.cvcod = c.cvcod ";
                sQuery = sQuery + string.Format("where a.status like '%{0}%' and a.cvcod like '%{1}%' and a.itnbr like '%{2}%' and a.invoice like '%{3}%' and a.depot_no like '{4}%'  ", QueryParm["STATUS"], QueryParm["CVCOD"], QueryParm["ITNBR"], QueryParm["INVOICE"], QueryParm["WHCODE"]);
                sQuery = sQuery + string.Format(" and a.invoice in (select distinct invoice from imhist_loc where saupj = '{0}') ", QueryParm["SAUPJ"]);
                sQuery = sQuery + " order by a.stock_YYMM ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region // 출고할 HEAD LIST
        public static DataTable StockOut()
        {
            string sQuery = "";
            try
            {
                sQuery = "select  a.depot_no, c.whname, a.status, decode(a.status,'SH2','In Warehouse','On Passage') as statname, ";
                sQuery = sQuery + " to_char(to_date(a.stock_YYMM, 'YYYYMMDD'), 'YYYY-MM-DD') as shipdate, a.invoice, ";
                //sQuery = sQuery + " a.stock_YYMM as shipdate, a.invoice, ";
                sQuery = sQuery + " to_char(to_date(a.arrdate, 'YYYYMMDD'), 'YYYY-MM-DD') as arrdate, a.itnbr, b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, ";
                //sQuery = sQuery + " arrdate, a.itnbr, b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, ";
                sQuery = sQuery + " to_char(nvl(a.jqty, 0), '999,999,999') jqty, to_char(nvl(a.jbqty, 0), '999,999,999') jbqty, ";
                sQuery = sQuery + " to_char(nvl(a.iqty, 0), '999,999,999') iqty, to_char(nvl(a.ibqty, 0), '999,999') ibqty, ";
                sQuery = sQuery + " to_char(nvl(a.oqty, 0), '999,999,999') oqty, to_char(nvl(a.obqty, 0), '999,999,999') obqty, ";
                sQuery = sQuery + " a.cvcod, FUN_GET_VNDSALENAME(a.cvcod) as salescvcodname, d.pspec, d.opseq, d.napvnd, a.cino, a.expno as pordno, d.cunit ,FUN_GET_SALESCOD(a.cvcod) as salescvcod, e.cvnas, d.saupj  ";
                sQuery = sQuery + " from stockmonth_loc a join itemas b on a.itnbr = b.itnbr join vndmst e on a.cvcod = e.cvcod ";
                sQuery = sQuery + " join(select rfgub as whcode, rfna1 as whname from reffpf where rfcod = '6G' and rfgub <> '00') c on a.depot_no = c.whcode ";
                sQuery = sQuery + " join (select distinct ref3, itnbr, pspec, opseq, napvnd, cino, pordno, cunit, saupj from imhist_loc ";
                sQuery = sQuery + string.Format(" where cvcod like '%{0}%' and depot_no like '%{1}%' and iogbn = 'SH2' and ref3 like '%{2}%' and itnbr like '%{3}%' and saupj = '{4}' ) d on a.invoice = d.ref3 and a.itnbr = d.itnbr " , string.IsNullOrEmpty(QueryParm["CVCOD"]) ? "%" : QueryParm["CVCOD"], string.IsNullOrEmpty(QueryParm["DEPOTNO"]) ? "%" : QueryParm["DEPOTNO"], string.IsNullOrEmpty(QueryParm["INVOICE"]) ? "%" : QueryParm["INVOICE"], string.IsNullOrEmpty(QueryParm["ITNBR"]) ? "%" : QueryParm["ITNBR"], QueryParm["SAUPJ"]);
                sQuery = sQuery + string.Format(" where a.cvcod like '%{0}%' and a.depot_no like '%{1}' and a.status = 'SH2' and a.invoice like '%{2}%' and a.itnbr like '%{3}%' ", string.IsNullOrEmpty(QueryParm["CVCOD"]) ? "%" : QueryParm["CVCOD"], string.IsNullOrEmpty(QueryParm["DEPOTNO"]) ? "%" : QueryParm["DEPOTNO"], string.IsNullOrEmpty(QueryParm["INVOICE"]) ? "%" : QueryParm["INVOICE"], string.IsNullOrEmpty(QueryParm["ITNBR"]) ? "%" : QueryParm["ITNBR"]);
                sQuery = sQuery + string.Format(" and a.depot_no like '%{0}%' ", string.IsNullOrEmpty(QueryParm["WHCODE"]) ? "%" : QueryParm["WHCODE"]);
                sQuery = sQuery + "  and nvl(jqty,0) <> 0  and   nvl(trim(arrdate), ' ' ) <> ' ' order by a.stock_YYMM, salescvcodname, a.arrdate ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        // Delivery Out Printing Query
        public static DataSet PrtInvoiceGet(string sql)
        {
            try
            {
                return dbConnSQL.ExcuteSQLReturnDataSet(sql);
            }
            catch
            {
                return null;
            }
        }

        #region // 취소할 HEAD LIST
        public static DataTable StockOutCancel()
        {
            string sQuery = "";
            try
            {
                sQuery = "select  a.depot_no, c.whname, a.status, decode(a.status,'SH2','Delivered','Delivered') as statname, ";
                sQuery = sQuery + " to_char(to_date(a.stock_YYMM, 'YYYYMMDD'), 'YYYY-MM-DD') as shipdate, a.invoice, ";
                sQuery = sQuery + " to_char(to_date(a.arrdate, 'YYYYMMDD'), 'YYYY-MM-DD') as arrdate, a.itnbr, b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, ";
                sQuery = sQuery + " to_char(nvl(a.jqty, 0), '999,999,999') jqty, to_char(nvl(a.jbqty, 0), '999,999,999') jbqty, ";
                sQuery = sQuery + " to_char(nvl(a.iqty, 0), '999,999,999') iqty, to_char(nvl(a.ibqty, 0), '999,999,999') ibqty, ";
                sQuery = sQuery + " to_char(nvl(a.oqty, 0), '999,999,999') oqty, to_char(nvl(a.obqty, 0), '999,999,999') obqty, ";
                sQuery = sQuery + " a.cvcod, FUN_GET_VNDSALENAME(a.cvcod) as salescvcodname, d.saupj ";
                sQuery = sQuery + " from stockmonth_loc a join itemas b on a.itnbr = b.itnbr ";
                sQuery = sQuery + " join (select rfgub as whcode, rfna1 as whname from reffpf where rfcod = '6G' and rfgub <> '00') c on a.depot_no = c.whcode ";
                sQuery = sQuery + string.Format("join (select distinct ref3, saupj from imhist_loc where saupj = '{0}') d on a.invoice = d.ref3 ", QueryParm["SAUPJ"]);
                sQuery = sQuery + string.Format(" where a.cvcod like '%{0}%' and a.depot_no like '%{1}' and a.status = 'SH2' and a.invoice like '%{2}%' and a.itnbr like '%{3}%' ", string.IsNullOrEmpty(QueryParm["CVCOD"]) ? "%" : QueryParm["CVCOD"], string.IsNullOrEmpty(QueryParm["WHCODE"]) ? "%" : QueryParm["WHCODE"], string.IsNullOrEmpty(QueryParm["INVOICE"]) ? "%" : QueryParm["INVOICE"], string.IsNullOrEmpty(QueryParm["ITNBR"]) ? "%" : QueryParm["ITNBR"]);
                sQuery = sQuery + string.Format(" and a.invoice in (select distinct ref3 from imhist_loc where io_date >= '{0}' and io_date <= '{1}'  and iogbn = 'O02' and ref4 like '%{2}%' ) ", QueryParm["FROM"], QueryParm["TO"], QueryParm["LOCALINVOICE"]);
                sQuery = sQuery + "  and nvl(oqty,0) <> 0 order by salescvcodname ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region // 취소할 DETAIL LIST
        public static DataTable StockOutCancelList()
        {
            string sQuery = "";
            try
            {
                sQuery = " select ref3,ref4, iojpno, to_char(to_date(sudat, 'YYYYMMDD'), 'YYYY-MM-DD') as sudat, iogbn, to_char(to_date(io_date, 'YYYYMMDD'), 'YYYY-MM-DD') as io_date, itnbr, pspec, opseq,  depot_no,  cvcod, napvnd,    "; 
                sQuery = sQuery + " depot_out, ioqty, ioreqty, cino, pordno, fioprc, fioamt, to_char(to_date(gumdat, 'YYYYMMDD'), 'YYYY-MM-DD') as gumdat, bigo, 'R' as flag, 'N' as chk, cunit, UPD_USER, UPD_DATE, UPD_TIME, CRT_USER, CRT_DATE, CRT_TIME , salescvcod, saupj  ";
                sQuery = sQuery + string.Format(" from   imhist_loc where ref3 = '{0}' and itnbr = '{1}' and iogbn = 'O02'", string.IsNullOrEmpty(QueryParm["INVOICE"]) ? "%" : QueryParm["INVOICE"], string.IsNullOrEmpty(QueryParm["ITNBR"]) ? "%" : QueryParm["ITNBR"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region // 취소할 local invoice infomation.
        public static DataTable StockOutCancelLocinvoiceList()
        {
            string sQuery = "";
            try
            {
                sQuery = " select freightamt, freightprc, rawamt, rawprc, loading, carrier, onboard, pickdate, po_a_date, marks1, marks2, marks3, marks4 from STOCK_LOCALINVOICE_INFO ";
                sQuery = sQuery + string.Format(" where locinvoice = '{0}' and iodate = '{1}' and use_wh = '{2}' and invcvcod = '{3}' ", QueryParm["REF4"], QueryParm["IODATE"], QueryParm["WHCODE"], QueryParm["CVCOD"]);

                //string aaa = sQuery;
                

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region // Modify Stock 
        public static DataTable StockModifyList()
        {
            string sQuery = "";
            try
            {
                sQuery = "select a.iojpno, a.ref3, a.ref4,  to_char(to_date(a.sudat,'YYYYMMDD'),'YYYY-MM-DD') as sudat, a.itnbr, d.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, a.depot_no, b.whname, a.cvcod, c.cvnas, a.napvnd, to_char(to_date(a.io_date,'YYYYMMDD'),'YYYY-MM-DD')as io_date, a.ioqty, a.ioreqty, ";
                sQuery = sQuery + " a.fioprc, a.fioamt, a.cino, a.pordno, decode(nvl(a.gumdat,''),'',a.gumdat, to_char(to_date(a.gumdat,'YYYYMMDD'),'YYYY-MM-DD')) as gumdat, a.cunit, a.dref4 from imhist_loc a , (select rfgub as whcode, rfna1 as whname from reffpf where rfcod = '6G' and rfgub <> '00') b , vndmst c, itemas d ";
                sQuery = sQuery + " where a.iogbn = 'O02' and a.depot_no = b.whcode and a.cvcod = c.cvcod and a.itnbr = d.itnbr ";
                sQuery = sQuery + string.Format(" and a.cvcod like '%{0}%' and a.depot_no like '%{1}' and a.io_date >= '{2}' and a.io_date <= '{3}' and a.itnbr like '%{4}%' and a.ref4 like '%{5}%'", QueryParm["CVCOD"], QueryParm["WHCODE"], QueryParm["IODATEFROM"], QueryParm["IODATETO"], QueryParm["ITNBR"], QueryParm["LOCALINVOICE"]);
                sQuery = sQuery + " order by a.io_date, ref4 ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region // 취소할 인보이스 출고 이력 체크.
        public static bool StokcinDeleteCHK()
        {
            string sQuery = "";
            try
            {
                sQuery = "select nvl(obqty,0) + nvl(oqty,0) from stockmonth_loc ";
                sQuery = sQuery + string.Format("where status = 'SH2' and stock_yymm = '{0}' and itnbr = '{1}' and invoice = '{2}'  ", QueryParm["STOCK_YYMM"], QueryParm["ITNBR"], QueryParm["INVOICE"]);

                DataTable dt = dbConnSQL.ExecuteSQLReturnDataTable(sQuery);

                int chkStock = int.Parse(dt.Rows[0][0].ToString());
                
                if (chkStock > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
    
            }
            catch
            {
                return false;
            }
        }

        #endregion

        public static DataTable SalesCustGet()
        {
            string sQuery = "";

            try
            {
                sQuery = string.Format("select distinct a.cvcod from vndmst_sub a join stockmonth_loc b on a.cvcod = b.cvcod where a.salescod like '{0}%'", Query.QueryParm["SALESCOD"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }

        }

        #region // consign stock warehouse month delivery Query Master
        public static DataTable StockDeliveryMonthM2()
        {
            string sQuery = "";
            try
            {
                sQuery = " SELECT  CVCOD, CVNAS, ITNBR, ITDSC, FUN_GET_ITMBUY_BUNBR(ITNBR, CVCOD) as buyeritem, DEPOT_OUT, WHNAME, CUNIT,   ";
                sQuery = sQuery + " SUM(Jan_Qty)   AS Jan_Qty, SUM(Feb_Qty)   AS Feb_Qty, SUM(Mar_Qty)   AS Mar_Qty,";
                sQuery = sQuery + "SUM(Apr_Qty)   AS Apr_Qty, SUM(May_Qty)   AS May_Qty, SUM(Jun_Qty)   AS Jun_Qty,";
                sQuery = sQuery + "SUM(Jul_Qty)   AS Jul_Qty, SUM(Aug_Qty)   AS Aug_Qty, SUM(Sept_Qty)  AS Sept_Qty,";
                sQuery = sQuery + "SUM(Oct_Qty)   AS Oct_Qty, SUM(Nov_Qty)   AS Nov_Qty, SUM(Dec_Qty)   AS Dec_Qty,";
                sQuery = sQuery + "SUM(QTY)       AS TotQTY,";
                sQuery = sQuery + "SUM(Jan_BOXQty)   AS Jan_BOXQty, SUM(Feb_BOXQty)   AS Feb_BOXQty, SUM(Mar_BOXQty)   AS Mar_BOXQty,";
                sQuery = sQuery + "SUM(Apr_BOXQty)   AS Apr_BOXQty, SUM(May_BOXQty)   AS May_BOXQty, SUM(Jun_BOXQty)   AS Jun_BOXQty,";
                sQuery = sQuery + "SUM(Jul_BOXQty)   AS Jul_BOXQty, SUM(Aug_BOXQty)   AS Aug_BOXQty, SUM(Sept_BOXQty)  AS Sept_BOXQty,";
                sQuery = sQuery + "SUM(Oct_BOXQty)   AS Oct_BOXQty, SUM(Nov_BOXQty)   AS Nov_BOXQty, SUM(Dec_BOXQty)   AS Dec_BOXQty,";
                sQuery = sQuery + "SUM(BOX_QTY)      AS TotBOX_QTY,";
                sQuery = sQuery + "SUM(Jan_AMT)   AS Jan_AMT, SUM(Feb_AMT)   AS Feb_AMT, SUM(Mar_AMT)   AS Mar_AMT, ";
                sQuery = sQuery + "SUM(Apr_AMT)   AS Apr_AMT, SUM(May_AMT)   AS May_AMT, SUM(Jun_AMT)   AS Jun_AMT, ";
                sQuery = sQuery + "SUM(Jul_AMT)   AS Jul_AMT, SUM(Aug_AMT)   AS Aug_AMT, SUM(Sept_AMT)  AS Sept_AMT, ";
                sQuery = sQuery + "SUM(Oct_AMT)   AS Oct_AMT, SUM(Nov_AMT)   AS Nov_AMT, SUM(Dec_AMT)   AS Dec_AMT, ";
                sQuery = sQuery + "SUM(AMT)  AS ToTAMT ";
                sQuery = sQuery + "FROM( ";
                sQuery = sQuery + "        SELECT  A.CVCOD, B.CVNAS, a.ITNBR, c.ITDSC, DEPOT_OUT, WHNAME, CUNIT,  ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '01', IOQTY, 0))   AS Jan_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '01', IOREQTY, 0)) AS Jan_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '01', FIOAMT, 0))  AS Jan_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '02', IOQTY, 0))   AS Feb_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '02', IOREQTY, 0)) AS Feb_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '02', FIOAMT, 0))  AS Feb_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '03', IOQTY, 0))   AS Mar_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '03', IOREQTY, 0)) AS Mar_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '03', FIOAMT, 0))  AS Mar_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '04', IOQTY, 0))   AS Apr_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '04', IOREQTY, 0)) AS Apr_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '04', FIOAMT, 0))  AS Apr_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '05', IOQTY, 0))   AS May_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '05', IOREQTY, 0)) AS May_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '05', FIOAMT, 0))  AS May_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '06', IOQTY, 0))   AS Jun_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '06', IOREQTY, 0)) AS Jun_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '06', FIOAMT, 0))  AS Jun_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '07', IOQTY, 0))   AS Jul_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '07', IOREQTY, 0)) AS Jul_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '07', FIOAMT, 0))  AS Jul_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '08', IOQTY, 0))   AS Aug_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '08', IOREQTY, 0)) AS Aug_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '08', FIOAMT, 0))  AS Aug_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '09', IOQTY, 0))   AS Sept_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '09', IOREQTY, 0)) AS Sept_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '09', FIOAMT, 0))  AS Sept_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '10', IOQTY, 0))   AS Oct_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '10', IOREQTY, 0)) AS Oct_BOXQty, ";
                sQuery = sQuery + "               SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '10', FIOAMT, 0))  AS Oct_AMT, ";
                sQuery = sQuery + "               SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '11', IOQTY, 0))   AS Nov_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '11', IOREQTY, 0)) AS Nov_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '11', FIOAMT, 0))  AS Nov_AMT, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '12', IOQTY, 0))   AS Dec_Qty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '12', IOREQTY, 0)) AS Dec_BOXQty, ";
                sQuery = sQuery + "                SUM(DECODE(SUBSTR(IO_DATE, 5, 2), '12', FIOAMT, 0))  AS Dec_AMT, ";
                sQuery = sQuery + "                SUM(IOQTY)   AS QTY,  SUM(IOREQTY) AS BOX_QTY,  SUM(FIOAMT)  AS AMT ";
                sQuery = sQuery + "        FROM    IMHIST_LOC a JOIN VNDMST b ON a.CVCOD = b.CVCOD JOIN ITEMAS c ON a.ITNBR = c.ITNBR ";
                sQuery = sQuery + "                JOIN(SELECT rfgub AS whcode, rfna1 AS whname FROM reffpf WHERE rfcod = '6G' AND rfgub <> '00') d ON a.DEPOT_OUT = d.WHCODE ";
                sQuery = sQuery + string.Format("        WHERE   IO_DATE >= '{0}' AND IO_DATE <= '{1}' AND A.CVCOD LIKE '%{2}%'", QueryParm["DELIVERYFROM"], QueryParm["DELIVERYTO"], QueryParm["CVCOD"] );
                sQuery = sQuery + string.Format("        AND     IOGBN = 'O02'  AND A.REF4 like '%{0}%' AND A.ITNBR LIKE '%{1}%' AND A.DEPOT_OUT LIKE '%{2}%' ", QueryParm["LOCALINVOICE"], QueryParm["ITNBR"], QueryParm["WHCODE"]);
                sQuery = sQuery + "        GROUP BY A.CVCOD, B.CVNAS, A.ITNBR, C.ITDSC, DEPOT_OUT, WHNAME, CUNIT  ";
                sQuery = sQuery + "       ) ";
                sQuery = sQuery + "GROUP BY CVCOD,CVNAS, ITNBR, ITDSC, DEPOT_OUT, WHNAME, CUNIT  ";
                sQuery = sQuery + "ORDER BY DEPOT_OUT, CVCOD, ITNBR ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        public static DataTable StockDeliveryMonthM(string from, string to)
        {
            string sQuery = "";
            try
            {

                //sQuery = string.Format("EXEC CSSP_IMHISTLOC_MONTH ('{0}', '{1}', :{2})", QueryParm["DELIVERYFROM"], QueryParm["DELIVERYTO"], QueryParm["OUTCURSOR"]);
                sQuery = "EXEC CSSP_IMHISTLOC_MONTH";
                dbConnSQL.QueryParm = new Dictionary<string, string>() { { "PARAM1", "ar_deliveryfrom" } };
                dbConnSQL.QueryParm.Add("PARAM2", "ar_deliveryto");
                dbConnSQL.QueryParm.Add("PARAM1_VALUE", "'" + from + "'");
                dbConnSQL.QueryParm.Add("PARAM2_VALUE", "'" + to + "'");
                dbConnSQL.QueryParm.Add("OPARAM", "DeliveryMstList");
                return dbConnSQL.ExecuteSQLOraSpReturnDataTable(sQuery);

                // General Query
                // return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region // consign stock warehouse month delivery Query Detail
        public static DataTable StockDeliveryMonthD()
        {
            string sQuery = "";
            try
            {

                sQuery = "SELECT to_char(to_date(A.IO_DATE,'YYYYMMDD'),'YYYY-MM-DD') as IO_DATE, A.CVCOD, B.CVNAS, A.REF3, A.REF4, A.ITNBR, C.ITDSC, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, A.DEPOT_OUT, D.WHNAME, IOQTY, IOREQTY, CUNIT, FIOPRC, FIOAMT, NVL(DREF4,0) AS DREF4 , (NVL(FIOAMT,0) + NVL(DREF4,0)) AS TOTAMT ";
                sQuery = sQuery + "FROM   IMHIST_LOC A JOIN VNDMST B ON A.CVCOD = B.CVCOD JOIN ITEMAS C ON A.ITNBR = C.ITNBR ";
                sQuery = sQuery + "JOIN(SELECT rfgub AS whcode, rfna1 AS whname FROM reffpf WHERE rfcod = '6G' AND rfgub <> '00') d ON a.DEPOT_OUT = d.WHCODE ";
                sQuery = sQuery + string.Format("WHERE IO_DATE >= '{0}' AND IO_DATE <= '{1}' AND IOGBN = 'O02' ", QueryParm["DFROM"], QueryParm["DTO"]);
                sQuery = sQuery + string.Format("AND A.CVCOD = '{0}' AND A.ITNBR = '{1}' ", QueryParm["CVCOD"], QueryParm["ITNBR"]);
                sQuery = sQuery + "ORDER BY IO_DATE";
                // General Query
                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region // STOCK MODIFY DETAIL LIST QUERY
        public static DataTable StockModifyDetailList()
        {
            string sQuery = "";
            try
            {
                sQuery = "select a.iojpno, to_char(to_date(a.io_date,'YYYYMMDD'),'YYYY-MM-DD')as io_date, a.ref3, a.ref4, a.itnbr, d.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as buyeritem, a.depot_no, a.cvcod, c.cvnas, a.napvnd, a.ioqty, a.ioreqty, ";
                sQuery = sQuery + " a.fioprc, a.fioamt, a.cino, a.pordno, decode(nvl(a.gumdat,''),'',a.gumdat, to_char(to_date(a.gumdat,'YYYYMMDD'),'YYYY-MM-DD')) as gumdat, a.cunit, a.dref4 from imhist_loc a join vndmst c on a.cvcod = c.cvcod join itemas d on a.itnbr = d.itnbr ";
                sQuery = sQuery + string.Format(" WHERE a.REF4 = '{0}' AND a.IO_DATE = '{1}' AND a.CVCOD = '{2}' AND a.DEPOT_NO = '{3}'", QueryParm["REF4"], QueryParm["IODATE"], QueryParm["CVCOD"], QueryParm["WH"]);
                sQuery = sQuery + "ORDER BY a.IO_DATE, a.IOJPNO, a.REF4 ";

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region // STOCK MODIFY DETAIL INVOICE INFO. QUERY
        public static DataTable StockModifyInvoiceInfo()
        {
            string sQuery = "";
            try
            {
                sQuery = "SELECT LOCINVOICE, IODATE, USE_WH, INVCVCOD, IOJPNO, ITEMAMT, ITEMPRC, FREIGHTAMT, FREIGHTPRC, RAWAMT, RAWPRC, TOTAMT, PO_A_DATE, MARKS1, MARKS2, MARKS3, MARKS4 ";
                sQuery = sQuery + " FROM STOCK_LOCALINVOICE_INFO ";
                sQuery = sQuery + string.Format("WHERE LOCINVOICE = '{0}' AND IODATE = '{1}' AND USE_WH = '{2}' AND INVCVCOD = '{3}' AND IOJPNO LIKE '%{4}%'", QueryParm["REF4"], QueryParm["IODATE"], QueryParm["WH"], QueryParm["CVCOD"], QueryParm["IOJPNO"]);

                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
