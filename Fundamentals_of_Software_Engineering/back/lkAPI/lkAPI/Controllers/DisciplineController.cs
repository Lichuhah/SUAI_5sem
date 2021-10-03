using lkAPI.Models;
using lkAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace lkAPI.Controllers
{
    public class DisciplineController : BaseController
    {
        DisciplineRepository rep = new DisciplineRepository();
        // GET: DisciplineController  
        public string All()
        {
            try
            {
                return JsonConvert.SerializeObject(rep.All());
            } catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        public string AllForStudent([FromBody]int id)
        {
            try
            {
                StudentRepository studrep = new StudentRepository();
                var query = studrep.Get(id).group.disciplines.Select(x => new Discipline
                {
                    id=x.discipline.id,
                    exam=x.discipline.exam,
                    hours=x.discipline.hours,
                    name = x.discipline.name
                }).ToList();
                return JsonConvert.SerializeObject(query);
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

    }
}
