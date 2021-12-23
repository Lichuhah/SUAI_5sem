using System.ComponentModel;

namespace Pharmacy.Domain.Models.Products
{
    public class Product : BaseNamedEntity
    {
        [DisplayName("Тип")]
        public virtual string TypeName { get { return Category != null &&Category.Type != null ? Category.Type.Name : null; } }

        [DisplayName("Название категории")]
        public virtual string CategoryName { get { return Category != null ? Category.Name : null; } }

        [DisplayName("Бренд")]
        public virtual string BrandName { get { return Brand != null ? Brand.Name : null; } }

        [DisplayName("Форма выпуска")]
        public virtual string FormName { get { return Form != null ? Form.Name : null; } }

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
