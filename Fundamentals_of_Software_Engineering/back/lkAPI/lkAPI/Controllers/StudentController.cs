using lkAPI.Models.Users;
using lkAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace lkAPI.Controllers
{
    public class StudentController : BaseController
    {

        // GET: StudentController/Get/{id}
        public string Get([FromBody] int id)
        {
            StudentRepository rep = new StudentRepository();
            var student = rep.Get(id);
            if (student != null)
            {
                student.fullname = new Fullname()
                {
                    name = student.fullname.name,
                    second_name = student.fullname.second_name,
                    other_name = student.fullname.other_name
                };
                return JsonConvert.SerializeObject(student);
            }
            else return JsonConvert.SerializeObject(null);
            
        }

    }
}
