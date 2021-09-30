using lkAPI.Models;

namespace lkAPI.NHibernate.Mappings
{
    public class GroupMapping : EntityBaseMapping<GroupModel> 
    {
        public GroupMapping()
        {
            Table("Group");
            Map(x => x.number).Column("Number");
            Map(x => x.cource).Column("Course");

            HasManyToMany(x => x.disciplines).Cascade.All()
                .Inverse().Table("Group_Discipline");
        }
    }
}
