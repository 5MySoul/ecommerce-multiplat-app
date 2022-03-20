using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysAccessToken
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? TokenValue { get; set; }
        public byte[]? TokenBytes { get; set; }
        public string? AuthenticationKey { get; set; }
        public byte[]? AuthenticationBytes { get; set; }
        public DateTime? Expiry { get; set; }
        public string? UserLogin { get; set; }
        public string? Locale { get; set; }
        public string? RefreshTokenValue { get; set; }
    }
}
