using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreXaPhuong
    {
        public WcbcoreXaPhuong()
        {
            SecUsers = new HashSet<SecUser>();
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreDiaChiGiaoDiches = new HashSet<WcbcoreDiaChiGiaoDich>();
            WcbcoreDonHangBanLeNguoiMuaXaPhuongs = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreDonHangBanLeNguoiNhanXaPhuongs = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreKhachHangs = new HashSet<WcbcoreKhachHang>();
            WcbcorePhieuXuatKhoNguoiMuaXaPhuongs = new HashSet<WcbcorePhieuXuatKho>();
            WcbcorePhieuXuatKhoNguoiNhanXaPhuongs = new HashSet<WcbcorePhieuXuatKho>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid? TinhThanhId { get; set; }
        public Guid? QuanHuyenId { get; set; }
        public string? Ma { get; set; }
        public string? Prefix { get; set; }
        public string? Ten { get; set; }
        public string? TenDayDu { get; set; }
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }

        public virtual WcbcoreQuanHuyen? QuanHuyen { get; set; }
        public virtual WcbcoreTinhThanh? TinhThanh { get; set; }
        public virtual ICollection<SecUser> SecUsers { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreDiaChiGiaoDich> WcbcoreDiaChiGiaoDiches { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiMuaXaPhuongs { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiNhanXaPhuongs { get; set; }
        public virtual ICollection<WcbcoreKhachHang> WcbcoreKhachHangs { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiMuaXaPhuongs { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiNhanXaPhuongs { get; set; }
    }
}
