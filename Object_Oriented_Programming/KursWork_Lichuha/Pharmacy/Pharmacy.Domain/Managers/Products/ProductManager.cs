using Pharmacy.Domain.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace Pharmacy.Domain.Managers.Products
{
    public class ProductManager : BaseManager<Product>
    {
        public new List<Product> All()
        {
            return repository.All().Where(x=>x.IsDeleted!=true).ToList();
        }

    }
}
