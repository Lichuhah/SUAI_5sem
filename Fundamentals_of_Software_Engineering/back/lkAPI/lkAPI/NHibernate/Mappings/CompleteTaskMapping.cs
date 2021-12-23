using lkAPI.Models.Tasks;

namespace lkAPI.NHibernate.Mappings
{
    public class CompleteTaskMapping : EntityBaseMapping<CompleteTask>
    {
        public CompleteTaskMapping()
        {
            Table("Task_User");
            Map(x => x.mark).Column("Mark");
            References<Task>(x => x.task, "Task_ID");
            HasMany(x => x.passList)
               .Table("PassTask")
               .KeyColumn("TaskUser_ID")
               .Cascade.AllDeleteOrphan();
        }
    }
}
