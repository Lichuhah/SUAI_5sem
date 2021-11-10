using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace KursWorkApp
{
    public partial class Form1 : Form
    {
        Plane Plane;
        Order Order;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Plane = new Plane();
            Plane.Sections.Add(new Section
            {
                Name = "Передний"
            });
            Plane.Sections.Add(new Section
            {
                Name = "Центральный"
            });
            Plane.Sections.Add(new Section
            {
                Name = "Задний"
            });

            //Order = new Order();
            //Order.Cargos.Add(new Cargo
            //{
            //    Name = "1"
            //});
            //Order.Cargos.Add(new Cargo
            //{
            //    Name = "2"
            //});
            //Order.Cargos.Add(new Cargo
            //{
            //    Name = "3"
            //});
            //Order.Cargos.Add(new Cargo
            //{
            //    Name = "4"
            //});
        }

        private void btnLoadFromExcel_Click(object sender, EventArgs e)
        {
            Excel.Application ObjExcel 
                = new Excel.Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            for (int i = 3; i < 5; i++)
            {
                //Выбираем область таблицы. (в нашем случае просто ячейку)
                Excel.Range range = ObjWorkSheet.get_Range("B" + i.ToString(), "B" + i.ToString());
                //Добавляем полученный из ячейки текст.
                Plane.Sections[i-3].LimitWeight = Convert.ToDouble(range.Text);
            }
            dgvPlane.DataSource = Plane.Sections;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
