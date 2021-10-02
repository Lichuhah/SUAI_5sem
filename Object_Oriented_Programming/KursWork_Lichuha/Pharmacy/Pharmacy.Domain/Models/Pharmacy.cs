using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models
{
    public class Pharmacy : BaseEntity
    {
       public virtual string Address { get; set; }
    }
}
