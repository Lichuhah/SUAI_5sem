using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Domain.Managers.Products;
using Pharmacy.Domain.Managers.Warehouse;
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
    public partial class CatalogForm : DevExpress.XtraEditors.XtraForm
    {
        public Product Product = null;
        List<Product> products = new List<Product>();
        List<WareHouseItem> warehouse = new List<WareHouseItem>();
        public WareHouseItem Item = null;
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

        private void loadWarehouse()
        {
            gridWareHouse.DataSource = null;
            var manager = new WareHouseItemManager();
            warehouse = manager.All();
            gridWareHouse.DataSource = warehouse;
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

            loadWarehouse();

            gridView1.Columns.ColumnByFieldName("Product").Visible = false;
            gridView1.Columns.ColumnByFieldName("WareHouse").Visible = false;
            gridView1.Columns.ColumnByFieldName("ID").Visible = false;

            gridView1.Columns.Add(new GridColumn()
            {
                Name = "btnColumnView",
                ColumnEdit = repositoryItemButtonEdit3,
                MaxWidth = 40
            });
            gridView1.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;
        }

        private void btnSelectProduct_Click_1(object sender, EventArgs e)
        {
            Product = products[gridView.FocusedRowHandle];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            Item = warehouse[gridView1.FocusedRowHandle];
            Product = Item.Product;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}