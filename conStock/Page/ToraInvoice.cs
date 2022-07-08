using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Globalization;
using conStock.Data;

namespace conStock.Page
{
    public partial class ToraInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public ToraInvoice(DataSet dt)
        {
            InitializeComponent();
            if (dt == null) { return; }
            Print_MainInfo(dt);
        }

        public void Print_MainInfo(DataSet dt)
        {
            this.DataSource = dt;
            #region //printing DATA Bindings

            // company info
            xrTableCellName.DataBindings.Add("Text", dt.Tables[0], "CONAME");
            xrTableCellAddr1.DataBindings.Add("Text", dt.Tables[0], "ADDR1");
            xrTableCellAddr2.DataBindings.Add("Text", dt.Tables[0], "ADDR2");

            xrlblCompanyAddr.DataBindings.Add("Text", dt.Tables[0], "ADDR");
            xrTableCellTelno.DataBindings.Add("Text", dt.Tables[0], "TELNO");
            xrTableCellFaxno.DataBindings.Add("Text", dt.Tables[0], "FAXNO");
            xrTableCellEmail.DataBindings.Add("Text", dt.Tables[0], "EMAILNO");

            // Consignee info
            xrTableCellConsignee1.DataBindings.Add("Text", dt.Tables[0], "CON1");
            xrTableCellConsignee2.DataBindings.Add("Text", dt.Tables[0], "CON2");
            xrTableCellConsignee3.DataBindings.Add("Text", dt.Tables[0], "CON3");
            xrTableCellConsignee4.DataBindings.Add("Text", dt.Tables[0], "CON4");
            xrTableCellConsignee5.DataBindings.Add("Text", dt.Tables[0], "CON5");

            // Notify info
            xrTableCellNoti1.DataBindings.Add("Text", dt.Tables[0], "NOTI1");
            xrTableCellNoti2.DataBindings.Add("Text", dt.Tables[0], "NOTI2");
            xrTableCellNoti3.DataBindings.Add("Text", dt.Tables[0], "NOTI3");
            xrTableCellNoti4.DataBindings.Add("Text", dt.Tables[0], "NOTI4");

            // Remarks Info.
            xrTableCellRemark1.DataBindings.Add("Text", dt.Tables[0], "REMARK1");
            xrTableCellRemark2.DataBindings.Add("Text", dt.Tables[0], "REMARK2");
            xrTableCellRemark3.DataBindings.Add("Text", dt.Tables[0], "REMARK3");
            xrTableCellRemark4.DataBindings.Add("Text", dt.Tables[0], "REMARK4");
            xrTableCellRemark5.DataBindings.Add("Text", dt.Tables[0], "REMARK5");
            xrTableCellRemark6.DataBindings.Add("Text", dt.Tables[0], "REMARK6");
            xrTableCellRemark7.DataBindings.Add("Text", dt.Tables[0], "REMARK7");

            // Invoice Info / Delivery Data
            xrTableCellLInvoice.DataBindings.Add("Text", dt.Tables[0], "REF4");
            //xrTableCellDeliveryDate.DataBindings.Add("Text", dt.Tables[0], "IO_DATE");

            xrTableCellPoADate.DataBindings.Add("Text", dt.Tables[0], "PO_A_DATE");

            xrTableCellMarksAdd1.DataBindings.Add("Text", dt.Tables[0], "MARKS1");
            xrTableCellMarksAdd2.DataBindings.Add("Text", dt.Tables[0], "MARKS2");
            xrTableCellMarksAdd3.DataBindings.Add("Text", dt.Tables[0], "MARKS3");
            xrTableCellMarksAdd4.DataBindings.Add("Text", dt.Tables[0], "MARKS4");

            DataTable dat = dt.Tables[0];

            string ioDate = ""; string inv = ""; string ioreqty = "0"; string partno = ""; string itdsc = ""; string sudat = ""; string aaa = "";
            foreach (DataRow row in dat.Rows)
            {
                ioDate = row["IO_DATE"].ToString();
                sudat = row["SUDAT"].ToString();
                inv = row["INV"].ToString();
                ioreqty = row["IOREQTY"].ToString();
                partno = row["PARTNO"].ToString();
                itdsc = row["ITDSC"].ToString();
                aaa = row["TOTAMT"].ToString();
                break;
            }
            DateTime ioUsdate = new DateTime(int.Parse(ioDate.Substring(0, 4)), int.Parse(ioDate.Substring(4, 2)), int.Parse(ioDate.Substring(6, 2)));
            xrlblIODATE.Text = ioUsdate.ToString("MMMM-dd-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            DateTime suUsdate = new DateTime(int.Parse(sudat.Substring(0, 4)), int.Parse(sudat.Substring(4, 2)), int.Parse(sudat.Substring(6, 2)));

            xrlblonboard.Text = suUsdate.ToString("MMMM-dd-yyyy", CultureInfo.CreateSpecificCulture("en-US")) + "/" + ioUsdate.ToString("MMMM-dd-yyyy", CultureInfo.CreateSpecificCulture("en-US"));

            // Loading/marks/deliveryTerms/Carrier/Onboard Data Info.
            xrlblLoading1.DataBindings.Add("Text", dt.Tables[0], "LODING");
            xrlblDeliveryTerms1.DataBindings.Add("Text", dt.Tables[0], "DELTERMS");
            xrlblMarks1.DataBindings.Add("Text", dt.Tables[0], "MARKS");
            xrTableCellCarrier.DataBindings.Add("Text", dt.Tables[0], "CARRIER");

            //xrTableCellOnboard.DataBindings.Add("Text", dt.Tables[0], "ONBRD_DATE");

            // Invoice Amount Info.
            //DateTime Tdate = ioUsdate;
            
            xrTableCellFreightTle.Text = "Freigth Surcharge " + MainSetting.GetQuarter(ioUsdate);
            xrTableCellRawTle.Text = "Raw Surcharge " + MainSetting.GetQuarter(ioUsdate);
            int cnt = inv.IndexOf('-');
            int cnt2 = inv.IndexOf('-', cnt + 1);
            string TempInv = "";
            if (cnt2 == -1)
            {
                TempInv = inv;
            }
            else
            {
                TempInv = inv.Substring(0, inv.LastIndexOf('-'));
            }
            
            //string aa = inv.Substring(0, inv.ind)
            string itemDsc = itdsc.Substring(0, itdsc.IndexOf('(')) + "(" + partno + ") \n" + TempInv + "\n (" + ioreqty.ToString() + " pallets)";
            xrTableCellItemTle.Text = itemDsc;
            xrTableCellItemPrice.DataBindings.Add("Text", dt.Tables[0], "FIOPRC", "{0:#,##0.###}");
            
            xrTableCellItemAmt.DataBindings.Add("Text", dt.Tables[0], "FIOAMT", "{0:#,###.##}");
            //xrTableCellFreight.DataBindings.Add("Text", dt.Tables[0], "DREF4", "{0:#,###.##}");
            xrTableCellFreight.DataBindings.Add("Text", dt.Tables[0], "FREIGHTAMT", "{0:#,###.##}");
            xrTableCellTotalAmt.DataBindings.Add("Text", dt.Tables[0], "TOTAMT", "{0:#,###.##}");

            xrTableCellQty1.DataBindings.Add("Text", dt.Tables[0], "IOQTY", "{0:#,###}");
            xrTableCellQty2.DataBindings.Add("Text", dt.Tables[0], "IOQTY", "{0:#,###}");
            xrTableCellQty3.DataBindings.Add("Text", dt.Tables[0], "IOQTY", "{0:#,###}");
            xrTableCellQty4.DataBindings.Add("Text", dt.Tables[0], "IOQTY", "{0:#,###}");

            xrTableCellRawMaterial.DataBindings.Add("Text", dt.Tables[0], "RAWAMT", "{0:#,###.##}");
            xrTableCellFreightPrice.DataBindings.Add("Text", dt.Tables[0], "FREIGHTPRC", "{0:#,##0.###}");
            xrTableCellMaterialPrice.DataBindings.Add("Text", dt.Tables[0], "RAWPRC", "{0:#,##0.###}");

            // Company bottom.
            xrlblPerson.DataBindings.Add("Text", dt.Tables[0], "EFF_ID");
            xrlblSupplierCode.DataBindings.Add("Text", dt.Tables[0], "SUPP_ID");
            xrlblCompany.DataBindings.Add("Text", dt.Tables[0], "CONAME");

            #endregion
        }
    }
}
