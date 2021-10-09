using Pharmacy.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Cashbox
{
    public class SaleItem : BaseEntity
    {
        public virtual Product Product { get; set; }
        public virtual string ProductName { get { return Product != null ? Product.Name : string.Empty; } }
        public virtual Sale Sale { get; set; }
        public virtual int Count { get; set; }
        public virtual double Price { get; set; }

    }
}
