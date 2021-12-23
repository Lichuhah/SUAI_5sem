using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Desktop.Module.Forms;
using Pharmacy.Domain.Managers.Warehouse;
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
    public partial class ucWarehouse : TutorialControlBase
    {
        public ucWarehouse()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            grid.DataSource = null;
            var manager = new WareHouseItemManager();
            var list = manager.All();
            grid.DataSource = list;
        }
        private void ucWarehouse_Load(object sender, EventArgs e)
        {
            loadData();

            gridView.Columns.ColumnByFieldName("WareHouse").Visible = false;
            gridView.Columns.ColumnByFieldName("Product").Visible = false;
            gridView.Columns.ColumnByFieldName("ID").Visible = false;
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
