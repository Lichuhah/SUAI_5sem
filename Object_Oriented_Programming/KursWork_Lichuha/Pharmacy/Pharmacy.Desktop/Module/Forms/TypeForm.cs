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
    public partial class TypeForm : DevExpress.XtraEditors.XtraForm
    {
        private TypeProduct Type = null;
        private TypeProductManager TypeManager = new TypeProductManager();
        public TypeForm()
        {
            InitializeComponent();
        }

        public TypeForm(int id)
        {
            this.Type = TypeManager.Get(id);
            InitializeComponent();
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            if (Type == null)
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

                txtName.Text = Type.Name;
            }
        }

        private void barBtnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Always;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
            barBtnCancelEdit.Visibility = BarItemVisibility.Never;
            layoutControl1.Enabled = false;
            TypeForm_Load(null, null);
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
            TypeProduct item = saveData();
            if (item != null)
            {
                item.ID = this.Type.ID;
                TypeManager.Update(item);
                this.Type = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            TypeProduct item = saveData();
            if (item != null)
            {
                item = TypeManager.Add(item);
                this.Type = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private TypeProduct saveData()
        {
            try
            {
                return new TypeProduct()
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