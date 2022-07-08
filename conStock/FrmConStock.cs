using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conStock.Data;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using conStock.Page;


namespace conStock
{
    public partial class FrmConStock : Form
    {
        AccordionControlElement selectedElement = new AccordionControlElement();

        private string usrFormCall = ""; // 이름으로 객체 호출.


        public FrmConStock()
        {
            InitializeComponent();

            //Query.SettingCustList();   
        }

        public class MenuList
        {
                public int menuGu { get; set; }
                public string menuNmae { get; set; }
                public string menuTitle { get; set; }
               
        }

        private List<MenuList> mnuList = new List<MenuList>();
        public static List<MenuList> tabList = new List<MenuList>();

        private void addMenuR()  // report menu
        {
            mnuList.Clear();
            // 메뉴 추가, 1 = report 2 = inout write
            
            mnuList.Add(new MenuList { menuGu = 2, menuNmae = "FrmStockView", menuTitle = " Delivery List " });
            mnuList.Add(new MenuList { menuGu = 2, menuNmae = "FrmStockViewList", menuTitle = " In/Out List " });
            mnuList.Add(new MenuList { menuGu = 2, menuNmae = "FrmDeliveryMonthList", menuTitle = " Delivery Month List " });
        }

        private void addMenuIO()  // io menu
        {
            mnuList.Clear();
            mnuList.Add(new MenuList { menuGu = 1, menuNmae = "FrmStockIn", menuTitle = " Stock In " });
            mnuList.Add(new MenuList { menuGu = 1, menuNmae = "FrmStockOut", menuTitle = " Stock Out " });
            mnuList.Add(new MenuList { menuGu = 1, menuNmae = "FrmStockModify", menuTitle = " Stock Modify" });
        }

        /// <summary>
        /// 메인 메뉴 셋팅
        /// </summary>
        /// <param name="accordian"></param>
        private void SetMenu(AccordionControlElement accordian)
        {

            for (int i = 0; i < mnuList.Count; i++)
            {
                AccordionControlElement element = new AccordionControlElement();
                element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                element.Text = mnuList[i].menuTitle;
                element.Tag = mnuList[i].menuNmae;
                
                element.Appearance.Normal.Font = new System.Drawing.Font("Arial", 12F);
                element.Appearance.Hovered.Font = element.Appearance.Normal.Font;
                element.Appearance.Hovered.ForeColor = Color.FromArgb(192, 0, 0);
                element.Appearance.Pressed.Font = element.Appearance.Normal.Font;
                element.Appearance.Pressed.ForeColor = Color.FromArgb(192, 0, 0);
                accordian.Elements.Add(element);
                element.Click += new EventHandler(accordionControlElement_ElementClick);
            }
        }

        /// <summary>
        /// 메뉴 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement_ElementClick(object sender, EventArgs e)
        {
            AccordionControlElement element = (AccordionControlElement)sender;

            usrFormCall = (string) element.Tag;
            string tabMenu = (string) element.Tag;
            string tabMenuTitle = (string)element.Text;
            usrFormCall = "conStock.Page." + usrFormCall;

            setTabSetting(tabMenu, tabMenuTitle, usrFormCall);
            //setFormCall(usrFormCall);
            
        }

        /// <summary>
        /// 탭에 메뉴 추가 및 Tab index 선택.
        /// </summary>
        /// <param name="tabName"></param>
        /// <param name="tabTitle"></param>
        private void setTabSetting(string tabName, string tabTitle, string usrFormCall)
        {

            if (tabList.Count == 0)
            {
                CallTabSetting(tabName, tabTitle, usrFormCall);   
            }
            else
            {
                int mlist = tabList.FindIndex(x => x.menuNmae == tabName);  // 존재 유무
                if (mlist != -1)
                {
                    xtraTabControl1.SelectedTabPageIndex = mlist;
                }
                else
                {
                    CallTabSetting(tabName, tabTitle, usrFormCall);
                }
                
            }
        }

        // 해당 폼 call
        private void CallTabSetting(string tabName, string tabTitle, string usrFormCall)
        {
            XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();
            Panel pnlMain = new Panel();
            
            xtraTabControl1.TabPages.Add(xtraTab);
            tabList.Add(new MenuList { menuGu = 2, menuNmae = tabName, menuTitle = tabTitle });
            xtraTab.Name = tabName;
            xtraTab.Text = tabTitle;
            
            xtraTab.Controls.Add(pnlMain);
            pnlMain.Dock = DockStyle.Fill;

            // 메뉴 call 
            setFormCall(usrFormCall, pnlMain);
            xtraTabControl1.SelectedTabPage = xtraTab;
        }


        /// <summary>
        /// 이름 from 메뉴 호출.
        /// </summary>
        /// <param name="strFormName"></param>
        private void setFormCall(string strFormName, Panel pnlTab)
        {
            var varPageType = Type.GetType(strFormName);
            if (varPageType != null)
            { 

                var varFormInstance = Activator.CreateInstance(varPageType) as UserControl;
                //this.mainPannel.Controls.Clear();
                //this.mainPannel.Controls.Add(varFormInstance);
                pnlTab.Controls.Clear();
                pnlTab.Controls.Add(varFormInstance);
                varFormInstance.Dock = DockStyle.Fill;
            }

        }

        private void FrmConStock_Load(object sender,System.EventArgs e)
        {
            //LoginCHK();
            addMenuIO();
            SetMenu(accMenuIOput);
            addMenuR();
            SetMenu(accMenuView);

            accdionCtl.CustomDrawElement += accdtionCtl_CustomDrawElement;
            accdionCtl.ElementClick += accdionCtl_ElementClick;

            if (MainSetting.gUserID != null) { 
                mainStatus.Items["userID"].Text = MainSetting.gUserID;
                mainStatus.Items["userName"].Text = MainSetting.gUserName;
                mainStatus.Items["whID"].Text = MainSetting.gWhID;
                mainStatus.Items["whName"].Text = MainSetting.gWHName;
                mainStatus.Items["todayDATE"].Text = DateTime.Now.ToString();
            }
            CultureInfo cultures = CultureInfo.CreateSpecificCulture("en-US");
            

        }

        private void SetComboList()
        {

        }

        private void Element_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void accdtionCtl_CustomDrawElement(object sender, CustomDrawElementEventArgs e)
        {
            if (e.ObjectInfo.Element == selectedElement || selectedElement.OwnerElement == e.ObjectInfo.Element)
            {
                e.Cache.FillRectangle(Color.FromArgb(201, 222, 245), e.ObjectInfo.HeaderBounds);
                e.DrawText();
                e.Handled = true;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }


        private void LoginCHK()
        {
            FrmLogIn frmLogIn = new FrmLogIn();
            DialogResult Result = frmLogIn.ShowDialog();

            if (Result != DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void accdionCtl_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (e.Element.Style != ElementStyle.Group)
            {
                selectedElement = e.Element;
            }
        }

        // Tab 닫기.
        private void xtraTabControl1_HeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.HeaderButtonEventArgs e)
        {
            string tabName;
            tabName = xtraTabControl1.SelectedTabPage.Name;
            xtraTabControl1.TabPages.Remove(e.ActivePage as XtraTabPage);
            int mlist = tabList.FindIndex(x => x.menuNmae == tabName);
            tabList.RemoveAt(mlist);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            todayDate.Text = DateTime.Now.ToString();
        }
    }
}
