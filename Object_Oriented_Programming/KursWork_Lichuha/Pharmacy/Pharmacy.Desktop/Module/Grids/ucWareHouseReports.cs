using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Domain.Managers.Warehouse.Changes;
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

namespace Pharmacy.Desktop.Module.Grids
{
    public partial class ucWareHouseReports : TutorialControlBase
    {
        public ucWareHouseReports()
        {
            InitializeComponent();
        }

        private void loadGeneralData()
        {
            grid.DataSource = null;
            var manager = new WareHouseReportManager();
            var list = manager.All();
            grid.DataSource = list;
        }

        private void loadEnrollmentData()
        {
            gridEnrollment.DataSource = null;
            var manager = new WareHouseEnrollmentManager();
            var list = manager.All();
            gridEnrollment.DataSource = list;
        }

        private void loadWriteOffData()
        {
            gridWriteOff.DataSource = null;
            var manager = new WareHouseWriteOffManager();
            var list = manager.All();
            gridWriteOff.DataSource = list;
        }
        private void ucWareHouseReports_Load(object sender, EventArgs e)
        {
            loadGeneralData();
            loadEnrollmentData();
            loadWriteOffData();

            gridView.Columns.ColumnByFieldName("WareHouse").Visible = false;
            gridView.Columns.ColumnByFieldName("Product").Visible = false;
            gridView.Columns.ColumnByFieldName("ID").Visible = false;
            //gridView.Columns.ColumnByFieldName("Name").VisibleIndex = 0;

            gridView.Columns.Add(new GridColumn()
            {
                Name = "btnColumnView",
                ColumnEdit = btnViewElement,
                MaxWidth = 40
            });
            gridView.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;
            gridView1.Columns.ColumnByFieldName("Type").Visible = false;
            gridView1.Columns.ColumnByFieldName("WareHouse").Visible = false;
            gridView1.Columns.ColumnByFieldName("Product").Visible = false;
            gridView1.Columns.ColumnByFieldName("ID").Visible = false;
            //gridView.Columns.ColumnByFieldName("Name").VisibleIndex = 0;

            gridView1.Columns.Add(new GridColumn()
            {
                Name = "btnColumnView",
                ColumnEdit = btnViewElement,
                MaxWidth = 40
            });
            gridView1.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;

            gridView2.Columns.ColumnByFieldName("Type").Visible = false;
            gridView2.Columns.ColumnByFieldName("WareHouse").Visible = false;
            gridView2.Columns.ColumnByFieldName("Product").Visible = false;
            gridView2.Columns.ColumnByFieldName("ID").Visible = false;
            //gridView.Columns.ColumnByFieldName("Name").VisibleIndex = 0;

            gridView2.Columns.Add(new GridColumn()
            {
                Name = "btnColumnView",
                ColumnEdit = btnViewElement,
                MaxWidth = 40
            });
            gridView2.Columns.ColumnByName("btnColumnView").VisibleIndex = 0;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnViewElement_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {

        }
    }
}
