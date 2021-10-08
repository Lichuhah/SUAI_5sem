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

namespace Pharmacy.Desktop.Module
{
    public partial class ProductForm : DevExpress.XtraEditors.XtraForm
    {
        Product product = null;
        ProductManager productManager = new ProductManager();
        List<TypeProduct> Types = new List<TypeProduct>();
        List<CategoryProduct> Categories = new List<CategoryProduct>();      
        List<Brand> Brands = new List<Brand>();
        List<FormProduct> Forms = new List<FormProduct>();
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(int idProduct)
        {
            this.product = productManager.Get(idProduct);
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
            LoadBrands();

            if (product == null)
            {               
                barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
                barBtnCancelEdit.Visibility = BarItemVisibility.Never;
                barBtnStartEdit.Visibility = BarItemVisibility.Never;

            } else
            {
                barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
                barBtnCancelEdit.Visibility = BarItemVisibility.Never;
                barBtnAdd.Visibility = BarItemVisibility.Never;

                layoutControl1.Enabled = false;

                txtName.Text = product.Name;
                txtCount.Value = product.Count;
                txtPrice.Value = (decimal)product.Price;
                chRecipe.Checked = product.IsNeedRecipe;
                cmbBoxType.SelectedIndex = Types.FindIndex(x => x.Name == product.Category.Type.Name);
                cmbBoxBrand.SelectedIndex = Brands.FindIndex(x => x.Name == product.Brand.Name);
                LoadCategories();
                LoadForms();
                cmbBoxCategory.SelectedIndex = Categories.FindIndex(x => x.Name == product.Category.Name);
                cmbBoxForm.SelectedIndex = Forms.FindIndex(x => x.Name == product.Form.Name);
                var a = (Forms.Find(x => x.Name == product.Form.Name)).Unit;
                layoutControlItem6.Text = "Кол-во (" + (Forms.Find(x => x.Name == product.Form.Name)).Unit +")";
            }
            
        }

        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategories();
            LoadForms();
        }

        private void LoadTypes()
        {
            TypeProductManager TypeManager = new TypeProductManager();
            cmbBoxType.Properties.Items.Clear();
            cmbBoxType.Text = null;
            Types = TypeManager.All();
            cmbBoxType.Properties.Items.AddRange(Types.Select(x => x.Name).ToList());
        }
        private void LoadCategories()
        {
            cmbBoxCategory.Enabled = true;
            cmbBoxCategory.Properties.Items.Clear();
            cmbBoxCategory.Text = null;
            Categories = Types[cmbBoxType.SelectedIndex].Categories.ToList();
            cmbBoxCategory.Properties.Items.AddRange(Categories.Select(x => x.Name).ToList());
        }
        private void LoadForms()
        {
            cmbBoxForm.Enabled = true;
            cmbBoxForm.Properties.Items.Clear();
            cmbBoxForm.Text = null;
            Forms = Types[cmbBoxType.SelectedIndex].Forms.ToList();
            cmbBoxForm.Properties.Items.AddRange(Forms.Select(x => x.Name).ToList());
        }
        private void LoadBrands()
        {
            BrandManager BrandManager = new BrandManager();
            cmbBoxBrand.Properties.Items.Clear();
            cmbBoxBrand.Text = null;
            Brands = BrandManager.All();
            cmbBoxBrand.Properties.Items.AddRange(Brands.Select(x => x.Name).ToList());
        }

        private void barBtnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnStartEdit.Visibility = BarItemVisibility.Always;
            barBtnCompleteEdit.Visibility = BarItemVisibility.Never;
            barBtnCancelEdit.Visibility = BarItemVisibility.Never;
            layoutControl1.Enabled = false;
            ProductForm_Load(null,null);
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
            Product product = saveData();          
            if (product != null)
            {
                product.ID = this.product.ID;
                productManager.Update(product);
                this.product = product;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void barBtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Product product = saveData();
            if (product != null)
            {
                ProductManager productManager = new ProductManager();
                product = productManager.Add(product);
                this.product = product;
                barBtnCancelEdit_ItemClick(null, null);
                this.DialogResult = DialogResult.OK;
            }
        }

        private Product saveData()
        {
            try
            {
                return new Product()
                {
                    Name = txtName.Text != null ? txtName.Text : throw new Exception(),
                    Price = (float)(txtPrice.Value != 0 ? txtPrice.Value : throw new Exception()),
                    Count = (int)(txtCount.Value != 0 ? txtCount.Value : throw new Exception()),
                    IsNeedRecipe = chRecipe.Checked,
                    Brand = cmbBoxBrand.Text != null ? Brands[cmbBoxBrand.SelectedIndex] : throw new Exception(),
                    Category = cmbBoxCategory.Text != null ? Categories[cmbBoxCategory.SelectedIndex] : throw new Exception(),
                    Form = cmbBoxForm.Text != null ? Forms[cmbBoxForm.SelectedIndex] : throw new Exception(),
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}