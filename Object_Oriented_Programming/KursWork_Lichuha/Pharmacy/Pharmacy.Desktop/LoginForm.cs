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
            if (LoginUser.CreateUser(textEdit1.Text, textEdit2.Text))
            {
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
        }
    }
}