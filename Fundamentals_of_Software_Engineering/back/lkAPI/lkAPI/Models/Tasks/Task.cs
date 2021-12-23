using Newtonsoft.Json;
using System;

namespace lkAPI.Models.Tasks
{
    public class Task : EntityBase
    {
        [JsonIgnore]
        public virtual GroupDiscipline discipline {get; set;}
        public virtual int disciplineId
        {
            get { return discipline.id; }
            set { disciplineId = value; }
        }
        public virtual string disciplineName
        {
            get { return discipline.discipline.name; }
            set { disciplineName = value; }
        }
        public virtual int number { get; set; }
        public virtual int maxMark { get; set; }
        public virtual string description { get; set; }
        public virtual DateTime deadline { get; set; }
    }
}
