using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreBaoHanh
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? NgayLap { get; set; }
        public Guid? NguoiLapId { get; set; }
        public int? TrangThai { get; set; }
        public DateTime? ThoiGianCapNhat { get; set; }
        public Guid? TaiKhoanCapNhatId { get; set; }
        public string? NguoiCapNhat { get; set; }
        public string? Ma { get; set; }
        public string? NoiDung { get; set; }
        public Guid? DonHangBanLeId { get; set; }
        public string? MoTaSanPham { get; set; }
        public decimal? PhiDichVu { get; set; }
        public Guid? KhachHangMuaId { get; set; }
        public string? NguoiMuaHoTen { get; set; }
        public string? NguoiMuaDienThoai { get; set; }
        public string? NguoiMuaEmail { get; set; }
        public Guid? NguoiMuaTinhThanhId { get; set; }
        public string? NguoiMuaTenTinhThanh { get; set; }
        public Guid? NguoiMuaQuanHuyenId { get; set; }
        public string? NguoiMuaTenQuanHuyen { get; set; }
        public Guid? NguoiMuaXaPhuongId { get; set; }
        public string? NguoiMuaTenXaPhuong { get; set; }
        public string? NguoiMuaDiaChi { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? NgayHenTra { get; set; }
        public Guid? ThuocTinhSanPhamId { get; set; }
        public string? TenSanPham { get; set; }
        public Guid? DuLieuXuatKhoId { get; set; }
        public decimal? SoLuong { get; set; }
        public Guid? SanPhamId { get; set; }
        public Guid? PhieuXuatKhoId { get; set; }
        public string? TenDonViTinh { get; set; }
        public DateTime? BaoHanh { get; set; }
        public DateTime? NgayMuaHang { get; set; }
        public Guid? DonViTinhId { get; set; }
        public string? TenNhaCungCap { get; set; }
        public Guid? NhaCungCapId { get; set; }
        public byte? DaBanGiaoNcc { get; set; }
        public string? BienBanBanGiao { get; set; }

        public virtual WcbcoreDonHangBanLe? DonHangBanLe { get; set; }
        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreSanPhamCuaPxk? DuLieuXuatKho { get; set; }
        public virtual WcbcoreKhachHang? KhachHangMua { get; set; }
        public virtual SecUser? NguoiLap { get; set; }
        public virtual WcbcoreQuanHuyen? NguoiMuaQuanHuyen { get; set; }
        public virtual WcbcoreTinhThanh? NguoiMuaTinhThanh { get; set; }
        public virtual WcbcoreXaPhuong? NguoiMuaXaPhuong { get; set; }
        public virtual WcbcoreNhaCungCap? NhaCungCap { get; set; }
        public virtual WcbcorePhieuXuatKho? PhieuXuatKho { get; set; }
        public virtual WcbcoreSanPham? SanPham { get; set; }
        public virtual SecUser? TaiKhoanCapNhat { get; set; }
        public virtual WcbcoreThuocTinhSanPham? ThuocTinhSanPham { get; set; }
        public virtual WcbcorePhieuBaoHanhCuaBbgn WcbcorePhieuBaoHanhCuaBbgn { get; set; } = null!;
    }
}
