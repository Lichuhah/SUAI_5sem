using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Products;
using System;
using DevExpress.DXperience.Demos;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Domain.Models.Products;
using System.Collections.Generic;

namespace Pharmacy.Desktop.Module
{
    public partial class ucProduct : TutorialControlBase
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            grid.DataSource = null;
            var manager = new ProductManager();
            var list = manager.All();
            grid.DataSource = list;
        }
        private void ucProduct_Load(object sender, EventArgs e)
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
                Name = "btnColumnDelete",
                ColumnEdit = btnDeleteElement,
                MaxWidth = 40
            });
            gridView.Columns.ColumnByName("btnColumnDelete").VisibleIndex = 0;

            gridView.Columns.Add(new GridColumn()
            {
                Name = "btnColumnView",
                ColumnEdit = btnViewElement,
                MaxWidth=40
            });
            gridView.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;
        }

        private void btnViewElement_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Product product = (Product)gridView.GetFocusedRow();
            ProductForm form = new ProductForm(product.ID);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductForm form = new ProductForm();
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            ProductManager manager = new ProductManager();
            if(manager.Delete((Product)gridView.GetFocusedRow())) 
                loadData();
            
        }

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
