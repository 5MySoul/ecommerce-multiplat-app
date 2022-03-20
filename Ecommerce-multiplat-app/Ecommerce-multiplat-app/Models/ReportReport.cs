using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class ReportReport
    {
        public ReportReport()
        {
            ReportExecutions = new HashSet<ReportExecution>();
            ReportTemplates = new HashSet<ReportTemplate>();
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
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? LocaleNames { get; set; }
        public Guid GroupId { get; set; }
        public int? ReportType { get; set; }
        public Guid? DefaultTemplateId { get; set; }
        public string? Xml { get; set; }
        public string? RolesIdx { get; set; }
        public string? ScreensIdx { get; set; }
        public string? InputEntityTypesIdx { get; set; }
        public byte? RestAccess { get; set; }
        public byte? IsSystem { get; set; }

        public virtual ReportTemplate? DefaultTemplate { get; set; }
        public virtual ReportGroup Group { get; set; } = null!;
        public virtual ICollection<ReportExecution> ReportExecutions { get; set; }
        public virtual ICollection<ReportTemplate> ReportTemplates { get; set; }
    }
}
