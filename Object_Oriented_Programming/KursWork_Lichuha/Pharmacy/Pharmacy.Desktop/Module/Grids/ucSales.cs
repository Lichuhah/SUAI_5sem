﻿using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Domain.Managers.Cashbox;
using Pharmacy.Domain.Models.Cashbox;
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
    public partial class ucSales : TutorialControlBase
    {
        List<Sale> Sales = new List<Sale>();
        public ucSales()
        {
            InitializeComponent();

        }

        private void loadData()
        {
            grid.DataSource = null;
            var manager = new SaleManager();
            Sales = manager.All();
            grid.DataSource = Sales;

        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucSales_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnViewElement_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {

        }

        private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            gridItems.DataSource = Sales[gridView.FocusedRowHandle].Items;
        }
    }
}
