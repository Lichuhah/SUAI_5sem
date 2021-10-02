using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace Pharmacy.Domain.NHibernate
{
    public class NHibernateHelper
    {
        private NHibernateHelper() {
            _sessionFactory = Configure();
        }

        private static NHibernateHelper _helper;
        private readonly ISessionFactory _sessionFactory;

        public static NHibernateHelper GetInstance()
        {
            return _helper != null ? _helper : new NHibernateHelper();
        }

        public static ISessionFactory Configure()
        {
            var cfg = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=DESKTOP-FC16M2F;Initial Catalog=PharmacyDB;User ID=sa;Password=1")).Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildConfiguration();

            return cfg.BuildSessionFactory();
        }

        public ISession GetCurrentSession()
        {
            return _sessionFactory.OpenSession();
        }
        public void CloseSession()
        {
            _sessionFactory.Close();
        }
        public void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
