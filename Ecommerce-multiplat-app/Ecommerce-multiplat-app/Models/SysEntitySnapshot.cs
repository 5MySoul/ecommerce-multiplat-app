using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysEntitySnapshot
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public string? SysTenantId { get; set; }
        public string EntityMetaClass { get; set; } = null!;
        public Guid? EntityId { get; set; }
        public string? StringEntityId { get; set; }
        public int? IntEntityId { get; set; }
        public long? LongEntityId { get; set; }
        public Guid AuthorId { get; set; }
        public string ViewXml { get; set; } = null!;
        public string SnapshotXml { get; set; } = null!;
        public DateTime SnapshotDate { get; set; }

        public virtual SecUser Author { get; set; } = null!;
    }
}
