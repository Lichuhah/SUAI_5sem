using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Managers.Warehouse.Changes
{
    public class WareHouseEnrollmentManager : WareHouseReportManager
    {
        new public List<WareHouseReport> All()
        {
            return repository.All().Where(x=>x.Count>0).ToList();
        }

        new public WareHouseReport Get(int id)
        {
            return repository.Get(id).Count>0 ? repository.Get(id) : null;
        }

        new public WareHouseReport Add(WareHouseReport data)
        {
            data.Type = "Зачисление";
            if (data.Count < 0) data.Count *= -1;
            return repository.Add(data);
        }

        new public WareHouseReport Update(WareHouseReport data)
        {
            if (data.Count < 0) data.Count *= -1;
            data.Type = "Зачисление товара";
            return repository.Save(data);
        }

        new public bool Delete(WareHouseReport data)
        {
            return repository.Delete(data);
        }
    }
}
