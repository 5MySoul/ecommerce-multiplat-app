using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreKhachHang
    {
        public WcbcoreKhachHang()
        {
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreDonHangBanLes = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreGiaoDichVoiKhachHangs = new HashSet<WcbcoreGiaoDichVoiKhachHang>();
            WcbcorePhieuXuatKhos = new HashSet<WcbcorePhieuXuatKho>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string Ma { get; set; } = null!;
        public string? HoVaTen { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? GhiChu { get; set; }
        public Guid? TinhThanhId { get; set; }
        public string? TenTinhThanh { get; set; }
        public Guid? QuanHuyenId { get; set; }
        public string? TenQuanHuyen { get; set; }
        public Guid? XaPhuongId { get; set; }
        public string? TenXaPhuong { get; set; }

        public virtual WcbcoreQuanHuyen? QuanHuyen { get; set; }
        public virtual WcbcoreTinhThanh? TinhThanh { get; set; }
        public virtual WcbcoreXaPhuong? XaPhuong { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLes { get; set; }
        public virtual ICollection<WcbcoreGiaoDichVoiKhachHang> WcbcoreGiaoDichVoiKhachHangs { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhos { get; set; }
    }
}
