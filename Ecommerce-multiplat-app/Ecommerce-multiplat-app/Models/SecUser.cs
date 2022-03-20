using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class SecUser
    {
        public SecUser()
        {
            ReportExecutions = new HashSet<ReportExecution>();
            SecEntityLogs = new HashSet<SecEntityLog>();
            SecFilters = new HashSet<SecFilter>();
            SecPresentations = new HashSet<SecPresentation>();
            SecRememberMes = new HashSet<SecRememberMe>();
            SecScreenHistorySubstitutedUsers = new HashSet<SecScreenHistory>();
            SecScreenHistoryUsers = new HashSet<SecScreenHistory>();
            SecSearchFolders = new HashSet<SecSearchFolder>();
            SecSessionLogSubstitutedUsers = new HashSet<SecSessionLog>();
            SecSessionLogUsers = new HashSet<SecSessionLog>();
            SecUserRoles = new HashSet<SecUserRole>();
            SecUserSettings = new HashSet<SecUserSetting>();
            SecUserSubstitutionSubstitutedUsers = new HashSet<SecUserSubstitution>();
            SecUserSubstitutionUsers = new HashSet<SecUserSubstitution>();
            SysEntitySnapshots = new HashSet<SysEntitySnapshot>();
            WcbcoreBaoHanhNguoiLaps = new HashSet<WcbcoreBaoHanh>();
            WcbcoreBaoHanhTaiKhoanCapNhats = new HashSet<WcbcoreBaoHanh>();
            WcbcoreBienBanGiaoNhanHangHoaVoiNccNguoiLaps = new HashSet<WcbcoreBienBanGiaoNhanHangHoaVoiNcc>();
            WcbcoreBienBanGiaoNhanHangHoaVoiNccTaiKhoanCapNhats = new HashSet<WcbcoreBienBanGiaoNhanHangHoaVoiNcc>();
            WcbcoreChuongTrinhKhuyenMais = new HashSet<WcbcoreChuongTrinhKhuyenMai>();
            WcbcoreDiaChiGiaoDiches = new HashSet<WcbcoreDiaChiGiaoDich>();
            WcbcoreDonHangBanLeNguoiLaps = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreDonHangBanLeNguoiMuaTaiKhoans = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreDonHangBanLeTaiKhoanCapNhat2s = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreDonHangBanLeTaiKhoanCapNhats = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreGiaoDichVoiKhachHangNguoiLaps = new HashSet<WcbcoreGiaoDichVoiKhachHang>();
            WcbcoreGiaoDichVoiKhachHangNguoiThucHiens = new HashSet<WcbcoreGiaoDichVoiKhachHang>();
            WcbcoreLichSuThayDoiPxks = new HashSet<WcbcoreLichSuThayDoiPxk>();
            WcbcoreLichSuThayDoiTrangThaiDhbls = new HashSet<WcbcoreLichSuThayDoiTrangThaiDhbl>();
            WcbcoreNhapSoDuDauKyNguoiKetChuyens = new HashSet<WcbcoreNhapSoDuDauKy>();
            WcbcoreNhapSoDuDauKyNguoiLaps = new HashSet<WcbcoreNhapSoDuDauKy>();
            WcbcorePhieuXuatKhoNguoiKetChuyens = new HashSet<WcbcorePhieuXuatKho>();
            WcbcorePhieuXuatKhoNguoiLaps = new HashSet<WcbcorePhieuXuatKho>();
            WcbcorePhieuXuatKhoNguoiMuaTaiKhoans = new HashSet<WcbcorePhieuXuatKho>();
            WcbcorePhieuXuatKhoTaiKhoanCapNhats = new HashSet<WcbcorePhieuXuatKho>();
            WcbcoreTiepNhanHangHoaNguoiKetChuyens = new HashSet<WcbcoreTiepNhanHangHoa>();
            WcbcoreTiepNhanHangHoaNguoiLaps = new HashSet<WcbcoreTiepNhanHangHoa>();
            WcbcoreTiepNhanHangHoaNguoiTiepNhans = new HashSet<WcbcoreTiepNhanHangHoa>();
        }

        public Guid Id { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public string? SysTenantId { get; set; }
        public string Login { get; set; } = null!;
        public string LoginLc { get; set; } = null!;
        public string? Password { get; set; }
        public string? PasswordEncryption { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Position { get; set; }
        public string? Email { get; set; }
        public string? Language { get; set; }
        public string? TimeZone { get; set; }
        public byte? TimeZoneAuto { get; set; }
        public byte? Active { get; set; }
        public Guid? GroupId { get; set; }
        public string? GroupNames { get; set; }
        public string? IpMask { get; set; }
        public byte? ChangePasswordAtLogon { get; set; }
        public int LoaiTaiKhoan { get; set; }
        public string? GioiTinh { get; set; }
        public string? DienThoai { get; set; }
        public byte? LaQuanTriHeThong { get; set; }
        public string MaTaiKhoan { get; set; } = null!;
        public string? HinhAnh { get; set; }
        public string? GhiChu { get; set; }
        public byte? XacThucSoDienThoai { get; set; }
        public byte? XacThucEmail { get; set; }
        public string? NgaySinh { get; set; }
        public string? SoGiayToTuyThan { get; set; }
        public int? LoaiGiayToTuyThan { get; set; }
        public string? SoTaiKhoanNganHang { get; set; }
        public string? TenTaiKhoanNganHang { get; set; }
        public string? TenNganHang { get; set; }
        public string? FacebookId { get; set; }
        public int? TrangThai { get; set; }
        public string? NguoiXacThuc { get; set; }
        public DateTime? ThoiGianXacThuc { get; set; }
        public string? NoiDungXacThuc { get; set; }
        public string? MaSoThue { get; set; }
        public string? AnhCmnd { get; set; }
        public string? HinhAnhKhac { get; set; }
        public string? DiaChi { get; set; }
        public string? Website { get; set; }
        public string? GioiThieu { get; set; }
        public string? Fanpage { get; set; }
        public string? Youtube { get; set; }
        public string? Dtype { get; set; }
        public string? VaiTro { get; set; }
        public Guid? TinhThanhId { get; set; }
        public Guid? XaPhuongId { get; set; }
        public Guid? QuanHuyenId { get; set; }

        public virtual SecGroup? Group { get; set; }
        public virtual WcbcoreQuanHuyen? QuanHuyen { get; set; }
        public virtual WcbcoreTinhThanh? TinhThanh { get; set; }
        public virtual WcbcoreXaPhuong? XaPhuong { get; set; }
        public virtual ICollection<ReportExecution> ReportExecutions { get; set; }
        public virtual ICollection<SecEntityLog> SecEntityLogs { get; set; }
        public virtual ICollection<SecFilter> SecFilters { get; set; }
        public virtual ICollection<SecPresentation> SecPresentations { get; set; }
        public virtual ICollection<SecRememberMe> SecRememberMes { get; set; }
        public virtual ICollection<SecScreenHistory> SecScreenHistorySubstitutedUsers { get; set; }
        public virtual ICollection<SecScreenHistory> SecScreenHistoryUsers { get; set; }
        public virtual ICollection<SecSearchFolder> SecSearchFolders { get; set; }
        public virtual ICollection<SecSessionLog> SecSessionLogSubstitutedUsers { get; set; }
        public virtual ICollection<SecSessionLog> SecSessionLogUsers { get; set; }
        public virtual ICollection<SecUserRole> SecUserRoles { get; set; }
        public virtual ICollection<SecUserSetting> SecUserSettings { get; set; }
        public virtual ICollection<SecUserSubstitution> SecUserSubstitutionSubstitutedUsers { get; set; }
        public virtual ICollection<SecUserSubstitution> SecUserSubstitutionUsers { get; set; }
        public virtual ICollection<SysEntitySnapshot> SysEntitySnapshots { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhNguoiLaps { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhTaiKhoanCapNhats { get; set; }
        public virtual ICollection<WcbcoreBienBanGiaoNhanHangHoaVoiNcc> WcbcoreBienBanGiaoNhanHangHoaVoiNccNguoiLaps { get; set; }
        public virtual ICollection<WcbcoreBienBanGiaoNhanHangHoaVoiNcc> WcbcoreBienBanGiaoNhanHangHoaVoiNccTaiKhoanCapNhats { get; set; }
        public virtual ICollection<WcbcoreChuongTrinhKhuyenMai> WcbcoreChuongTrinhKhuyenMais { get; set; }
        public virtual ICollection<WcbcoreDiaChiGiaoDich> WcbcoreDiaChiGiaoDiches { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiLaps { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeNguoiMuaTaiKhoans { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeTaiKhoanCapNhat2s { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLeTaiKhoanCapNhats { get; set; }
        public virtual ICollection<WcbcoreGiaoDichVoiKhachHang> WcbcoreGiaoDichVoiKhachHangNguoiLaps { get; set; }
        public virtual ICollection<WcbcoreGiaoDichVoiKhachHang> WcbcoreGiaoDichVoiKhachHangNguoiThucHiens { get; set; }
        public virtual ICollection<WcbcoreLichSuThayDoiPxk> WcbcoreLichSuThayDoiPxks { get; set; }
        public virtual ICollection<WcbcoreLichSuThayDoiTrangThaiDhbl> WcbcoreLichSuThayDoiTrangThaiDhbls { get; set; }
        public virtual ICollection<WcbcoreNhapSoDuDauKy> WcbcoreNhapSoDuDauKyNguoiKetChuyens { get; set; }
        public virtual ICollection<WcbcoreNhapSoDuDauKy> WcbcoreNhapSoDuDauKyNguoiLaps { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiKetChuyens { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiLaps { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoNguoiMuaTaiKhoans { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhoTaiKhoanCapNhats { get; set; }
        public virtual ICollection<WcbcoreTiepNhanHangHoa> WcbcoreTiepNhanHangHoaNguoiKetChuyens { get; set; }
        public virtual ICollection<WcbcoreTiepNhanHangHoa> WcbcoreTiepNhanHangHoaNguoiLaps { get; set; }
        public virtual ICollection<WcbcoreTiepNhanHangHoa> WcbcoreTiepNhanHangHoaNguoiTiepNhans { get; set; }
    }
}
