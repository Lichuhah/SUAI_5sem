using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWork
{
    public class Order
    {
        public Order()
        {
            Cargos = new List<Cargo>();
            Cargos.Add(new Cargo
            {
                Name = "1"
            });
            Cargos.Add(new Cargo
            {
                Name = "2"
            });
            Cargos.Add(new Cargo
            {
                Name = "3"
            });
            Cargos.Add(new Cargo
            {
                Name = "4"
            });
        }
        public List<Cargo> Cargos { get; set; }

        public void Load()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            for (int i = 10; i < 14; i++)
            {
                Cargo cargo = this.Cargos[i - 10];
                Range range = ObjWorkSheet.get_Range("B" + i.ToString());
                cargo.Weight = Convert.ToDouble(range.Text);
                range = ObjWorkSheet.get_Range("C" + i.ToString());
                cargo.VolumePerTon = Convert.ToDouble(range.Text);
                range = ObjWorkSheet.get_Range("D" + i.ToString());
                cargo.Price = Convert.ToDouble(range.Text);
            }
            ObjExcel.Quit();
        }

        public void Save()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            for (int i = 10; i < 14; i++)
            {
                Cargo cargo = this.Cargos[i - 10];
                Range range = ObjWorkSheet.get_Range("B" + i.ToString());
                range.Value = cargo.Weight;
                Range range2 = ObjWorkSheet.get_Range("C" + i.ToString());
                range2.Value = cargo.VolumePerTon;
                Range range3 = ObjWorkSheet.get_Range("D" + i.ToString());
                range3.Value = cargo.Price;
            }
            ObjWorkBook.Save();
            ObjExcel.Quit();
        }
    }
}
