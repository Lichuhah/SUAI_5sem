using lkAPI.Models.Tasks;

namespace lkAPI.NHibernate.Mappings
{
    public class PassTaskMapping : EntityBaseMapping<PassTaskModel>
    {
        public PassTaskMapping()
        {
            Table("PassTask");
            Map(x => x.answer).Column("Answer");
            Map(x => x.date).Column("Date");
            Map(x => x.description).Column("Description");
        }
    }
}
