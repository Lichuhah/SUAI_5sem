using Pharmacy.Domain.Models.Administration;
using Pharmacy.Domain.Models.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Models
{
    public class User : BaseNamedEntity
    {
        [DisplayName("Логин")]
        public virtual string Login { get; set; }
        [DisplayName("Пароль")]
        public virtual string Password { get; set; }
        [DisplayName("Роль")]
        public virtual UserRole Role { get; set; }
        [Browsable(false)]
        public virtual string PharmacyAddress { 
            get { return Pharmacy != null ? Pharmacy.Address : null; }
        }
        [Browsable(false)]
        public virtual PharmacyModel Pharmacy { get; set; }
    }
}
