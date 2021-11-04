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
        public new bool Delete(Product data)
        {
            data.IsDeleted = true;
            return repository.Save(data)!=null ? true : false;
        }
    }
}
