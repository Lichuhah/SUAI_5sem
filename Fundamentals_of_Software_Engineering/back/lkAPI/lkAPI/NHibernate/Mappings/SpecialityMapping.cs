using lkAPI.Models;
using lkAPI.Models.Enums;

namespace lkAPI.NHibernate.Mappings
{
    public class SpecialityMapping : EntityBaseMapping<Speciality>
    {
        public SpecialityMapping()
        {
            Table("Speciality");
            Map(x => x.code).Column("Code");
            Map(x => x.name).Column("Name");
            Map(x => x.educationType).Column("Education").CustomType<EducationType>();
        }
    }
}
