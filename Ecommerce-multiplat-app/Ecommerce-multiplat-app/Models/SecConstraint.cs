using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecConstraint
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
        public string? Code { get; set; }
        public string? CheckType { get; set; }
        public string? OperationType { get; set; }
        public string EntityName { get; set; } = null!;
        public string? JoinClause { get; set; }
        public string? WhereClause { get; set; }
        public string? GroovyScript { get; set; }
        public string? FilterXml { get; set; }
        public byte? IsActive { get; set; }
        public Guid? GroupId { get; set; }

        public virtual SecGroup? Group { get; set; }
    }
}
