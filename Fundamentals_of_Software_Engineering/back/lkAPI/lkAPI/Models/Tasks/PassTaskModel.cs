using System;

namespace lkAPI.Models.Tasks
{
    public class PassTaskModel : EntityBase
    {
        public virtual string answer { get; set; }
        public virtual DateTime date { get; set; }
        public virtual string description { get; set; }
    }
}
