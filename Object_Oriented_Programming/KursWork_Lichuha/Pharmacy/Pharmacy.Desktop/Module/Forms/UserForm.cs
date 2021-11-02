using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Administration;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.Models.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Desktop.Module.Forms
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        User User = null;
        UserManager UserManager = new UserManager();
        List<PharmacyModel> Pharmacies = new List<PharmacyModel>();
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(int id)
        {
            this.User = UserManager.Get(id);
            InitializeComponent();
        }

        private void barBtnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Always;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
            barBtnCancelEdit.Visibility = BarItemVisibility.Never;
            layoutControl1.Enabled = false;
            UserForm_Load(null, null);
        }

        private void barBtnStartEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Never;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Always;
            barBtnCancelEdit.Visibility = BarItemVisibility.Always;
            layoutControl1.Enabled = true;
        }

        private void barBtnCompleteEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            User user = saveData();
            if (user != null)
            {
                user.ID = this.User.ID;
                UserManager.Update(user);
                this.User = user;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            User user = saveData();
            if (user != null)
            {
                UserManager UserManager = new UserManager();
                user = UserManager.Add(user);
                this.User = user;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LoadPharmacy()
        {
            //PharmacyManager manager = new PharmacyManager();
            //Pharmacies = manager.All();
            //cmbPharmacy.Properties.Items.Clear();
            //cmbPharmacy.Properties.Items.AddRange(Pharmacies.Select(x => x.Address).ToList());
        }

        private User saveData()
        {
            try
            {
                return new User()
                {
                    Name = txtName.Text != null ? txtName.Text : throw new Exception(),
                    Login = txtLogin.Text != null ? txtLogin.Text : throw new Exception(),
                    Password = txtPas1.Text != null && txtPas1.Text == txtPas2.Text ? txtPas1.Text : throw new Exception(),
                    Role = cmbRole.SelectedIndex!=-1 ? (UserRole)cmbRole.SelectedIndex : throw new Exception(),
                    //Pharmacy = Pharmacies[cmbPharmacy.SelectedIndex]
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadPharmacy();
            if (User == null)
            {
                barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
                barBtnCancelEdit.Visibility = BarItemVisibility.Never;
                barBtnStartEdit.Visibility = BarItemVisibility.Never;

            }
            else
            {
                barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
                barBtnCancelEdit.Visibility = BarItemVisibility.Never;
                barBtnAdd.Visibility = BarItemVisibility.Never;

                layoutControl1.Enabled = false;

                txtName.Text = User.Name;
                txtLogin.Text = User.Login;
                txtPas1.Text = User.Password;
                txtPas2.Text = User.Password;
                cmbRole.SelectedIndex = (int)User.Role;
               // cmbPharmacy.SelectedIndex = User.Pharmacy != null ? Pharmacies.FindIndex(x => x.Address == User.PharmacyAddress) : -1;
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbRole.SelectedIndex > 1)
            //{
            //    cmbPharmacy.Enabled = true;
            //} else
            //{
            //    cmbPharmacy.SelectedItem = null;
            //    cmbPharmacy.Enabled = false;
            //}
        }
    }
}