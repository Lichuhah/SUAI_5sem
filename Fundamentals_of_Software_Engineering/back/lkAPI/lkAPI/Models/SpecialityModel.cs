using lkAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.Models
{
    public class SpecialityModel : EntityBase
    {
        public virtual string code { get; set; }
        public virtual string name { get; set; }
        public virtual EducationType educationType { get; set; }
    }
}
