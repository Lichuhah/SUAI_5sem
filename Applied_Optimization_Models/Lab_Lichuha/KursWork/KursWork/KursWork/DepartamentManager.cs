using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork
{
    public class DepartamentManager
    {
        public DepartamentManager()
        {
            Departaments = new List<Departament>();
        }
        public List<Departament> Departaments { get; set; }

        public void Load()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            for (int i = 5; i < 9; i++)
            {
                Departament departament = new Departament();
                Range range = ObjWorkSheet.get_Range("L" + i.ToString());
                departament.Name = range.Text;
                range = ObjWorkSheet.get_Range("Q" + i.ToString());
                departament.MaxCount = Convert.ToInt32(range.Value);
                Departaments.Add(departament);
            }
            ObjExcel.Quit();
        }

        public void Save()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsx", 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            for (int i = 5; i < 9; i++)
            {
                Departament departament = this.Departaments[i - 5];
                Range range = ObjWorkSheet.get_Range("L" + i.ToString());
                range.Value = departament.Name;
                Range range2 = ObjWorkSheet.get_Range("Q" + i.ToString());
                range2.Value = departament.MaxCount;
            }
            ObjWorkBook.Save();
            ObjExcel.Quit();
        }

    }
}
