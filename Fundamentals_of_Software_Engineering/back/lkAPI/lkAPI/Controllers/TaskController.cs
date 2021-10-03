using lkAPI.Models;
using lkAPI.Models.Tasks;
using lkAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace lkAPI.Controllers
{
    public class TaskController : BaseController
    {
        public string AllForStudent([FromBody] int id)
        {
            try
            {
                StudentRepository studrep = new StudentRepository();
                var taskslist = studrep.Get(id).tasks;
                var query = studrep.Get(id).tasks.Select(x => new CompleteTask
                {
                    id = x.id,
                    mark = x.mark,
                    passList = null,
                    task = new Task()
                    {
                        number = x.task.number,
                        maxMark = x.task.maxMark,
                        description = x.task.description,
                        deadline = x.task.deadline,
                        discipline = x.task.discipline
                    }
                }).ToList();
                var a = JsonConvert.SerializeObject(query);
                return a;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        public string GetForStudent(int id, [FromBody] int userId)
        {
            try
            {
                CompleteTaskRepository rep = new CompleteTaskRepository();
                var task = rep.Get(id);
                task.task = new Task()
                {
                    number = task.task.number,
                    maxMark = task.task.maxMark,
                    description = task.task.description,
                    deadline = task.task.deadline,
                    discipline = task.task.discipline
                };
                var a = JsonConvert.SerializeObject(task);
                return a;
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        [HttpPost]
        public bool AddNewTry(int id, [FromBody] PassTask data)
        {
            try
            {
                CompleteTaskRepository rep = new CompleteTaskRepository();
                var task = rep.Get(id);
                if (task != null)
                {
                    data.id = 0;
                    data.date = new DateTime();
                    data.task = task;
                    task.passList.Add(data);
                } else throw new Exception();
                rep.Save(task);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
