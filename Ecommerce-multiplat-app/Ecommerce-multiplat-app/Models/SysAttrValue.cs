using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysAttrValue
    {
        public SysAttrValue()
        {
            InverseParent = new HashSet<SysAttrValue>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public Guid CategoryAttrId { get; set; }
        public Guid? EntityId { get; set; }
        public string? StringEntityId { get; set; }
        public int? IntEntityId { get; set; }
        public long? LongEntityId { get; set; }
        public string? StringValue { get; set; }
        public int? IntegerValue { get; set; }
        public decimal? DoubleValue { get; set; }
        public decimal? DecimalValue { get; set; }
        public DateTime? DateValue { get; set; }
        public DateTime? DateWoTimeValue { get; set; }
        public byte? BooleanValue { get; set; }
        public Guid? EntityValue { get; set; }
        public string? StringEntityValue { get; set; }
        public int? IntEntityValue { get; set; }
        public long? LongEntityValue { get; set; }
        public string Code { get; set; } = null!;
        public Guid? ParentId { get; set; }

        public virtual SysCategoryAttr CategoryAttr { get; set; } = null!;
        public virtual SysAttrValue? Parent { get; set; }
        public virtual ICollection<SysAttrValue> InverseParent { get; set; }
    }
}
