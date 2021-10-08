using DevExpress.XtraBars;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using Pharmacy.Desktop.Module.Forms;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.Models.Administration;
using Pharmacy.Domain.Login;

namespace Pharmacy.Desktop
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        User User = LoginUser.GetUser();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            barHeaderItem1.Caption = User.Name;
            switch (User.Role)
            {
                case UserRole.Admin:
                    ControlAdmins.Enabled = true;
                    ControlCatalog.Enabled = true;
                    ControlWarehouse.Enabled = true;
                    ControlCashbox.Enabled = true;
                    break;
                case UserRole.Manager:
                    ControlAdmins.Enabled = false;
                    ControlCatalog.Enabled = true;
                    ControlCashbox.Enabled = false;
                    ControlWarehouse.Enabled = false;
                    break;
                case UserRole.Cashier:
                    ControlAdmins.Enabled = false;
                    ControlCatalog.Enabled = false;
                    ControlWarehouse.Enabled = false;
                    ControlCashbox.Enabled = true;
                    break;
                case UserRole.Warehouse:
                    ControlAdmins.Enabled = false;
                    ControlCatalog.Enabled = false;
                    ControlCashbox.Enabled = false;
                    ControlWarehouse.Enabled = true;
                    break;
            }
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

        private void barLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
