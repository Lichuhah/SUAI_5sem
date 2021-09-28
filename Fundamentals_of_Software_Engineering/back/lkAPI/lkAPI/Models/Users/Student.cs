using lkAPI.Models.Users;

namespace lkAPI.Models
{
    public class Student : EntityBase
    {
        public virtual Fullname fullname { get; set; }
        public virtual string mail { get; set; }
        public virtual string phonenumber { get; set; }
        public virtual string groupnumber { get; set; }
    }
}
