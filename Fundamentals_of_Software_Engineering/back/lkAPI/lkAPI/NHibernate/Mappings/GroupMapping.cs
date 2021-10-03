using lkAPI.Models;

namespace lkAPI.NHibernate.Mappings
{
    public class GroupMapping : EntityBaseMapping<Group> 
    {
        public GroupMapping()
        {
            Table("[Group]");
            Map(x => x.number).Column("Number");
            Map(x => x.cource).Column("Course");

            HasManyToMany(x => x.disciplines).Cascade.AllDeleteOrphan()
                .Table("Group_Discipline").ParentKeyColumn("Group_ID").ChildKeyColumn("Discipline_ID");

            HasMany(x => x.students)
                .Table("User")
                .KeyColumn("Group_ID")
                .Cascade.AllDeleteOrphan();
        }
    }
}
