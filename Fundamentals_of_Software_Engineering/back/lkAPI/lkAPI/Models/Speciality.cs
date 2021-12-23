using lkAPI.Models.Enums;

namespace lkAPI.Models
{
    public class Speciality : EntityBase
    {
        public virtual string code { get; set; }
        public virtual string name { get; set; }
        public virtual EducationType educationType { get; set; }
    }
}
