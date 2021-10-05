using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using Pharmacy.Desktop.Module;
using Pharmacy.Desktop.Module.Forms;

namespace Pharmacy.Desktop
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormContainer.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {

                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                } else
                {
                    var control = fluentDesignFormContainer.Controls.Find(module.Name, true);
                    if (control.Length == 1) fluentDesignFormContainer.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                }
            });
        }

        private async void ControlCatalogProducts_Click(object sender, EventArgs e)
        {
            await Loaduc("ucProduct", "Pharmacy.Desktop.Module.ucProduct");
        }

        private async void ControlCatalogTypes_Click(object sender, EventArgs e)
        {
            await Loaduc("ucType", "Pharmacy.Desktop.Module.ucType");
        }

        private async void ControlCatalogCategories_Click(object sender, EventArgs e)
        {
            await Loaduc("ucCategory", "Pharmacy.Desktop.Module.ucCategory");
        }

        private async void ControlCatalogForms_Click(object sender, EventArgs e)
        {
            await Loaduc("ucForm", "Pharmacy.Desktop.Module.ucForm");
        }

        private async void ControlCatalogBrands_Click(object sender, EventArgs e)
        {
            await Loaduc("ucBrand", "Pharmacy.Desktop.Module.ucBrand");
        }

        private async void ControlUserList_Click(object sender, EventArgs e)
        {
            await Loaduc("ucUsers", "Pharmacy.Desktop.Module.ucUsers");
        }

        private async void ControlPharmacyList_Click(object sender, EventArgs e)
        {
            await Loaduc("ucPharmacy", "Pharmacy.Desktop.Module.Grids.ucPharmacy");
        }

        private async void ControlWarehouseItems_Click(object sender, EventArgs e)
        {
            await Loaduc("ucWarehouse", "Pharmacy.Desktop.Module.Grids.ucWarehouse");
        }

        private void ControlWarehouseReport_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }

        private async void ControleWarehouseChanges_Click(object sender, EventArgs e)
        {
            await Loaduc("ucWarehouseReports", "Pharmacy.Desktop.Module.Grids.ucWareHouseReports");
        }

        private void ControlNewSale_Click(object sender, EventArgs e)
        {
            SaleForm form = new SaleForm();
            form.ShowDialog();
        }

        private async void ControlCashBoxList_Click(object sender, EventArgs e)
        {
            await Loaduc("ucSales", "Pharmacy.Desktop.Module.Grids.ucSales");
        }

        private async Task Loaduc(string uc, string path)
        {
            if (ModulesInfo.GetItem(uc) == null)
                ModulesInfo.Add(new ModuleInfo(uc, path));
            await LoadModuleAsync(ModulesInfo.GetItem(uc));
        }
    }
}
