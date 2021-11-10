using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork
{
    public partial class Form2 : Form
    {
        DepartamentManager DepartamentManager;
        TimesManager TimesManager;
        EmployesManager EmployesManager;
        PlanManager PlanManager;
        Workbook ObjWorkBook;
        Microsoft.Office.Interop.Excel.Application ObjExcel;

        public Form2()
        {
            InitializeComponent();
            try
            {
                ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                ObjWorkBook = ObjExcel.Workbooks.Open(@"C:\Users\belov\Desktop\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsm", 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DepartamentManager = new DepartamentManager(ObjWorkBook);
            TimesManager = new TimesManager(ObjWorkBook);
            EmployesManager = new EmployesManager(ObjWorkBook);
            PlanManager = new PlanManager(ObjWorkBook, EmployesManager, TimesManager, DepartamentManager);       
        }

        ~Form2()
        {
            ObjWorkBook.Close(0);
            ObjExcel.Quit();
        }

        public void Refresh()
        {
            DepartamentManager.Departaments.Clear();
            TimesManager.Times.Clear();
            EmployesManager.Employees.Clear();
            PlanManager.Clear();

            dgvMF.DataSource = null;
            dgvDeps.DataSource = null;
            dgvEmployee.DataSource = null;
            dgvPlan.DataSource = null;
            dgvPlanInfo.DataSource = null;
            dgvPoints.DataSource = null;


            DepartamentManager.Load();
            dgvDeps.DataSource = DepartamentManager.Departaments;

            TimesManager.Load();
            dgvPoints.DataSource = TimesManager.Times;

            EmployesManager.Load();
            EmployesManager.setDeps(DepartamentManager);
            dgvEmployee.DataSource = EmployesManager.Employees;

            PlanManager.Load();
            dgvPlan.DataSource = PlanManager.Plans;

            dgvPlanInfo.DataSource = PlanManager.PlanDeps;
            for (int i = 0; i < TimesManager.Times.Count; i++)
            {
                dgvPlanInfo.Columns[i + 2].HeaderText = TimesManager.Times[i].Period;
            }
            dgvMF.DataSource = PlanManager.PlanMFs;

            lblDeltaMF.Text = "Коэффициент: " + PlanManager.DeltaMF.ToString();
            lblResult.Text = "Количество итоговых баллов: " + PlanManager.Result.ToString();

            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            Range range = ObjWorkSheet.get_Range("A50");
            range.Value = PlanManager.Result;
            ObjWorkBook.Save();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dgvEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            char value = Convert.ToChar(dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            if (value != 'м' && value != 'ж')
            {
                MessageBox.Show("Выберите м или ж, данные не сохранены");
                return;
            }
            EmployesManager.Save();
            Refresh();
        }

        private void dgvPoints_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TimesManager.Save();
            Refresh();
        }

        private void dgvDeps_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double value = Convert.ToInt32(dgvDeps.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            if (value <= 0)
            {
                MessageBox.Show("Отрицательное число, данные не сохранены");
                return;
            }
            DepartamentManager.Save();
            Refresh();
            
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == 2)
            {
                SelectForm form = new SelectForm(ObjWorkBook);
                form.ShowDialog();
                Plan item = (Plan)senderGrid.Rows[e.RowIndex].DataBoundItem;
                item.Time = TimesManager.Times.Where(x => x.Period == form.Result).First();
                dgvPlan.Refresh();
                PlanManager.Save();
            }
            Refresh();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ObjWorkBook.Close(0);
            ObjExcel.Quit();
        }

        private void btnSolver1_Click(object sender, EventArgs e)
        {
            ObjExcel.Run("Macros1");
            Refresh();           
        }

        private void btnSolver2_Click(object sender, EventArgs e)
        {
            ObjExcel.Run("Macros2");
            Refresh();
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            List<string> ErrorList = new List<string>();
            lblError.Text = string.Empty;
            for (int i = 0; i < TimesManager.Times.Count(); i++) {
                if ((PlanManager.Plans.Where(x => x.TimePeriod == TimesManager.Times[i].Period).Count())<2){
                    ErrorList.Add("В " + TimesManager.Times[i].Period + " обедает только один сотрудник\n");
                }
            }
            foreach(var item in PlanManager.PlanDeps)
            {
                foreach(var count in item.Counts)
                {
                    if(count > item.DepMax)
                    {
                        ErrorList.Add("В отделе " + item.DepName + " на обед одновременно уходит слишком много сотрудников\n");
                    }
                }
            }
            if(ErrorList.Any())
            {
                foreach(var item in ErrorList) { lblError.Text += item; }
            } else
            {
                lblError.Text = "Все проверки успешно пройдены";
            }
        }

        private void dgvEmployee_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
             MessageBox.Show("Выберите м или ж, данные не сохранены");
             return;
        }

        private void dgvPoints_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректные данные");
            return;
        }

        private void dgvPlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректные данные");
            return;
        }

        private void dgvDeps_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректные данные");
            return;
        }
    }
}
