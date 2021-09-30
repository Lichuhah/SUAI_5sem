using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lkAPI.Models.Tasks
{
    public class CompleteTaskModel : EntityBase
    {
        public virtual Task task { get; set; }
        public virtual int mark { get; set; }
        public virtual List<PassTaskModel> passList { get; set; }
    }
}
