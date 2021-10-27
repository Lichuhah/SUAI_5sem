using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork
{
    public class EmployesManager
    {
        public EmployesManager() { Employees = new List<Employee>(); }
        public List<Employee> Employees { get; set; }
        public void Load()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            for (int i = 5; i < 18; i++)
            {
                Employee employee = new Employee();
                Range range = ObjWorkSheet.get_Range("C" + i.ToString());
                employee.Name = range.Text;
                range = ObjWorkSheet.get_Range("D" + i.ToString());
                employee.Sex = range.Text[0];
                Employees.Add(employee);
            }
            ObjExcel.Quit();
        }

        public void Save()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsx", 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            for (int i = 5; i < 18; i++)
            {
                Employee employee = this.Employees[i - 5];
                Range range = ObjWorkSheet.get_Range("C" + i.ToString());
                range.Value = employee.Name;
                Range range2 = ObjWorkSheet.get_Range("D" + i.ToString());
                range2.Value = employee.Sex.ToString();
            }
            ObjWorkBook.Save();
            ObjExcel.Quit();
        }

        public void setDeps(DepartamentManager departamentManager)
        {
            for (int i = 0; i < 5; i++)
            {
                Employees[i].Departament = departamentManager.Departaments[0];
            }
            for (int i = 5; i < 9; i++)
            {
                Employees[i].Departament = departamentManager.Departaments[1];
            }
            for (int i = 9; i < 11; i++)
            {
                Employees[i].Departament = departamentManager.Departaments[2];
            }
            for (int i = 11; i < 13; i++)
            {
                Employees[i].Departament = departamentManager.Departaments[3];
            }
        }

    }      
}
