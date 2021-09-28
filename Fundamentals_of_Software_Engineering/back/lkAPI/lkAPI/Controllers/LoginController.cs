using lkAPI.Models;
using lkAPI.Models.Users;
using lkAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lkAPI.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Auth([FromBody] AuthRequest data)
        {
            UserRepository rep = new UserRepository();
            try
            {
                var user = rep.All().Where(x =>
                    x.login == data.login
                        && x.password == data.password).ToList().First();
                
                AuthResponse ap = new AuthResponse()
                {
                    id = user.id,
                    role = (UserRole)user.role
                };
                return JsonConvert.SerializeObject(ap);
            } catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        //[HttpGet]
        //public List<AuthRequest> GetAllUsers()
        //{
        //    SqlConnection sqlConnection = new SqlConnection("workstation id=UniversityLkDB.mssql.somee.com;packet size=4096;user id=Lichuha_SQLLogin_1;pwd=97zrq365t7;data source=UniversityLkDB.mssql.somee.com;persist security info=False;initial catalog=UniversityLkDB ");
        //    sqlConnection.Open();
        //    SqlCommand com = new SqlCommand("SELECT * FROM [User]", sqlConnection);
        //    SqlDataReader sqlDataReader = com.ExecuteReader();
        //    List<AuthRequest> list = new List<AuthRequest>();
        //    while (sqlDataReader.Read())
        //    {
        //        AuthRequest log = new AuthRequest()
        //        {
        //            login = sqlDataReader["Login"].ToString(),
        //            password = sqlDataReader["Password"].ToString()
        //        };
        //        list.Add(log);
        //    }

        //    return list;
        //}

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
