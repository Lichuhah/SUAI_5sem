using Pharmacy.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Warehouse
{
    public class WareHouseItem : BaseEntity
    {
        public virtual Product Product { get; set; }
        public virtual int Count { get; set; }
    }
}
