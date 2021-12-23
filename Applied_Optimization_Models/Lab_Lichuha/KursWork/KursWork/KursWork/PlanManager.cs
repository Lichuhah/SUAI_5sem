using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork
{
    public class PlanManager
    {
        public PlanManager(Workbook ObjWorkBook, EmployesManager employesManager, TimesManager timesManager, DepartamentManager departamentManager)
        {
            this.DepartamentManager = departamentManager;
            this.EmployesManager = employesManager;
            this.TimesManager = timesManager;
            Plans = new List<Plan>();
            PlanDeps = new List<PlanDep>();
            PlanMFs = new List<PlanMF>();
            this.ObjWorkBook = ObjWorkBook;
        }

        Workbook ObjWorkBook;
        EmployesManager EmployesManager;
        TimesManager TimesManager;
        DepartamentManager DepartamentManager;
        public List<Plan> Plans { get; set; }
        public List<PlanDep> PlanDeps{ get; set; }
        public List<PlanMF> PlanMFs { get; set; }
        public double DeltaMF { get; set; }
        public double Result { get; set; }

        public void Load()
        {
            for(int i=0; i<EmployesManager.Employees.Count; i++)
            {
                Plans.Add(new Plan { Employee = EmployesManager.Employees[i], Departament = EmployesManager.Employees[i].Departament });
            }
            setTimes();
            createPlanDeps();
            createPlanMFs();
        }
        public void Save()
        {
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            for(int i = 5; i<18; i++)
            {
                Plan plan = this.Plans[i - 5];
                Range range1 = ObjWorkSheet.get_Range("E" + i.ToString());
                range1.Value = plan.TimePeriod == TimesManager.Times[0].Period ? 1 : 0;
                Range range2 = ObjWorkSheet.get_Range("F" + i.ToString());
                range2.Value = plan.TimePeriod == TimesManager.Times[1].Period ? 1 : 0;
                Range range3 = ObjWorkSheet.get_Range("G" + i.ToString());
                range3.Value = plan.TimePeriod == TimesManager.Times[2].Period ? 1 : 0;
            }
            ObjWorkBook.Save();
        }
        public void setTimes()
        {
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            for (int i = 0; i < this.Plans.Count; i++)
            {
                Plan plan = Plans[i];
                char c = 'E';
                for (int j = 0; j < 3; j++)
                {
                    string adres = c + (i + 5).ToString();
                    Range range = ObjWorkSheet.get_Range(adres);
                    if (range.Value != 0)
                    {
                        plan.Time = TimesManager.Times[j];
                    }
                    c++;
                }

            }

            Range rang = ObjWorkSheet.get_Range("X7");
            DeltaMF = rang.Value;

            rang = ObjWorkSheet.get_Range("E25");
            Result = rang.Value;

            ObjWorkBook.Save();
        }

        public void createPlanDeps()
        {
            for(int i=0; i<DepartamentManager.Departaments.Count; i++)
            {
                PlanDep pd = new PlanDep() { DepName = DepartamentManager.Departaments[i].Name, DepMax=DepartamentManager.Departaments[i].MaxCount };
                for(int j=0; j<TimesManager.Times.Count; j++)
                {
                    pd.Counts.Add(Plans.Where(x => x.Departament == DepartamentManager.Departaments[i]).ToList()
                        .Where(x => x.TimePeriod == TimesManager.Times[j].Period).ToList().Count);
                }
                PlanDeps.Add(pd);
            }
        }

        public void Clear()
        {
            this.PlanDeps.Clear();
            this.PlanMFs.Clear();
            this.Plans.Clear();
        }
        public void createPlanMFs()
        {
            for(int i=0; i<TimesManager.Times.Count; i++)
            {
                PlanMF mf = new PlanMF() { Time = TimesManager.Times[i] };
                mf.CountF = Plans.Where(x => x.Time == mf.Time).Where(x => x.Employee.Sex == 'ж').ToList().Count;
                mf.CountM = Plans.Where(x => x.Time == mf.Time).Where(x => x.Employee.Sex == 'м').ToList().Count;
                PlanMFs.Add(mf);
            }
        }
    }
    
    
}
