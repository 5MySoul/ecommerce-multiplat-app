using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecUserSetting
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public Guid? UserId { get; set; }
        public string? ClientType { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }

        public virtual SecUser? User { get; set; }
    }
}
