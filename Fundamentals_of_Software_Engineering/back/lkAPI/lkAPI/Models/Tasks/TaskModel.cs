using lkAPI.Models;
using System;

namespace lkAPI.Models.Tasks
{
    public class TaskModel : EntityBase
    {
        public virtual DisciplineModel discipline {get; set;}
        public virtual int number { get; set; }
        public virtual int maxMark { get; set; }
        public virtual string description { get; set; }
        public virtual DateTime deadline { get; set; }
    }
}
