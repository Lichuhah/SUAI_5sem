using lkAPI.Models;
using lkAPI.Models.Tasks;

namespace lkAPI.NHibernate.Mappings
{
    public class TaskMapping : EntityBaseMapping<Task>
    {
        public TaskMapping()
        {
            Table("Task");
            Map(x => x.description).Column("Description");
            Map(x => x.deadline).Column("Deadline");
            Map(x => x.maxMark).Column("MaxMark");
            Map(x => x.number).Column("Number");
            References<GroupDiscipline>(x => x.discipline, "Group_Discipline_ID");
        }
    }
}
