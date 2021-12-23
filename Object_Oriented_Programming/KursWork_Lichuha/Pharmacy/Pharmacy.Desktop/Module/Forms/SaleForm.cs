using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Cashbox;
using Pharmacy.Domain.Models.Cashbox;
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
    public partial class SaleForm : DevExpress.XtraEditors.XtraForm
    {
        List<SaleItem> items = new List<SaleItem>();
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            SaleItemForm form = new SaleItemForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var a = form.Item;
                if (items.Where(x => x.Product.ID == form.Item.Product.ID).Count()>0)
                {

                }
                else
                {
                    items.Add(form.Item);
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = items;
                    gridControl1.Refresh();
                    txtPrice.Value = txtPrice.Value + (decimal)form.Item.Price;
                }
                gridView1.Columns.ColumnByFieldName("Product").Visible = false;
                gridView1.Columns.ColumnByFieldName("Sale").Visible = false;
                gridView1.Columns.ColumnByFieldName("ID").Visible = false;
            }           
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            SaleManager manager = new SaleManager();
            Sale item = new Sale()
            {
                Items = this.items,
                Price = (double)txtPrice.Value,
                Date = dateEdit.DateTime
            };
            manager.Add(item);
            manager.SetCountBySale(item);
            this.Close();
        }
    }
}