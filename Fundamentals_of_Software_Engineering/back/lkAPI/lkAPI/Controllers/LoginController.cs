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
    public class LoginController : BaseController
    {

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

    }
}
