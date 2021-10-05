
namespace Pharmacy.Desktop.Module.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbPharmacy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPas1 = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPas2 = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPharmacy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPas1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPas2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(492, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 187);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(492, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 163);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(492, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 163);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbPharmacy);
            this.layoutControl1.Controls.Add(this.cmbRole);
            this.layoutControl1.Controls.Add(this.txtPas1);
            this.layoutControl1.Controls.Add(this.txtLogin);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtPas2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(492, 163);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbPharmacy
            // 
            this.cmbPharmacy.Enabled = false;
            this.cmbPharmacy.Location = new System.Drawing.Point(118, 132);
            this.cmbPharmacy.MenuManager = this.barManager1;
            this.cmbPharmacy.Name = "cmbPharmacy";
            this.cmbPharmacy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPharmacy.Size = new System.Drawing.Size(345, 20);
            this.cmbPharmacy.StyleController = this.layoutControl1;
            this.cmbPharmacy.TabIndex = 8;
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(118, 108);
            this.cmbRole.MenuManager = this.barManager1;
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRole.Properties.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Кассир",
            "Работник склада"});
            this.cmbRole.Size = new System.Drawing.Size(345, 20);
            this.cmbRole.StyleController = this.layoutControl1;
            this.cmbRole.TabIndex = 7;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // txtPas1
            // 
            this.txtPas1.Location = new System.Drawing.Point(118, 60);
            this.txtPas1.MenuManager = this.barManager1;
            this.txtPas1.Name = "txtPas1";
            this.txtPas1.Size = new System.Drawing.Size(345, 20);
            this.txtPas1.StyleController = this.layoutControl1;
            this.txtPas1.TabIndex = 6;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(118, 36);
            this.txtLogin.MenuManager = this.barManager1;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(345, 20);
            this.txtLogin.StyleController = this.layoutControl1;
            this.txtLogin.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 12);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 4;
            // 
            // txtPas2
            // 
            this.txtPas2.Location = new System.Drawing.Point(118, 84);
            this.txtPas2.Name = "txtPas2";
            this.txtPas2.Size = new System.Drawing.Size(345, 20);
            this.txtPas2.StyleController = this.layoutControl1;
            this.txtPas2.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(475, 164);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.CustomizationFormText = "Имя";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(455, 24);
            this.layoutControlItem1.Text = "Имя";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtLogin;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(455, 24);
            this.layoutControlItem2.Text = "Логин";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPas1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(455, 24);
            this.layoutControlItem3.Text = "Пароль";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbRole;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(455, 24);
            this.layoutControlItem4.Text = "Роль";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmbPharmacy;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(455, 24);
            this.layoutControlItem5.Text = "Аптека";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPas2;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "Пароль";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(455, 24);
            this.layoutControlItem6.Text = "Повторите пароль";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(94, 13);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 187);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPharmacy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPas1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPas2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPharmacy;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRole;
        private DevExpress.XtraEditors.TextEdit txtPas1;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtPas2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}