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

namespace Pharmacy.Desktop.Module
{
    public partial class ucUsers : TutorialControlBase
    {
        public ucUsers()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            grid.DataSource = null;
            var manager = new UserManager();
            var list = manager.All();
            grid.DataSource = list;
        }

        private void ucUsers_Load(object sender, EventArgs e)
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

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserForm form = new UserForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            UserManager manager = new UserManager();
            if (manager.Delete(((List<User>)grid.DataSource)[gridView.FocusedRowHandle]))
                loadData();

        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void btnViewElement_Click(object sender, EventArgs e)
        {
            User user = ((List<User>)grid.DataSource)[gridView.FocusedRowHandle];
            UserForm form = new UserForm(user.ID);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                loadData();
        }
    }
}
