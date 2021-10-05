using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Warehouse.Changes
{
    public class WareHouseEnrollment : WareHouseReport
    {
        [DisplayName("Информация о зачислении")]
        override public string Description { get; set; }
    }
}
