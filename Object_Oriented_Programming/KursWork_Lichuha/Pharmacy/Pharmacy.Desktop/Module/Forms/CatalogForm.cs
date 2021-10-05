using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class CatalogForm : DevExpress.XtraEditors.XtraForm
    {
        public Product Product = null;
        List<Product> products = new List<Product>();
        public CatalogForm()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            grid.DataSource = null;
            var manager = new ProductManager();
            products = manager.All();
            grid.DataSource = products;
        }
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            loadData();

            gridView.Columns.ColumnByFieldName("Category").Visible = false;
            gridView.Columns.ColumnByFieldName("Brand").Visible = false;
            gridView.Columns.ColumnByFieldName("Form").Visible = false;
            gridView.Columns.ColumnByFieldName("ID").Visible = false;
            gridView.Columns.ColumnByFieldName("IsDeleted").Visible = false;
            gridView.Columns.ColumnByFieldName("Name").VisibleIndex = 0;

            gridView.Columns.Add(new GridColumn()
            {
                Name = "btnColumnView",
                ColumnEdit = btnSelectProduct,
                MaxWidth = 40
            });
            gridView.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            Product = products[gridView.GetSelectedRows()[0]];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}