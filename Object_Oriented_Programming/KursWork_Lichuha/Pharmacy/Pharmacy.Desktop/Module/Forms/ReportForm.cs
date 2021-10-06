using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Warehouse.Changes;
using Pharmacy.Domain.Models.Products;
using Pharmacy.Domain.Models.Warehouse;
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
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        Product product = null;
        WareHouseReport report = null;
        WareHouseReportManager manager = new WareHouseReportManager();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            CatalogForm catalog = new CatalogForm();
            var result = catalog.ShowDialog();
            if(result == DialogResult.OK)
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

                txtCountOnWarehouse.Value = manager.GetCountByProduct(product);

                btnEnrollment.Enabled = true;
                btnWriteOff.Enabled = true;
            }     
        }

        private void saveData()
        {
            try
            {
                report = new WareHouseReport()
                {
                    Product = product,
                    Count = (int)(txtCountInReport.Value != 0 ? txtCountInReport.Value : throw new Exception()),
                    Description = txtInfo.Text,
                    Date = dateEdit.DateTime,
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                report = null;
            }
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            saveData();
            if (report != null)
            {
                WareHouseEnrollmentManager man = new WareHouseEnrollmentManager();
                report = man.Add(report);
                manager.SetCountByReport(report);
                this.Close();
            }                   
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            saveData();
            if (report != null && txtCountOnWarehouse.Value >= report.Count)
            {
                WareHouseWriteOffManager man = new WareHouseWriteOffManager();
                report = man.Add(report);
                manager.SetCountByReport(report);
                this.Close();
            } else
            {
                MessageBox.Show("Нельзя списать больше товара чем есть на складе");
            }
        }
    }
}