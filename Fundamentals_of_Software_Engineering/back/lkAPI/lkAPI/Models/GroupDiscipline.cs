using lkAPI.Models.Tasks;
using System.Collections.Generic;

namespace lkAPI.Models
{
    public class GroupDiscipline : EntityBase
    { 
        public virtual Discipline discipline { get; set; }
        public virtual IList<Task> tasks { get; set; }
    }
}
