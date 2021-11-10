
namespace KursWorkApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoadFromExcel = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPlane = new System.Windows.Forms.DataGridView();
            this.tabCargo = new System.Windows.Forms.TabPage();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.tabPlan = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).BeginInit();
            this.tabCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadFromExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnLoadFromExcel
            // 
            this.btnLoadFromExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadFromExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFromExcel.Image")));
            this.btnLoadFromExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadFromExcel.Name = "btnLoadFromExcel";
            this.btnLoadFromExcel.Size = new System.Drawing.Size(29, 24);
            this.btnLoadFromExcel.Text = "Загрузить из EXCEL";
            this.btnLoadFromExcel.Click += new System.EventHandler(this.btnLoadFromExcel_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabCargo);
            this.tabs.Controls.Add(this.tabPlan);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(902, 510);
            this.tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPlane);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Самолет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPlane
            // 
            this.dgvPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlane.Location = new System.Drawing.Point(3, 3);
            this.dgvPlane.Name = "dgvPlane";
            this.dgvPlane.RowHeadersWidth = 51;
            this.dgvPlane.RowTemplate.Height = 29;
            this.dgvPlane.Size = new System.Drawing.Size(888, 471);
            this.dgvPlane.TabIndex = 0;
            // 
            // tabCargo
            // 
            this.tabCargo.Controls.Add(this.dgvCargo);
            this.tabCargo.Location = new System.Drawing.Point(4, 29);
            this.tabCargo.Name = "tabCargo";
            this.tabCargo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCargo.Size = new System.Drawing.Size(894, 477);
            this.tabCargo.TabIndex = 1;
            this.tabCargo.Text = "Грузы";
            this.tabCargo.UseVisualStyleBackColor = true;
            // 
            // dgvCargo
            // 
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCargo.Location = new System.Drawing.Point(3, 3);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.RowHeadersWidth = 51;
            this.dgvCargo.RowTemplate.Height = 29;
            this.dgvCargo.Size = new System.Drawing.Size(888, 471);
            this.dgvCargo.TabIndex = 0;
            // 
            // tabPlan
            // 
            this.tabPlan.Location = new System.Drawing.Point(4, 29);
            this.tabPlan.Name = "tabPlan";
            this.tabPlan.Size = new System.Drawing.Size(894, 477);
            this.tabPlan.TabIndex = 2;
            this.tabPlan.Text = "План";
            this.tabPlan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 537);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).EndInit();
            this.tabCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadFromExcel;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPlane;
        private System.Windows.Forms.TabPage tabCargo;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.TabPage tabPlan;
    }
}

