using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreTepDinhKemSanPham
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public int? ThuTu { get; set; }
        public string? TenTep { get; set; }
        public long? DungLuong { get; set; }
        public string? DuongDan { get; set; }
        public string? MoTa { get; set; }
        public string? GhiChu { get; set; }
        public string? LienKet { get; set; }
        public Guid? SanPhamId { get; set; }

        public virtual WcbcoreSanPham? SanPham { get; set; }
    }
}
