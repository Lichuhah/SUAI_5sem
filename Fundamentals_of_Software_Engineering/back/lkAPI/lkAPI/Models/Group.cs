using Newtonsoft.Json;
using System.Collections.Generic;

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
