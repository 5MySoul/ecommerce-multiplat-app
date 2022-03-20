using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecSearchFolder
    {
        public Guid FolderId { get; set; }
        public string? FilterComponent { get; set; }
        public string? FilterXml { get; set; }
        public Guid? UserId { get; set; }
        public Guid? PresentationId { get; set; }
        public byte? ApplyDefault { get; set; }
        public byte? IsSet { get; set; }
        public string? EntityType { get; set; }

        public virtual SysFolder Folder { get; set; } = null!;
        public virtual SecPresentation? Presentation { get; set; }
        public virtual SecUser? User { get; set; }
    }
}
