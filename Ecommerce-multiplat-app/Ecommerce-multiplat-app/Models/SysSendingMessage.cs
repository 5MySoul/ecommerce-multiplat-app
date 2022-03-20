using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SysSendingMessage
    {
        public SysSendingMessage()
        {
            SysSendingAttachments = new HashSet<SysSendingAttachment>();
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
        public string? AddressTo { get; set; }
        public string? AddressCc { get; set; }
        public string? AddressBcc { get; set; }
        public string? AddressFrom { get; set; }
        public string? Caption { get; set; }
        public string? EmailHeaders { get; set; }
        public string? ContentText { get; set; }
        public Guid? ContentTextFileId { get; set; }
        public DateTime? Deadline { get; set; }
        public int? Status { get; set; }
        public DateTime? DateSent { get; set; }
        public int? AttemptsCount { get; set; }
        public int? AttemptsMade { get; set; }
        public string? AttachmentsName { get; set; }
        public string? BodyContentType { get; set; }

        public virtual SysFile? ContentTextFile { get; set; }
        public virtual ICollection<SysSendingAttachment> SysSendingAttachments { get; set; }
    }
}
