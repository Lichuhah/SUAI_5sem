using Pharmacy.Domain.Managers.Warehouse;
using Pharmacy.Domain.Models.Cashbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Managers.Cashbox
{
    public class SaleManager : BaseManager<Sale>
    {
        public Sale Add(Sale data)
        {
            foreach(var item in data.Items)
            {
                item.Sale = data;
            }
            return repository.Add(data);
        }
        public bool SetCountBySale(Sale sale)
        {
            WareHouseItemManager man = new WareHouseItemManager();
            var list = man.All();
            foreach (var saleItem in sale.Items)
            {
                var itemList = list.Where(x => x.Product.ID == saleItem.Product.ID);
                if (itemList.Count() > 0)
                {
                    var item = itemList.First();
                    item.Count -= saleItem.Count;
                    if (item.Count == 0) { man.Delete(item); } else { man.Update(item); };
                }
            }
            return true;
        }
    }
}
