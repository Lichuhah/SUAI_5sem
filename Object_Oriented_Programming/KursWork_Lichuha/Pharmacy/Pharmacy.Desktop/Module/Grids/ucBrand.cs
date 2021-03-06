using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Desktop.Module.Forms;
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
    public partial class ucBrand : TutorialControlBase
    {
        public ucBrand()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            grid.DataSource = null;
            var manager = new BrandManager();
            var list = manager.All();
            grid.DataSource = list;
        }
        private void ucBrand_Load(object sender, EventArgs e)
        {
            loadData();

            gridView.Columns.ColumnByFieldName("ID").Visible = false;
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
                MaxWidth = 40
            });
            gridView.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;
        }

        private void btnViewElement_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Brand item = (Brand)gridView.GetFocusedRow();
            BrandForm form = new BrandForm(item.ID);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BrandForm form = new BrandForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            BrandManager manager = new BrandManager();
            if (manager.Delete((Brand)gridView.GetFocusedRow()))
                loadData();

        }

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
