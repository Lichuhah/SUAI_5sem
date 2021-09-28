using lkAPI.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;


namespace lkAPI.Repositories
{
    public class BaseRepository<T> where T : EntityBase
    {
        public List<T> All()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                 var items = session.Query<T>().ToList();
                 return items;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }

        }

        public T Get(int id)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                var item = session.Get<T>(id);
                return item;
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
