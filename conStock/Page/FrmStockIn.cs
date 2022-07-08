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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System.Text.RegularExpressions;
using Conndb;

namespace conStock.Page
{
    public partial class FrmStockIn : UserControl
    {
        public FrmStockIn()
        {
            InitializeComponent();
            dbConnInfo.Division = "20";
            SetComBoBX();

            //this.gridView.MouseDown += GridView_mouseDBClick;
        }

        private void SetComBoBX()
        {
            MainSetting.CompanySet(cbxCompany);
            cbxCompany.SelectedIndex = 0;

            var status = new Dictionary<string, string>();
            status.Add("SH1", "ON Passage");
            status.Add("SH2", "IN Warehouse");

            cbxStat.DataSource = new BindingSource(status, null);
            cbxStat.DisplayMember = "Value";
            cbxStat.ValueMember = "Key";

            cbxStat.SelectedIndex = 0;

            MainSetting.SetComboBXSetting(cbxWh,"WHNAME", "WHCODE");

            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", cbxStat.SelectedValue.ToString());
            Query.QueryParm.Add("CVCOD", "");
            Query.QueryParm.Add("ITNBR", "");
            Query.QueryParm.Add("INVOICE", txtInvoice.Text.ToString());
            Query.QueryParm.Add("SAUPJ", cbxCompany.SelectedValue.ToString());

            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            MainSetting.SetComboBXSetting(cbxItem, "ITDSC", "ITNBR");
            //MainSetting.SetComboBXSetting(cbxInvoice, "INVOICENAME", "INVOICE");
            //string queryStr = "select distinct invoice, invoice as inv from stockmonth_loc where status like '%";
            
        }

        private void comboNuuchkTot()
        {
            cbxCust = MainSetting.ChkCombNull(cbxCust);
            cbxWh = MainSetting.ChkCombNull(cbxWh);
            cbxItem = MainSetting.ChkCombNull(cbxItem);
            //cbxInvoice = MainSetting.ChkCombNull(cbxInvoice);
            cbxStat = MainSetting.ChkCombNull(cbxStat);


            //comboNullchk(cbxCust);
            //comboNullchk(cbxWh);
            //comboNullchk(cbxItem);
            //comboNullchk(cbxInvoice);
            //comboNullchk(cbxStat);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //comboNuuchkTot();

            QueryRefresh();

        }

        private void QueryRefresh()
        {
            MainSetting.DivisionCHK(cbxCompany);
            comboNuuchkTot();
            //string aa = cbxCust.SelectedValue.ToString();
            Query.QueryParm = new Dictionary<string, string>() { { "CVCOD", cbxCust.SelectedValue.ToString() } };
            Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());
            Query.QueryParm.Add("INVOICE", txtInvoice.Text.ToString());
            //Query.QueryParm.Add("INVOICE", cbxInvoice.SelectedValue.ToString());
            Query.QueryParm.Add("STATUS", cbxStat.SelectedValue.ToString());
            Query.QueryParm.Add("WHCODE", cbxWh.SelectedValue.ToString());
            Query.QueryParm.Add("SAUPJ", cbxCompany.SelectedValue.ToString());

            Grid.DataSource = Query.Stockin();
            //gridView.OptionsSelection.CheckBoxSelectorField = "CHK";
            gridView.IndicatorWidth = 30;
        }

        /// <summary>
        /// combobox null check.
        /// </summary>
        /// <param name="cbx1"></param>
        /// <param name="cbx2"></param>
        /// <param name="cbx3"></param>
        private void comboNullchk(System.Windows.Forms.ComboBox cbx)
        {
            if (cbx != null)
            {
                if (cbx.SelectedValue == null)
                {
                    cbx.SelectedIndex = cbx.Items.Count - 1;
                }
            }

        }

        /// <summary>
        /// Gridview Column에 달력 넣기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void GridView_mouseDBClick(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = gridView.CalcHitInfo(e.Location);

            ClearForm();

            if (e.Button == MouseButtons.Right && (hitInfo.HitTest == GridHitTest.RowCell || hitInfo.HitTest == GridHitTest.Row))
            {
                DateEdit dateEdit = new DateEdit();

                dateEdit.EditValue = this.gridView.GetRowCellValue(hitInfo.RowHandle, gridView.Columns["ARRDATE"]);
                dateEditForm = new VistaPopupDateEditForm(dateEdit);
                dateEditForm.Calendar.EditValueChanged += new EventHandler(OnEditDateModified);

                dateEditForm.ClosePopup();

                dateEditForm.Tag = hitInfo.RowHandle;

                dateEditForm.Location = PointToScreen(e.Location);

                dateEditForm.Size = dateEditForm.CalcFormSize();

                dateEditForm.ShowPopupForm();

            }
        }

        VistaPopupDateEditForm dateEditForm;

        private void ClearForm()
        {
            if (dateEditForm != null)
            {
                dateEditForm.Calendar.EditValueChanged -= new EventHandler(OnEditDateModified);
                dateEditForm.ClosePopup();
                dateEditForm.Dispose();
            }
        }

        private void OnEditDateModified(object sender, EventArgs e)
        {
            int rowHandle = Convert.ToInt32(dateEditForm.Tag);
            gridView.SetRowCellValue(rowHandle, gridView.Columns["ARRDATE"], dateEditForm.Calendar.DateTime.ToString("yyyyMMdd"));
            dateEditForm.HidePopupForm();
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //bool isChecked = Convert.ToBoolean(gridView.GetRowCellValue(e.RowHandle, gridView.Columns[0]));
            //string aa = gridView.Columns[0].ToString();
            //bool sel = gridView.IsMultiSelect;
            //chk = gridView.IsRowSelected(e.RowHandle);
            //textBox1.Text  = chk.ToString();
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ////string curChk = gridView.GetRowCellValue(e.RowHandle, gridView.Columns[0]).ToString();
            ////if (gridView.Columns[0] ==  )
            string isChecked = gridView.GetRowCellValue(e.RowHandle, gridView.Columns["ARRDATE"]).ToString();
            //if (!isChecked.All(char.IsDigit))
            //{
            //    throw new Exception("Please enter a number.");
            //}
            if (e.Column.FieldName == "ARRDATE" && isChecked != "") { 
                int len = isChecked.Length;
              
                if (gridView.GetRowCellValue(e.RowHandle, "ARRDATE").ToString().Length > 10)
                {
                    gridView.SetRowCellValue(e.RowHandle, "ARRDATE", gridView.GetRowCellValue(e.RowHandle, "ARRDATE").ToString().Substring(0, 10));
                }
            }
        }

        private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
            bool isChecked = gridView.IsRowSelected(gridView.FocusedRowHandle);
            if (isChecked == true)
            {
                if (cbxStat.SelectedValue.ToString() == "SH1")
                { 
                    string dd = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "ARRDATE", dd);
                }
            }
            else
            {
                if (cbxStat.SelectedValue.ToString() == "SH1")
                { 
                    gridView.SetRowCellValue(gridView.FocusedRowHandle, "ARRDATE", "");
                }
            }

        }

        private void gridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////string colname = gridView.Columns["ARRDATE"].FieldName.ToString();
            //if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            //{
            //    throw new Exception("Please enter a number.");
            //}
        }


        // 저장 버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxStat.SelectedValue.ToString() != "SH1")
            {
                MessageBox.Show("Please set the Stock Status to 'On Passage'.", "NOTICE");
                return;
            }
            if (MessageBox.Show("Are you sure you want to save your selections?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Canceled saving.", "NOTICE");
                return;
            }
            MainSetting.DivisionCHK(cbxCompany);

            int gridCnt = gridView.RowCount;
            string arrdate = "";
            string shipdate = "";
            string invoiceNo = "";
            string itnbr = "";
            string sql = "";
            for (int i = 0; i < gridView.RowCount ; i++)
            {
                var rows = gridView.GetSelectedRows();
                arrdate = gridView.GetRowCellValue(gridView.GetRowHandle(i), "ARRDATE").ToString().Replace("-","");
                arrdate = arrdate.Trim();
                if (arrdate != "")
                {
                    
                    shipdate = gridView.GetRowCellValue(gridView.GetRowHandle(i), "SHIPDATE").ToString().Replace("-","");
                    invoiceNo = gridView.GetRowCellValue(gridView.GetRowHandle(i), "INVOICE").ToString();
                    itnbr = gridView.GetRowCellValue(gridView.GetRowHandle(i), "ITNBR").ToString();

                    sql = string.Format("update stockmonth_loc set arrdate = '{0}', status = '{1}', jqty = iqty, jbqty = ibqty where stock_yymm = '{2}' and invoice = '{3}' and itnbr = '{4}'", arrdate, "SH2", shipdate, invoiceNo, itnbr);
                    dbConnSQL.ExecuteTransactionSql(sql);

                }
            }
            QueryRefresh();
        }
        // 삭제버튼
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                MainSetting.DivisionCHK(cbxCompany);
                if (cbxStat.SelectedValue.ToString() != "SH2")
                {
                    MessageBox.Show("Please set the Stock Status to 'In Warehouse'.","NOTICE");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to cancel the receipt of the selected item?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("Canceled.", "NOTICE");
                    return;
                }

                int gridCnt = gridView.RowCount;
                //string arrdate = "";
                string shipdate = "";
                string invoiceNo = "";
                string itnbr = "";
                string sql = "";
                
                for (int i = 0; i < gridView.RowCount; i++)
                {


                    if (gridView.IsRowSelected(i) == true)
                    {
                        shipdate = gridView.GetRowCellValue(gridView.GetRowHandle(i), "SHIPDATE").ToString().Replace("-", "");
                        invoiceNo = gridView.GetRowCellValue(gridView.GetRowHandle(i), "INVOICE").ToString();
                        itnbr = gridView.GetRowCellValue(gridView.GetRowHandle(i), "ITNBR").ToString();

                        Query.QueryParm = new Dictionary<string, string>() { { "INVOICE", invoiceNo } };
                        Query.QueryParm.Add("ITNBR", itnbr);
                        Query.QueryParm.Add("STOCK_YYMM", shipdate);



                        // 출고 있는지 확인
                        if (Query.StokcinDeleteCHK() == true)
                        {
                            return;
                        }
                        
                        sql = string.Format("update stockmonth_loc set arrdate = '{0}', status = '{1}', jqty = iqty-iqty, jbqty = ibqty-ibqty where stock_yymm = '{2}' and invoice = '{3}' and itnbr = '{4}'", null, "SH1", shipdate, invoiceNo, itnbr);
                        dbConnSQL.ExecuteTransactionSql(sql);
                    }
                }
                QueryRefresh();
            }
            catch
            {
                throw;

            }
        }

        private void gridView_Click(object sender, EventArgs e)
        {
            string colName = gridView.FocusedColumn.FieldName.ToString();
            
            if (gridView.IsRowSelected(gridView.FocusedRowHandle) == true)
                if (colName == "ARRDATE")
                {
                
                    string aa = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ARRDATE").ToString();

                    if (aa == "")
                    {
                        string dd = dateTimePicker2.Value.ToString("yyyyMMdd");
                        gridView.SetRowCellValue(gridView.FocusedRowHandle, "ARRDATE", dd);
                    }
                }
        }

        private void gridView_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Grid_Click(object sender, EventArgs e)
        {

        }

        private void cbxWh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalSelectSetCbx();
        }

        private void LocalSelectSetCbx()
        {
            comboNuuchkTot();

            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", cbxStat.SelectedValue.ToString());
            Query.QueryParm.Add("CVCOD", cbxCust.SelectedValue.ToString());
            Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());
            Query.QueryParm.Add("INVOICE", txtInvoice.Text.ToString());
            //Query.QueryParm.Add("INVOICE", cbxInvoice.SelectedValue.ToString());
            Query.QueryParm.Add("SAUPJ", cbxCompany.SelectedValue.ToString());

            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            MainSetting.SetComboBXSetting(cbxItem, "ITDSC", "ITNBR");
           // MainSetting.SetComboBXSetting(cbxInvoice, "INVOICENAME", "INVOICE");
        }

        private void cbxStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStat.SelectedValue.ToString() == "SH2")
            {
                gridView.Columns["ARRDATE"].OptionsColumn.AllowEdit = false;
                QueryRefresh();
            }
            else
            {
                gridView.Columns["ARRDATE"].OptionsColumn.AllowEdit = true;
                QueryRefresh();
            }
                
        }

        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCompany.SelectedValue.ToString() == "10")
            {
                dbConnInfo.Division = "10";
                QueryRefresh();
            }
            else
            {
                dbConnInfo.Division = "20";
                QueryRefresh();
            }
        }
    }
}
