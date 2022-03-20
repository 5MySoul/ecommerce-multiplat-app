using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecGroupHierarchy
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public string? SysTenantId { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? ParentId { get; set; }
        public int? HierarchyLevel { get; set; }

        public virtual SecGroup? Group { get; set; }
        public virtual SecGroup? Parent { get; set; }
    }
}
