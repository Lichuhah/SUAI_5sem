using lkAPI.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;


namespace lkAPI.Repositories
{
    public class BaseRepository<T> where T : EntityBase
    {
        private ISession session;
        public BaseRepository()
        {
            session = NHibernateHelper.OpenSession();
        }

        ~BaseRepository()
        {
            NHibernateHelper.CloseSession();
        }
        public List<T> All()
        {
            return new List<T>(session.CreateCriteria(typeof(T)).List<T>());
        }

        public T Get(int id)
        {  
            return session.Get<T>(id);
        }

        public T Save(T entity)
        {
            ITransaction tr = session.BeginTransaction();
            entity.id = (int)session.Save(entity);       
            tr.Commit();
            return entity;
        }

        public bool Delete(T data)
        {
            session.Delete(data);
            return true;
        }
    }
}
