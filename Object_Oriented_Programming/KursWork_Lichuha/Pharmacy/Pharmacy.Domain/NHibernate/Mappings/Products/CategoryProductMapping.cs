using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.NHibernate.Mappings.Products
{
    public class CategoryProductMapping : BaseNamedEntityMapping<CategoryProduct>
    {
        public CategoryProductMapping()
        {
            References<TypeProduct>(x => x.Type, "Type_ID").Not.LazyLoad();
        }
    }
}
