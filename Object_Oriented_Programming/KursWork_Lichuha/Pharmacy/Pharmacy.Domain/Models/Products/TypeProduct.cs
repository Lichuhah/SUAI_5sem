using System.Collections.Generic;
using System.ComponentModel;

namespace Pharmacy.Domain.Models.Products
{
    public class TypeProduct : BaseNamedEntity
    {
        public virtual IList<CategoryProduct> Categories { get; set; }

        public virtual IList<FormProduct> Forms { get; set; }

        [Browsable(false)]
        public virtual bool IsDeleted { get; set; }
    }
}
