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

namespace KursWork
{
    public partial class SelectForm : Form
    {
        public SelectForm(Workbook ObjWorkBook)
        {
            InitializeComponent();
            this.ObjWorkBook = ObjWorkBook;
        }
        Workbook ObjWorkBook;
        public string Result = string.Empty;
        private void SelectForm_Load(object sender, EventArgs e)
        {
            TimesManager TimesManager = new TimesManager(ObjWorkBook);
            TimesManager.Load();
            foreach(var item in TimesManager.Times) { comboBox1.Items.Add(item.Period); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result = comboBox1.Text;
        }
    }
}
