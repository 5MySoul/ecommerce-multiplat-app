using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreNhomTinTuc
    {
        public WcbcoreNhomTinTuc()
        {
            InverseLopTren = new HashSet<WcbcoreNhomTinTuc>();
            WcbcoreTinTucs = new HashSet<WcbcoreTinTuc>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid? LopTrenId { get; set; }
        public byte? HoatDong { get; set; }
        public int? SoThuTu { get; set; }
        public byte? DuaVaoMenuTinTuc { get; set; }
        public string? Ten { get; set; }
        public string? TenNn { get; set; }
        public string? TenDayDu { get; set; }
        public string? TenDayDuNn { get; set; }
        public string? MoTa { get; set; }
        public string? MoTaNn { get; set; }
        public string? GhiChu { get; set; }

        public virtual WcbcoreNhomTinTuc? LopTren { get; set; }
        public virtual ICollection<WcbcoreNhomTinTuc> InverseLopTren { get; set; }
        public virtual ICollection<WcbcoreTinTuc> WcbcoreTinTucs { get; set; }
    }
}
