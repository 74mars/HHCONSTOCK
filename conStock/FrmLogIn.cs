using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conStock.Data;

namespace conStock
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();

        }

        public void FrmSub_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Conndb.dbConnInfo.Division = "20";

            if (EmptyCheck())
            {
                Query.UserID = txtUser.Text.ToString().ToUpper();
                Query.PassWord = txtPassword.Text.ToString().ToUpper();

            }

            if (Query.UserCheck != "0" )
            {
                DialogResult = DialogResult.OK;
                //MainSetting.gUserID = txtUser.Text.ToString();
                //MainSetting.gUserName = txtUserName.Text.ToString();
                //MainSetting.gWhID = txtWhID.Text.ToString();
                //MainSetting.gWHName = txtWHName.Text.ToString();

                Close();
            }
            else
            {
                lblMessage.Text = "Please Check you USER ID and Password";
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Select();
            }
            
        }

        private bool EmptyCheck()
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                lblMessage.Text = "PLEASE, INPUT USER ID.";
                txtUser.Select();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblMessage.Text = "PLEASE, INPUT PASSWORD.";
                txtPassword.Select();
                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
                btnOK.Select();
            }
        }
    }
}
