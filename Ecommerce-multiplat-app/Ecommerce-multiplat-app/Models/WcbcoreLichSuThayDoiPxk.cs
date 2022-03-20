using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreLichSuThayDoiPxk
    {
        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ThoiGian { get; set; }
        public Guid? TaiKhoanId { get; set; }
        public Guid? DonHangId { get; set; }
        public int? TrangThaiCu { get; set; }
        public int? TrangThaiMoi { get; set; }

        public virtual SecUser? TaiKhoan { get; set; }
    }
}
