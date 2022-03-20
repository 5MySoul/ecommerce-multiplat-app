using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecFilter
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string? SysTenantId { get; set; }
        public string? Component { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Xml { get; set; }
        public Guid? UserId { get; set; }
        public byte? GlobalDefault { get; set; }

        public virtual SecUser? User { get; set; }
    }
}
