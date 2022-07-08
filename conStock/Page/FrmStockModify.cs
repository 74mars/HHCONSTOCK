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
using Conndb;

namespace conStock.Page
{
    public partial class FrmStockModify : UserControl
    {
        public FrmStockModify()
        {
            InitializeComponent();
            MainSetting.CompanySet(cbxCompany);
            dateTimePicker1.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")), int.Parse(DateTime.Now.ToString("MM")), 1);
            SetComBoBX();
        }

        #region //Combo BOX Setting
        private void SetComBoBX()
        {
            MainSetting.SetComboBXSetting(cbxWh, "WHNAME", "WHCODE");
            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", "SH2");
            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            Query.QueryParm.Add("CVCOD", cbxCust.SelectedValue.ToString());
            MainSetting.SetComboBXSetting(cbxItem, "ITDSC", "ITNBR");
            Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());
        }

        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryRefresh();
        }

        #region // Refresh Query
        private int sel = 0;
        private bool ioqtyChange = false;  // ioqty 변경시 비용부분 체크용.
        private int ioqtychangeCnt = 0;

        // Query RE Execute.
        private void QueryRefresh()
        {
            MainSetting.ChkCombNull(cbxCust);
            MainSetting.ChkCombNull(cbxItem);
            ioqtyChange = false; ioqtychangeCnt = 0; sel = 0;

            Query.QueryParm = new Dictionary<string, string>() { { "CVCOD", string.IsNullOrEmpty(cbxCust.SelectedValue.ToString()) ? "%" : cbxCust.SelectedValue.ToString() } };
            Query.QueryParm.Add("ITNBR", string.IsNullOrEmpty(cbxItem.SelectedValue.ToString()) ? "%" : cbxItem.SelectedValue.ToString());
            Query.QueryParm.Add("LOCALINVOICE", string.IsNullOrEmpty(txtLocalInvoice.Text.ToString()) ? "%" : txtLocalInvoice.Text.ToString());
            Query.QueryParm.Add("WHCODE", string.IsNullOrEmpty(cbxWh.SelectedValue.ToString()) ? "%" : cbxWh.SelectedValue.ToString());
            Query.QueryParm.Add("IODATEFROM", dateTimePicker1.Value.ToString("yyyy-MM-dd").Replace("-", ""));
            Query.QueryParm.Add("IODATETO", dateTimePicker2.Value.ToString("yyyy-MM-dd").Replace("-", ""));

            Grid.DataSource = Query.StockModifyList();
            GridList.DataSource = null;
            txtPoDate.Text = ""; txtIojpno.Text = "";
            txtMarks1.Text = ""; txtMarks2.Text = ""; txtMarks3.Text = ""; txtMarks4.Text = "";

            txtFreight.Text = "0"; txtFreightPrice.Text = "0";
            txtRawMaterialAmt.Text = "0"; txtRawMaterialPrice.Text = "0";

            gridEditLock();
            gridView.IndicatorWidth = 20;
        }
        #endregion

        #region // HEAD Grid Select.

        private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataTable ds = null;
            
            if (gridView.IsRowSelected(gridView.FocusedRowHandle) == true)
            {
                if (sel == 1) { MessageBox.Show("You can only select one data to edit.!! Again search. ", "WARNING"); QueryRefresh();  return; }
                ioqtyChange = false; ioqtychangeCnt = 0; sel = 1;

                // 하위 그리드 List UP.
                GridList.DataSource = null;
                Query.QueryParm = new Dictionary<string, string>() { { "REF4", gridView.GetRowCellValue(gridView.FocusedRowHandle, "REF4").ToString() } };
                Query.QueryParm.Add("IODATE", gridView.GetRowCellValue(gridView.FocusedRowHandle, "IO_DATE").ToString().Replace("-", ""));
                Query.QueryParm.Add("CVCOD", gridView.GetRowCellValue(gridView.FocusedRowHandle, "CVCOD").ToString());
                Query.QueryParm.Add("WH", gridView.GetRowCellValue(gridView.FocusedRowHandle, "DEPOT_NO").ToString());
                Query.QueryParm.Add("IOJPNO", "%");
                GridList.DataSource = Query.StockModifyDetailList();
                // WHERE REF3 = '{0}' AND IO_DATE = '{1}' AND CVCOD = '{2}' AND DEPOT_NO = '{3}'

                // Invoice 정보 Marks -- display..
                
                ds = Query.StockModifyInvoiceInfo();

                if (ds == null)
                {
                    txtPoDate.Text = "";
                    txtMarks1.Text = ""; txtMarks2.Text = ""; txtMarks3.Text = ""; txtMarks4.Text = "";

                    txtFreight.Text = "0";          txtFreightPrice.Text = "0";
                    txtRawMaterialAmt.Text = "0";   txtRawMaterialPrice.Text = "0";
                   
                    return;
                }

                foreach (DataRow row in ds.Rows)
                {
                    txtIojpno.Text = row["IOJPNO"].ToString(); // 전표번호

                    txtPoDate.Text = row["PO_A_DATE"].ToString();
                    txtMarks1.Text = row["MARKS1"].ToString();
                    txtMarks2.Text = row["MARKS2"].ToString();
                    txtMarks3.Text = row["MARKS3"].ToString();
                    txtMarks4.Text = row["MARKS4"].ToString();

                    txtFreightPrice.Text = string.Format("{0:#,##0.###}", double.Parse(row["FREIGHTPRC"].ToString().Replace(",", "")));
                    //txtFreightPrice.Text = string.Format("{0:#,##0.###}", txtFreightPrice.Text);
                    txtFreight.Text = string.Format("{0:#,##0.##}", double.Parse(row["FREIGHTAMT"].ToString().Replace(",", "")));
                    //txtFreight.Text = string.Format("{0:#,##0.##}", txtFreight.Text);
                    txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", double.Parse(row["RAWAMT"].ToString().Replace(",", "")));
                    //txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", txtRawMaterialAmt.Text);
                    txtRawMaterialPrice.Text = string.Format("{0:#,##0.###}", double.Parse(row["RAWPRC"].ToString().Replace(",","")));
                    //txtRawMaterialPrice.Text = string.Format("{0:#,##0.###}", txtRawMaterialPrice.Text);
                }

                //txtIojpno.DataBindings.Add("Text", ds.Tables[0], "IOJPNO"); // 전표번호

                //txtPoDate.DataBindings.Add("Text", ds.Tables[0], "PO_A_DATE" );
                //txtMarks1.DataBindings.Add("Text", ds.Tables[0], "MARKS1");
                //txtMarks2.DataBindings.Add("Text", ds.Tables[0], "MARKS2");
                //txtMarks3.DataBindings.Add("Text", ds.Tables[0], "MARKS3");
                //txtMarks4.DataBindings.Add("Text", ds.Tables[0], "MARKS4");

                //txtFreightPrice.DataBindings.Add("Text", ds.Tables[0], "FREIGHTPRC");
                //txtFreightPrice.Text = string.Format("{0:#,##0.###}", txtFreightPrice.Text);
                //txtFreight.DataBindings.Add("Text", ds.Tables[0], "FREIGHTAMT");
                //txtRawMaterialAmt.DataBindings.Add("Text", ds.Tables[0], "RAWAMT");
                //txtRawMaterialPrice.DataBindings.Add("Text", ds.Tables[0], "RAWPRC");


                //xrTableCellTotalAmt.DataBindings.Add("Text", dt.Tables[0], "PTOTAMT", "{0:#,###.##}");

                ////gridView.Columns["REF4"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["IO_DATE"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["FIOPRC"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["FIOAMT"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["IOQTY"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["IOREQTY"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["GUMDAT"].OptionsColumn.AllowEdit = true;
                //gridView.Columns["DREF4"].OptionsColumn.AllowEdit = true;

            }
            else
            {
               
                // 하위 그리드 Refresh
                GridList.DataSource = null;
                ioqtyChange = false; ioqtychangeCnt = 0;
                sel = 0;
                // Invoice 정보 Marks display 제거
                ds = null;
                txtPoDate.Text = ""; txtIojpno.Text = "";
                txtMarks1.Text = ""; txtMarks2.Text = ""; txtMarks3.Text = ""; txtMarks4.Text = "";

                txtFreight.Text = "0"; txtFreightPrice.Text = "0";
                txtRawMaterialAmt.Text = "0"; txtRawMaterialPrice.Text = "0";

                //gridView.Columns["REF4"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["IO_DATE"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["FIOPRC"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["FIOAMT"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["IOQTY"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["IOREQTY"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["GUMDAT"].OptionsColumn.AllowEdit = false;
                //gridView.Columns["DREF4"].OptionsColumn.AllowEdit = false;

            }

        }
        #endregion

        #region // Field Condition 사용안함.
        // Field condition
        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "IO_DATE")
            {
                if (gridView.GetRowCellValue(e.RowHandle, "IO_DATE").ToString().Length > 10)
                {
                    string iodate = gridView.GetRowCellValue(e.RowHandle, "IO_DATE").ToString().Substring(0, 10);
                    if (MainSetting.isDateCheck(iodate) == true)
                    {
                        gridView.SetRowCellValue(e.RowHandle, "IO_DATE", gridView.GetRowCellValue(e.RowHandle, "IO_DATE").ToString().Substring(0, 10));
                    }
                }
            }

            if (e.Column.FieldName == "GUMDAT")
            {
                if (gridView.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Length > 10)
                {
                    string iodate = gridView.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Substring(0, 10);
                    if (MainSetting.isDateCheck(iodate) == true)
                    {
                        gridView.SetRowCellValue(e.RowHandle, "GUMDAT", gridView.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Substring(0, 10));
                    }
                }
            }

            if (e.Column.FieldName == "IOQTY")
            {
                if (double.Parse(gridView.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",","")) >= 0)
                {
                    double ioqty = double.Parse(gridView.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", ""));
                    ioqty = Math.Truncate(ioqty);
                    double prc = double.Parse(gridView.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", ""));
                    string amt = Math.Round((prc * ioqty), 3).ToString();

                    gridView.SetRowCellValue(e.RowHandle, "FIOAMT", amt);
                    //ioqtyChange = true; ioqtychangeCnt = 2;
                }
                else
                {
                    MessageBox.Show("The quantity issued cannot be less than the number 0.", "NOTICE");
                    return;
                }
            }

            if (e.Column.FieldName == "FIOPRC")
            {
                if (double.Parse(gridView.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", "")) > 0)
                {
                    double prc = double.Parse(gridView.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", ""));
                    prc = (Math.Truncate(prc * 1000) / 1000);
                    //gridView.SetRowCellValue(e.RowHandle, "FIOPRC", prc);
                    double qty = Math.Truncate(double.Parse(gridView.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", "")));
                    qty = Math.Truncate(qty);
                    string amt = Math.Round((prc * qty), 3).ToString();

                    gridView.SetRowCellValue(e.RowHandle, "FIOAMT", amt);

                }
            }
            
            //if (e.Column.FieldName == "DREF4")
            //{
                
            //}
        }
        #endregion

        #region // UPDATE SAVE
        // SAVE UPDATE
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridDetail.RowCount == 0)
            {
                return;
            }
            double titemqty = 0; 
            // 수량 바뀌었는데 비용 수정 안했을시 체크
            if (ioqtyChange == true || ioqtychangeCnt != 0)
            {
                if (MessageBox.Show("WARNING : Delivery quantity has changed. Would you like to apply the quantity change to the cost? ", "WARNING", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    for (int i = 0; i < gridDetail.RowCount + 1; i++)
                    {
                        titemqty = titemqty +  double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOQTY").ToString().Replace(",", ""));
                    }
                    txtFreight.Text = string.Format("{0:#,##0.##}", Math.Round( titemqty * double.Parse(txtFreightPrice.Text.ToString().Replace(",", ""))* 1000 / 1000,3));
                    txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", Math.Round(titemqty * double.Parse(txtRawMaterialPrice.Text.ToString().Replace(",", "")) * 1000 / 1000, 3));
                    ioqtyChange = false;   ioqtychangeCnt = 0;
                }
                else
                {
                    return;
                }
            }

            if (MessageBox.Show("Are you sure you want to save your modifications?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Canceled saving.", "NOTICE");
                return;
            }
            string tempJPNO = ""; // 전표번호
            //tempJPNO = txtIojpno.Text;
            string sql = ""; string sql2 = "";
            double costAmt = 0; double titemamt = 0; double titemprc = 0;

            for (int i = 0; i < gridDetail.RowCount; i++)
            {

                //if (gridDetail.IsRowSelected(i) == true)
                //{
                    
                    if (gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOJPNO").ToString() == "")
                    {

                    }
                    else
                    {
                        string iodate = ""; string ref4 = ""; string gumdat = ""; string temp = "";
                        iodate = gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IO_DATE").ToString().Replace("-", "");
                        ref4 = gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "REF4").ToString();
                        gumdat = gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "GUMDAT").ToString().Replace("-", "");
                        double ioqty = 0; double ioreqty = 0; double fioprc = 0; double fioamt = 0; // double dref4 = 0;
                        ioqty = double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOQTY").ToString().Replace(",", ""));
                        ioqty = Math.Truncate(ioqty);
                        ioreqty = double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOREQTY").ToString().Replace(",", ""));
                        ioreqty = Math.Truncate(ioreqty);
                        fioprc = double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "FIOPRC").ToString().Replace(",", ""));
                        fioprc = (Math.Truncate(fioprc * 1000) / 1000);
                        fioamt = double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "FIOAMT").ToString().Replace(",", ""));
                        titemamt = titemamt + fioamt; titemprc = fioprc;
                        temp = gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "DREF4").ToString();
                        
                        if (gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "DREF4").ToString() != "" && gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "DREF4").ToString() != "0")
                        {
                            tempJPNO = gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOJPNO").ToString();
                        }
                        //if (gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "DREF4").ToString().Replace(",", "") != "")
                        //{
                        //    dref4 = double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "DREF4").ToString().Replace(",", ""));
                        //    dref4 = (Math.Truncate(dref4 * 100) / 100);
                        //}
                        //else
                        //{
                        //    dref4 = 0;
                        //}
                    
                        sql = string.Format("update imhist_loc set io_date = '{0}', ", gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IO_DATE").ToString().Replace("-", ""));
                        sql = sql + string.Format(" ioqty = {0}, ioreqty = {1}, ", ioqty, ioreqty);
                        sql = sql + string.Format(" fioprc = {0}, fioamt = {1}, ", fioprc, fioamt);
                        //sql = sql + string.Format(" gumdat = {0} , dref4 = {1} ", gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "GUMDAT").ToString().Replace("-", ""), dref4);
                        sql = sql + string.Format(" gumdat = {0} ", gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "GUMDAT").ToString().Replace("-", ""));
                        sql = sql + string.Format(" where iojpno = '{0}' ", gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOJPNO").ToString());

                        dbConnSQL.ExecuteTransactionSql(sql);
                    }
                //}
            }
            if (tempJPNO == "")
            {
                tempJPNO = gridDetail.GetRowCellValue(gridDetail.GetRowHandle(0), "IOJPNO").ToString();
            }

            costAmt = double.Parse(txtFreight.Text.ToString().Replace(",", "")) + double.Parse(txtRawMaterialAmt.Text.ToString().Replace(",", ""));

            string tlocinvoice = ""; string  tiodate = ""; string twh = ""; string tcvcod = ""; string tcurr = "";
            tlocinvoice = gridDetail.GetRowCellValue(gridDetail.FocusedRowHandle, "REF4").ToString();
            tiodate = gridDetail.GetRowCellValue(gridDetail.FocusedRowHandle, "IO_DATE").ToString().Replace("-", "");
            twh = gridDetail.GetRowCellValue(gridDetail.FocusedRowHandle, "DEPOT_NO").ToString();
            tcvcod = gridDetail.GetRowCellValue(gridDetail.FocusedRowHandle, "CVCOD").ToString();
            tcurr = gridDetail.GetRowCellValue(gridDetail.FocusedRowHandle, "CUNIT").ToString();

            sql2 = "";
            sql2 = string.Format("update STOCK_LOCALINVOICE_INFO set iodate = '{0}', ", tiodate);
            sql2 = sql2 + string.Format("TOTAMT = {0}, FREIGHTAMT = {1}, FREIGHTPRC = {2}, ", costAmt, txtFreight.Text.ToString().Replace(",",""), txtFreightPrice.Text.ToString().Replace(",",""));
            sql2 = sql2 + string.Format("RAWAMT = {0}, RAWPRC = {1} , ", txtRawMaterialAmt.Text.ToString().Replace(",", ""), txtRawMaterialPrice.Text.ToString().Replace(",", ""));
            sql2 = sql2 + string.Format("PO_A_DATE = '{0}', MARKS1 = '{1}', MARKS2 = '{2}', ", txtPoDate.Text.ToString(),txtMarks1.Text.ToString(), txtMarks2.Text.ToString());
            sql2 = sql2 + string.Format("MARKS3 = '{0}', MARKS4 = '{1}' ", txtMarks3.Text.ToString(), txtMarks4.Text.ToString());
            
            // 실제 수정가능한 전표인지 check..
            if (txtIojpno.Text != "" && txtIojpno.Text == tempJPNO )
            {
                sql2 = sql2 + string.Format("where locinvoice = '{0}' and iodate = '{1}' and use_wh = '{2}' and invcvcod = '{3}' and iojpno = '{4}'", tlocinvoice, tiodate, twh, tcvcod, tempJPNO);
                dbConnSQL.ExecuteTransactionSql(sql2);

                // 총비용 금액 UPDATE
                sql = "";
                sql = string.Format("update imhist_loc set dref4 = {0} where iojpno = '{1}' ", costAmt, tempJPNO);
                dbConnSQL.ExecuteTransactionSql(sql);
            }
            else if (txtIojpno.Text == "" && tempJPNO != "" && (txtFreight.Text != "" || txtRawMaterialAmt.Text != "" || txtPoDate.Text != "" || txtMarks1.Text != "" || txtMarks2.Text != "" || txtMarks3.Text != "" || txtMarks4.Text != "")) 
            {
                sql2 = "";
                sql2 = "insert into STOCK_LOCALINVOICE_INFO (locinvoice, iodate, use_wh, invcvcod, iojpno, cunit, itemamt, itemprc, freightamt, freightprc, rawamt, rawprc, totamt, po_a_date, marks1, marks2, marks3, marks4)";
                sql2 = sql2 + string.Format("values ('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},", tlocinvoice, tiodate, twh, tcvcod, tempJPNO, tcurr, titemamt, titemprc);
                sql2 = sql2 + string.Format("{0}, {1}, {2}, {3}, ", txtFreight.Text.ToString().Replace(",",""), txtFreightPrice.Text.ToString().Replace(",", ""), txtRawMaterialAmt.Text.ToString().Replace(",", ""), txtRawMaterialPrice.Text.ToString().Replace(",", ""));
                sql2 = sql2 + string.Format("{0},'{1}','{2}','{3}','{4}','{5}' )", titemamt + costAmt, txtPoDate.Text.ToString(), txtMarks1.Text.ToString(), txtMarks2.Text.ToString(), txtMarks3.Text.ToString(), txtMarks4.Text.ToString());

                dbConnSQL.ExecuteTransactionSql(sql2);

                // 총비용 금액 UPDATE
                sql = "";
                sql = string.Format("update imhist_loc set dref4 = {0} where iojpno = '{1}' ", costAmt, tempJPNO);
                dbConnSQL.ExecuteTransactionSql(sql);
            }

            tempJPNO = "";  txtIojpno.Text = ""; costAmt = 0; titemamt = 0; titemprc = 0;

            QueryRefresh();


            //if (gridView.RowCount == 0)
            //{
            //    return;
            //}

            //if (MessageBox.Show("Are you sure you want to save your modifications?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    MessageBox.Show("Canceled saving.", "NOTICE");
            //    return;
            //}

            //for (int i = 0; i < gridView.RowCount + 1; i++)
            //{

            //    if (gridView.IsRowSelected(i) == true)
            //    {
            //        string sql = ""; string sql2 = "";
            //        if (gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOJPNO").ToString() == "")
            //        {

            //        }
            //        else
            //        {
            //            string iodate = ""; string ref4 = ""; string gumdat = "";
            //            iodate = gridView.GetRowCellValue(gridView.GetRowHandle(i), "IO_DATE").ToString().Replace("-", "");
            //            ref4 = gridView.GetRowCellValue(gridView.GetRowHandle(i), "REF4").ToString();
            //            gumdat = gridView.GetRowCellValue(gridView.GetRowHandle(i), "GUMDAT").ToString().Replace("-", "");
            //            double ioqty = 0; double ioreqty = 0; double fioprc = 0; double fioamt = 0; double dref4 = 0;
            //            ioqty = double.Parse(gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOQTY").ToString().Replace(",", ""));
            //            ioqty = Math.Truncate(ioqty);
            //            ioreqty = double.Parse(gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOREQTY").ToString().Replace(",", ""));
            //            ioreqty = Math.Truncate(ioreqty);
            //            fioprc = double.Parse(gridView.GetRowCellValue(gridView.GetRowHandle(i), "FIOPRC").ToString().Replace(",", ""));
            //            fioprc = (Math.Truncate(fioprc * 1000) / 1000);
            //            fioamt = double.Parse(gridView.GetRowCellValue(gridView.GetRowHandle(i), "FIOAMT").ToString().Replace(",", ""));
            //            if (gridView.GetRowCellValue(gridView.GetRowHandle(i), "DREF4").ToString().Replace(",", "") != "")
            //            { 
            //                dref4 = double.Parse(gridView.GetRowCellValue(gridView.GetRowHandle(i), "DREF4").ToString().Replace(",", ""));
            //                dref4 = (Math.Truncate(dref4 * 100) / 100);
            //            }
            //            else
            //            {
            //                dref4 = 0;
            //            }
            ////sql = string.Format("update imhist_loc set io_date = '{0}', ref4 = '{1}', ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "IO_DATE").ToString().Replace("-",""), gridView.GetRowCellValue(gridView.GetRowHandle(i), "REF4").ToString() );
            //sql = string.Format("update imhist_loc set io_date = '{0}', ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "IO_DATE").ToString().Replace("-", ""));
            //            //sql = sql + string.Format(" ioqty = {0}, ioreqty = {1}, ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOQTY").ToString(), gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOREQTY").ToString());
            //            sql = sql + string.Format(" ioqty = {0}, ioreqty = {1}, ", ioqty, ioreqty);
            //            //sql = sql + string.Format(" fioprc = {0}, fioamt = {1}, ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "FIOPRC").ToString(), gridView.GetRowCellValue(gridView.GetRowHandle(i), "FIOAMT").ToString());
            //            sql = sql + string.Format(" fioprc = {0}, fioamt = {1}, ", fioprc, fioamt);
            //            //sql = sql + string.Format(" gumdat = {0} , dref4 = {1} ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "GUMDAT").ToString().Replace("-", ""), gridView.GetRowCellValue(gridView.GetRowHandle(i), "DREF4").ToString().Replace("-", ""));
            //            sql = sql + string.Format(" gumdat = {0} , dref4 = {1} ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "GUMDAT").ToString().Replace("-", ""), dref4);
            //            sql = sql + string.Format(" where iojpno = '{0}' ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOJPNO").ToString());

            //            dbConnSQL.ExecuteTransactionSql(sql);


            //            sql2 = string.Format("update STOCK_LOCALINVOICE_INFO set io_date = '{0}' ", gridView.GetRowCellValue(gridView.GetRowHandle(i), "IO_DATE").ToString().Replace("-", ""));
            //            //sql2 = sql2 + string


            //    }
            //}
            //}


        }
        #endregion

        #region //Grid Lock
        // Grid Lock
        private void gridEditLock()
        {
            if (gridView.RowCount < 0) { return; }

            gridView.Columns["REF4"].OptionsColumn.AllowEdit = false;
            gridView.Columns["IO_DATE"].OptionsColumn.AllowEdit = false;
            gridView.Columns["FIOPRC"].OptionsColumn.AllowEdit = false;
            gridView.Columns["FIOAMT"].OptionsColumn.AllowEdit = false;
            gridView.Columns["IOQTY"].OptionsColumn.AllowEdit = false;
            gridView.Columns["IOREQTY"].OptionsColumn.AllowEdit = false;
            gridView.Columns["GUMDAT"].OptionsColumn.AllowEdit = false;
            gridView.Columns["DREF4"].OptionsColumn.AllowEdit = false;
        }
        #endregion

        #region // Print Button Click

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount < 0)
            {
                return;
            }

            for (int i = 0; i < gridView.RowCount + 1; i++)
            {
                if (gridView.IsRowSelected(i) == true)
                {
                    string iodate = ""; string ref4 = ""; string ref3 = ""; string iojpno = "";

                    iodate = "'" + gridView.GetRowCellValue(gridView.GetRowHandle(i), "IO_DATE").ToString().Replace("-", "") + "'";
                    iojpno = "'" + gridView.GetRowCellValue(gridView.GetRowHandle(i), "IOJPNO").ToString() + "'";
                    ref4 = "'" + gridView.GetRowCellValue(gridView.GetRowHandle(i), "REF4").ToString() + "'";
                    ref3 = "'" + gridView.GetRowCellValue(gridView.GetRowHandle(i), "REF3").ToString() + "'";

                    MainSetting.vInvoicePrint(ref3, ref4, iodate, iojpno);
                }
            }

        }

        #endregion

        #region // Detail Part cell value changed event
        private void gridDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridDetail.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Length > 10)
            {
                gridDetail.SetRowCellValue(e.RowHandle, "GUMDAT", gridDetail.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Substring(0, 10));
            }

            if (e.Column.FieldName == "IOQTY")
            {
                if (double.Parse(gridDetail.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", "")) >= 0)
                {
                    double ioqty = double.Parse(gridDetail.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", ""));
                    ioqty = Math.Truncate(ioqty);
                    double prc = double.Parse(gridDetail.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", ""));
                    string amt = Math.Round((prc * ioqty), 3).ToString();

                    gridDetail.SetRowCellValue(e.RowHandle, "FIOAMT", amt);
                    ioqtyChange = true; ioqtychangeCnt = 2;
                }
                else
                {
                    MessageBox.Show("The quantity issued cannot be less than the number 0.", "NOTICE");
                    return;
                }
            }

            if (e.Column.FieldName == "FIOPRC")
            {
                if (double.Parse(gridDetail.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", "")) > 0)
                {
                    double prc = double.Parse(gridDetail.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", ""));
                    prc = (Math.Truncate(prc * 1000) / 1000);
                    //gridView.SetRowCellValue(e.RowHandle, "FIOPRC", prc);
                    double qty = Math.Truncate(double.Parse(gridDetail.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", "")));
                    qty = Math.Truncate(qty);
                    string amt = Math.Round((prc * qty), 3).ToString();

                    gridDetail.SetRowCellValue(e.RowHandle, "FIOAMT", amt);

                }
            }
        }
        #endregion

        #region // textbox event;

        private void txtFreightPrice_Leave(object sender, EventArgs e)
        {
            if (ioqtyChange == true)
            {
                if (ioqtychangeCnt > 0 ) { ioqtychangeCnt = ioqtychangeCnt - 1; }
                if (ioqtychangeCnt == 0) { ioqtyChange = false; }
            }
            double titemqty = 0;
            for (int i = 0; i < gridDetail.RowCount; i++)
            {
                titemqty = titemqty + double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOQTY").ToString().Replace(",", ""));
            }

            double frg = 0; double frgprc = 0;
            if (txtFreightPrice.Text.ToString() == "") { txtFreightPrice.Text = "0"; }
            frgprc = Math.Truncate(double.Parse(txtFreightPrice.Text.ToString()) * 1000) / 1000;
            txtFreightPrice.Text = string.Format("{0:#,##0.###}", frgprc);
            frg = Math.Round((titemqty * double.Parse(txtFreightPrice.Text.ToString())), 3);
            txtFreight.Text = string.Format("{0:#,##0.##}", frg);
        }

        private void txtRawMaterialPrice_Leave(object sender, EventArgs e)
        {
            if (ioqtyChange == true)
            {
                if (ioqtychangeCnt > 0) { ioqtychangeCnt = ioqtychangeCnt - 1; }
                if (ioqtychangeCnt == 0) { ioqtyChange = false; }
            }
            if (ioqtyChange == true) { ioqtyChange = false; }
            double titemqty = 0;
            for (int i = 0; i < gridDetail.RowCount; i++)
            {
                titemqty = titemqty + double.Parse(gridDetail.GetRowCellValue(gridDetail.GetRowHandle(i), "IOQTY").ToString().Replace(",", ""));
            }

            double raw = 0; double rawprc = 0;
            if (txtRawMaterialPrice.Text.ToString() == "") { txtRawMaterialPrice.Text = "0"; }
            rawprc = Math.Truncate(double.Parse(txtRawMaterialPrice.Text.ToString()) * 1000) / 1000;
            txtRawMaterialPrice.Text = string.Format("{0:#,##0.###}", rawprc);
            raw = Math.Round((titemqty * double.Parse(txtRawMaterialPrice.Text.ToString())), 3);
            txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", raw);
        }

        private void txtFreightPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtFreight.Focus();
            }
        }

        private void txtRawMaterialPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtRawMaterialAmt.Focus();
            }
        }



        private void txtFreight_Leave(object sender, EventArgs e)
        {
            double freight = double.Parse(txtFreight.Text.ToString());
            txtFreight.Text = string.Format("{0:#,##0.##}", freight);
        }

        private void txtRawMaterialAmt_Leave(object sender, EventArgs e)
        {
            double RawMaterialAmt = double.Parse(txtRawMaterialAmt.Text.ToString());
            txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", RawMaterialAmt);
        }
        #endregion

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
