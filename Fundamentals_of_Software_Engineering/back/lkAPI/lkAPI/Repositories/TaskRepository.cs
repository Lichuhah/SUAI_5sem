using lkAPI.Models.Tasks;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lkAPI.Repositories
{
    public class TaskRepository : BaseRepository<Task>
    {
        public List<CompleteTask> AllForStudent(int id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                var items = session.Query<CompleteTask>().ToList();
                return items;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }

        }
    }
}
