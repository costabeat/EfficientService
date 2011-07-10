using EfficientService.Core.Entities;
using FluentNHibernate.Mapping;

namespace EfficientService.Core.Mappings
{
    public sealed class IncidentMap : ClassMap<Incident>
    {
         public IncidentMap()
         {
             this.Table("IncidentSet");
             Id(x => x.UID).GeneratedBy.Guid();
             Map(x => x.Title).Column("Title").Not.Nullable();
             Map(x => x.Description).Not.Nullable();
             Map(x => x.Type);
             References(x => x.Customer).Column("Customer_Id").Cascade.All();
         }
    }
}