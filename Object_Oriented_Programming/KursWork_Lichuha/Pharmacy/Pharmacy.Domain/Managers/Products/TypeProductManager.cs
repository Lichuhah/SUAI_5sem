using Pharmacy.Domain.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace Pharmacy.Domain.Managers.Products
{
    public class TypeProductManager : BaseManager<TypeProduct>
    {
        public new List<TypeProduct> All()
        {
            return repository.All().Where(x => x.IsDeleted != true).ToList();
        }

    }
}
