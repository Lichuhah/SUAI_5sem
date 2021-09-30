using Newtonsoft.Json;

namespace lkAPI.Models.Users
{
    public class User : EntityBase
    {
        public virtual string login { get; set; }
        public virtual string password { get; set; }
        public virtual UserRole? role { get; set; }

    }
}
