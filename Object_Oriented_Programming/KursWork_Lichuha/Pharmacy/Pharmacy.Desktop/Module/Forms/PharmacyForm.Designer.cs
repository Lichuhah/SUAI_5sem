
namespace Pharmacy.Desktop.Module.Forms
{
    partial class PharmacyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStartEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCompleteEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(514, 42);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(497, 54);
            this.Root.TextVisible = false;
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
            this.barBtnAdd,
            this.barBtnStartEdit,
            this.barBtnCompleteEdit,
            this.barBtnCancelEdit});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Сервис";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnStartEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCompleteEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCancelEdit)});
            this.bar1.Text = "Сервис";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "Добавить";
            this.barBtnAdd.Id = 0;
            this.barBtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAdd.ImageOptions.Image")));
            this.barBtnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAdd.ImageOptions.LargeImage")));
            this.barBtnAdd.Name = "barBtnAdd";
            this.barBtnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_ItemClick);
            // 
            // barBtnStartEdit
            // 
            this.barBtnStartEdit.Caption = "Изменить";
            this.barBtnStartEdit.Id = 1;
            this.barBtnStartEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnStartEdit.ImageOptions.Image")));
            this.barBtnStartEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStartEdit.ImageOptions.LargeImage")));
            this.barBtnStartEdit.Name = "barBtnStartEdit";
            this.barBtnStartEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnStartEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStartEdit_ItemClick);
            // 
            // barBtnCompleteEdit
            // 
            this.barBtnCompleteEdit.Caption = "Сохранить изменения";
            this.barBtnCompleteEdit.Id = 2;
            this.barBtnCompleteEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCompleteEdit.ImageOptions.Image")));
            this.barBtnCompleteEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCompleteEdit.ImageOptions.LargeImage")));
            this.barBtnCompleteEdit.Name = "barBtnCompleteEdit";
            this.barBtnCompleteEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCompleteEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCompleteEdit_ItemClick);
            // 
            // barBtnCancelEdit
            // 
            this.barBtnCancelEdit.Caption = "Отменить изменения";
            this.barBtnCancelEdit.Id = 3;
            this.barBtnCancelEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCancelEdit.ImageOptions.Image")));
            this.barBtnCancelEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCancelEdit.ImageOptions.LargeImage")));
            this.barBtnCancelEdit.Name = "barBtnCancelEdit";
            this.barBtnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelEdit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(514, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 66);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(514, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 42);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(514, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 42);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(63, 12);
            this.txtAddress.MenuManager = this.barManager1;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(422, 20);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtAddress;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(477, 24);
            this.layoutControlItem1.Text = "Address";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(477, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 66);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PharmacyForm";
            this.Text = "PharmacyForm";
            this.Load += new System.EventHandler(this.PharmacyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnStartEdit;
        private DevExpress.XtraBars.BarButtonItem barBtnCompleteEdit;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelEdit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}