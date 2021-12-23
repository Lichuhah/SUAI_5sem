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
                return JsonConvert.SerializeObject(query);
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
                return JsonConvert.SerializeObject(task);
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        [HttpPost]
        public string AddNewTry(int id, [FromBody] PassTask data)
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
                return JsonConvert.SerializeObject(task.passList.Last());
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(null);
            }
        }

        [HttpDelete]
        public bool DeleteTry(int id, [FromBody] int tryId)
        {
            try
            {
                CompleteTaskRepository rep = new CompleteTaskRepository();
                var task = rep.Get(id);
                if (task != null)
                {
                    if (task.passList.Where(x => x.id == tryId).Count() > 0) task.passList.Remove(task.passList.Where(x => x.id == tryId).First());
                }
                else throw new Exception();
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
