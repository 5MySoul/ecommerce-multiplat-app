using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreNhapSoDuDauKy
    {
        public WcbcoreNhapSoDuDauKy()
        {
            WcbcoreSanPhamCuaSoDuDauKies = new HashSet<WcbcoreSanPhamCuaSoDuDauKy>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime NgayLap { get; set; }
        public int? TrangThai { get; set; }
        public Guid NguoiLapId { get; set; }
        public string? NoiDung { get; set; }
        public string? GhiChu { get; set; }
        public Guid? KhoHangId { get; set; }
        public DateTime? NgayKetChuyen { get; set; }
        public Guid? NguoiKetChuyenId { get; set; }
        public string? Ma { get; set; }
        public decimal? TongTien { get; set; }

        public virtual WcbcoreKhoHang? KhoHang { get; set; }
        public virtual SecUser? NguoiKetChuyen { get; set; }
        public virtual SecUser NguoiLap { get; set; } = null!;
        public virtual ICollection<WcbcoreSanPhamCuaSoDuDauKy> WcbcoreSanPhamCuaSoDuDauKies { get; set; }
    }
}
