using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Administration;
using Pharmacy.Domain.Models;
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
    public partial class PharmacyForm : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyModel Pharmacy = null;
        private PharmacyManager PharmacyManager = new PharmacyManager();
        public PharmacyForm()
        {
            InitializeComponent();
        }

        public PharmacyForm(int id)
        {
            this.Pharmacy = PharmacyManager.Get(id);
            InitializeComponent();
        }
        private void PharmacyForm_Load(object sender, EventArgs e)
        {
            if (Pharmacy == null)
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

                txtAddress.Text = Pharmacy.Address;
            }
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PharmacyModel item = saveData();
            if (item != null)
            {
                item = PharmacyManager.Add(item);
                this.Pharmacy = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnStartEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Never;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Always;
            barBtnCancelEdit.Visibility = BarItemVisibility.Always;
            layoutControl1.Enabled = true;
        }

        private void barBtnCompleteEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PharmacyModel item = saveData();
            if (item != null)
            {
                item.ID = this.Pharmacy.ID;
                PharmacyManager.Update(item);
                this.Pharmacy = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnCancelEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Always;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
            barBtnCancelEdit.Visibility = BarItemVisibility.Never;
            layoutControl1.Enabled = false;
            PharmacyForm_Load(null, null);
        }

        private PharmacyModel saveData()
        {
            try
            {
                return new PharmacyModel()
                {
                    Address = txtAddress.Text != null ? txtAddress.Text : throw new Exception(),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}