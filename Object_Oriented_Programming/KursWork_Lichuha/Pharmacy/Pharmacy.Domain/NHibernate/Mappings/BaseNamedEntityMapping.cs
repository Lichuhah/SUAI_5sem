using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.NHibernate.Mappings
{
    public class BaseNamedEntityMapping<T> : BaseEntityMapping<T> where T: BaseNamedEntity
    {
        public BaseNamedEntityMapping()
        {
            Map(x => x.Name).Column("Name");
        }
    }
}
