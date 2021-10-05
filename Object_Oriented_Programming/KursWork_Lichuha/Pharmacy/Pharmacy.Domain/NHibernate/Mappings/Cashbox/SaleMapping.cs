using Pharmacy.Domain.Models;
using Pharmacy.Domain.Models.Cashbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings.Cashbox
{
    public class SaleMapping : BaseEntityMapping<Sale>
    {
        public SaleMapping()
        {
            Table("Sale");
            Map(x => x.Price);
            Map(x => x.Date).Column("Date").CustomType<DateTime>();
            References<PharmacyModel>(x => x.Pharmacy, "Pharmacy_Id");
            HasMany(x => x.Items)
                .Table("SaleItem")
                .KeyColumn("Sale_ID").Inverse().Not.LazyLoad()
                .Cascade.AllDeleteOrphan();
        }
    }
}
