using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork
{
    public class TimesManager
    {
        public TimesManager()
        {
            Times = new List<Time>();
        }

        public List<Time> Times { get; set; }

        public void Load()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            char c = 'C';
            for (int i = 0; i < 3; i++)
            {
                Time time = new Time();
                Range range = ObjWorkSheet.get_Range(c + "23");
                time.Period = range.Text;
                range = ObjWorkSheet.get_Range(c + "24");
                time.Points = Convert.ToInt32(range.Value);
                Times.Add(time);
                c++;
            }
            ObjExcel.Quit();
        }

        public void Save()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork\KursWork2.xlsx", 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[2];
            char c = 'C';
            for (int i = 0; i < 3; i++)
            {
                Time time = this.Times[i];
                Range range = ObjWorkSheet.get_Range(c + "23");
                range.Value = time.Period;
                Range range2 = ObjWorkSheet.get_Range(c+"24");
                range2.Value = time.Points;
                c++;
            }
            ObjWorkBook.Save();
            ObjExcel.Quit();
        }
    }
}
