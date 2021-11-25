using System.ComponentModel;

namespace Pharmacy.Domain.Models.Products
{
    public class Brand : BaseNamedEntity
    {
        [Browsable(false)]
        public virtual bool IsDeleted { get; set; }
    }
}
