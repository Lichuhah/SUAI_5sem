using lkAPI.Models.Tasks;

namespace lkAPI.NHibernate.Mappings
{
    public class CompleteTaskMapping : EntityBaseMapping<CompleteTaskModel>
    {
        public CompleteTaskMapping()
        {
            Table("Task_User");
            Map(x => x.mark).Column("Mark");
            References<TaskModel>(x => x.task, "Task_ID").Cascade.None();
            HasMany(x => x.passList).Table("PassTask").KeyColumn("Task_ID").CollectionType<PassTaskMapping>();
        }
    }
}
