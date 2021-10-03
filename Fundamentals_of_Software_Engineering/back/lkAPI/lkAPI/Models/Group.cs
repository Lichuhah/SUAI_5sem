using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.Models
{
    public class Group : EntityBase
    {
        public virtual string number { get; set; }
        public virtual Speciality speciality { get; set; }
        public virtual int cource { get; set; }

        [JsonIgnore]
        public virtual IList<GroupDiscipline> disciplines { get; set; }

        [JsonIgnore]
        public virtual IList<Student> students { get; set; }
    }
}
