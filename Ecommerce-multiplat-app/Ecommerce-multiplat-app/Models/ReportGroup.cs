using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class ReportGroup
    {
        public ReportGroup()
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
        public string? SysTenantId { get; set; }
        public string Title { get; set; } = null!;
        public string? Code { get; set; }
        public string? LocaleNames { get; set; }

        public virtual ICollection<ReportReport> ReportReports { get; set; }
    }
}
