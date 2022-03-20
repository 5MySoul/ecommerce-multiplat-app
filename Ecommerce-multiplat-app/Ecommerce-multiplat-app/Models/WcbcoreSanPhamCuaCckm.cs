using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreSanPhamCuaCckm
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid? ChuongTrinhKhuyenMaiId { get; set; }
        public Guid SanPhamId { get; set; }
        public string? MaSanPham { get; set; }
        public Guid? ThuocTinhSanPhamId { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? DonViTinhId { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ChietKhau { get; set; }
        public string? GhiChu { get; set; }
        public byte? HoatDong { get; set; }
        public string? TenSanPhamKm { get; set; }
        public Guid? SanPhamKmId { get; set; }
        public DateTime? BatDau { get; set; }
        public Guid? ThuocTinhSanPhamKmId { get; set; }
        public DateTime? KetThuc { get; set; }
        public Guid? DonViTinhKmId { get; set; }
        public int? LoaiKhuyenMai { get; set; }
        public decimal? SoLuongToiThieu { get; set; }
        public decimal? SoLuongKm { get; set; }
        public string? MaSanPhamKm { get; set; }
        public string? TenDonViTinh { get; set; }

        public virtual WcbcoreChuongTrinhKhuyenMai? ChuongTrinhKhuyenMai { get; set; }
        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreDonViTinh? DonViTinhKm { get; set; }
        public virtual WcbcoreSanPham SanPham { get; set; } = null!;
        public virtual WcbcoreSanPham? SanPhamKm { get; set; }
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPham { get; set; }
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPhamKm { get; set; }
    }
}
