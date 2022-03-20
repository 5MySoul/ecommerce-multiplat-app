using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreTiepNhanHangHoa
    {
        public WcbcoreTiepNhanHangHoa()
        {
            WcbcoreSanPhamCuaTiepNhanHangHoas = new HashSet<WcbcoreSanPhamCuaTiepNhanHangHoa>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string? Ma { get; set; }
        public DateTime NgayLap { get; set; }
        public Guid NguoiLapId { get; set; }
        public Guid NguoiTiepNhanId { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? NgayKetChuyen { get; set; }
        public Guid? NguoiKetChuyenId { get; set; }
        public Guid NhaCungCapId { get; set; }
        public string? NguoiLienHe { get; set; }
        public string? ChungTuGoc { get; set; }
        public string? NoiDung { get; set; }
        public string? GhiChu { get; set; }
        public Guid KhoHangId { get; set; }
        public decimal? PhiVanChuyen { get; set; }
        public decimal? ChietKhau { get; set; }
        public decimal? ThueGtgt { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? TongTien { get; set; }

        public virtual WcbcoreKhoHang KhoHang { get; set; } = null!;
        public virtual SecUser? NguoiKetChuyen { get; set; }
        public virtual SecUser NguoiLap { get; set; } = null!;
        public virtual SecUser NguoiTiepNhan { get; set; } = null!;
        public virtual WcbcoreNhaCungCap NhaCungCap { get; set; } = null!;
        public virtual ICollection<WcbcoreSanPhamCuaTiepNhanHangHoa> WcbcoreSanPhamCuaTiepNhanHangHoas { get; set; }
    }
}
