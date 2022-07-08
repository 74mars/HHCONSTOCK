using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conndb;

namespace conStock.Data
{
    public class Query
    {
        public static Dictionary<string, string> QueryParm { get; set; }
        

        public static DataTable StockView()
        {
            string sQuery = "";

            try
            {
                sQuery = string.Format("select a.invoice, a.itnbr, c.itdsc,c.ispec, a. jbqty, a.jqty, a.ibqty, a.iqty, a.obqty, a.oqty,a.cvcod, b.cvnas from stockMonth_loc a  join vndmst b on a.cvcod = b.cvcod  join itemas c on a.itnbr = c.itnbr where stock_yymm = '{0}'", QueryParm["yy_mm"]);
                return dbConnSQL.ExecuteSQLReturnDataTable(sQuery);
            }
            catch
            {
                return null;
            }
        }
    }
}
