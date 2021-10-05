using Pharmacy.Domain.Models;
using Pharmacy.Domain.Models.Administration;

namespace Pharmacy.Domain.NHibernate.Mappings.Administration
{
    public class UserMapping : BaseNamedEntityMapping<User>
    {
        public UserMapping()
        {
            Map(x => x.Login).Column("Login");
            Map(x => x.Password).Column("Password");
            Map(x => x.Role).Column("Role").CustomType<UserRole>();
            References<PharmacyModel>(x => x.Pharmacy, "Pharmacy_ID");
        }
    }
}
