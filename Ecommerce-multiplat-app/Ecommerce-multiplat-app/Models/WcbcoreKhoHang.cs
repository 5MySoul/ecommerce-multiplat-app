using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreKhoHang
    {
        public WcbcoreKhoHang()
        {
            WcbcoreBieuGhiLuuTruTonKhos = new HashSet<WcbcoreBieuGhiLuuTruTonKho>();
            WcbcoreBieuGhiTonKhos = new HashSet<WcbcoreBieuGhiTonKho>();
            WcbcoreDonHangBanLes = new HashSet<WcbcoreDonHangBanLe>();
            WcbcoreNhapSoDuDauKies = new HashSet<WcbcoreNhapSoDuDauKy>();
            WcbcorePhieuXuatKhos = new HashSet<WcbcorePhieuXuatKho>();
            WcbcoreTiepNhanHangHoas = new HashSet<WcbcoreTiepNhanHangHoa>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public byte? HoatDong { get; set; }
        public byte? LaKhoMacDinh { get; set; }
        public string Ma { get; set; } = null!;
        public string Ten { get; set; } = null!;
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<WcbcoreBieuGhiLuuTruTonKho> WcbcoreBieuGhiLuuTruTonKhos { get; set; }
        public virtual ICollection<WcbcoreBieuGhiTonKho> WcbcoreBieuGhiTonKhos { get; set; }
        public virtual ICollection<WcbcoreDonHangBanLe> WcbcoreDonHangBanLes { get; set; }
        public virtual ICollection<WcbcoreNhapSoDuDauKy> WcbcoreNhapSoDuDauKies { get; set; }
        public virtual ICollection<WcbcorePhieuXuatKho> WcbcorePhieuXuatKhos { get; set; }
        public virtual ICollection<WcbcoreTiepNhanHangHoa> WcbcoreTiepNhanHangHoas { get; set; }
    }
}
