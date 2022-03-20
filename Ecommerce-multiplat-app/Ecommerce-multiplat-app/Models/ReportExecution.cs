using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class ReportExecution
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public Guid? ReportId { get; set; }
        public string ReportName { get; set; } = null!;
        public string? ReportCode { get; set; }
        public Guid UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public byte? IsSuccess { get; set; }
        public byte? Cancelled { get; set; }
        public string? Params { get; set; }
        public string? ErrorMessage { get; set; }
        public string? ServerId { get; set; }
        public Guid? OutputDocumentId { get; set; }

        public virtual SysFile? OutputDocument { get; set; }
        public virtual ReportReport? Report { get; set; }
        public virtual SecUser User { get; set; } = null!;
    }
}
