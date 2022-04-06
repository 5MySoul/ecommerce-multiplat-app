using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreSanPham
    {
        public WcbcoreSanPham()
        {
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreBieuGhiLuuTruTonKhos = new HashSet<WcbcoreBieuGhiLuuTruTonKho>();
            WcbcoreBieuGhiTonKhos = new HashSet<WcbcoreBieuGhiTonKho>();
            WcbcorePhieuBaoHanhCuaBbgns = new HashSet<WcbcorePhieuBaoHanhCuaBbgn>();
            WcbcoreSanPhamCuaBbgns = new HashSet<WcbcoreSanPhamCuaBbgn>();
            WcbcoreSanPhamCuaCckmSanPhamKms = new HashSet<WcbcoreSanPhamCuaCckm>();
            WcbcoreSanPhamCuaCckmSanPhams = new HashSet<WcbcoreSanPhamCuaCckm>();
            WcbcoreSanPhamCuaDhbls = new HashSet<WcbcoreSanPhamCuaDhbl>();
            WcbcoreSanPhamCuaPxks = new HashSet<WcbcoreSanPhamCuaPxk>();
            WcbcoreSanPhamCuaSoDuDauKies = new HashSet<WcbcoreSanPhamCuaSoDuDauKy>();
            WcbcoreSanPhamCuaTiepNhanHangHoas = new HashSet<WcbcoreSanPhamCuaTiepNhanHangHoa>();
            WcbcoreSanPhamKmDhblSanPhamGocs = new HashSet<WcbcoreSanPhamKmDhbl>();
            WcbcoreSanPhamKmDhblSanPhams = new HashSet<WcbcoreSanPhamKmDhbl>();
            WcbcoreTepDinhKemSanPhams = new HashSet<WcbcoreTepDinhKemSanPham>();
            WcbcoreThuocTinhSanPhams = new HashSet<WcbcoreThuocTinhSanPham>();
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

        public WcbcoreNhomSanPham WcbcoreNhomSanPham { get; set; }

        public string? HinhAnh { get; set; }
        public string? HinhAnhKhac { get; set; }
        public string? TenNhom { get; set; }
        public Guid? NhomChinhId { get; set; }
        public string? TenNhomChinh { get; set; }
        public Guid? NhaCungCapId { get; set; }
        public string? TenNhaCungCap { get; set; }
        public string Ma { get; set; } = null!;
        public string? MaVach { get; set; }
        public string? Ten { get; set; }
        public string? TenHienThi { get; set; }
        public string? TenKhuyenMai { get; set; }
        public Guid? DonViTinhId { get; set; }
        public string? TenDonViTinh { get; set; }
        public Guid? DonViQuyDoi1Id { get; set; }
        public string? TenDonViQuyDoi1 { get; set; }
        public decimal? HeSoQuyDoi1 { get; set; }
        public Guid? DonViQuyDoi2Id { get; set; }
        public string? TenDonViQuyDoi2 { get; set; }
        public decimal? HeSoQuyDoi2 { get; set; }
        public decimal? SoLuongToiThieu { get; set; }
        public decimal? SoLuongToiDa { get; set; }
        public string? TenDonViCoSo { get; set; }
        public double? ThueGtgtBanLe { get; set; }
        public double? ThueTtdb { get; set; }
        public double? ThueMoiTruong { get; set; }
        public decimal? GiaBan { get; set; }
        public decimal? GiaMua { get; set; }
        public string? MoTa { get; set; }
        public string? NoiDung { get; set; }
        public byte? PhanLoaiTheoThuocTinh { get; set; }
        public string? GhiChu { get; set; }
        public Guid? HangSanXuatId { get; set; }
        public string? TenHangSanXuat { get; set; }
        public Guid? DonViCoSoId { get; set; }
        public int? ThoiGianBaoHanh { get; set; }
        public string? AnhHangSanXuat { get; set; }
        public string? SeoUrl { get; set; }
        public decimal? GiaTruocKm { get; set; }
        public int? SoLuongThich { get; set; }
        public int? SoLuongKhongThich { get; set; }
        public int? SoLuongXem { get; set; }

        public virtual WcbcoreDonViTinh? DonViCoSo { get; set; }
        public virtual WcbcoreDonViTinh? DonViQuyDoi1 { get; set; }
        public virtual WcbcoreDonViTinh? DonViQuyDoi2 { get; set; }
        public virtual WcbcoreDonViTinh? DonViTinh { get; set; }
        public virtual WcbcoreHangSanXuat? HangSanXuat { get; set; }
        public virtual WcbcoreNhaCungCap? NhaCungCap { get; set; }
        public virtual WcbcoreNhomSanPham? Nhom { get; set; }
        public virtual WcbcoreNhomSanPham? NhomChinh { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreBieuGhiLuuTruTonKho> WcbcoreBieuGhiLuuTruTonKhos { get; set; }
        public virtual ICollection<WcbcoreBieuGhiTonKho> WcbcoreBieuGhiTonKhos { get; set; }
        public virtual ICollection<WcbcorePhieuBaoHanhCuaBbgn> WcbcorePhieuBaoHanhCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaBbgn> WcbcoreSanPhamCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckmSanPhamKms { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckmSanPhams { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaDhbl> WcbcoreSanPhamCuaDhbls { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaPxk> WcbcoreSanPhamCuaPxks { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaSoDuDauKy> WcbcoreSanPhamCuaSoDuDauKies { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaTiepNhanHangHoa> WcbcoreSanPhamCuaTiepNhanHangHoas { get; set; }
        public virtual ICollection<WcbcoreSanPhamKmDhbl> WcbcoreSanPhamKmDhblSanPhamGocs { get; set; }
        public virtual ICollection<WcbcoreSanPhamKmDhbl> WcbcoreSanPhamKmDhblSanPhams { get; set; }
        public virtual ICollection<WcbcoreTepDinhKemSanPham> WcbcoreTepDinhKemSanPhams { get; set; }
        public virtual ICollection<WcbcoreThuocTinhSanPham> WcbcoreThuocTinhSanPhams { get; set; }
    }
}
