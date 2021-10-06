using System.Collections.Generic;

namespace Pharmacy.Domain.Models.Products
{
    public class TypeProduct : BaseNamedEntity
    {
        public virtual IList<CategoryProduct> Categories { get; set; }

        public virtual IList<FormProduct> Forms { get; set; }
    }
}
