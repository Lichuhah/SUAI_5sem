using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.NHibernate.Mappings.Products
{
    public class TypeProductMapping : BaseNamedEntityMapping<TypeProduct>
    {
        public TypeProductMapping()
        {
            HasMany(x => x.Categories)
                .Table("CategoryProduct")
                .KeyColumn("Type_ID")
                .Inverse()
                .Cascade.DeleteOrphan().Not.LazyLoad();

            HasMany(x => x.Forms)
                .Table("TypeProduct")
                .KeyColumn("Type_ID")
                .Inverse()
                .Cascade.DeleteOrphan().Not.LazyLoad();
        }
    }
}
