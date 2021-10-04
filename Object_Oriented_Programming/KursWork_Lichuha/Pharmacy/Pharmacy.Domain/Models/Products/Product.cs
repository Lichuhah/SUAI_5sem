using System.ComponentModel;

namespace Pharmacy.Domain.Models.Products
{
    public class Product : BaseNamedEntity
    {
        [DisplayName("Название категории")]
        public virtual string CategoryName { get { return Category.Name; } }

        [DisplayName("Бренд")]
        public virtual string BrandName { get { return Brand.Name; } }

        [DisplayName("Форма выпуска")]
        public virtual string FormName { get { return Form.Name; } }

        [DisplayName("По рецепту")]
        public virtual bool IsNeedRecipe { get; set; }

        [DisplayName("Цена")]
        public virtual float Price { get; set; }

        [DisplayName("Кол-во в упаковке")]
        public virtual int Count { get; set; }

        public virtual CategoryProduct Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual FormProduct Form { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
