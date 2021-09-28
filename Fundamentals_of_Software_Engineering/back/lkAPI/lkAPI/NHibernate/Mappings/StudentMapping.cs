using lkAPI.Models;
using lkAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.NHibernate.Mappings
{
    public class StudentMapping : EntityBaseMapping<Student>
    {
        public StudentMapping()
        {
            Table("[User]");
            References<Fullname>(x => x.fullname, "Fullname_ID").Cascade.None();
            Map(x => x.mail).Column("Mail");
            //Map(x => x.groupnumber).Column("Groupnumber");
            Map(x => x.phonenumber).Column("PhoneNumber");
        }
    }
}
