using lkAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.NHibernate.Mappings
{
    public class FullnameMapping : EntityBaseMapping<Fullname>
    {
        public FullnameMapping()
        {
            Table("[User_Fullname]");
            Map(x => x.name).Column("Name");
            Map(x => x.lastname).Column("LastName");
            Map(x => x.othername).Column("OtherName");
        }
    }
}
