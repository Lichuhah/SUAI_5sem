using Pharmacy.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Warehouse
{
    public class WareHouseReport : BaseEntity
    {
        public virtual WareHouse WareHouse { get; set; }
        public virtual Product Product { get; set; }
        [DisplayName("Кол-во")]
        public virtual int Count { get; set; }
        [DisplayName("Вид")]
        public virtual string Type { get; set; }

        [DisplayName("Доп. информация")]
        public virtual string Description { get; set; }
        [DisplayName("Дaта")]
        public virtual DateTime Date { get; set; }

        [DisplayName("Название продукта")]
        public virtual string ProductName { get { return Product != null ? Product.Name : string.Empty; } }
    }
}
