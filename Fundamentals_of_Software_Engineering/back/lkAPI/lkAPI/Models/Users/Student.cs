using lkAPI.Models.Tasks;
using lkAPI.Models.Users;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace lkAPI.Models
{
    public class Student : EntityBase
    {
        public virtual Fullname fullname { get; set; }
        public virtual string mail { get; set; }
        public virtual string phonenumber { get; set; }
        public virtual string groupnumber {
            get { return group.number; }
            set { group.number = value; }
        }

        [JsonIgnore]
        public virtual Group group { get; set; }

        [JsonIgnore]
        public virtual IList<CompleteTask> tasks { get; set; }
    }
}
