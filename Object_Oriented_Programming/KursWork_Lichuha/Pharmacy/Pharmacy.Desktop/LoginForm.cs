using DevExpress.XtraEditors;
using Pharmacy.Domain.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Desktop
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            if (LoginUser.CreateUser(txtLogin.Text, txtPassword.Text))
            {
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
                if(form.DialogResult == DialogResult.Retry)
                {
                    this.Visible = true;
                } else
                {
                    this.Close();
                }
                
            } else
            {
                lblError.Text = "Ошибка, неудачная аутентификация\n Проверьте введенные данные.";
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            txtLogin.Text = String.Empty;
            txtPassword.Text = String.Empty;
            lblError.Text = String.Empty;
        }
    }
}