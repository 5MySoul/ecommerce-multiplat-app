using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysCategory
    {
        public SysCategory()
        {
            SysCategoryAttrs = new HashSet<SysCategoryAttr>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string Name { get; set; } = null!;
        public string? Special { get; set; }
        public string EntityType { get; set; } = null!;
        public byte? IsDefault { get; set; }
        public int? Discriminator { get; set; }
        public string? LocaleNames { get; set; }

        public virtual ICollection<SysCategoryAttr> SysCategoryAttrs { get; set; }
    }
}
