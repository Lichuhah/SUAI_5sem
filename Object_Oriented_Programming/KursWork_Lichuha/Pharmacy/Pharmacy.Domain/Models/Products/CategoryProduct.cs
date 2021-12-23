using System.Collections.Generic;
using System.ComponentModel;

namespace Pharmacy.Domain.Models.Products
{
    public class CategoryProduct : BaseNamedEntity
    {
        public virtual TypeProduct Type { get; set; }

        [DisplayName("Тип продукта")]
        public virtual string TypeName { get { return Type != null ? Type.Name : null; } }
        [Browsable(false)]
        public virtual bool IsDeleted { get; set; }
    }
}
