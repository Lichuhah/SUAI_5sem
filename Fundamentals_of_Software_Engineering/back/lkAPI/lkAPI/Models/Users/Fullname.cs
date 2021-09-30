using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.Models.Users
{
    public class Fullname : EntityBase
    {
        [JsonProperty]
        public virtual string name { get; set; }
        [JsonProperty]
        public virtual string second_name { get; set; }
        [JsonProperty]
        public virtual string other_name { get; set; }
    }
}
