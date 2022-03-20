using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecPermission
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public int? PermissionType { get; set; }
        public string? Target { get; set; }
        public int? Value { get; set; }
        public Guid? RoleId { get; set; }

        public virtual SecRole? Role { get; set; }
    }
}
