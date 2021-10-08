using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.NHibernate.Mappings.Products
{
    public class FormProductMapping : BaseNamedEntityMapping<FormProduct>
    {
        public FormProductMapping()
        {
            Map(x => x.Unit).Column("Unit").Nullable();
            References<TypeProduct>(x => x.Type, "Type_ID").Not.LazyLoad();
        }
    }
}
