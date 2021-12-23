using Pharmacy.Domain.Login;
using Pharmacy.Domain.Models.Products;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Managers.Warehouse
{
    public class WareHouseItemManager : BaseManager<WareHouseItem>
    {
        public List<WareHouseItem> All()
        {
            if (LoginUser.GetUser().Pharmacy != null)
            {
                return LoginUser.GetUser().Pharmacy.WareHouse.Items.ToList();
            }
            else
            {
                return repository.All();
            }
        }
    }
}
