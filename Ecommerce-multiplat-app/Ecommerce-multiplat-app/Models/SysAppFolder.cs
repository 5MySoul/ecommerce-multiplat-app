using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysAppFolder
    {
        public Guid FolderId { get; set; }
        public string? FilterComponent { get; set; }
        public string? FilterXml { get; set; }
        public string? VisibilityScript { get; set; }
        public string? QuantityScript { get; set; }
        public byte? ApplyDefault { get; set; }

        public virtual SysFolder Folder { get; set; } = null!;
    }
}
