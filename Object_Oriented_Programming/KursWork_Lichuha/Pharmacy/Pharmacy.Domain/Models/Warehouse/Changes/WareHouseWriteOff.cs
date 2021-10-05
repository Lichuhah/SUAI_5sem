using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Warehouse.Changes
{
    public class WareHouseWriteOff : WareHouseReport
    {
        [DisplayName("Причина списания")]
        override public string Description { get; set; }
    }
}
