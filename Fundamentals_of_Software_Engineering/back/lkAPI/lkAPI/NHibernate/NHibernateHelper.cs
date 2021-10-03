using NHibernate;
using System.Reflection;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using lkAPI.Models;

namespace lkAPI
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
            var cfg = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString("workstation id=UniversityLkDB.mssql.somee.com;packet size=4096;user id=Lichuha_SQLLogin_1;pwd=97zrq365t7;data source=UniversityLkDB.mssql.somee.com;persist security info=False;initial catalog=UniversityLkDB")).Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildConfiguration();

            var factory = cfg.BuildSessionFactory();

            return factory;
        }

        private static HbmMapping GetMappings()
        {
            var mapper = new ModelMapper();

            mapper.AddMappings(Assembly.GetAssembly(typeof(EntityBase)).GetExportedTypes());
            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            return mapping;
        }
    }

}