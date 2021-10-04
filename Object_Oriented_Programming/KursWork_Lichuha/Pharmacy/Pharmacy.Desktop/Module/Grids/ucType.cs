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
    public partial class ucType : TutorialControlBase
    {
        public ucType()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            grid.DataSource = null;
            var manager = new TypeProductManager();
            var list = manager.All();
            grid.DataSource = list;
        }
        private void ucType_Load(object sender, EventArgs e)
        {
            loadData();

            gridView.Columns.ColumnByFieldName("Categories").Visible = false;
            gridView.Columns.ColumnByFieldName("Forms").Visible = false;
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
            TypeProduct item = ((List<TypeProduct>)grid.DataSource)[gridView.FocusedRowHandle];
            TypeForm form = new TypeForm(item.ID);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TypeForm form = new TypeForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            TypeProductManager manager = new TypeProductManager();
            if (manager.Delete(((List<TypeProduct>)grid.DataSource)[gridView.FocusedRowHandle]))
                loadData();

        }

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
