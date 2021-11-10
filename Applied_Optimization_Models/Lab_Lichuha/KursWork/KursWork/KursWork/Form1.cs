using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace KursWork
{
    public partial class Form1 : Form
    {
        Plane Plane = new Plane();
        Order Order = new Order();
        Plan Plan;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<Plane.Sections.Count; i++)
            {
                for(int j=0; j<Order.Cargos.Count; j++)
                {
                    
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Plane.Load();
            dgvPlane.DataSource = Plane.Sections;
            Order.Load();
            dgvOrder.DataSource = Order.Cargos;

            Plan = new Plan(Order, Plane);
            Plan.Load();
            dgvPlan.DataSource = Plan.Items;

        }

        private void dgvPlane_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for(int i = 0; i<3; i++)
            {
                Plane.Sections[i].LimitWeight = Convert.ToDouble(dgvPlane.Rows[i].Cells[1].Value);
                Plane.Sections[i].LimitVolume = Convert.ToDouble(dgvPlane.Rows[i].Cells[2].Value);
            }
            Plane.Save();
            

        }

        private void dgvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Order.Cargos[i].Weight = Convert.ToDouble(dgvOrder.Rows[i].Cells[1].Value);
                Order.Cargos[i].VolumePerTon = Convert.ToDouble(dgvOrder.Rows[i].Cells[2].Value);
                Order.Cargos[i].Price = Convert.ToDouble(dgvOrder.Rows[i].Cells[3].Value);
            }
            Order.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application ObjExcel = new Application();
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"D:\Study\SUAI_5sem\Applied_Optimization_Models\Lab_Lichuha\KursWork.xlsx", 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            
                
        }
    }
}
