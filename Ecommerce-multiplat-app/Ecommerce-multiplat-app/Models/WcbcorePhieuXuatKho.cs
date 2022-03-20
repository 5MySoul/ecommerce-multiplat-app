using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcorePhieuXuatKho
    {
        public WcbcorePhieuXuatKho()
        {
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreGiaoDichVoiKhachHangs = new HashSet<WcbcoreGiaoDichVoiKhachHang>();
            WcbcoreSanPhamCuaPxks = new HashSet<WcbcoreSanPhamCuaPxk>();
        }

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
        public int? TrangThaiThanhToan { get; set; }
        public int? SoLuongSanPham { get; set; }
        public decimal? ChietKhau { get; set; }
        public decimal? ThueGtgt { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? TongTien { get; set; }
        public Guid? NguoiMuaTaiKhoanId { get; set; }
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
        public string? NguoiNhanHoTen { get; set; }
        public string? NguoiNhanDienThoai { get; set; }
        public string? NguoiNhanEmail { get; set; }
        public Guid? NguoiNhanTinhThanhId { get; set; }
        public string? NguoiNhanTenTinhThanh { get; set; }
        public Guid? NguoiNhanQuanHuyenId { get; set; }
        public string? NguoiNhanTenQuanHuyen { get; set; }
        public Guid? NguoiNhanXaPhuongId { get; set; }
        public string? NguoiNhanTenXaPhuong { get; set; }
        public string? NguoiNhanDiaChi { get; set; }
        public Guid? KhoHangId { get; set; }
        public DateTime? NgayKetChuyen { get; set; }
        public Guid? NguoiKetChuyenId { get; set; }
        public string? MoTaSanPham { get; set; }
        public Guid? KhachHangMuaId { get; set; }
        public Guid? PhuongThucVanChuyenId { get; set; }
        public Guid? DonViVanChuyenId { get; set; }
        public string? TenDonViVanChuyen { get; set; }
        public string? TenPhuongThucVanChuyen { get; set; }
        public string? TenKho { get; set; }

        public virtual WcbcoreDonHangBanLe? DonHangBanLe { get; set; }
        public virtual WcbcoreDonViVanChuyen? DonViVanChuyen { get; set; }
        public virtual WcbcoreKhachHang? KhachHangMua { get; set; }
        public virtual WcbcoreKhoHang? KhoHang { get; set; }
        public virtual SecUser? NguoiKetChuyen { get; set; }
        public virtual SecUser? NguoiLap { get; set; }
        public virtual WcbcoreQuanHuyen? NguoiMuaQuanHuyen { get; set; }
        public virtual SecUser? NguoiMuaTaiKhoan { get; set; }
        public virtual WcbcoreTinhThanh? NguoiMuaTinhThanh { get; set; }
        public virtual WcbcoreXaPhuong? NguoiMuaXaPhuong { get; set; }
        public virtual WcbcoreQuanHuyen? NguoiNhanQuanHuyen { get; set; }
        public virtual WcbcoreTinhThanh? NguoiNhanTinhThanh { get; set; }
        public virtual WcbcoreXaPhuong? NguoiNhanXaPhuong { get; set; }
        public virtual WcbcorePhuongThucVanChuyen? PhuongThucVanChuyen { get; set; }
        public virtual SecUser? TaiKhoanCapNhat { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreGiaoDichVoiKhachHang> WcbcoreGiaoDichVoiKhachHangs { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaPxk> WcbcoreSanPhamCuaPxks { get; set; }
    }
}
