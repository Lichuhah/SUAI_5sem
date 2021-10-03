using Newtonsoft.Json;
using System;

namespace lkAPI.Models.Tasks
{
    public class PassTask : EntityBase
    {
        public virtual string answer { get; set; }
        public virtual DateTime date { get; set; }
        public virtual string description { get; set; }

        [JsonIgnore]
        public virtual CompleteTask task { get; set; }

        public virtual int taskId
        {
            get { return task.id; }
            set { taskId = value; }
        }
    }
}
