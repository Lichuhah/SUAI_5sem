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
    }
}
