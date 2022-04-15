using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreNhomSanPham
    {
        public WcbcoreNhomSanPham()
        {
            InverseLopTren = new HashSet<WcbcoreNhomSanPham>();
            WcbcoreSanPhamNhomChinhs = new HashSet<WcbcoreSanPham>();
            WcbcoreSanPhamNhoms = new HashSet<WcbcoreSanPham>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public byte? HoatDong { get; set; }
        public Guid? LopTrenId { get; set; }
        public string? TenLopTren { get; set; }
        public int? SoThuTu { get; set; }
        public string Ten { get; set; } = null!;
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }
        public string? TenDayDu { get; set; }
        public string? TagId { get; set; }
        public byte? HienThiTrenTrangChu { get; set; }
        public string? SeoUrl { get; set; }
        public string? HinhAnh { get; set; }

        public virtual WcbcoreNhomSanPham? LopTren { get; set; }
        [JsonIgnore]
        public virtual ICollection<WcbcoreNhomSanPham> InverseLopTren { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhamNhomChinhs { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhamNhoms { get; set; }
    }
}
