using Pharmacy.Domain.Models.Cashbox;
using Pharmacy.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.NHibernate.Mappings.Cashbox
{
    public class SaleItemMapping : BaseEntityMapping<SaleItem>
    {
        public SaleItemMapping()
        {
            Table("SaleItem");
            Map(x => x.Price);
            Map(x => x.Count);
            References<Product>(x => x.Product, "Product_ID").Not.LazyLoad();
            //HasOne<Sale>(x => x.Sale).ForeignKey("Sale_ID").Cascade.All().Not.LazyLoad();
            References(x => x.Sale).Not.LazyLoad();
        }
    }
}
