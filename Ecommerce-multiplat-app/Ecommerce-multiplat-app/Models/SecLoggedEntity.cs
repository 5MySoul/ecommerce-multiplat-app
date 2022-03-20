using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecLoggedEntity
    {
        public SecLoggedEntity()
        {
            SecLoggedAttrs = new HashSet<SecLoggedAttr>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public string? Name { get; set; }
        public byte? Auto { get; set; }
        public byte? Manual { get; set; }

        public virtual ICollection<SecLoggedAttr> SecLoggedAttrs { get; set; }
    }
}
