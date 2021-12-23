using System.ComponentModel;

namespace Pharmacy.Domain.Models.Products
{
    public class FormProduct : BaseNamedEntity
    {
        public virtual TypeProduct Type { get; set; }

        [DisplayName("Тип продукта")]
        public virtual string TypeName { get { return Type != null ? Type.Name : null ; } }

        [DisplayName("Единица измеоения")]
        public virtual string Unit { get; set; }

        [Browsable(false)]
        public virtual bool IsDeleted { get; set; }
    }
}
