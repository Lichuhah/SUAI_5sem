using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Cashbox
{
    public class Sale : BaseEntity
    {
        public virtual PharmacyModel Pharmacy { get; set; }
        public virtual double Price { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual IList<SaleItem> Items { get; set; }
    }
}
