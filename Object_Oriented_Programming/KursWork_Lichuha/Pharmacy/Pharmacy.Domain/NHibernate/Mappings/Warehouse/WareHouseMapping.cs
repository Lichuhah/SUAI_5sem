using Pharmacy.Domain.Models;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings.Warehouse
{
    public class WareHouseMapping : BaseEntityMapping<WareHouse>
    {
        public WareHouseMapping()
        {
            References<PharmacyModel>(x => x.Pharmacy, "Pharmacy_ID");

            HasMany(x => x.Items)
                .Table("WarehouseChanges")
                .KeyColumn("Warehouse_ID")
                .Inverse()
                .Cascade.DeleteOrphan().Not.LazyLoad();

            HasMany(x => x.Changes)
                .Table("WarehouseItem")
                .KeyColumn("Warehouse_ID")
                .Inverse()
                .Cascade.DeleteOrphan().Not.LazyLoad();
        }
    }
}
