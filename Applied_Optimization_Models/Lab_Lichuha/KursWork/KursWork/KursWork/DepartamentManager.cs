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
        public DepartamentManager(Workbook ObjWorkBook)
        {
            Departaments = new List<Departament>();
            this.ObjWorkBook = ObjWorkBook;
        }
        public List<Departament> Departaments { get; set; }
        Workbook ObjWorkBook;
        public void Load()
        {
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
        }

        public void Save()
        {
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
        }

    }
}
