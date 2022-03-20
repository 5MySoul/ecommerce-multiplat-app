using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysScheduledExecution
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public string? SysTenantId { get; set; }
        public Guid? TaskId { get; set; }
        public string? Server { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string? Result { get; set; }

        public virtual SysScheduledTask? Task { get; set; }
    }
}
