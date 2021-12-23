using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace Pharmacy.Domain.NHibernate
{
    public class NHibernateHelper
    {
        private static readonly ISessionFactory _sessionFactory;
        static NHibernateHelper()
        {
            _sessionFactory = Configure();
        }
        public static ISession GetCurrentSession()
        {
            return _sessionFactory.OpenSession();
        }
        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
        public static void CloseSession()
        {
            _sessionFactory.Close();
        }
        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }

        public static ISessionFactory Configure()
        {
            var cfg = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=DESKTOP-FC16M2F;Initial Catalog=PharmacyDB;User ID=sa;Password=1")).Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildConfiguration();

            var factory = cfg.BuildSessionFactory();

            return factory;
        }
    }
}
