using lkAPI.Models;
using lkAPI.Models.Enums;

namespace lkAPI.NHibernate.Mappings
{
    public class DisciplineMapping : EntityBaseMapping<DisciplineModel>
    {
        public DisciplineMapping()
        {
            Table("Discipline");
            Map(x => x.name).Column("Name");
            Map(x => x.hours).Column("Hours");
            Map(x => x.exam).Column("Exam").CustomType<ExamType>();

            HasManyToMany(x => x.groups).Cascade.All()
                .Inverse().Table("Group_Discipline");
        }
    }
}
