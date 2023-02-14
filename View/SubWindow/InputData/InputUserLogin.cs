using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htv5_mixer_control
{
    public partial class InputUserLogin : Form
    {
        public InputUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (ToolSupport.checkAccount(txbInputUsername.Text.TrimEnd(), txbInputPassword.Text.TrimEnd()))
                {
                    InputMainForm inputMainForm = new InputMainForm();
                    inputMainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(txbInputPassword, "Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }

        private void txbInputUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputUsername.Text))
            {
                e.Cancel = true;
                txbInputUsername.Focus();
                errorProvider.SetError(txbInputUsername, "Tên đăng nhập không được trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputUsername, null);
            }
        }

        private void txbInputPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbInputPassword.Text))
            {
                e.Cancel = true;
                txbInputPassword.Focus();
                errorProvider.SetError(txbInputPassword, "Mật khẩu không được trống!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txbInputPassword, null);
            }
        }

        private void txbInputPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (ToolSupport.checkAccount(txbInputUsername.Text.TrimEnd(), txbInputPassword.Text.TrimEnd()))
                    {
                        InputMainForm inputMainForm = new InputMainForm();
                        inputMainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        errorProvider.SetError(txbInputPassword, "Sai tên đăng nhập hoặc mật khẩu!");
                    }
                }
            }
        }

        private void InputUserLogin_Load(object sender, EventArgs e)
        {
            btnLogin.ButtonText = "LOGIN" + Environment.NewLine + "登录";
        }
    }
}
