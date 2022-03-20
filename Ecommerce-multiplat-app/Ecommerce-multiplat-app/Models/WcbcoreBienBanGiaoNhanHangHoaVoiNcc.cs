using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreBienBanGiaoNhanHangHoaVoiNcc
    {
        public WcbcoreBienBanGiaoNhanHangHoaVoiNcc()
        {
            WcbcorePhieuBaoHanhCuaBbgns = new HashSet<WcbcorePhieuBaoHanhCuaBbgn>();
            WcbcoreSanPhamCuaBbgns = new HashSet<WcbcoreSanPhamCuaBbgn>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? NgayLap { get; set; }
        public Guid? NguoiLapId { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? ThoiGianCapNhat { get; set; }
        public Guid? TaiKhoanCapNhatId { get; set; }
        public string? NguoiCapNhat { get; set; }
        public string? Ma { get; set; }
        public string? NoiDung { get; set; }
        public Guid? NhaCungCapId { get; set; }
        public string? TenNhaCungCap { get; set; }
        public string? GhiChu { get; set; }
        public int? SoLuong { get; set; }

        public virtual SecUser? NguoiLap { get; set; }
        public virtual WcbcoreNhaCungCap? NhaCungCap { get; set; }
        public virtual SecUser? TaiKhoanCapNhat { get; set; }
        public virtual ICollection<WcbcorePhieuBaoHanhCuaBbgn> WcbcorePhieuBaoHanhCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaBbgn> WcbcoreSanPhamCuaBbgns { get; set; }
    }
}
