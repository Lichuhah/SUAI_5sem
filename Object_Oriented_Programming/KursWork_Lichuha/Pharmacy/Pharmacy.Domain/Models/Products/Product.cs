namespace Pharmacy.Domain.Models.Products
{
    public class Product : BaseNamedEntity
    {
        public virtual CategoryProduct Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual FormProduct Form { get; set; }
        public virtual bool IsNeedRecipe { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual float Price { get; set; }
        public virtual int Count { get; set; }
    }
}
