using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysFolder
    {
        public SysFolder()
        {
            InverseParent = new HashSet<SysFolder>();
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
        public string? FolderType { get; set; }
        public Guid? ParentId { get; set; }
        public string? Name { get; set; }
        public string? TabName { get; set; }
        public int? SortOrder { get; set; }

        public virtual SysFolder? Parent { get; set; }
        public virtual SecSearchFolder SecSearchFolder { get; set; } = null!;
        public virtual SysAppFolder SysAppFolder { get; set; } = null!;
        public virtual ICollection<SysFolder> InverseParent { get; set; }
    }
}
