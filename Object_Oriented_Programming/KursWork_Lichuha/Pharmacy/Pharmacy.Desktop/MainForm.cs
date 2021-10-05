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
            if (ModulesInfo.GetItem("ucProduct") == null)
                ModulesInfo.Add(new ModuleInfo("ucProduct", "Pharmacy.Desktop.Module.ucProduct"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucProduct"));
        }

        private async void ControlCatalogTypes_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucType") == null)
                ModulesInfo.Add(new ModuleInfo("ucType", "Pharmacy.Desktop.Module.ucType"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucType"));
        }

        private async void ControlCatalogCategories_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucCategory") == null)
                ModulesInfo.Add(new ModuleInfo("ucCategory", "Pharmacy.Desktop.Module.ucCategory"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucCategory"));
        }

        private async void ControlCatalogForms_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucForm") == null)
                ModulesInfo.Add(new ModuleInfo("ucForm", "Pharmacy.Desktop.Module.ucForm"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucForm"));
        }

        private async void ControlCatalogBrands_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucBrand") == null)
                ModulesInfo.Add(new ModuleInfo("ucBrand", "Pharmacy.Desktop.Module.ucBrand"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucBrand"));
        }

        private async void ControlUserList_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucUsers") == null)
                ModulesInfo.Add(new ModuleInfo("ucUsers", "Pharmacy.Desktop.Module.ucUsers"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucUsers"));
        }
    }
}
