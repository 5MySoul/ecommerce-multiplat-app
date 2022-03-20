using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysCategoryAttr
    {
        public SysCategoryAttr()
        {
            SysAttrValues = new HashSet<SysAttrValue>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string? CategoryEntityType { get; set; }
        public string? Name { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
        public string? EntityClass { get; set; }
        public string? DataType { get; set; }
        public string? DefaultString { get; set; }
        public int? DefaultInt { get; set; }
        public decimal? DefaultDouble { get; set; }
        public decimal? DefaultDecimal { get; set; }
        public DateTime? DefaultDate { get; set; }
        public DateTime? DefaultDateWoTime { get; set; }
        public byte? DefaultDateIsCurrent { get; set; }
        public byte? DefaultBoolean { get; set; }
        public Guid? DefaultEntityValue { get; set; }
        public string? DefaultStrEntityValue { get; set; }
        public int? DefaultIntEntityValue { get; set; }
        public long? DefaultLongEntityValue { get; set; }
        public string? Enumeration { get; set; }
        public int? OrderNo { get; set; }
        public string? Screen { get; set; }
        public byte? Required { get; set; }
        public byte? Lookup { get; set; }
        public string? TargetScreens { get; set; }
        public string? Width { get; set; }
        public int? RowsCount { get; set; }
        public byte? IsCollection { get; set; }
        public string? JoinClause { get; set; }
        public string? WhereClause { get; set; }
        public string? FilterXml { get; set; }
        public string? LocaleNames { get; set; }
        public string? LocaleDescriptions { get; set; }
        public string? EnumerationLocales { get; set; }
        public string? AttributeConfigurationJson { get; set; }

        public virtual SysCategory Category { get; set; } = null!;
        public virtual ICollection<SysAttrValue> SysAttrValues { get; set; }
    }
}
