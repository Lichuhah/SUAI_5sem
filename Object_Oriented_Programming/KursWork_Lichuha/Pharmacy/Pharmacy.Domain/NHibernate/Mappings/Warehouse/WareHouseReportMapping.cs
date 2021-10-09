using Pharmacy.Domain.Models.Products;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings.Warehouse
{
    public class WareHouseReportMapping : BaseEntityMapping<WareHouseReport>
    {
        public WareHouseReportMapping()
        {
            Table("WarehouseChanges");
            Map(x => x.Count).Column("Count");
            Map(x => x.Type).Column("Type");
            Map(x => x.Description).Column("Description");
            Map(x => x.Date).Column("Date").CustomType<DateTime>();
            References<Product>(x => x.Product, "Product_ID").Not.LazyLoad();
            References<WareHouse>(x => x.WareHouse, "WareHouse_ID").Not.LazyLoad();
        }
    }
}
