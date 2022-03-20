using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class ReportTemplate
    {
        public ReportTemplate()
        {
            ReportReports = new HashSet<ReportReport>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public Guid ReportId { get; set; }
        public string? Code { get; set; }
        public int OutputType { get; set; }
        public byte? IsDefault { get; set; }
        public byte? IsGroovy { get; set; }
        public byte? IsCustom { get; set; }
        public byte? IsAlterableOutput { get; set; }
        public int? CustomDefinedBy { get; set; }
        public string? CustomClass { get; set; }
        public string? OutputNamePattern { get; set; }
        public string? Name { get; set; }
        public byte[]? Content { get; set; }

        public virtual ReportReport Report { get; set; } = null!;
        public virtual ICollection<ReportReport> ReportReports { get; set; }
    }
}
