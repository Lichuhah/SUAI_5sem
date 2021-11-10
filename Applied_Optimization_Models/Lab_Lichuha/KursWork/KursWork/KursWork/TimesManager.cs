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
        public TimesManager(Workbook ObjWorkBook)
        {
            Times = new List<Time>();
            this.ObjWorkBook = ObjWorkBook;
        }

        Workbook ObjWorkBook;
        public List<Time> Times { get; set; }

        public void Load()
        {
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
        }

        public void Save()
        {
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
        }
    }
}
