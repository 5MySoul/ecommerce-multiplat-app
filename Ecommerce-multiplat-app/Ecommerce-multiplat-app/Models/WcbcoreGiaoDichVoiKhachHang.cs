using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreGiaoDichVoiKhachHang
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public Guid? LoaiId { get; set; }
        public string? TenLoai { get; set; }
        public Guid? DonHangId { get; set; }
        public string? MaDonHang { get; set; }
        public string? MaKhachHang { get; set; }
        public string? TenKhachHang { get; set; }
        public string? DienThoai { get; set; }
        public Guid? KhachHangId { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string? NoiDung { get; set; }
        public string? PhanHoi { get; set; }
        public string? GhiChu { get; set; }
        public Guid? NguoiLapId { get; set; }
        public string? MaPhieuXuatKho { get; set; }
        public DateTime? ThoiGianThucHien { get; set; }
        public string? NoiDungDonHang { get; set; }
        public int? TrangThai { get; set; }
        public Guid? NguoiThucHienId { get; set; }
        public Guid? PhieuXuatKhoId { get; set; }

        public virtual WcbcoreDonHangBanLe? DonHang { get; set; }
        public virtual WcbcoreKhachHang? KhachHang { get; set; }
        public virtual WcbcoreLoaiGiaoDich? Loai { get; set; }
        public virtual SecUser? NguoiLap { get; set; }
        public virtual SecUser? NguoiThucHien { get; set; }
        public virtual WcbcorePhieuXuatKho? PhieuXuatKho { get; set; }
    }
}
