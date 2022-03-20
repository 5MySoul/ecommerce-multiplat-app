using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreTinhThanh
    {
        public WcbcoreTinhThanh()
        {
            SecUsers = new HashSet<SecUser>();
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreDiaChiGiaoDiches = new HashSet<WcbcoreDiaChiGiaoDich>();
            WcbcoreDonHangBanLeNguoiMuaTinhThanhs = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreDonHangBanLeNguoiNhanTinhThanhs = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreKhachHangs = new HashSet<WcbcoreKhachHang>();
            WcbcorePhieuXuatKhoNguoiMuaTinhThanhs = new HashSet<WcbcorePhieuXuatKho>();
            WcbcorePhieuXuatKhoNguoiNhanTinhThanhs = new HashSet<WcbcorePhieuXuatKho>();
            WcbcoreQuanHuyens = new HashSet<WcbcoreQuanHuyen>();
            WcbcoreXaPhuongs = new HashSet<WcbcoreXaPhuong>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string? Ma { get; set; }
        public string? Prefix { get; set; }
        public string? Ten { get; set; }
        public string? TenDayDu { get; set; }
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<SecUser> SecUsers { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreDiaChiGiaoDich> WcbcoreDiaChiGiaoDiches { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiMuaTinhThanhs { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiNhanTinhThanhs { get; set; }
        public virtual ICollection<WcbcoreKhachHang> WcbcoreKhachHangs { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiMuaTinhThanhs { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiNhanTinhThanhs { get; set; }
        public virtual ICollection<WcbcoreQuanHuyen> WcbcoreQuanHuyens { get; set; }
        public virtual ICollection<WcbcoreXaPhuong> WcbcoreXaPhuongs { get; set; }
    }
}
