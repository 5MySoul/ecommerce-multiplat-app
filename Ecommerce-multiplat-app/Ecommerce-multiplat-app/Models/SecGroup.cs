using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecGroup
    {
        public SecGroup()
        {
            InverseParent = new HashSet<SecGroup>();
            SecConstraints = new HashSet<SecConstraint>();
            SecGroupHierarchyGroups = new HashSet<SecGroupHierarchy>();
            SecGroupHierarchyParents = new HashSet<SecGroupHierarchy>();
            SecSessionAttrs = new HashSet<SecSessionAttr>();
            SecUsers = new HashSet<SecUser>();
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
        public Guid? ParentId { get; set; }

        public virtual SecGroup? Parent { get; set; }
        public virtual ICollection<SecGroup> InverseParent { get; set; }
        public virtual ICollection<SecConstraint> SecConstraints { get; set; }
        public virtual ICollection<SecGroupHierarchy> SecGroupHierarchyGroups { get; set; }
        public virtual ICollection<SecGroupHierarchy> SecGroupHierarchyParents { get; set; }
        public virtual ICollection<SecSessionAttr> SecSessionAttrs { get; set; }
        public virtual ICollection<SecUser> SecUsers { get; set; }
    }
}
