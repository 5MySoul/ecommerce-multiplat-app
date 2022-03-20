using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecSessionLog
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string? SysTenantId { get; set; }
        public Guid SessionId { get; set; }
        public Guid UserId { get; set; }
        public Guid? SubstitutedUserId { get; set; }
        public string? UserData { get; set; }
        public int LastAction { get; set; }
        public string? ClientInfo { get; set; }
        public string? ClientType { get; set; }
        public string? Address { get; set; }
        public DateTime? StartedTs { get; set; }
        public DateTime? FinishedTs { get; set; }
        public string? ServerId { get; set; }

        public virtual SecUser? SubstitutedUser { get; set; }
        public virtual SecUser User { get; set; } = null!;
    }
}
