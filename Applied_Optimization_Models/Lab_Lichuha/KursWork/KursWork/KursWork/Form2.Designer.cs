
namespace KursWork
{
    partial class Form2
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.btnValidation = new System.Windows.Forms.Button();
            this.btnSolver2 = new System.Windows.Forms.Button();
            this.btnSolver1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDeltaMF = new System.Windows.Forms.Label();
            this.dgvPlanInfo = new System.Windows.Forms.DataGridView();
            this.dgvMF = new System.Windows.Forms.DataGridView();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPoints = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDeps = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeps)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblError);
            this.tabPage2.Controls.Add(this.btnValidation);
            this.tabPage2.Controls.Add(this.btnSolver2);
            this.tabPage2.Controls.Add(this.btnSolver1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblResult);
            this.tabPage2.Controls.Add(this.lblDeltaMF);
            this.tabPage2.Controls.Add(this.dgvPlanInfo);
            this.tabPage2.Controls.Add(this.dgvMF);
            this.tabPage2.Controls.Add(this.dgvPlan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(952, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Планирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(485, 448);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(104, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Проверок не было.";
            // 
            // btnValidation
            // 
            this.btnValidation.Location = new System.Drawing.Point(485, 416);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(459, 23);
            this.btnValidation.TabIndex = 10;
            this.btnValidation.Text = "Проверка на ошибки";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // btnSolver2
            // 
            this.btnSolver2.Location = new System.Drawing.Point(744, 201);
            this.btnSolver2.Name = "btnSolver2";
            this.btnSolver2.Size = new System.Drawing.Size(172, 23);
            this.btnSolver2.TabIndex = 9;
            this.btnSolver2.Text = "Найти оптимальное м/ж";
            this.btnSolver2.UseVisualStyleBackColor = true;
            this.btnSolver2.Click += new System.EventHandler(this.btnSolver2_Click);
            // 
            // btnSolver1
            // 
            this.btnSolver1.Location = new System.Drawing.Point(25, 416);
            this.btnSolver1.Name = "btnSolver1";
            this.btnSolver1.Size = new System.Drawing.Size(459, 23);
            this.btnSolver1.TabIndex = 8;
            this.btnSolver1.Text = "Найти оптимальное решение";
            this.btnSolver1.UseVisualStyleBackColor = true;
            this.btnSolver1.Click += new System.EventHandler(this.btnSolver1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Соотношение м/ж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "План по отделам";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "План";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(21, 442);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label4";
            // 
            // lblDeltaMF
            // 
            this.lblDeltaMF.AutoSize = true;
            this.lblDeltaMF.Location = new System.Drawing.Point(498, 364);
            this.lblDeltaMF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeltaMF.Name = "lblDeltaMF";
            this.lblDeltaMF.Size = new System.Drawing.Size(70, 13);
            this.lblDeltaMF.TabIndex = 3;
            this.lblDeltaMF.Text = "ААААААААА";
            // 
            // dgvPlanInfo
            // 
            this.dgvPlanInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanInfo.Location = new System.Drawing.Point(501, 37);
            this.dgvPlanInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlanInfo.Name = "dgvPlanInfo";
            this.dgvPlanInfo.RowHeadersWidth = 51;
            this.dgvPlanInfo.RowTemplate.Height = 24;
            this.dgvPlanInfo.Size = new System.Drawing.Size(415, 145);
            this.dgvPlanInfo.TabIndex = 2;
            // 
            // dgvMF
            // 
            this.dgvMF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMF.Location = new System.Drawing.Point(501, 229);
            this.dgvMF.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMF.Name = "dgvMF";
            this.dgvMF.RowHeadersWidth = 51;
            this.dgvMF.RowTemplate.Height = 24;
            this.dgvMF.Size = new System.Drawing.Size(415, 122);
            this.dgvMF.TabIndex = 1;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(25, 37);
            this.dgvPlan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersWidth = 51;
            this.dgvPlan.RowTemplate.Height = 24;
            this.dgvPlan.Size = new System.Drawing.Size(459, 340);
            this.dgvPlan.TabIndex = 0;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            this.dgvPlan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPlan_DataError);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEmployee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvPoints);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvDeps);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(952, 495);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Входные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(431, 59);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(346, 339);
            this.dgvEmployee.TabIndex = 5;
            this.dgvEmployee.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellEndEdit);
            this.dgvEmployee.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEmployee_DataError);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cотрудники";
            // 
            // dgvPoints
            // 
            this.dgvPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoints.Location = new System.Drawing.Point(127, 282);
            this.dgvPoints.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPoints.Name = "dgvPoints";
            this.dgvPoints.RowHeadersWidth = 51;
            this.dgvPoints.RowTemplate.Height = 24;
            this.dgvPoints.Size = new System.Drawing.Size(289, 116);
            this.dgvPoints.TabIndex = 3;
            this.dgvPoints.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoints_CellEndEdit);
            this.dgvPoints.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPoints_DataError);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Баллы комфорта";
            // 
            // dgvDeps
            // 
            this.dgvDeps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeps.Location = new System.Drawing.Point(127, 59);
            this.dgvDeps.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeps.Name = "dgvDeps";
            this.dgvDeps.RowHeadersWidth = 51;
            this.dgvDeps.RowTemplate.Height = 24;
            this.dgvDeps.Size = new System.Drawing.Size(289, 184);
            this.dgvDeps.TabIndex = 1;
            this.dgvDeps.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeps_CellEndEdit);
            this.dgvDeps.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDeps_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отделы";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 521);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "СУПЕРПЛАНИРОВКАОБЕДОВ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeps)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDeltaMF;
        private System.Windows.Forms.DataGridView dgvPlanInfo;
        private System.Windows.Forms.DataGridView dgvMF;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDeps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSolver1;
        private System.Windows.Forms.Button btnSolver2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnValidation;
    }
}