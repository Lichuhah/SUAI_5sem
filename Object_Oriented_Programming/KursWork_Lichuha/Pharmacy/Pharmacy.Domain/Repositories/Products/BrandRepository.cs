using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.Repositories.Products
{
    public class BrandRepository : BaseRepository<Brand>
    {
        public new bool Delete(Brand data)
        {
            data.IsDeleted = true;
            return this.Save(data) != null ? true : false;
        }
    }
}
