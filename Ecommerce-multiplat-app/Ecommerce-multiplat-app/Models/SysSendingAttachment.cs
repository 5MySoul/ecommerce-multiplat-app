using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysSendingAttachment
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
        public Guid? MessageId { get; set; }
        public byte[]? Content { get; set; }
        public Guid? ContentFileId { get; set; }
        public string? ContentId { get; set; }
        public string? Name { get; set; }
        public string? Disposition { get; set; }
        public string? TextEncoding { get; set; }

        public virtual SysFile? ContentFile { get; set; }
        public virtual SysSendingMessage? Message { get; set; }
    }
}
