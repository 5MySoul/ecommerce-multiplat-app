using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysFtsQueue
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public Guid? EntityId { get; set; }
        public string? StringEntityId { get; set; }
        public int? IntEntityId { get; set; }
        public long? LongEntityId { get; set; }
        public string? EntityName { get; set; }
        public string? ChangeType { get; set; }
        public string? SourceHost { get; set; }
        public string? IndexingHost { get; set; }
        public byte? Fake { get; set; }
    }
}
