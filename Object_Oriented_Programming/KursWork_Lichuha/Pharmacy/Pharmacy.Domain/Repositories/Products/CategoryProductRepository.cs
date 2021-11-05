using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.Repositories.Products
{
    public class CategoryProductRepository : BaseRepository<CategoryProduct>
    {
        public new bool Delete(CategoryProduct data)
        {
            data.IsDeleted = true;
            return this.Save(data) != null ? true : false;
        }
    }
}
