using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecRole
    {
        public SecRole()
        {
            SecPermissions = new HashSet<SecPermission>();
            SecUserRoles = new HashSet<SecUserRole>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string? SysTenantId { get; set; }
        public string Name { get; set; } = null!;
        public string? LocName { get; set; }
        public string? Description { get; set; }
        public byte? IsDefaultRole { get; set; }
        public int? RoleType { get; set; }
        public string? SecurityScope { get; set; }

        public virtual ICollection<SecPermission> SecPermissions { get; set; }
        public virtual ICollection<SecUserRole> SecUserRoles { get; set; }
    }
}
