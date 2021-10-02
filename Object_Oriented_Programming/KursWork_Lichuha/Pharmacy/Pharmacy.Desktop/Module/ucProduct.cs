using DevExpress.XtraEditors;
using Pharmacy.Domain.Managers.Products;
using System;

namespace Pharmacy.Desktop.Module
{
    public partial class ucProduct : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            var manager = new ProductManager();
            
        }
    }
}
