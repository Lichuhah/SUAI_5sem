
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
            this.ControlAdmins = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlUserList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlPharmacyList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlWarehouse = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlWarehouseItems = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlWarehouseReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControleWarehouseChanges = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCashbox = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlNewSale = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlCashBoxList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(776, 551);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlCatalog,
            this.ControlAdmins,
            this.ControlWarehouse,
            this.ControlCashbox});
            this.accordionControl.Location = new System.Drawing.Point(0, 31);
            this.accordionControl.Name = "accordionControl";
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
            this.ControlCatalog.Expanded = true;
            this.ControlCatalog.Name = "ControlCatalog";
            this.ControlCatalog.Text = "Каталог";
            // 
            // ControlCatalogProducts
            // 
            this.ControlCatalogProducts.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.ControlCatalogProducts.Name = "ControlCatalogProducts";
            this.ControlCatalogProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogProducts.Text = "Товары";
            this.ControlCatalogProducts.Click += new System.EventHandler(this.ControlCatalogProducts_Click);
            // 
            // ControlCatalogTypes
            // 
            this.ControlCatalogTypes.Name = "ControlCatalogTypes";
            this.ControlCatalogTypes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogTypes.Text = "Типы товаров";
            this.ControlCatalogTypes.Click += new System.EventHandler(this.ControlCatalogTypes_Click);
            // 
            // ControlCatalogCategories
            // 
            this.ControlCatalogCategories.Name = "ControlCatalogCategories";
            this.ControlCatalogCategories.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogCategories.Text = "Категории товаров";
            this.ControlCatalogCategories.Click += new System.EventHandler(this.ControlCatalogCategories_Click);
            // 
            // ControlCatalogForms
            // 
            this.ControlCatalogForms.Name = "ControlCatalogForms";
            this.ControlCatalogForms.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogForms.Text = "Формы выпуска товаров";
            this.ControlCatalogForms.Click += new System.EventHandler(this.ControlCatalogForms_Click);
            // 
            // ControlCatalogBrands
            // 
            this.ControlCatalogBrands.Name = "ControlCatalogBrands";
            this.ControlCatalogBrands.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCatalogBrands.Text = "Бренды";
            this.ControlCatalogBrands.Click += new System.EventHandler(this.ControlCatalogBrands_Click);
            // 
            // ControlAdmins
            // 
            this.ControlAdmins.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlUserList,
            this.ControlPharmacyList});
            this.ControlAdmins.Expanded = true;
            this.ControlAdmins.Name = "ControlAdmins";
            this.ControlAdmins.Text = "Администрирование";
            // 
            // ControlUserList
            // 
            this.ControlUserList.Name = "ControlUserList";
            this.ControlUserList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlUserList.Text = "Список пользователей";
            this.ControlUserList.Click += new System.EventHandler(this.ControlUserList_Click);
            // 
            // ControlPharmacyList
            // 
            this.ControlPharmacyList.Name = "ControlPharmacyList";
            this.ControlPharmacyList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlPharmacyList.Text = "Список аптек";
            this.ControlPharmacyList.Click += new System.EventHandler(this.ControlPharmacyList_Click);
            // 
            // ControlWarehouse
            // 
            this.ControlWarehouse.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlWarehouseItems,
            this.ControlWarehouseReport,
            this.ControleWarehouseChanges});
            this.ControlWarehouse.Expanded = true;
            this.ControlWarehouse.Name = "ControlWarehouse";
            this.ControlWarehouse.Text = "Склад";
            // 
            // ControlWarehouseItems
            // 
            this.ControlWarehouseItems.Name = "ControlWarehouseItems";
            this.ControlWarehouseItems.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlWarehouseItems.Text = "Посмотреть склад";
            this.ControlWarehouseItems.Click += new System.EventHandler(this.ControlWarehouseItems_Click);
            // 
            // ControlWarehouseReport
            // 
            this.ControlWarehouseReport.Name = "ControlWarehouseReport";
            this.ControlWarehouseReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlWarehouseReport.Text = "Зачисление/списание товара";
            this.ControlWarehouseReport.Click += new System.EventHandler(this.ControlWarehouseReport_Click);
            // 
            // ControleWarehouseChanges
            // 
            this.ControleWarehouseChanges.Name = "ControleWarehouseChanges";
            this.ControleWarehouseChanges.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControleWarehouseChanges.Text = "Отчетность";
            this.ControleWarehouseChanges.Click += new System.EventHandler(this.ControleWarehouseChanges_Click);
            // 
            // ControlCashbox
            // 
            this.ControlCashbox.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlNewSale,
            this.ControlCashBoxList});
            this.ControlCashbox.Enabled = false;
            this.ControlCashbox.Name = "ControlCashbox";
            this.ControlCashbox.Text = "Касса";
            // 
            // ControlNewSale
            // 
            this.ControlNewSale.Name = "ControlNewSale";
            this.ControlNewSale.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlNewSale.Text = "Создать продажу";
            this.ControlNewSale.Click += new System.EventHandler(this.ControlNewSale_Click);
            // 
            // ControlCashBoxList
            // 
            this.ControlCashBoxList.Name = "ControlCashBoxList";
            this.ControlCashBoxList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlCashBoxList.Text = "Отчетность";
            this.ControlCashBoxList.Click += new System.EventHandler(this.ControlCashBoxList_Click);
            // 
            // fluentDesignFormControl
            // 
            this.fluentDesignFormControl.FluentDesignForm = this;
            this.fluentDesignFormControl.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl.Manager = this.fluentFormDefaultManager;
            this.fluentDesignFormControl.Name = "fluentDesignFormControl";
            this.fluentDesignFormControl.Size = new System.Drawing.Size(1036, 31);
            this.fluentDesignFormControl.TabIndex = 2;
            this.fluentDesignFormControl.TabStop = false;
            // 
            // fluentFormDefaultManager
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlAdmins;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlWarehouse;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCashbox;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogTypes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogCategories;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogForms;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCatalogBrands;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlWarehouseItems;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlWarehouseReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlUserList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlPharmacyList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControleWarehouseChanges;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlNewSale;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlCashBoxList;
    }
}