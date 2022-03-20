using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreSanPhamCuaSoDuDauKy
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public Guid? NhapSoDuDauKyId { get; set; }
        public Guid SanPhamId { get; set; }
        public string? MaSanPham { get; set; }
        public Guid? ThuocTinhSanPhamId { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? DonViTinhId { get; set; }
        public decimal SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public string? GhiChu { get; set; }

        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreNhapSoDuDauKy? NhapSoDuDauKy { get; set; }
        public virtual WcbcoreSanPham SanPham { get; set; } = null!;
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPham { get; set; }
    }
}
