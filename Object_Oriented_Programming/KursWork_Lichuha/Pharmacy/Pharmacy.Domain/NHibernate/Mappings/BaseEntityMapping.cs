using FluentNHibernate.Mapping;
using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.NHibernate.Mappings
{
    public class BaseEntityMapping<T> : ClassMap<T> where T : BaseEntity
    {
        public BaseEntityMapping()
        {
            Id(x => x.ID).Column("ID");
        }
    }
}
