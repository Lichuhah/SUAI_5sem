using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Products;
using System;
using DevExpress.DXperience.Demos;

namespace Pharmacy.Desktop.Module
{
    public partial class ucProduct : TutorialControlBase
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            var manager = new ProductManager();
            var list = manager.All();
            gridControl1.DataSource = list;
        }
    }
}
