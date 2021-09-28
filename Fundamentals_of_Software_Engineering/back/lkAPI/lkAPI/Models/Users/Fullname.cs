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
        public virtual string lastname { get; set; }
        [JsonProperty]
        public virtual string othername { get; set; }
    }
}
