using FluentNHibernate.Mapping;
using Lab8.Models;

namespace Lab8.Nhibernate
{
    public class BuildingMapping : ClassMap<Building>
    {
        public BuildingMapping()
        {
            Table("Building");
            Id(x => x.ID).Column("ID");
            Map(x => x.Size).Column("Size");
            Map(x => x.Price).Column("Price");
            References<TypeBuilding>(x => x.Type, "ID_TypeBuilding").Cascade.AllDeleteOrphan();
        }
    }
}
