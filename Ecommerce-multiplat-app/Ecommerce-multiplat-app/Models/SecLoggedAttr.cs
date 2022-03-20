using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecLoggedAttr
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public Guid? EntityId { get; set; }
        public string? Name { get; set; }

        public virtual SecLoggedEntity? Entity { get; set; }
    }
}
