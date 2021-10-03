using FluentNHibernate.Mapping;
using lkAPI.Models;


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
