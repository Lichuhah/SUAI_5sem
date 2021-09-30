﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Lab8.Models;
using Microsoft.Data.SqlClient;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        string stringConnection = "Data Source=DESKTOP-FC16M2F;Initial Catalog=GardeningDB;User ID=sa;Password=1";
        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshButtonClick(object sender, System.EventArgs e)
        {
            dgv.DataSource = null;
            switch (toolStripComboBox1.SelectedItem.ToString())
            {
                case "ADO.NET: Подключение источника данных": LoadData1(); break;
                case "ADO.NET: Чтение результата запроса": LoadData2(); break;
                case "Nhibernate: Маппинг таблицы": LoadData3(); break;
            }
        }

        public SqlConnection GetSql()
        {
            return new SqlConnection(stringConnection);
        }

        public ISessionFactory GetNhibernate()
        {
            var cfg = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(stringConnection)).Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildConfiguration();

            var factory = cfg.BuildSessionFactory();

            return factory;
        }
        public void LoadData1()
        {
            SqlConnection connection = GetSql();
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Building.Size, Building.Price, TypeBuilding.Name FROM Building JOIN TypeBuilding ON Building.ID_TypeBuilding=TypeBuilding.ID", connection);
            SqlDataReader dataReader = command.ExecuteReader();         
            if(dataReader.HasRows) {
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                dgv.DataSource = dt; 
            };
        }

        public void LoadData2()
        {
            SqlConnection connection = GetSql();
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Building JOIN TypeBuilding ON Building.ID_TypeBuilding=TypeBuilding.ID", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if(dataReader.HasRows)
            {
                List<Building> list = new List<Building>();
                while (dataReader.Read())
                {
                    list.Add(new Building()
                    {
                        Price = Convert.ToDouble(dataReader["Price"]),
                        Size = Convert.ToDouble(dataReader["Size"]),
                        Type = new TypeBuilding()
                        {
                            Name = dataReader["Name"].ToString()
                        }
                    });
                }
                dgv.DataSource = list;
                dgv.Columns["ID"].Visible = false;
                dgv.Columns["Type"].Visible = false;
            }      
        }

        public void LoadData3()
        {
            ISession session = GetNhibernate().OpenSession();
            var list = session.Query<Building>().ToList();
            dgv.DataSource = list;
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Type"].Visible = false;
        }
    }
}
