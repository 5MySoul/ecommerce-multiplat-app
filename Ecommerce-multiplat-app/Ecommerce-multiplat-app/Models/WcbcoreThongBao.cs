using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreThongBao
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public byte? HoatDong { get; set; }
        public byte? NoiBat { get; set; }
        public byte? LienKetNgoai { get; set; }
        public int? SoThuTu { get; set; }
        public string? HinhAnh { get; set; }
        public string? TieuDe { get; set; }
        public string? TieuDeNn { get; set; }
        public string? MoTa { get; set; }
        public string? MoTaNn { get; set; }
        public string? NoiDung { get; set; }
        public string? NoiDungNn { get; set; }
        public string? TacGia { get; set; }
        public string? TuKhoa { get; set; }
        public string? GhiChu { get; set; }
        public int? SoLuongXem { get; set; }
        public int? SoLuongThich { get; set; }
        public int? SoLuongKhongThich { get; set; }
    }
}
