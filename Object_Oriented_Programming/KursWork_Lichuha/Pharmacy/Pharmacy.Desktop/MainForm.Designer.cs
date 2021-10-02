
namespace Pharmacy.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ControlCatalog = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCatalogProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCatalogTypes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCatalogCategories = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCatalogForms = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCatalogBrands = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlWarehouse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCashbox = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(776, 551);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlCatalog,
            this.ControlUsers,
            this.ControlWarehouse,
            this.ControlCashbox});
            this.accordionControl.Location = new System.Drawing.Point(0, 31);
            this.accordionControl.Name = "accordionControl1";
            this.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl.Size = new System.Drawing.Size(260, 551);
            this.accordionControl.TabIndex = 1;
            this.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ControlCatalog
            // 
            this.ControlCatalog.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlCatalogProducts,
            this.ControlCatalogTypes,
            this.ControlCatalogCategories,
            this.ControlCatalogForms,
            this.ControlCatalogBrands});
            this.ControlCatalog.Name = "ControlCatalog";
            this.ControlCatalog.Text = "Каталог";
            // 
            // ControlCatalogProducts
            // 
            this.ControlCatalogProducts.Name = "ControlCatalogProducts";
            this.ControlCatalogProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogProducts.Text = "Товары";
            // 
            // ControlCatalogTypes
            // 
            this.ControlCatalogTypes.Name = "ControlCatalogTypes";
            this.ControlCatalogTypes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogTypes.Text = "Типы товаров";
            // 
            // ControlCatalogCategories
            // 
            this.ControlCatalogCategories.Name = "ControlCatalogCategories";
            this.ControlCatalogCategories.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogCategories.Text = "Категории товаров";
            // 
            // ControlCatalogForms
            // 
            this.ControlCatalogForms.Name = "ControlCatalogForms";
            this.ControlCatalogForms.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogForms.Text = "Формы выпуска товаров";
            // 
            // ControlCatalogBrands
            // 
            this.ControlCatalogBrands.Name = "ControlCatalogBrands";
            this.ControlCatalogBrands.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogBrands.Text = "Бренды";
            // 
            // ControlUsers
            // 
            this.ControlUsers.Enabled = false;
            this.ControlUsers.Name = "ControlUsers";
            this.ControlUsers.Text = "Пользователи";
            // 
            // ControlWarehouse
            // 
            this.ControlWarehouse.Enabled = false;
            this.ControlWarehouse.Name = "ControlWarehouse";
            this.ControlWarehouse.Text = "Склад";
            // 
            // ControlCashbox
            // 
            this.ControlCashbox.Enabled = false;
            this.ControlCashbox.Name = "ControlCashbox";
            this.ControlCashbox.Text = "Касса";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl.FluentDesignForm = this;
            this.fluentDesignFormControl.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl.Manager = this.fluentFormDefaultManager;
            this.fluentDesignFormControl.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl.Size = new System.Drawing.Size(1036, 31);
            this.fluentDesignFormControl.TabIndex = 2;
            this.fluentDesignFormControl.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager.Form = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 582);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl);
            this.Controls.Add(this.fluentDesignFormControl);
            this.FluentDesignFormControl = this.fluentDesignFormControl;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl;
            this.Text = "FluentDesignForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalog;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlWarehouse;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCashbox;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogTypes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogCategories;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogForms;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogBrands;
    }
}