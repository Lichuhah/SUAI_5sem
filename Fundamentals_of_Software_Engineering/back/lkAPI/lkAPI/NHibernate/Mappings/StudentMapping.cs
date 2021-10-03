using lkAPI.Models;
using lkAPI.Models.Users;

namespace lkAPI.NHibernate.Mappings
{
    public class StudentMapping : EntityBaseMapping<Student>
    {
        public StudentMapping()
        {
            Table("[User]");
            References<Fullname>(x => x.fullname, "Fullname_ID");
            Map(x => x.mail).Column("Mail");
            Map(x => x.phonenumber).Column("PhoneNumber");
            References<Group>(x => x.group, "Group_ID");

            HasManyToMany(x => x.tasks).Cascade.AllDeleteOrphan()
                .Table("Task_User").ParentKeyColumn("User_ID").ChildKeyColumn("Task_ID");
        }
    }
}
