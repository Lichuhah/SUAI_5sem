using NHibernate;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.NHibernate;
using Pharmacy.Domain.NHibernate.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private PharmacySession session;
        public BaseRepository()
        {
            session = PharmacySession.GetInstance();
            session.Clear();
        }

        ~BaseRepository()
        {
            NHibernateHelper.CloseSession();
        }
        public List<T> All()
        {
            return session.GetList<T>();
        }

        public T Get(int id)
        {
            return session.Get<T>(id);
        }

        public T Save(T entity)
        {
            
            ITransaction tr = session.BeginTransaction();
            entity.ID = ((T)session.Merge(entity)).ID;
           // entity.ID = (int)session.Save(entity);
            tr.Commit();
            return entity;
        }

        public T Add(T entity)
        {

            ITransaction tr = session.BeginTransaction();
            entity.ID = (int)session.Save(entity);
            // entity.ID = (int)session.Save(entity);
            tr.Commit();
            session.Flush();
            return entity;
        }
        public bool Delete(T entity)
        {
            ITransaction tr = session.BeginTransaction();
            session.Delete(entity);
            // entity.ID = (int)session.Save(entity);
            tr.Commit();
            return true;
        }
    }

}
