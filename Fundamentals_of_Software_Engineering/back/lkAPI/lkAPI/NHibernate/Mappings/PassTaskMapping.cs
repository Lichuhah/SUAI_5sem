using lkAPI.Models.Tasks;
using System;

namespace lkAPI.NHibernate.Mappings
{
    public class PassTaskMapping : EntityBaseMapping<PassTask>
    {
        public PassTaskMapping()
        {
            Table("PassTask");
            Map(x => x.answer).Column("Answer");
            Map(x => x.date).Column("Date").CustomType<DateTime>();
            Map(x => x.description).Column("Description");
            References<CompleteTask>(x => x.task, "TaskUser_ID");
        }
    }
}
