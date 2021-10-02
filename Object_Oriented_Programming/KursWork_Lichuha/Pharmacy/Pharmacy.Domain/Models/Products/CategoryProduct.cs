using System.Collections.Generic;

namespace Pharmacy.Domain.Models.Products
{
    public class CategoryProduct : BaseNamedEntity
    {
        public virtual TypeProduct Type { get; set; }

    }
}
