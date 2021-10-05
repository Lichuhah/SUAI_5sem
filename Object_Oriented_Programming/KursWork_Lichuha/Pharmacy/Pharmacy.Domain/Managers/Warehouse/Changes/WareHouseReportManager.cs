using Pharmacy.Domain.Managers.Products;
using Pharmacy.Domain.Models.Products;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Managers.Warehouse.Changes
{
    public class WareHouseReportManager : BaseManager<WareHouseReport>
    {
        public int GetCountByProduct(Product product)
        {
            var result = this.All().Where(x => x.Product.ID == product.ID);
            return result.Count() > 0 ? result.First().Count : 0;
        }

        public bool SetCountByReport(WareHouseReport report)
        {
            WareHouseItemManager man = new WareHouseItemManager();
            var result = man.All().Where(x => x.Product.ID == report.Product.ID);
            if (report.Count > 0)
            {
                if (result.Count() > 0)
                {
                    var item = result.First();
                    item.Count += report.Count;
                    man.Update(item);
                    return true;
                } else
                {
                    man.Add(new WareHouseItem()
                    {
                        WareHouse = report.WareHouse,
                        Product = report.Product,
                        Count = report.Count
                    });
                    return true;
                }
            }
            else
            {
                if (result.Count() > 0)
                {
                    var item = result.First();
                    item.Count += report.Count;
                    if (item.Count == 0) { man.Delete(item); } else { man.Update(item); };
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
