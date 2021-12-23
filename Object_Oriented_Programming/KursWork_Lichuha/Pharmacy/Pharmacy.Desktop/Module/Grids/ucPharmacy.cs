using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Desktop.Module.Forms;
using Pharmacy.Domain.Managers.Administration;
using Pharmacy.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Desktop.Module.Grids
{
    public partial class ucPharmacy : TutorialControlBase
    {
        public ucPharmacy()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            grid.DataSource = null;
            var manager = new PharmacyManager();
            var list = manager.All();
            grid.DataSource = list;
        }
        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PharmacyForm form = new PharmacyForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void ucPharmacy_Load(object sender, EventArgs e)
        {
            loadData();

            gridView.Columns.ColumnByFieldName("ID").Visible = false;
            gridView.Columns.ColumnByFieldName("WareHouse").Visible = false;
            gridView.Columns.ColumnByFieldName("Sales").Visible = false;
            gridView.Columns.ColumnByFieldName("Address").VisibleIndex = 0;

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

        private void btnViewElement_Click(object sender, EventArgs e)
        {
            PharmacyModel item = ((List<PharmacyModel>)grid.DataSource)[gridView.FocusedRowHandle];
            PharmacyForm form = new PharmacyForm(item.ID);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            PharmacyManager manager = new PharmacyManager();
            if (manager.Delete(((List<PharmacyModel>)grid.DataSource)[gridView.FocusedRowHandle]))
                loadData();
        }
    }
}
