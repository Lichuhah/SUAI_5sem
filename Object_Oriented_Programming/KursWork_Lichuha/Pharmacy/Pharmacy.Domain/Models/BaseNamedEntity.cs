using System.ComponentModel;

namespace Pharmacy.Domain.Models
{
    public class BaseNamedEntity : BaseEntity
    {
        [DisplayName("Название")]
        public virtual string Name { get; set; }

    }
}
