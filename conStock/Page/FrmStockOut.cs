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
using DevExpress.XtraReports.UI;
using System.Globalization;

namespace conStock.Page
{
    public partial class FrmStockOut : UserControl
    {
        private int SelCnt = 0;
        private bool SelChk = false;
        private int totItemcnt = 0;
        private string tempJpno = "";

        private DataSet dsDeliveryList = new DataSet();
        private DataTable dtDelvieryList = new DataTable("NewDeliveryList");

        private string[] prtLcIvc = new string[10]; // Invoice Prt

        public FrmStockOut()
        {
            InitializeComponent();

            MainSetting.CompanySet(cbxCompany);

            SetComBoBX();
            initDeliveryChk();
            GridOut.Dock = DockStyle.Fill;
            GridOut.Visible = true;
            GridOutCancel.Dock = DockStyle.None;
            GridOutCancel.Visible = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
            dateTimePicker1.Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")), int.Parse(DateTime.Now.ToString("MM")), 1);
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            //txtLocalinvoice.Visible = false;
            txtLocalinvoice.Visible = true;
        }

        private void SetComBoBX()
        {
            //Query.QueryParm.Add("STATUS", "SH2");
            MainSetting.SetComboBXSetting(cbxWh, "WHNAME", "WHCODE");
            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", "SH2");
            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            Query.QueryParm.Add("CVCOD", cbxCust.SelectedValue.ToString());
            MainSetting.SetComboBXSetting(cbxItem, "ITDSC", "ITNBR");
            Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());

            Query.QueryParm.Add("LOCALINVOICE", txtLocalinvoice.Text.ToString());
            //MainSetting.SetComboBXSetting(cbxInvoice, "INVOICENAME", "INVOICE");
        }

        private void cbxWh_SelectedValueChanged(object sender, EventArgs e)
        {
            Query.QueryParm = new Dictionary<string, string>() { { "WHCODE", cbxWh.SelectedValue.ToString() } };
            Query.QueryParm.Add("STATUS", "SH2");
            MainSetting.SetComboBXSetting(cbxCust, "CVNAS", "CVCOD");
            Query.QueryParm.Add("CVCOD", cbxCust.SelectedValue.ToString());
            MainSetting.SetComboBXSetting(cbxItem, "ITDSC", "ITNBR");
            Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());
            //MainSetting.SetComboBXSetting(cbxInvoice, "INVOICENAME", "INVOICE");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {   
            QueryRefresh();
        }

        #region // Query Refresh 수정 삭제 후 재조회

        private void QueryRefresh()
        {
            MainSetting.DivisionCHK(cbxCompany);
            SelChk = false;
            SelCnt = 0;
            totItemcnt = 0;
            comboNuuchkTot();
            initDeliveryChk();
            prtLcIvc = MainSetting.vArrInit(prtLcIvc, 10); // save 된 정보 초기화
            txtFreight.Text = "0"; txtFreightPrice.Text = "0";
            txtRawMaterialAmt.Text = "0"; txtRawMaterialPrice.Text = "0";
            txtPoDate.Text = ""; txtMarks1.Text = ""; txtMarks2.Text = ""; txtMarks3.Text = ""; txtMarks4.Text = "";

            Query.QueryParm = new Dictionary<string, string>() { { "CVCOD", cbxCust.SelectedValue.ToString() } };
            Query.QueryParm.Add("ITNBR", cbxItem.SelectedValue.ToString());
            Query.QueryParm.Add("INVOICE", txtLocalinvoice.Text.ToString().ToUpper());
            Query.QueryParm.Add("STATUS", "SH2");
            Query.QueryParm.Add("WHCODE", cbxWh.SelectedValue.ToString());
            Query.QueryParm.Add("DEPOTNO", "");
            Query.QueryParm.Add("FROM", dateTimePicker1.Value.ToString("yyyy-MM-dd").Replace("-", ""));
            Query.QueryParm.Add("TO",   dateTimePicker2.Value.ToString("yyyy-MM-dd").Replace("-", ""));
            Query.QueryParm.Add("LOCALINVOICE", txtLocalinvoice.Text.ToString().ToUpper());
            Query.QueryParm.Add("SAUPJ", cbxCompany.SelectedValue.ToString());

            if (rdoDev.Checked == true)
            {
                Grid.DataSource = Query.StockOut();
                GridOut.DataSource = null;
                GridOut.RepositoryItems.Clear();

                initDeliveryChk();
            }

            if (rdoDevCancel.Checked == true)
            {
                Grid.DataSource = Query.StockOutCancel();
                GridOutCancel.DataSource = null;
                GridOutCancel.RepositoryItems.Clear();
            }
            //gridView.OptionsSelection.CheckBoxSelectorField = "CHK";
            gridView.IndicatorWidth = 0; // click되면 안됨.
        }

        #endregion 

        private void comboNuuchkTot()
        {
            cbxCust = MainSetting.ChkCombNull(cbxCust);
            cbxWh = MainSetting.ChkCombNull(cbxWh);
            cbxItem = MainSetting.ChkCombNull(cbxItem);
            //cbxInvoice = MainSetting.ChkCombNull(cbxInvoice);
            //cbxStat = MainSetting.ChkCombNull(cbxStat);
        }

        #region // 출고 취소 선택시 Delviery cancel Select..

        // 출고 취소선택 시
        private void rdoDevCancel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDevCancel.Checked == true)
            {
                btnCancel.Enabled = true;
                btnSave.Enabled = false;

                QueryRefresh();
                txtPoDate.Enabled = false;
                txtMarks1.Enabled = false; txtMarks2.Enabled = false; txtMarks3.Enabled = false; txtMarks4.Enabled = false;
                txtFreight.Enabled = false; txtFreightPrice.Enabled = false;
                txtRawMaterialPrice.Enabled = false; txtRawMaterialAmt.Enabled = false;

                //gridView.OptionsSelection.MultiSelect = false;
                //gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

                //txtFreight.Visible = false;
                //lblFreight.Visible = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                label3.Text = "Local Invoice";
                txtLocalinvoice.Visible = true;
                
                //cbxInvoice.Visible = false;
                GridOut.DataSource = null;
                GridOut.RepositoryItems.Clear();

                GridOut.Dock = DockStyle.None;
                GridOut.Visible = false;

                GridOutCancel.DataSource = null;
                GridOutCancel.RepositoryItems.Clear();

                GridOutCancel.Dock = DockStyle.Fill;
                GridOutCancel.Visible = true;

                // ONE Gridcontrol
                //GridOut.MainView = gridViewOutCancel;
                //gridViewOutCancel.OptionsSelection.MultiSelect = true;
                //gridViewOutCancel.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                //gridViewOutCancel.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
                //gridViewOutCancel.OptionsBehavior.Editable = false;
                //gridViewOutCancel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                //gridViewOutCancel.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
        }

        #endregion

        #region // 출고 체크시

        private void rdoDev_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDev.Checked == true)
            {
                btnCancel.Enabled = false;
                btnSave.Enabled = true;

                QueryRefresh();
                txtFreight.Visible = true;
                lblFreight.Visible = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                label3.Text = "[HH]Invoice";
                //cbxInvoice.Visible = true;
                //txtLocalinvoice.Visible = false;
                txtLocalinvoice.Visible = true;

                txtPoDate.Enabled = true;
                txtMarks1.Enabled = true; txtMarks2.Enabled = true; txtMarks3.Enabled = true; txtMarks4.Enabled = true;
                txtFreight.Enabled = true; txtFreightPrice.Enabled = true;
                txtRawMaterialPrice.Enabled = true; txtRawMaterialAmt.Enabled = true;

                gridView.OptionsSelection.MultiSelect = true;
                gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                GridOut.DataSource = null;
                GridOut.RepositoryItems.Clear();

                GridOut.Dock = DockStyle.Fill;
                GridOut.Visible = true;

                GridOutCancel.DataSource = null;
                GridOutCancel.RepositoryItems.Clear();

                GridOutCancel.Dock = DockStyle.None;
                GridOutCancel.Visible = false;

                initDeliveryChk();

                //gridview 초기화
                //RepositoryItemComboBox repositoryItemComboBox;
                //gridViewOut.Columns["IO_DATE"].ColumnEdit = repositoryItemDateEdit2;
                //gridViewOut.Columns["GUMDAT"].ColumnEdit = repositoryItemDateEdit2;

                ////gridViewOut.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                //gridViewOut.SetRowCellValue(gridViewOut.FocusedRowHandle, "REF3", inv);

            }
        }

        #endregion

        #region // First Select delivery Data Datatable initialize

        // 맨처음 선택될 출고데이터 데이터테이블 초기화
        private void initDeliveryChk()
        {
            // datatabel 생성.
            dtDelvieryList = null;
            string sql = "select nvl(invoice,'') invoice, '' as iojpno, '' as sudate, 'O02' as iogbn, '' as io_date, itnbr , '' as pspec, '' as opseq, '' as depot_no, cvcod, ";
            sql = sql + "cvcod as napvnd, '' depot_out, 0 ioqty, 0 ioreqty, cino , expno as pordno, '' ref4, 0 fioprc, 0 fioamt, '' gumdat, '' bigo, 'R' flag, 'N' chk, '' cunit, ";
            sql = sql + "arrdate, 0 jqty, 0 jbqty, '' salescvcod , '' saupj from stockmonth_loc where invoice = '' ";

            dtDelvieryList = dbConnSQL.ExecuteSQLReturnDataTable(sql);
            GridOut.DataSource = dtDelvieryList;
            InitArray(30);
        }
        #endregion

        #region  // SAVE BUTTON Click

        // SAVE click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridViewOut.RowCount == 0)
            {
                return;
            }
            // 필수값 입력 체크
            if (InsertValueChk() == false)
            {
                MessageBox.Show("Required input values ​​are not entered.", "CAUTION");
                return;
            }
            prtLcIvc = MainSetting.vArrInit(prtLcIvc, 10);
            string InvChk = ""; string CvcodChk = ""; string IodateChk = ""; string itemChk = ""; string cunitChk = ""; double itemprcChk = 0;

            #region // Local Invoice check
            // Local Invoice check
            //for (int i = 1;i <= dtDelvieryList.Rows.Count; i++)
            //{
                foreach (DataRow row in dtDelvieryList.Rows)
                {
                    if (InvChk == "")
                    {
                        InvChk = row["REF4"].ToString().ToUpper();
                        CvcodChk = row["CVCOD"].ToString();
                        IodateChk = row["IO_DATE"].ToString();
                        itemChk = row["ITNBR"].ToString();
                        cunitChk = row["CUNIT"].ToString();
                        itemprcChk = double.Parse(row["FIOPRC"].ToString());
                    }
                    else
                    {
                        if (InvChk != row["REF4"].ToString().ToUpper() || CvcodChk != row["CVCOD"].ToString() || IodateChk != row["IO_DATE"].ToString() || itemChk != row["ITNBR"].ToString())
                        {
                            MessageBox.Show("Local Invoice / Buyer / Delivery Date / Item is different. Please check.", "Check DATA");
                            return;
                        }
                    }
                }
            //}
            #endregion

            if (MessageBox.Show("Are you sure you want to save your selections?", "NOTICE",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Canceled saving.", "NOTICE");
                return;
            }
            int intCnt = 1; double rowAmt = 0; double rowQty = 0;  double invtotAmt = 0;

            // local invoice duplication check
            if (Query.localinvoiceCheck(InvChk) == false)
            {
                MessageBox.Show("The same invoice exists. Please check.!!", "Warning");
                return;
            }
            MainSetting.DivisionCHK(cbxCompany);

            // prtLcInv[i] => 1: local invoice, 2: iodate, 3: 전표번호, 4: freight, 5:freight price, 6: Raw Material Price, 7 : Raw Material, 8 : DEPT_NO(wh), 9 : CVCOD(BUYER)
            //for (int i = 1; i <= dtDelvieryList.Rows.Count ; i++) {
            foreach (DataRow row in dtDelvieryList.Rows)
                {
                    if (intCnt == 1)
                    {
                        prtLcIvc[4] = txtFreight.Text.ToString();
                        prtLcIvc[0] = "'" + row["INVOICE"].ToString() + "'";
                        prtLcIvc[1] = "'" + row["REF4"].ToString().ToUpper() + "'";
                        prtLcIvc[2] = "'" + row["IO_DATE"].ToString() + "'";
                        prtLcIvc[8] = "'" + row["DEPOT_NO"].ToString() + "'";
                        // prtLcIvc[9] = "'" + row["CVCOD"].ToString() + "'";
                        prtLcIvc[5] = txtFreightPrice.Text;  prtLcIvc[6] = txtRawMaterialPrice.Text;  prtLcIvc[7] = txtRawMaterialAmt.Text;
                    } //freight check
                    if (intCnt != 1) { prtLcIvc[4] = "0"; prtLcIvc[5] = "0"; prtLcIvc[6] = "0"; prtLcIvc[7] = "0"; }
                    //prtLcIvc[0] = prtLcIvc[0] + "'" + row["INVOICE"].ToString() + "',";  // invoice 2개 이상일수 있다.
                    //prtLcIvc[1] = prtLcIvc[1] + "'" + row["REF4"].ToString().ToUpper() + "',";
                    //prtLcIvc[2] = prtLcIvc[2] + "'" + row["IO_DATE"].ToString() + "',";
                    SaveDeliveryData(row);

                    rowAmt = rowAmt + double.Parse(row["FIOAMT"].ToString());
                    rowQty = rowQty + double.Parse(row["IOQTY"].ToString());

                    intCnt = intCnt + 1;
                }
            //}
            string sql = "";
            invtotAmt = Math.Round(rowAmt + double.Parse(txtRawMaterialAmt.Text.ToString()) + double.Parse(txtFreight.Text.ToString()), 2);
            // 총비용 금액 UPDATE
            sql = "";
            sql = string.Format("update imhist_loc set dref4 = {0} where iojpno = '{1}' ", (double.Parse(txtRawMaterialAmt.Text.ToString()) + double.Parse(txtFreight.Text.ToString())), tempJpno);
            dbConnSQL.ExecuteTransactionSql(sql);

            // Invoice 전체사항 Insert

            sql = "";
            sql = "INSERT INTO STOCK_LOCALINVOICE_INFO (LOCINVOICE, IODATE, USE_WH, INVCVCOD, CUNIT, ITEMAMT, ITEMPRC, FREIGHTAMT, FREIGHTPRC, ";
            sql = sql + "RAWAMT, RAWPRC, TOTAMT, ONBOARD, PICKDATE,  PO_A_DATE, MARKS1, MARKS2, MARKS3,MARKS4,iojpno ) VALUES (";
            sql = sql + string.Format("{0}, {1}, {2},'{3}', '{4}', {5}, {6}, {7}, {8},", prtLcIvc[1], prtLcIvc[2].ToString().Replace("-",""), prtLcIvc[8], CvcodChk, cunitChk, rowAmt, itemprcChk, double.Parse(txtFreight.Text.ToString()), double.Parse(txtFreightPrice.Text.ToString()));
            sql = sql + string.Format("{0}, {1}, {2}, '{3}', {4} ,", double.Parse(txtRawMaterialAmt.Text.ToString()), double.Parse(txtRawMaterialPrice.Text.ToString()), invtotAmt, "", prtLcIvc[2].ToString().Replace("-", "")[2]);
            sql = sql + string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )", txtPoDate.Text.ToString(), txtMarks1.Text.ToString(), txtMarks2.Text.ToString(), txtMarks3.Text.ToString(), txtMarks4.Text.ToString(), tempJpno );

            dbConnSQL.ExecuteTransactionSql(sql);

            

            tempJpno = "";
            // invoice Print 
            
            int lCnt = 0;
            //lCnt = prtLcIvc[0].Length;
            //prtLcIvc[0] = prtLcIvc[0].Substring(0, lCnt - 1);
            //lCnt = 0; lCnt = prtLcIvc[1].Length;
            //prtLcIvc[1] = prtLcIvc[1].Substring(0, lCnt - 1);
            lCnt = 0; lCnt = prtLcIvc[2].Length;
            prtLcIvc[2] = prtLcIvc[2].Substring(0, lCnt - 1);
            lCnt = 0; lCnt = prtLcIvc[3].Length;
            prtLcIvc[3] = prtLcIvc[3].Substring(0, lCnt - 1);
            // Save Invoice Print
            InvoicePrint(prtLcIvc[0], prtLcIvc[1], prtLcIvc[2], prtLcIvc[3]);
            QueryRefresh();

            prtLcIvc = MainSetting.vArrInit(prtLcIvc, 10);
            //initial freigtht
            txtFreight.Text = "0"; txtFreightPrice.Text = "0"; txtRawMaterialPrice.Text = "0"; txtRawMaterialAmt.Text = "0";
            totItemcnt = 0;
        }
        #endregion

        #region // Printed here only here (여기에서만 사용 수정시 Mainsetting에도 수정)
        private void InvoicePrint(string vInvoice, string vLinvoice, string vOutDate, string vIojpno)
        {
            this.Cursor = Cursors.WaitCursor;

            string sql = "select a.*, b.*, c.*, (b.addr1||b.addr2) as addr , '" + vInvoice.ToString().Replace("'", "") + "' inv  , (select distinct sudat from imhist_loc where iogbn = 'O02' and ref3 = '" + vInvoice.ToString().Replace("'", "") + "') as sudat ";
            sql = sql + " from (select b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod) as partno, cvcod as pcvcod, ref4, io_date, depot_out as pdepot_out, fioprc, ";
            sql = sql + " d.itemamt, d.itemprc, d.freightamt, d.freightprc, d.rawamt, d.rawprc, d.totamt as totamt, d.loading as ploading, d.carrier as pcarrier, d.onboard, ";
            sql = sql + " d.pickdate, d.po_a_date, d.marks1, d.marks2, d.marks3, d.marks4, d.lcissue1, d.lcissue2, d.lcissue3, ";
            sql = sql + " sum(ioqty) as ioqty, sum(ioreqty) as ioreqty, sum(fioamt) as fioamt , sum(nvl(dref4,0)) as dref4 , sum(fioamt + nvl(dref4,0)) as ptotamt from imhist_loc a join itemas b on a.itnbr = b.itnbr";
            sql = sql + string.Format(" left join STOCK_LOCALINVOICE_INFO d on a.ref4 = d.locinvoice where ref4 IN ({0}) ", vLinvoice);
            //sql = sql + string.Format("where io_date in ({0}) and ref4 = ({1}) ",vOutDate, vLinvoice);
            sql = sql + " group by b.itdsc, FUN_GET_ITMBUY_BUNBR(a.itnbr, a.cvcod), cvcod,ref4,io_date,depot_out, fioprc, d.itemamt, d.itemprc, d.freightamt, d.freightprc, d.rawamt, d.rawprc, d.totamt, d.loading, d.carrier, d.onboard, d.pickdate, d.po_a_date, d.marks1, d.marks2, d.marks3, d.marks4, d.lcissue1, d.lcissue2, d.lcissue3 ) a ";
            sql = sql + " join inv_company  b on b.eff_date <= a.io_date and b.end_date >= a.io_date and a.pdepot_out = b.use_wh ";
            sql = sql + " join inv_buyer_info c on a.pcvcod = c.cvcod and a.pdepot_out = c.use_wh and c.eff_date <= a.io_date and c.end_date >= a.io_date ";
            //string sql = string.Format("select distinct REF4, IO_DATE from imhist_loc where ref3 = '{0}' and ref4 = '{1}' and io_date = '{2}';", vInvoice, vLinvoice, vOutDate);
            //sql = sql + "select * from INV_COMPANY where end_date >= '20220411' and eff_date <= '20220411' and use_wh = 'B01';";
            DataSet dtPrt = Query.PrtInvoiceGet(sql);
            //dtPrt = Query.PrtInvoiceGet(sql);

            ToraInvoice report = new ToraInvoice(dtPrt);
            ReportPrintTool printTool = new ReportPrintTool(report);
            //printTool.Print();
            printTool.ShowPreview();
            //printTool.ShowRibbonPreviewDialog();
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region // Primary value check(Include Freight  cost check)

        // 필수 값 체크 구문. Include Freight  cost check
        private bool InsertValueChk()
        {
            //int stockQty = gridView.Columns.
            for (int i = 1; i < dtDelvieryList.Rows.Count + 1; i++)
            {
                foreach (DataRow chkRow in dtDelvieryList.Rows)
                {
                    if (chkRow["IO_DATE"].ToString() == "") { return false; }
                    if (chkRow["DEPOT_NO"].ToString() == "") { return false; }
                    if (chkRow["IOQTY"].ToString() == "") { return false; }
                    if (chkRow["IOREQTY"].ToString() == "") { return false; }
                    if (chkRow["CVCOD"].ToString() == "") { return false; }
                    if (chkRow["REF4"].ToString() == "") { return false; }
                    if (chkRow["FIOPRC"].ToString() == "") { return false; }
                    if (chkRow["FIOAMT"].ToString() == "") { return false; }
                    if (chkRow["GUMDAT"].ToString() == "") { return false; }  
                    // check delivery Qty, box Qty.
                    if (Int32.Parse((chkRow["IOQTY"].ToString())) > Int32.Parse( chkRow["JQTY"].ToString()))
                    {
                        MessageBox.Show("The issued quantity cannot be greater than the stock quantity.", "CAUTION");
                        return false;
                    }
                    if (Int32.Parse((chkRow["IOREQTY"].ToString())) > Int32.Parse(chkRow["JBQTY"].ToString()))
                    {
                        MessageBox.Show("The issued quantity cannot be greater than the stock quantity.", "CAUTION");
                        return false;
                    }
                    // Freight check
                    if (txtFreight.Text.ToString() == "") { txtFreight.Text = "0"; }
                    if (double.Parse((txtFreight.Text.ToString().Replace(",",""))) == 0)
                    {
                        if (MessageBox.Show("You have not entered a freight cost. Do you want to continue.?", "Freight Check", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        #endregion

        #region // 출고데이터 저장 하기 / 하위 그리드 초기화 / 전표번호 만들어 주기
        private void SaveDeliveryData(DataRow inRow)
        {
            string saupj = "";
            inArr.Initialize();
            InitArray(30);

            inArr[1] = inRow["SUDATE"].ToString();
            inArr[2] = "O02";
            inArr[3] = inRow["ITNBR"].ToString();
            inArr[4] = inRow["PSPEC"].ToString();
            inArr[5] = inRow["OPSEQ"].ToString();
            inArr[6] = inRow["DEPOT_NO"].ToString();
            inArr[7] = inRow["CVCOD"].ToString();
            inArr[8] = inRow["NAPVND"].ToString();
            inArr[9] = inRow["DEPOT_NO"].ToString(); // DEPOT_OUT
            inArr[10] = inRow["IOQTY"].ToString();
            inArr[11] = inRow["IOREQTY"].ToString();
            inArr[12] = inRow["IO_DATE"].ToString().Replace("-","").Substring(0, 8);
            inArr[13] = inRow["CINO"].ToString();
            inArr[14] = inRow["PORDNO"].ToString();
            inArr[15] = inRow["GUMDAT"].ToString().Replace("-", "").Substring(0, 8);
            inArr[16] = inRow["CUNIT"].ToString();
            inArr[17] = inRow["FIOPRC"].ToString();
            inArr[18] = inRow["FIOAMT"].ToString();
            inArr[19] = MainSetting.gUserID; // USER
            //inArr[20] = ""; // DATE
            //inArr[21] = ""; // TIME
            inArr[20] = inRow["INVOICE"].ToString();
            inArr[21] = inRow["REF4"].ToString().ToUpper();
            inArr[22] = inRow["BIGO"].ToString(); 
            inArr[23] = inRow["SALESCVCOD"].ToString();
            //inArr[24] = inRow["CHK"].ToString();
            saupj = inRow["SAUPJ"].ToString();
            if (saupj.ToString() == "")
            {
                saupj = dbConnInfo.Division.ToString();
            }

            string valueSql = "";
            for (int i = 1; i < 24; i++)
            {
                if (i == 10 || i == 11 || i == 17 || i == 18 )
                {
                    valueSql = valueSql + string.Format("{0}, ", inArr[i]);
                }
                else
                {
                    valueSql = valueSql + string.Format("'{0}', ", inArr[i]);
                }
            }

            // 전표번호 채번하기

            string iojpno = "";
            double seq = 0;
            double maxSeq = 0;
            char pad = '0';
            string ls_date = inRow["IO_DATE"].ToString().Replace("-", "").Substring(0,8);
            string sQuery = string.Format("select max(iojpno ) from  imhist_loc where iojpno like '{0}' || '%'", ls_date);
            iojpno = Query.stringReturn(sQuery);

            if (iojpno == "")
            {
                seq = 1;
            }
            else
            {
                seq = double.Parse(iojpno.Substring(8, 4));
                maxSeq = double.Parse(iojpno.Substring(12, 4));
            }
            maxSeq = maxSeq + 1;
            iojpno = ls_date + seq.ToString().PadLeft(4, pad) + maxSeq.ToString().PadLeft(4, pad);
            string today = DateTime.Now.ToString("yyyyMMdd hhmmss");
            string inDate = today.Substring(0, 8);
            string inTime = today.Substring(9, 6);
            if (iojpno.Length != 16)
            {
                return;
            }
            sQuery = " ";
            // Invoice Save
            sQuery = "insert into imhist_loc (iojpno, sudat, iogbn, itnbr, pspec, opseq, depot_no, cvcod, napvnd, depot_out, ioqty, ioreqty, io_date, cino, ";
            sQuery = sQuery + " pordno, gumdat, cunit, fioprc, fioamt, crt_user, ref3, ref4, bigo, salescvcod, crt_date, crt_time ,saupj ) values ( ";  // , dref4
            sQuery = sQuery + string.Format("'{0}', ", iojpno);
            sQuery = sQuery + valueSql + string.Format("'{0}','{1}','{2}' ) ", inDate, inTime, saupj);  // , '{2}' , prtLcIvc[4].ToString().Replace(",", "") //   + double.Parse(prtLcIvc[4].ToString().Replace(",","")) + ")";

            // Print iojpno add
            prtLcIvc[3] = prtLcIvc[3] + "'" + iojpno.ToString() + "',";

            // save command 
            dbConnSQL.ExecuteTransactionSql(sQuery);
            if (tempJpno == "") { tempJpno = iojpno.ToString(); }
            
            //// Invoice Freight
            //sQuery = "";
            //sQuery = "insert into stock_invoice_amt (std_yymm, localinvoice, salescvcod, cunit, freight_amt, mat_amt, etc_amt, dr_amt, cr_amt, ja_amt";
        }

        #endregion

        private string[] inArr = new string[30]; // 변수 저장.

        // Array 초기화
        private void InitArray(int arrCnt)
        {
            for (int i = 0; i < arrCnt ; i ++ )
            {
                inArr[i] = "";
            }
        }


        #region // head grid 선택 및 선택해제시 
        // 선택된 출고데이터 그리드상에 ROW 추가하기
        private void AddRowGridOut(int colCnt)
        {
            DataRow dtRow = dtDelvieryList.NewRow();

            for (int i = 0; i < colCnt+ 1; i++)
            {
                dtRow[i] = inArr[i];

            }
            dtDelvieryList.Rows.Add(dtRow);
        }

        // 선택해제시 그리드에 해당값 삭제.
        private void DeliverySelectCancel(string invioce)
        {
            foreach (DataRow row in dtDelvieryList.Rows)
            {
                if (row["INVOICE"].ToString() == invioce)
                {
                    dtDelvieryList.Rows.Remove(row);
                    return;
                }
            }
            
        }
        #endregion

        #region // HEAD GRID 선택 시 출고, 삭제 선택시

        private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
            if (rdoDev.Checked == true)
            {
                if (gridView.IsRowSelected(gridView.FocusedRowHandle) == true)
                {
                    SelChk = true;
                    SelCnt = SelCnt + 1;
                    inArr.Initialize();
                    InitArray(30);

                    // 출고값 배열에 넣기
                    inArr[0] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "INVOICE").ToString(); // invoice
                    inArr[1] = "IOJPNO";
                    inArr[2] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "SHIPDATE").ToString().Replace("-","");
                    inArr[3] = "O02";  // iogbn
                    inArr[4] = ""; //io_date
                    inArr[5] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ITNBR").ToString();
                    inArr[6] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "PSPEC").ToString();
                    inArr[7] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "OPSEQ").ToString();
                    inArr[8] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DEPOT_NO").ToString();
                    inArr[9] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "CVCOD").ToString();
                    inArr[10] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "CVCOD").ToString();
                    inArr[11] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DEPOT_NO").ToString(); // DEPOT_OUT
                    inArr[12] = "0";
                    inArr[13] = "0";
                    inArr[14] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "CINO").ToString();
                    inArr[15] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "PORDNO").ToString();
                    inArr[16] = ""; // REF4 DELIVERY(LOCAL) INVOICE
                    inArr[17] = "0"; // FIOPRC
                    inArr[18] = "0"; // FIOAMT
                    inArr[19] = ""; // nego day
                    inArr[20] = "";  // REMARK
                    inArr[21] = "R";
                    inArr[22] = "N";
                    inArr[23] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "CUNIT").ToString();  // CUNIT
                    inArr[24] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ARRDATE").ToString(); // arrdate
                    inArr[25] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "JQTY").ToString(); // stockQty  .Replace(",","").Replace(" ","")
                    inArr[26] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "JBQTY").ToString(); // stockQtybox .Replace(",","").Replace(" ", "")
                    inArr[27] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "SALESCVCOD").ToString();
                    inArr[28] = gridView.GetRowCellValue(gridView.FocusedRowHandle, "SAUPJ").ToString();

                    AddRowGridOut(28);

                } 
                else
                {
                    SelCnt = SelCnt - 1;
                    // 선택해제한 인보이스 임시 
                    string invoice = gridView.GetRowCellValue(gridView.FocusedRowHandle, "INVOICE").ToString();
                    // 인보이스 삭제 루틴 넣기
                    DeliverySelectCancel(invoice);
                    if (SelCnt == 0)
                    {
                        SelChk = false;
                    }
                }
            }
            else if (rdoDevCancel.Checked == true)
            {
                if (gridView.IsRowSelected(gridView.FocusedRowHandle) == true)
                {
                    SelChk = true;  // 상태 체크값
                    SelCnt = SelCnt + 1; // 총 체크 카운터 값
                    if (SelCnt > 1)
                    {
                        MessageBox.Show("You can only select one invoice when you select Cancel Delivery.", "NOTICE");
                        //gridView.RefreshRow(gridView.FocusedRowHandle);
                        //gridView.InvertRowSelection
                        
                        return;
                    }
                    string invoice = "";
                    string itnbr = "";

                    invoice = gridView.GetRowCellValue(gridView.FocusedRowHandle, "INVOICE").ToString();
                    itnbr = gridView.GetRowCellValue(gridView.FocusedRowHandle, "ITNBR").ToString();

                    Query.QueryParm = new Dictionary<string, string>() { { "INVOICE", invoice } };
                    Query.QueryParm.Add("ITNBR", itnbr);

                    DevCancelList(); // 취소할 출고 list
                    string locInvoice = gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "REF4").ToString();
                    //string iodate     = gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "IO_DATE").ToString();

                    Query.QueryParm.Add("REF4",   gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "REF4").ToString());
                    Query.QueryParm.Add("IODATE", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "IO_DATE").ToString().Replace("-",""));
                    Query.QueryParm.Add("WHCODE", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "DEPOT_NO").ToString());
                    Query.QueryParm.Add("CVCOD", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "CVCOD").ToString());

                    DeliveryCancelInvoiceinfo(); // Invoice info. table 정보 넣기
                }
                else
                {
                    SelCnt = SelCnt - 1;
                    if (SelCnt > 1)
                    {
                        MessageBox.Show("You can only select one invoice when you select Cancel Delivery.", "NOTICE");
                        gridView.RefreshRow(gridView.FocusedRowHandle);
                        return;
                    }
                    else if (SelCnt == 0)
                    {
                        Query.QueryParm = new Dictionary<string, string>() { { "INVOICE", "" } };
                        Query.QueryParm.Add("ITNBR", "");

                        txtFreight.Text = "0"; txtFreightPrice.Text = "0";
                        txtRawMaterialAmt.Text = "0"; txtRawMaterialPrice.Text = "0";
                        txtPoDate.Text = ""; txtMarks1.Text = ""; txtMarks2.Text = ""; txtMarks3.Text = ""; txtMarks4.Text = "";
                        DevCancelList(); // 취소할 출고 list
                                         //string locInvoice = gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "REF4").ToString();

                        //    Query.QueryParm.Add("REF4", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "REF4").ToString());
                        //    Query.QueryParm.Add("IODATE", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "IO_DATE").ToString().Replace("-", ""));
                        //    Query.QueryParm.Add("WHCODE", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "DEPOT_NO").ToString());
                        //    Query.QueryParm.Add("CVCOD", gridViewDeliveryCancel.GetRowCellValue(gridViewDeliveryCancel.FocusedRowHandle, "CVCOD").ToString());

                        //    DeliveryCancelInvoiceinfo(); // Invoice info. table 정보 넣기
                    }

                    //gridView.RefreshRow(gridView.FocusedRowHandle);
                    SelChk = false;    
                }
            }
        }

        #endregion

        #region  // 취소할 출고 list Query
        private void DevCancelList()
        {
            //GridOut.DataSource = Query.StockOutCancelList();
            GridOutCancel.DataSource = Query.StockOutCancelList();

            gridViewDeliveryCancel.IndicatorWidth = 20;
        }
        #endregion

        #region  // 취소할 출고 Local Invoice 정보 List -- STOCK_LOCALINVOICE_INFO 정보 List up
        private void DeliveryCancelInvoiceinfo()
        {

            DataTable dt = Query.StockOutCancelLocinvoiceList();
            if (dt == null) { return; }
            if (dt.Rows.Count == 0)
            {
                return;
            }
            txtPoDate.Text = dt.Rows[0]["PO_A_DATE"].ToString();
            //txtPoDate.Enabled = false;

            txtMarks1.Text = dt.Rows[0]["MARKS1"].ToString();
            txtMarks2.Text = dt.Rows[0]["MARKS2"].ToString();
            txtMarks3.Text = dt.Rows[0]["MARKS3"].ToString();
            txtMarks4.Text = dt.Rows[0]["MARKS4"].ToString();
            //txtMarks1.Enabled = false; txtMarks2.Enabled = false; txtMarks3.Enabled = false; txtMarks4.Enabled = false;

            txtFreight.Text = string.Format("{0:#,##0.##}", double.Parse(dt.Rows[0]["FREIGHTAMT"].ToString()));
            txtFreightPrice.Text = string.Format("{0:#,##0.###}", double.Parse(dt.Rows[0]["FREIGHTPRC"].ToString()));
            //txtFreight.Enabled = false; txtFreightPrice.Enabled = false;

            txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", double.Parse(dt.Rows[0]["RAWAMT"].ToString()));
            txtRawMaterialPrice.Text = string.Format("{0:#,##0.###}", double.Parse(dt.Rows[0]["RAWPRC"].ToString()));
            //txtRawMaterialPrice.Enabled = false; txtRawMaterialAmt.Enabled = false;
        }
        #endregion

        #region   // CANCEL BUTTON CLICK
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (gridViewDeliveryCancel.RowCount == 0) { return; }

            if (MessageBox.Show("Are you sure you want to save the delivery cancellation of the selected item?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Canceled.", "NOTICE");
                return;
            }

            MainSetting.DivisionCHK(cbxCompany);

            // 삭제시 전체 삭제 수정
            for (Int32 i = 0; i < gridViewDeliveryCancel.RowCount; i++ )
            {
                //string aa = gridViewDeliveryCancel.IsRowSelected(i).ToString();
                // delete시 전체 삭제.. 아래 주석
                //if (gridViewDeliveryCancel.IsRowSelected(i) == true)
                //{
                SaveDeliveryCancelData(i);
                //}
            }

            // Local Invoice Information delete
            SaveDeliveryCancelDateLocalInvoice(gridViewDeliveryCancel.GetRowCellValue(0, "REF4").ToString(), gridViewDeliveryCancel.GetRowCellValue(0, "IO_DATE").ToString(), gridViewDeliveryCancel.GetRowCellValue(0, "DEPOT_NO").ToString(), gridViewDeliveryCancel.GetRowCellValue(0, "CVCOD").ToString());
            txtFreight.Text = "0"; txtFreightPrice.Text = "0";
            txtRawMaterialAmt.Text = "0"; txtRawMaterialPrice.Text = "0";
            txtPoDate.Text = ""; txtMarks1.Text = ""; txtMarks2.Text = ""; txtMarks3.Text = ""; txtMarks4.Text = "";

            QueryRefresh();
        }

        #endregion

        #region  // delivery cancel(delete) data save  -- imhist_loc 삭제
        private void SaveDeliveryCancelData(int rowCnt)
        {
            inArr.Initialize();
            InitArray(30);

            inArr[0] = gridViewDeliveryCancel.GetRowCellValue(rowCnt, "IOJPNO").ToString();
            inArr[1] = gridViewDeliveryCancel.GetRowCellValue(rowCnt, "REF3").ToString();
            inArr[2] = gridViewDeliveryCancel.GetRowCellValue(rowCnt, "REF4").ToString();
            inArr[3] = gridViewDeliveryCancel.GetRowCellValue(rowCnt, "ITNBR").ToString();
            inArr[4] = gridViewDeliveryCancel.GetRowCellValue(rowCnt, "SAUPJ").ToString();
            string sql = "";
            sql = string.Format("delete from imhist_loc where iojpno = '{0}' and ref3 = '{1}' and ref4 = '{2}' and itnbr = '{3}' and saupj = '{4}' ", inArr[0], inArr[1], inArr[2], inArr[3], inArr[4]);
            // 삭제 실행문.
            dbConnSQL.ExecuteTransactionSql(sql);

        }
        #endregion

        #region  // Delivery 삭제시 Local Invoice 정보 삭제. -- STOCK_LOCALINVOICE_INFO 삭제
        private void SaveDeliveryCancelDateLocalInvoice(string ref4, string iodate, string wh, string cvcod)
        {
            string sql = "";
            sql = string.Format("delete from STOCK_LOCALINVOICE_INFO where locinvoice = '{0}' and  iodate = '{1}' and use_wh = '{2}' and invcvcod = '{3}'", ref4, iodate.ToString().Replace("-",""), wh, cvcod);

            // 삭제 실행문.
            dbConnSQL.ExecuteTransactionSql(sql);

        }
        #endregion

        #region // delivery out selections check
        private void gridViewOut_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "IO_DATE")
            {
                if ((gridViewOut.GetRowCellValue(e.RowHandle, "IO_DATE").ToString() == "")) { return; }
                //string iodate = "6/12/2012";//gridViewOut.GetRowCellValue(e.RowHandle, "IO_DATE").ToString();
                //DateTime ioDT;
                //ioDT = DateTime.ParseExact(iodate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (gridViewOut.GetRowCellValue(e.RowHandle, "IO_DATE").ToString().Length > 10)
                {
                    gridViewOut.SetRowCellValue(e.RowHandle, "IO_DATE", gridViewOut.GetRowCellValue(e.RowHandle, "IO_DATE").ToString().Substring(0, 10));
                    DateTime gmdat = DateTime.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "IO_DATE").ToString());
                    gmdat = gmdat.AddDays(60);
                    gridViewOut.SetRowCellValue(e.RowHandle, "GUMDAT", gmdat.ToString("yyyy-MM-dd"));
                }
            }
            if (e.Column.FieldName == "GUMDAT")
            {
                if (gridViewOut.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Length > 10)
                {
                    gridViewOut.SetRowCellValue(e.RowHandle, "GUMDAT", gridViewOut.GetRowCellValue(e.RowHandle, "GUMDAT").ToString().Substring(0, 10));
                }
            }
            if (e.Column.FieldName == "IOQTY")
            {
                if (double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", "")) == 0)
                {
                    return;
                }
                if (double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",","")) > 0)
                {
                    double prc = double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "FIOPRC").ToString());
                    prc = (Math.Truncate(prc * 1000) / 1000);
                    double qty = Math.Truncate(double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", "")));
                    string amt = Math.Round((prc * qty), 3).ToString();

                    dtDelvieryList.Rows[e.RowHandle].BeginEdit();
                    dtDelvieryList.Rows[e.RowHandle]["FIOAMT"] = amt;
                    dtDelvieryList.Rows[e.RowHandle].EndEdit();
                    dtDelvieryList.AcceptChanges();
                }
            }
            if (e.Column.FieldName == "FIOPRC")
            {
                if (double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", "")) > 0)
                {
                    double prc = double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "FIOPRC").ToString().Replace(",", ""));
                    prc = (Math.Truncate(prc * 1000) / 1000);
                    double qty = Math.Truncate(double.Parse(gridViewOut.GetRowCellValue(e.RowHandle, "IOQTY").ToString().Replace(",", "")));
                    string amt = Math.Round((prc * qty),3).ToString();

                    dtDelvieryList.Rows[e.RowHandle].BeginEdit();
                    dtDelvieryList.Rows[e.RowHandle]["FIOAMT"] = amt;
                    dtDelvieryList.Rows[e.RowHandle].EndEdit();
                    dtDelvieryList.AcceptChanges();

                    //gridViewOut.SetRowCellValue(e.RowHandle, "FIOAMT", gridViewOut.GetRowCellValue(e.RowHandle, "FIOAMT").ToString());
                }
            }
        }
        #endregion

        private void gridViewOut_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "IO_DATE")
            {
                e.RepositoryItem = this.repositoryItemDateEdit1;

            }
            if (e.Column.FieldName == "GUMDAT")
            {
                e.RepositoryItem = this.repositoryItemDateEdit2;
            }
        }

        #region // Saved Invoice Print..

        // Saved Invoice Print..
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                // Save시 Print Value 값 선택되어 있음.
                if (prtLcIvc[1].ToString() == "" || prtLcIvc[0].ToString() == "" || prtLcIvc[2].ToString() == "")
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("There is no data to print.", "Information");
                    return;
                }
                MainSetting.DivisionCHK(cbxCompany);

                // string format adjust.
                int strLenCnt = prtLcIvc[0].Length;
                //prtLcIvc[0] = prtLcIvc[0].ToString().Substring(0, strLenCnt - 1);
                //strLenCnt = prtLcIvc[1].Length;
                //prtLcIvc[1] = prtLcIvc[1].ToString().Substring(0, strLenCnt - 1);
                strLenCnt = prtLcIvc[2].Length;
                prtLcIvc[2] = prtLcIvc[2].ToString().Substring(0, strLenCnt - 1);
                strLenCnt = prtLcIvc[3].Length;
                prtLcIvc[3] = prtLcIvc[3].ToString().Substring(0, strLenCnt - 1);

                InvoicePrint(prtLcIvc[0], prtLcIvc[1], prtLcIvc[2], prtLcIvc[3]);

                //InvoicePrint("HHLH-211219-10R80", "'HHA-220509-506'", "2022-05-09", "");
                this.Cursor = Cursors.Default;
            }
            catch
            {
                throw;
            }
            //catch(Exception ex)
            //{
            //    MessageBox.Show(Convert.ToString(ex));
            //}
        }
        #endregion

        #region // text box event..

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            //if (txtFreight.Text != "")
            //{
                 //string strfrg = txtFreight.Text.Replace(",", "");
                //double frg = 0;
                //if (double.TryParse(strfrg, out frg))
                //{
                //    txtFreight.Text = string.Format("{0:#,##0.###0}", frg);
                //}
            //}

        }

        private void txtFreight_Leave(object sender, EventArgs e)
        {
            double frg = double.Parse(txtFreight.Text.Replace(",", ""));
            txtFreight.Text = string.Format("{0:#,##0.##}", frg);
        }

        private void txtFreight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtRawMaterialPrice.Focus();
                //Grid.Focus();
            }
        }

        private void txtFreightPrice_Leave(object sender, EventArgs e)
        {
            totItemcnt = 0;
            foreach (DataRow row in dtDelvieryList.Rows)
            {
                totItemcnt = totItemcnt + int.Parse(row["IOQTY"].ToString());
            }

            double frg = 0; double frgprc = 0;
            frgprc = Math.Truncate(double.Parse(txtFreightPrice.Text.ToString())*1000)/1000;
            txtFreightPrice.Text = string.Format("{0:#,##0.###}", frgprc);
            frg = Math.Round((totItemcnt * double.Parse(txtFreightPrice.Text.ToString())), 3);
            txtFreight.Text = string.Format("{0:#,##0.##}", frg );
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

        private void txtRawMaterialPrice_Leave(object sender, EventArgs e)
        {
            totItemcnt = 0;
            foreach (DataRow row in dtDelvieryList.Rows)
            {
                totItemcnt = totItemcnt + int.Parse(row["IOQTY"].ToString());
            }
            double raw = 0; double rawprc = 0;
            rawprc = Math.Truncate(double.Parse(txtRawMaterialPrice.Text.ToString())*1000) / 1000;
            txtRawMaterialPrice.Text = string.Format("{0:#,##0.###}", rawprc);
            raw = Math.Round((totItemcnt * double.Parse(txtRawMaterialPrice.Text.ToString())), 3);
            txtRawMaterialAmt.Text = string.Format("{0:#,##0.##}", raw);
        }

        private void txtFreightPrice_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = sender as TextBox;

            //string text = textBox.Text.Replace(",", "");

            //double num = 0;
            //if (double.TryParse(text,out num))  // 숫자형태 값 일때만 처리
            //{
            //    textBox.Text = string.Format("{0:#,##0}", num);
            //    textBox.SelectionStart = textBox.TextLength;
            //    textBox.SelectionLength = 0;

            //}
            //else { textBox.Text = "0"; }
        }

        private void txtRawMaterialAmt_Leave(object sender, EventArgs e)
        {
            double raw = double.Parse(txtRawMaterialAmt.Text.Replace(",", ""));
            txtRawMaterialAmt.Text = string.Format("{0:#,###.##}", raw);
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
