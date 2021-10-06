using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings
{
    public class PharmacySession
    {
        private PharmacySession() { session = NHibernateHelper.OpenSession(); }

        private static PharmacySession _instance;
        private static ISession session;

        public static PharmacySession GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PharmacySession();
            }
            return _instance;
        }

        public ICriteria CreateCriteria(Type type)
        {
            return session.CreateCriteria(type);
        }

        public T Get<T>(int id)
        {
            return session.Get<T>(id);
        }

        public ITransaction BeginTransaction()
        {
            return session.BeginTransaction();
        }

        public object Merge(object entity)
        {
            return session.Merge(entity);
        }

        public object Save(object entity)
        {
            return session.Save(entity);
        }

        public void Flush()
        {
            session.Flush();
        }

        public void Delete(object entity)
        {
            session.Delete(entity);
        }
    }
}
