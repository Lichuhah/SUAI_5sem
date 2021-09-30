using lkAPI.Models;
using lkAPI.Models.Users;

namespace lkAPI.NHibernate.Mappings
{
    public class StudentMapping : EntityBaseMapping<Student>
    {
        public StudentMapping()
        {
            Table("[User]");
            References<Fullname>(x => x.fullname, "Fullname_ID").Cascade.None();
            Map(x => x.mail).Column("Mail");
            Map(x => x.phonenumber).Column("PhoneNumber");
            References<GroupModel>(x => x.group, "Group_ID").Cascade.None();
        }
    }
}
