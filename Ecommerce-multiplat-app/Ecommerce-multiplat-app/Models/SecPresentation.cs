using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecPresentation
    {
        public SecPresentation()
        {
            SecSearchFolders = new HashSet<SecSearchFolder>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public string? SysTenantId { get; set; }
        public string? Component { get; set; }
        public string? Name { get; set; }
        public string? Xml { get; set; }
        public Guid? UserId { get; set; }
        public byte? IsAutoSave { get; set; }

        public virtual SecUser? User { get; set; }
        public virtual ICollection<SecSearchFolder> SecSearchFolders { get; set; }
    }
}
