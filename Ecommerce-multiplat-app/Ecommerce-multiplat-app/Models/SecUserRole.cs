using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecUserRole
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual SecRole? Role { get; set; }
        public virtual SecUser? User { get; set; }
    }
}
