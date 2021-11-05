using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.Repositories.Products
{
    public class TypeProductRepository : BaseRepository<TypeProduct>
    {
        public new bool Delete(TypeProduct data)
        {
            data.IsDeleted = true;
            return this.Save(data) != null ? true : false;
        }
    }
}
