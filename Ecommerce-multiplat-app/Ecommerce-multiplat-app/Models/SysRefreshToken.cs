using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysRefreshToken
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? TokenValue { get; set; }
        public byte[]? TokenBytes { get; set; }
        public byte[]? AuthenticationBytes { get; set; }
        public DateTime? Expiry { get; set; }
        public string? UserLogin { get; set; }
    }
}
