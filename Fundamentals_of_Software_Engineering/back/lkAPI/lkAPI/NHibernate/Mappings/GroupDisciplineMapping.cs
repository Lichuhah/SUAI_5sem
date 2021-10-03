using lkAPI.Models;

namespace lkAPI.NHibernate.Mappings
{
    public class GroupDisciplineMapping : EntityBaseMapping<GroupDiscipline>
    {
        public GroupDisciplineMapping()
        {
            Table("Group_Discipline");

            HasMany(x => x.tasks)
                 .Table("Task")
                 .KeyColumn("Group_Discipline_ID")
                 .Cascade.AllDeleteOrphan();

            References<Discipline>(x => x.discipline, "Discipline_ID");
        }
        
    }
}
