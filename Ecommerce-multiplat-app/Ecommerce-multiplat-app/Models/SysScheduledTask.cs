using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysScheduledTask
    {
        public SysScheduledTask()
        {
            SysScheduledExecutions = new HashSet<SysScheduledExecution>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string? SysTenantId { get; set; }
        public string? DefinedBy { get; set; }
        public string? ClassName { get; set; }
        public string? ScriptName { get; set; }
        public string? BeanName { get; set; }
        public string? MethodName { get; set; }
        public string? MethodParams { get; set; }
        public string? UserName { get; set; }
        public byte? IsSingleton { get; set; }
        public byte? IsActive { get; set; }
        public int? Period { get; set; }
        public int? Timeout { get; set; }
        public DateTime? StartDate { get; set; }
        public int? TimeFrame { get; set; }
        public int? StartDelay { get; set; }
        public string? PermittedServers { get; set; }
        public byte? LogStart { get; set; }
        public byte? LogFinish { get; set; }
        public DateTime? LastStartTime { get; set; }
        public string? LastStartServer { get; set; }
        public string? Description { get; set; }
        public string? Cron { get; set; }
        public string? SchedulingType { get; set; }

        public virtual ICollection<SysScheduledExecution> SysScheduledExecutions { get; set; }
    }
}
