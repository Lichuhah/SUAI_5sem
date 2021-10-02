namespace Pharmacy.Domain.Models
{
    public class BaseNamedEntity : BaseEntity
    {
        public virtual string Name { get; set; }
    }
}
