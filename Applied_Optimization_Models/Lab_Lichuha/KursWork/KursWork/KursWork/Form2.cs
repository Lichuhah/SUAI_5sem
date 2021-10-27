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
        DepartamentManager DepartamentManager = new DepartamentManager();
        TimesManager TimesManager = new TimesManager();
        EmployesManager EmployesManager = new EmployesManager();
        PlanManager PlanManager;


        public Form2()
        {
            InitializeComponent();
            PlanManager = new PlanManager(EmployesManager, TimesManager, DepartamentManager);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DepartamentManager.Load();
            dgvDeps.DataSource = DepartamentManager.Departaments;

            TimesManager.Load();
            dgvPoints.DataSource = TimesManager.Times;

            EmployesManager.Load();
            EmployesManager.setDeps(DepartamentManager);
            dgvEmployee.DataSource = EmployesManager.Employees;

            PlanManager.Load();
            dgvPlan.DataSource = PlanManager.Plans;
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            dgvPlan.Columns.Add(colBtn);

            dgvPlanInfo.DataSource = PlanManager.PlanDeps;
            for(int i=0; i< TimesManager.Times.Count; i++){
                dgvPlanInfo.Columns.Add("a", "");
            }
            for(int i=0; i < TimesManager.Times.Count; i++)
            {
                dgvPlanInfo.Columns[i + 2].HeaderText = TimesManager.Times[i].Period;
            }
            dgvMF.DataSource = PlanManager.PlanMFs;

            lblDeltaMF.Text = PlanManager.DeltaMF.ToString();
            lblResult.Text = PlanManager.Result.ToString();
        }

        private void dgvEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EmployesManager.Save();
        }

        private void dgvPoints_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TimesManager.Save();
        }

        private void dgvDeps_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DepartamentManager.Save();
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                SelectForm form = new SelectForm();
                form.ShowDialog();
                Plan item = (Plan)senderGrid.Rows[e.RowIndex].DataBoundItem;
                item.Time = TimesManager.Times.Where(x => x.Period == form.Result).First();
                dgvPlan.Refresh();
                PlanManager.Save();
            }
        }
    }
}
