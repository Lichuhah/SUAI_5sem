using FluentNHibernate.Mapping;
using lkAPI.Models;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace lkAPI.NHibernate.Mappings
{
    public class EntityBaseMapping<T> : ClassMap<T> where T : EntityBase
    {
        public EntityBaseMapping()
        {
            Id(x => x.id);
        }
    }
}
