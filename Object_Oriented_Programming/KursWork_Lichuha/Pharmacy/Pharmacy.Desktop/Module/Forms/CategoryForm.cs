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
    public partial class CategoryForm : DevExpress.XtraEditors.XtraForm
    {
        private CategoryProduct Category = null; 
        private CategoryProductManager CategoryManager = new CategoryProductManager();
        List<TypeProduct> Types = new List<TypeProduct>();
        public CategoryForm()
        {
            InitializeComponent();
        }

        public CategoryForm(int id)
        {
            this.Category = CategoryManager.Get(id);
            InitializeComponent();
        }

        private void LoadTypes()
        {
            TypeProductManager TypeManager = new TypeProductManager();
            cmbBoxType.Properties.Items.Clear();
            cmbBoxType.Text = null;
            Types = TypeManager.All();
            cmbBoxType.Properties.Items.AddRange(Types.Select(x => x.Name).ToList());
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadTypes();

            if (Category == null)
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

                txtName.Text = Category.Name;
                cmbBoxType.SelectedIndex = Types.FindIndex(x => x.Name == Category.Type.Name);
            }
        }

        private void barBtnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Always;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
            barBtnCancelEdit.Visibility = BarItemVisibility.Never;
            layoutControl1.Enabled = false;
            CategoryForm_Load(null, null);
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
            CategoryProduct item = saveData();
            if (item != null)
            {
                item.ID = this.Category.ID;
                CategoryManager.Update(item);
                this.Category = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            CategoryProduct item = saveData();
            if (item != null)
            {
                item = CategoryManager.Add(item);
                this.Category = item;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private CategoryProduct saveData()
        {
            try
            {
                return new CategoryProduct()
                {
                    Name = txtName.Text != null ? txtName.Text : throw new Exception(),
                    Type = cmbBoxType.Text != null ? Types[cmbBoxType.SelectedIndex] : throw new Exception(),
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