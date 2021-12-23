
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
            this.Control = new DevExpress.XtraBars.Navigation.AccordionControl();
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
            this.controlStat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlStatTime = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.BarEditItem();
            this.barPharmacy = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPharmacy)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(260, 51);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(776, 531);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // Control
            // 
            this.Control.Dock = System.Windows.Forms.DockStyle.Left;
            this.Control.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlCatalog,
            this.ControlAdmins,
            this.ControlWarehouse,
            this.ControlCashbox,
            this.controlStat});
            this.Control.Location = new System.Drawing.Point(0, 51);
            this.Control.Name = "Control";
            this.Control.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.Control.Size = new System.Drawing.Size(260, 531);
            this.Control.TabIndex = 1;
            this.Control.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
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
            this.ControlPharmacyList.Visible = false;
            this.ControlPharmacyList.Click += new System.EventHandler(this.ControlPharmacyList_Click);
            // 
            // ControlWarehouse
            // 
            this.ControlWarehouse.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlWarehouseItems,
            this.ControlWarehouseReport,
            this.ControleWarehouseChanges});
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
            this.ControlCashbox.Name = "ControlCashbox";
            this.ControlCashbox.Text = "Касса";
            this.ControlCashbox.Click += new System.EventHandler(this.ControlCashbox_Click);
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
            // controlStat
            // 
            this.controlStat.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlStatTime});
            this.controlStat.Name = "controlStat";
            this.controlStat.Text = "Статистика";
            // 
            // controlStatTime
            // 
            this.controlStatTime.Name = "controlStatTime";
            this.controlStatTime.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlStatTime.Text = "Общая";
            this.controlStatTime.Click += new System.EventHandler(this.controlStatTime_Click);
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar3,
            this.barButtonItem1,
            this.barHeaderItem1,
            this.barLogout});
            this.barManager1.MaxItemId = 4;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.barPharmacy});
            // 
            // bar1
            // 
            this.bar1.BarName = "Сервис";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLogout)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.Text = "Сервис";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 2;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barLogout
            // 
            this.barLogout.Caption = "Выйти из системы";
            this.barLogout.Id = 3;
            this.barLogout.Name = "barLogout";
            this.barLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLogout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1036, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1036, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1036, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // bar3
            // 
            this.bar3.Caption = "Аптека:";
            this.bar3.Edit = this.barPharmacy;
            this.bar3.Id = 0;
            this.bar3.Name = "bar3";
            // 
            // barPharmacy
            // 
            this.barPharmacy.AutoHeight = false;
            this.barPharmacy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.barPharmacy.Name = "barPharmacy";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Out";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 582);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.fluentDesignFormControl);
            this.FluentDesignFormControl = this.fluentDesignFormControl;
            this.Name = "MainForm";
            this.NavigationControl = this.Control;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPharmacy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl Control;
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
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem bar3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox barPharmacy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barLogout;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlStat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlStatTime;
    }
}