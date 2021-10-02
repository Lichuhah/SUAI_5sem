namespace Pharmacy.Domain.Models.Products
{
    public class FormProduct : BaseNamedEntity
    {
        public virtual TypeProduct Type { get; set; }

        public virtual string Unit { get; set; }
    }
}
