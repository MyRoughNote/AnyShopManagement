using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyShopManagement.Interface;
using AnyShopManagement.Models;
using AnyShopUI.Factory;

namespace AnyShopUI
{
    public partial class Login : Form
    {
        private readonly IValidate _Validate;
        public Login()
        {

        }
        public Login(IValidate Validate)
        {
            InitializeComponent();
            Text = "Login";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtPassword.PasswordChar = '*';
            txtUserName.Focus();
            _Validate = Validate;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var request = new AuthenticateRequest() {
                UserName = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            ValidateLogin(request);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void ValidateLogin(AuthenticateRequest request)
        {
            bool isValidUser = false;

            if (string.IsNullOrWhiteSpace(request.UserName) && string.IsNullOrWhiteSpace(request.Password))
            {
                MessageBox.Show("UserName and Password is Required");
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(request.UserName))
            {
                MessageBox.Show("UserName is Required");
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(request.UserName))
            {
                MessageBox.Show("Password is Required");
                txtPassword.Focus();
            }
            else
            {
                isValidUser = _Validate.Validate(request);

                if (isValidUser)
                {
                    this.Hide();
                    var form= FormFactory.Show("MAIN");
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName & Password");
                    Cancel();
                }
            }
        }

        private void Cancel()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((this.ActiveControl == txtPassword) && (keyData == Keys.Enter))
            {
                var request = new AuthenticateRequest()
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };
                ValidateLogin(request);
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
