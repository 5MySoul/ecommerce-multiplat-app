using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreNhaCungCap
    {
        public WcbcoreNhaCungCap()
        {
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreBienBanGiaoNhanHangHoaVoiNccs = new HashSet<WcbcoreBienBanGiaoNhanHangHoaVoiNcc>();
            WcbcoreSanPhams = new HashSet<WcbcoreSanPham>();
            WcbcoreTiepNhanHangHoas = new HashSet<WcbcoreTiepNhanHangHoa>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public byte? HoatDong { get; set; }
        public string? MaLienKet { get; set; }
        public Guid? NhomId { get; set; }
        public string? TenNhom { get; set; }
        public string? MaSoThue { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public string? TenHienThi { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? NguoiDaiDien { get; set; }
        public Guid? ChucVuId { get; set; }
        public string? TenChucVu { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? NguoiLienHe { get; set; }

        public virtual WcbcoreChucVu? ChucVu { get; set; }
        public virtual WcbcoreNhomNcc? Nhom { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreBienBanGiaoNhanHangHoaVoiNcc> WcbcoreBienBanGiaoNhanHangHoaVoiNccs { get; set; }
        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhams { get; set; }
        public virtual ICollection<WcbcoreTiepNhanHangHoa> WcbcoreTiepNhanHangHoas { get; set; }
    }
}
