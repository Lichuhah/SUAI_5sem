using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace KursWork
{
    public class Plane
    {
        public Plane()
        {
            Sections = new List<Section>();
            Sections.Add(new Section
            {
                Name = "Передний"
            });
            Sections.Add(new Section
            {
                Name = "Центральный"
            });
            Sections.Add(new Section
            {
                Name = "Задний"
            });
        }
        public List<Section> Sections { get; set; }

        public void Load()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            for (int i = 3; i < 6; i++)
            {
                Section section = this.Sections[i - 3];
                Range range = ObjWorkSheet.get_Range("B" + i.ToString());
                section.LimitWeight = Convert.ToDouble(range.Text);
                range = ObjWorkSheet.get_Range("C" + i.ToString(), "C" + i.ToString());
                section.LimitVolume = Convert.ToDouble(range.Text);
            }
            ObjExcel.Quit();
        }

        public void Save()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            for (int i = 3; i < 6; i++)
            {
                Section section = this.Sections[i - 3];
                Range range = ObjWorkSheet.get_Range("B" + i.ToString());
                range.Value = section.LimitWeight;
                Range range2 = ObjWorkSheet.get_Range("C" + i.ToString(), "C" + i.ToString());
                range2.Value = section.LimitVolume;
            }
            ObjWorkBook.Save();
            ObjExcel.Quit();
        }
    }
}
