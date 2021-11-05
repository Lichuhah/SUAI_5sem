using Pharmacy.Domain.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace Pharmacy.Domain.Managers.Products
{
    public class FormProductManager : BaseManager<FormProduct>
    {
        public new List<FormProduct> All()
        {
            return repository.All().Where(x => x.IsDeleted != true).ToList();
        }

    }
}
