using Pharmacy.Domain.Models.Cashbox;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models
{
    public class PharmacyModel : BaseEntity
    {
        public virtual string Address { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public virtual IList<Sale> Sales { get; set; }
    }
}
