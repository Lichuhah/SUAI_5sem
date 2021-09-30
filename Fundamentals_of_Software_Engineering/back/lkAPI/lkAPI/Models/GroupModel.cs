using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.Models
{
    public class GroupModel : EntityBase
    {
        public virtual string number { get; set; }
        public virtual SpecialityModel speciality { get; set; }
        public virtual int cource { get; set; }

        [JsonIgnore]
        public virtual List<DisciplineModel> disciplines { get; set; }
    }
}
