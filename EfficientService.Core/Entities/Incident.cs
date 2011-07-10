using System;
using EfficientService.Core.Utils;

namespace EfficientService.Core.Entities
{
    public class Incident : EntityBase
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Priorities Priority { get; set; }
        public virtual Statuses Status { get; set; }
        public virtual string Customer { get; set; }
        public virtual int Type { get; set; }
        public virtual int ServiceID { get; set; }
        public virtual DateTime StartTime { get; internal set; }
        public virtual DateTime LastChangeTime { get; internal set; }
        public virtual Guid ResponsibleID { get; set; }
        public virtual string Document { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual DateTime MustResolveTime { get; set; }
        public virtual string Comment { get; set; }
    }
}
