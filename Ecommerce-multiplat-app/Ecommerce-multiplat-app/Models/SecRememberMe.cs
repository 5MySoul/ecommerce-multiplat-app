using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecRememberMe
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; } = null!;

        public virtual SecUser User { get; set; } = null!;
    }
}
