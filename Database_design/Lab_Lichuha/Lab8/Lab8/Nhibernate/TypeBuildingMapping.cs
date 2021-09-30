using FluentNHibernate.Mapping;
using Lab8.Models;

namespace Lab8.Nhibernate
{
    public class TypeBuildingMapping : ClassMap<TypeBuilding>
    {
        public TypeBuildingMapping()
        {
            Table("TypeBuilding");
            Id(x => x.ID).Column("ID");
            Map(x => x.Name).Column("Name");
        }
    }
}
