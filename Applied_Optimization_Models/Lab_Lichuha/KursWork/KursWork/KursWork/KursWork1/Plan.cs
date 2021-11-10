using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace KursWork
{
    public class Plan
    {
        public Plane Plane;
        public Order Order;
        public List<List<PlanItem>> Items = new List<List<PlanItem>>();
        public Plan(Order order, Plane plane)
        {
            this.Plane = plane;
            this.Order = order;
            for(int i=0; i<Order.Cargos.Count; i++)
            {
                Items.Add(new List<PlanItem>());
                for(int j=0; j<Plane.Sections.Count; j++)
                {
                    Items[i].Add(new PlanItem());
                }
            }
        }

        public void Load()
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            for (int i = 19; i < 22; i++)
            {
                PlanItem item = this.Items[i - 19][0];
                Range range = ObjWorkSheet.get_Range("B" + i.ToString());
                item.Count = Convert.ToDouble(range.Text);
                PlanItem item1 = this.Items[i - 19][1];
                Range range1 = ObjWorkSheet.get_Range("C" + i.ToString());
                item1.Count = Convert.ToDouble(range.Text);
                PlanItem item2 = this.Items[i - 19][2];
                Range range2 = ObjWorkSheet.get_Range("D" + i.ToString());
                item2.Count = Convert.ToDouble(range.Text);
            }
            ObjExcel.Quit();
        }
    }
}
