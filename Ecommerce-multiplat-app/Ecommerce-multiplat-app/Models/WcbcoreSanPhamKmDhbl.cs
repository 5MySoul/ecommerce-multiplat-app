using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreSanPhamKmDhbl
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid? DonHangBanLeId { get; set; }
        public Guid? DongDuLieuId { get; set; }
        public Guid? SanPhamGocId { get; set; }
        public Guid? ThuocTinhSanPhamGocId { get; set; }
        public Guid SanPhamId { get; set; }
        public string? MaSanPham { get; set; }
        public Guid? ThuocTinhSanPhamId { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? DonViTinhId { get; set; }
        public decimal SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThueGtgt { get; set; }
        public decimal? ChietKhau { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? TongTien { get; set; }
        public string? GhiChu { get; set; }
        public string? TenDonViTinh { get; set; }

        public virtual WcbcoreDonHangBanLe? DonHangBanLe { get; set; }
        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreSanPham SanPham { get; set; } = null!;
        public virtual WcbcoreSanPham? SanPhamGoc { get; set; }
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPham { get; set; }
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPhamGoc { get; set; }
    }
}
