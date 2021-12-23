using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.NHibernate.Mappings.Products
{
    public class ProductMapping : BaseNamedEntityMapping<Product>
    {
        public ProductMapping()
        {
            Table("[Product]");
            Map(x => x.IsDeleted).Column("Deleted");
            Map(x => x.IsNeedRecipe).Column("NeedRecipe");
            Map(x => x.Price).Column("Price");
            Map(x => x.Count).Column("Count");
            References<CategoryProduct>(x=>x.Category, "Category_ID").Not.LazyLoad();
            References<Brand>(x => x.Brand, "Brand_ID").Not.LazyLoad();
            References<FormProduct>(x => x.Form, "Form_ID").Not.LazyLoad();
        }
    }
}
