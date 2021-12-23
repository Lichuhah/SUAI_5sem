using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Warehouse
{
    public class WareHouse : BaseEntity
    {
        public virtual PharmacyModel Pharmacy { get; set; }

        public virtual IList<WareHouseItem> Items { get; set; }

        public virtual IList<WareHouseReport> Changes { get; set; }
    }
}
