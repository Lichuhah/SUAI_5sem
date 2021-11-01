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

            TypeProductManager TypeManager = new TypeProductManager();
            cmbType.Properties.Items.Clear();
            cmbType.Text = null;
            Types = TypeManager.All();
            cmbType.Properties.Items.Add("Без фильтра");
            cmbType.Properties.Items.AddRange(Types.Select(x => x.Name).ToList());

            

            Statistic = new DataTable("Table1");
            Statistic.Columns.Add("Argument");
            Statistic.Columns.Add("Value", typeof(Int32));

            FilterByTime = 0;
            FilterByValue = 0;
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
        int FilterByValue;
        bool isFilterByCategory = false;
        bool isFilterByType = false;
        CategoryProduct FilterByCategory;
        TypeProduct FilterByType;
        List<TypeProduct> Types = new List<TypeProduct>();
        List<CategoryProduct> Categories = new List<CategoryProduct>();

        public void CreateStatisctic()
        {
            Statistic.Rows.Clear();
            List<Sale> Sales = getSales();
            List<int> Data = new List<int>();
            switch (FilterByValue)
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
            FilterByValue = ((RadioGroup)sender).SelectedIndex;
            CreateStatisctic();
        }

        private void rbtnTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByTime = ((RadioGroup)sender).SelectedIndex;
            CreateStatisctic();
        }
        public List<int> getByCount()
        {
            List<Sale> Sales = getSales();
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
            List<Sale> Sales = getSales();
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

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCat.Enabled = true;
            cmbCat.Properties.Items.Clear();
            cmbCat.Text = null;
            if (cmbType.SelectedIndex != 0)
            {
                isFilterByType = true;
                FilterByType = Types[cmbType.SelectedIndex - 1];
                Categories = Types[cmbType.SelectedIndex-1].Categories.ToList();
                cmbCat.Properties.Items.Add("Все");
                cmbCat.Properties.Items.AddRange(Categories.Select(x => x.Name).ToList());
            } else
            {
                isFilterByCategory = false;
                isFilterByType = false;
            }
            CreateStatisctic();
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.SelectedIndex != 0)
            {
                isFilterByCategory = true;
                FilterByCategory = Categories[cmbCat.SelectedIndex - 1];
            }
            else
            {
                isFilterByCategory = false;
            }
            CreateStatisctic();
        }

        public List<Sale> getSales()
        {
            var manager = new SaleManager();
            List<Sale> Sales = manager.All();
            if (isFilterByCategory)
            {
                foreach (var sale in Sales)
                {
                    List<SaleItem> RemoveList = new List<SaleItem>();
                    foreach (var item in sale.Items)
                    {
                        if (item.Product.Category.ID != FilterByCategory.ID)
                        {
                            sale.Price -= item.Price;
                            RemoveList.Add(item);
                        }
                    }
                    foreach(var item in RemoveList)
                    {
                        sale.Items.Remove(item);
                    }
                }
            } else {
                if (isFilterByType)
                {
                    foreach (var sale in Sales)
                    {
                        List<SaleItem> RemoveList = new List<SaleItem>();
                        foreach (var item in sale.Items)
                        {
                            if (item.Product.Category.Type.ID != FilterByType.ID)
                            {
                                sale.Price -= item.Price;
                                RemoveList.Add(item);
                            }
                        }
                        foreach (var item in RemoveList)
                        {
                            sale.Items.Remove(item);
                        }
                    }
                }
            }
            return Sales;
        }
    }
}
