using DevExpress.DXperience.Demos;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Pharmacy.Desktop.Module.Forms;
using Pharmacy.Domain.Managers.Cashbox;
using Pharmacy.Domain.Managers.Products;
using Pharmacy.Domain.Models.Cashbox;
using Pharmacy.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Desktop.Module.Grids
{
    public partial class ucStatByTime : TutorialControlBase
    {
        public ucStatByTime()
        {
            InitializeComponent();

            Statistic = new DataTable("Table1");
            Statistic.Columns.Add("Argument");
            Statistic.Columns.Add("Value", typeof(Int32));

            FilterByTime = 0;
            FilterByType = 0;
            CreateStatisctic();
            //DataRow row = table.NewRow();
            //row["Argument"] = "Зима";
            //row["Value"] = 5;
            //table.Rows.Add(row);
            //row = table.NewRow();
            //row["Argument"] = "Весна";
            //row["Value"] = 3;
            //table.Rows.Add(row);
            //row = table.NewRow();
            //row["Argument"] = "Лето";
            //row["Value"] = 1;
            //table.Rows.Add(row);
            //row = table.NewRow();
            //row["Argument"] = "Осень";
            //row["Value"] = 4;
            //table.Rows.Add(row);

            Series series = new Series();
            chartControl1.Series.Add(series);
            series.DataSource = Statistic;
            series.ArgumentDataMember = "Argument";
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        DataTable Statistic;
        int FilterByTime;
        int FilterByType;

        public void CreateStatisctic()
        {
            Statistic.Rows.Clear();
            var manager = new SaleManager();
            List<Sale> Sales = manager.All();
            List<int> Data = new List<int>();
            switch (FilterByType)
            {
                case 0: Data = getByCount(); break;
                case 1: Data = getByPrice(); break;
            }
            var a = getByCount();
            switch (FilterByTime){
                case 0:
                    for (int i = 0; i < 4; i++) { Statistic.Rows.Add(Statistic.NewRow()); }
                    Statistic.Rows[0]["Argument"] = "Зима";
                    Statistic.Rows[1]["Argument"] = "Весна";
                    Statistic.Rows[2]["Argument"] = "Лето";
                    Statistic.Rows[3]["Argument"] = "Осень";
                    break;
                case 1:
                    for (int i = 0; i < 12; i++) { Statistic.Rows.Add(Statistic.NewRow()); }
                    Statistic.Rows[0]["Argument"] = "Январь";
                    Statistic.Rows[1]["Argument"] = "Февраль";
                    Statistic.Rows[2]["Argument"] = "Март";
                    Statistic.Rows[3]["Argument"] = "Апрель";
                    Statistic.Rows[4]["Argument"] = "Май";
                    Statistic.Rows[5]["Argument"] = "Июнь";
                    Statistic.Rows[6]["Argument"] = "Июль";
                    Statistic.Rows[7]["Argument"] = "Август";
                    Statistic.Rows[8]["Argument"] = "Сентябрь";
                    Statistic.Rows[9]["Argument"] = "Октябрь";
                    Statistic.Rows[10]["Argument"] = "Ноябрь";
                    Statistic.Rows[11]["Argument"] = "Декабрь";
                    break;
            }
            
            for(int i = 0; i < Statistic.Rows.Count; i++)
            {
                Statistic.Rows[i]["Value"] = Data[i];
            }
        }

        private void rbtnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByType = ((RadioGroup)sender).SelectedIndex;
            CreateStatisctic();
        }

        private void rbtnTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByTime = ((RadioGroup)sender).SelectedIndex;
            CreateStatisctic();
        }
        public List<int> getByCount()
        {
            var manager = new SaleManager();
            List<Sale> Sales = manager.All();
            List<int> Month = new List<int>();
            for (int i = 0; i < 12; i++) { Month.Add(0); }
            var listByMonth = Sales.GroupBy(x => x.Date.Month);
            foreach (var g in listByMonth)
            {
                Month[g.Key] = g.Count();
            }

            switch (FilterByTime)
            {
                case 1: return Month; 
                case 0:
                    List<int> TimeOfYear = new List<int>();
                    TimeOfYear.Add(Month[11] + Month[0] + Month[1]);
                    TimeOfYear.Add(Month[2] + Month[3] + Month[4]);
                    TimeOfYear.Add(Month[5] + Month[6] + Month[7]);
                    TimeOfYear.Add(Month[8] + Month[9] + Month[10]);
                    return TimeOfYear;
                default: return Month;
            }
        }

        public List<int> getByPrice()
        {
            var manager = new SaleManager();
            List<Sale> Sales = manager.All();
            List<int> Month = new List<int>();
            for (int i = 0; i < 12; i++) { Month.Add(0); }
            var listByMonth = Sales.GroupBy(x => x.Date.Month);
            foreach (var g in listByMonth)
            {
                var prices = g.Select(x=>x.Price);
                foreach(int price in prices)
                {
                    Month[g.Key] += price;
                }
            }

            switch (FilterByTime)
            {
                case 1: return Month;
                case 0:
                    List<int> TimeOfYear = new List<int>();
                    TimeOfYear.Add(Month[11] + Month[0] + Month[1]);
                    TimeOfYear.Add(Month[2] + Month[3] + Month[4]);
                    TimeOfYear.Add(Month[5] + Month[6] + Month[7]);
                    TimeOfYear.Add(Month[8] + Month[9] + Month[10]);
                    return TimeOfYear;
                default: return Month;
            }
        }
    }
}
