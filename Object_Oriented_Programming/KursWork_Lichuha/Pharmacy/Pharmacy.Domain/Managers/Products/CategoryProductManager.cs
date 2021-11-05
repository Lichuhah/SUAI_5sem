using Pharmacy.Domain.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace Pharmacy.Domain.Managers.Products
{
    public class CategoryProductManager : BaseManager<CategoryProduct>
    {
        public new List<CategoryProduct> All()
        {
            return repository.All().Where(x => x.IsDeleted != true).ToList();
        }

    }
}
