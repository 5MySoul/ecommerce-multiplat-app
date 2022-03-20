using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreChuongTrinhKhuyenMai
    {
        public WcbcoreChuongTrinhKhuyenMai()
        {
            WcbcoreSanPhamCuaCckms = new HashSet<WcbcoreSanPhamCuaCckm>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime NgayLap { get; set; }
        public Guid NguoiLapId { get; set; }
        public byte? HoatDong { get; set; }
        public string? Ma { get; set; }
        public string Ten { get; set; } = null!;
        public DateTime BatDau { get; set; }
        public DateTime KetThuc { get; set; }
        public string? NoiDung { get; set; }
        public string? GhiChu { get; set; }

        public virtual SecUser NguoiLap { get; set; } = null!;
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckms { get; set; }
    }
}
