using lkAPI.Models.Users;

namespace lkAPI.NHibernate.Mappings
{
    public class FullnameMapping : EntityBaseMapping<Fullname>
    {
        public FullnameMapping()
        {
            Table("[User_Fullname]");
            Map(x => x.name).Column("Name");
            Map(x => x.second_name).Column("LastName");
            Map(x => x.other_name).Column("OtherName");
        }
    }
}
