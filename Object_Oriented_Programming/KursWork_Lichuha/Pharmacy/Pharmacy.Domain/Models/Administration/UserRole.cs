using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models.Administration
{
    public enum UserRole
    {
        Admin = 0,
        Manager = 1,
        Cashier = 2,
        Warehouse = 3
    }
}
