using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreThuocTinhSanPham
    {
        public WcbcoreThuocTinhSanPham()
        {
            WcbcoreBaoHanhs = new HashSet<WcbcoreBaoHanh>();
            WcbcoreBieuGhiLuuTruTonKhos = new HashSet<WcbcoreBieuGhiLuuTruTonKho>();
            WcbcoreBieuGhiTonKhos = new HashSet<WcbcoreBieuGhiTonKho>();
            WcbcorePhieuBaoHanhCuaBbgns = new HashSet<WcbcorePhieuBaoHanhCuaBbgn>();
            WcbcoreSanPhamCuaBbgns = new HashSet<WcbcoreSanPhamCuaBbgn>();
            WcbcoreSanPhamCuaCckmThuocTinhSanPhamKms = new HashSet<WcbcoreSanPhamCuaCckm>();
            WcbcoreSanPhamCuaCckmThuocTinhSanPhams = new HashSet<WcbcoreSanPhamCuaCckm>();
            WcbcoreSanPhamCuaDhbls = new HashSet<WcbcoreSanPhamCuaDhbl>();
            WcbcoreSanPhamCuaPxks = new HashSet<WcbcoreSanPhamCuaPxk>();
            WcbcoreSanPhamCuaSoDuDauKies = new HashSet<WcbcoreSanPhamCuaSoDuDauKy>();
            WcbcoreSanPhamCuaTiepNhanHangHoas = new HashSet<WcbcoreSanPhamCuaTiepNhanHangHoa>();
            WcbcoreSanPhamKmDhblThuocTinhSanPhamGocs = new HashSet<WcbcoreSanPhamKmDhbl>();
            WcbcoreSanPhamKmDhblThuocTinhSanPhams = new HashSet<WcbcoreSanPhamKmDhbl>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public int? SoThuTu { get; set; }
        public byte? HoatDong { get; set; }
        public string? MaLienKet { get; set; }
        public string? Ten { get; set; }
        public string? GhiChu { get; set; }
        public Guid? SanPhamId { get; set; }
        public decimal? DonGia { get; set; }

        public virtual WcbcoreSanPham? SanPham { get; set; }
        public virtual ICollection<WcbcoreBaoHanh> WcbcoreBaoHanhs { get; set; }
        public virtual ICollection<WcbcoreBieuGhiLuuTruTonKho> WcbcoreBieuGhiLuuTruTonKhos { get; set; }
        public virtual ICollection<WcbcoreBieuGhiTonKho> WcbcoreBieuGhiTonKhos { get; set; }
        public virtual ICollection<WcbcorePhieuBaoHanhCuaBbgn> WcbcorePhieuBaoHanhCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaBbgn> WcbcoreSanPhamCuaBbgns { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckmThuocTinhSanPhamKms { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaCckm> WcbcoreSanPhamCuaCckmThuocTinhSanPhams { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaDhbl> WcbcoreSanPhamCuaDhbls { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaPxk> WcbcoreSanPhamCuaPxks { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaSoDuDauKy> WcbcoreSanPhamCuaSoDuDauKies { get; set; }
        public virtual ICollection<WcbcoreSanPhamCuaTiepNhanHangHoa> WcbcoreSanPhamCuaTiepNhanHangHoas { get; set; }
        public virtual ICollection<WcbcoreSanPhamKmDhbl> WcbcoreSanPhamKmDhblThuocTinhSanPhamGocs { get; set; }
        public virtual ICollection<WcbcoreSanPhamKmDhbl> WcbcoreSanPhamKmDhblThuocTinhSanPhams { get; set; }
    }
}
