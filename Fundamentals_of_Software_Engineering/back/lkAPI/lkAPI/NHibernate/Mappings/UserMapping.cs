using lkAPI.Models;
using lkAPI.Models.Users;
using NHibernate.Mapping.ByCode.Conformist;

namespace lkAPI.NHibernate.Mappings
{
    public class UserMapping : EntityBaseMapping<User>
    {
        public UserMapping()
        {
            Table("[User]");
            Map(x => x.login).Column("Login");
            Map(x => x.password).Column("Password");
            Map(x => x.role).Column("UserRole_Id").CustomType<UserRole>().Nullable();
        }
    }
}
