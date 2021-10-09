using Pharmacy.Domain.Models.Products;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings.Warehouse
{
    public class WareHouseItemMapping : BaseEntityMapping<WareHouseItem>
    {
        public WareHouseItemMapping()
        {
            Table("WareHouseItem");
            References<Product>(x => x.Product, "Product_ID").Not.LazyLoad();
            References<WareHouse>(x => x.WareHouse, "Warehouse_ID").Not.LazyLoad();
            Map(x => x.Count).Column("Count");
        }
    }
}
