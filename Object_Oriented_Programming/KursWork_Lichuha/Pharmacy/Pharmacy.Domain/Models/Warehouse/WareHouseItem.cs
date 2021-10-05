using Pharmacy.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Warehouse
{
    public class WareHouseItem : BaseEntity
    {
        public virtual WareHouse WareHouse { get; set; }
        public virtual Product Product { get; set; }
        [DisplayName("Название продукта")]
        public virtual string ProductName
        {
            get { return Product != null ? Product.Name : null; }
        }

        [DisplayName("Название категории")]
        public virtual string CategoryName { get { return Product !=null && Product.Category != null ? Product.Category.Name : null; } }

        [DisplayName("Бренд")]
        public virtual string BrandName { get { return Product != null && Product.Brand != null ? Product.Brand.Name : null; } }

        [DisplayName("Форма выпуска")]
        public virtual string FormName { get { return Product != null && Product.Form != null ? Product.Form.Name : null; } }
        [DisplayName("Кол-во на складе")]
        public virtual int Count { get; set; }
    }
}
