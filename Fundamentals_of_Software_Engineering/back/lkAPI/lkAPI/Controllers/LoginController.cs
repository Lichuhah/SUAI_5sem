using lkAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace lkAPI.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<LoginData> GetAllUsers()
        {
            SqlConnection sqlConnection = new SqlConnection("workstation id=UniversityLkDB.mssql.somee.com;packet size=4096;user id=Lichuha_SQLLogin_1;pwd=97zrq365t7;data source=UniversityLkDB.mssql.somee.com;persist security info=False;initial catalog=UniversityLkDB ");
            sqlConnection.Open();
            SqlCommand com = new SqlCommand("SELECT * FROM [User]", sqlConnection);
            SqlDataReader sqlDataReader = com.ExecuteReader();
            List<LoginData> list = new List<LoginData>();
            while (sqlDataReader.Read())
            {
                LoginData log = new LoginData()
                {
                    login = sqlDataReader["Login"].ToString(),
                    password = sqlDataReader["Password"].ToString()
                };
                list.Add(log);
            }

            return list;
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
