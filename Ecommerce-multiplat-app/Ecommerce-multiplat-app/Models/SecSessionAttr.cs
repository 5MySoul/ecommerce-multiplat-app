using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecSessionAttr
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
        public string? Name { get; set; }
        public string? StrValue { get; set; }
        public string? Datatype { get; set; }
        public Guid? GroupId { get; set; }

        public virtual SecGroup? Group { get; set; }
    }
}
