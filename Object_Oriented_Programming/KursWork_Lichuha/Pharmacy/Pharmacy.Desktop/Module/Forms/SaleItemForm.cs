using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Warehouse.Changes;
using Pharmacy.Domain.Models.Cashbox;
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
    public partial class SaleItemForm : DevExpress.XtraEditors.XtraForm
    {
        Product product = null;
        public SaleItem Item = null;
        public SaleItemForm()
        {
            InitializeComponent();
        }

        private void SaleItemForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            CatalogForm catalog = new CatalogForm();
            var result = catalog.ShowDialog();
            if (result == DialogResult.OK)
            {
                product = catalog.Product;
                txtName.Text = product.Name;
                txtCount.Value = product.Count;
                txtPrice.Value = (decimal)product.Price;
                chRecipe.Checked = product.IsNeedRecipe;
                txtBrand.Text = product.BrandName;
                txtCategory.Text = product.CategoryName;
                txtForm.Text = product.FormName;
                txtType.Text = product.Category.TypeName;
                WareHouseReportManager manager = new WareHouseReportManager();
                txtCountOnWarehouse.Value = manager.GetCountByProduct(product);
                btnEnrollment.Enabled = true;
            }
        }

        private void saveData()
        {
            try
            {
                Item = new SaleItem()
                {
                    Product = product,
                    Count = (int)(txtCountInReport.Value != 0 ? txtCountInReport.Value : throw new Exception()),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Item = null;
            }
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            saveData();
            if (Item != null && txtCountOnWarehouse.Value >= Item.Count)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Нельзя списать больше товара чем есть на складе");
            }
        }
    }
}