using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysQueryResult
    {
        public long Id { get; set; }
        public Guid SessionId { get; set; }
        public int QueryKey { get; set; }
        public Guid? EntityId { get; set; }
        public string? StringEntityId { get; set; }
        public int? IntEntityId { get; set; }
        public long? LongEntityId { get; set; }
    }
}
