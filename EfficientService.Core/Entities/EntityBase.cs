using System;

namespace EfficientService.Core.Entities
{
    public abstract class EntityBase
    {
        public virtual Guid UID { get; set; }
    }
}