using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Products;
using Pharmacy.Domain.Models.Products;
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
    public partial class BrandForm : DevExpress.XtraEditors.XtraForm
    {
        private Brand Brand = null;
        private BrandManager BrandManager = new BrandManager();
        public BrandForm()
        {
            InitializeComponent();
        }

        public BrandForm(int id)
        {
            this.Brand = BrandManager.Get(id);
            InitializeComponent();
        }

        private void BrandForm_Load(object sender, EventArgs e)
        {
            if (Brand == null)
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

                txtName.Text = Brand.Name;
            }
        }
        private void barBtnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Always;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
            barBtnCancelEdit.Visibility = BarItemVisibility.Never;
            layoutControl1.Enabled = false;
            BrandForm_Load(null, null);
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
            Brand item = saveData();
            if (item != null)
            {
                item.ID = this.Brand.ID;
                BrandManager.Update(item);
                this.Brand = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Brand item = saveData();
            if (item != null)
            {
                item = BrandManager.Add(item);
                this.Brand = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private Brand saveData()
        {
            try
            {
                return new Brand()
                {
                    Name = txtName.Text != null ? txtName.Text : throw new Exception(),
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