using System.Collections.Generic;

namespace lkAPI.Models.Tasks
{
    public class CompleteTask : EntityBase
    {
        public virtual Task task { get; set; }
        public virtual int mark { get; set; }
        public virtual IList<PassTask> passList { get; set; }
    }
}
