using lkAPI.Models.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace lkAPI.Models
{
    public class Discipline : EntityBase
    {
        public virtual string name { get; set; }
        public virtual ExamType exam { get; set; }
        public virtual int hours { get; set; }

        [JsonIgnore]
        public virtual IList<Group> groups { get; set; }
    }
}
