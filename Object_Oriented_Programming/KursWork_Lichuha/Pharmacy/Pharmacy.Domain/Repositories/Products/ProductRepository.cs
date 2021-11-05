using Pharmacy.Domain.Models.Products;
using Pharmacy.Domain.NHibernate.Mappings;

namespace Pharmacy.Domain.Repositories.Products
{
    public class ProductRepository : BaseRepository<Product>
    {
        public new bool Delete(Product data)
        {
            data.IsDeleted = true;
            return this.Save(data) != null ? true : false;
        }
    }
}
