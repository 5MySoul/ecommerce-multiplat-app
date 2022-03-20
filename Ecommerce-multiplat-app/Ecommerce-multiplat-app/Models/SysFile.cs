using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysFile
    {
        public SysFile()
        {
            ReportExecutions = new HashSet<ReportExecution>();
            SysSendingAttachments = new HashSet<SysSendingAttachment>();
            SysSendingMessages = new HashSet<SysSendingMessage>();
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
        public string? Ext { get; set; }
        public long? FileSize { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<ReportExecution> ReportExecutions { get; set; }
        public virtual ICollection<SysSendingAttachment> SysSendingAttachments { get; set; }
        public virtual ICollection<SysSendingMessage> SysSendingMessages { get; set; }
    }
}
