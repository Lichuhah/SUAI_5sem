using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Managers.Warehouse.Changes
{
    public class WareHouseWriteOffManager : WareHouseReportManager
    {
        new public List<WareHouseReport> All()
        {
            var list = repository.All().Where(x => x.Count < 0).ToList();
            list.ForEach(x=>x.Count = x.Count*-1);
            return list;
        }

        new public WareHouseReport Get(int id)
        {
            var item =  repository.Get(id);
            if (item != null)
            {
                item.Count *= -1;
            }
            return item;
        }

        new public WareHouseReport Add(WareHouseReport data)
        {
            if (data.Count > 0) data.Count *= -1;
            return repository.Save(data);
        }

        new public WareHouseReport Update(WareHouseReport data)
        {
            if (data.Count > 0) data.Count *= -1;
            data.Type = "Списание товара";
            return repository.Save(data);
        }

        new public bool Delete(WareHouseReport data)
        {
            return repository.Delete(data);
        }
    }
}
