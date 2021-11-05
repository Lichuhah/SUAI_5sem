using Pharmacy.Domain.Models.Products;

namespace Pharmacy.Domain.Repositories.Products
{
    public class FormProductRepository : BaseRepository<FormProduct>
    {
        public new bool Delete(FormProduct data)
        {
            data.IsDeleted = true;
            return this.Save(data) != null ? true : false;
        }
    }
}
