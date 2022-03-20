using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecScreenHistory
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public string? SysTenantId { get; set; }
        public Guid? UserId { get; set; }
        public string? Caption { get; set; }
        public string? Url { get; set; }
        public Guid? EntityId { get; set; }
        public string? StringEntityId { get; set; }
        public int? IntEntityId { get; set; }
        public long? LongEntityId { get; set; }
        public Guid? SubstitutedUserId { get; set; }

        public virtual SecUser? SubstitutedUser { get; set; }
        public virtual SecUser? User { get; set; }
    }
}
