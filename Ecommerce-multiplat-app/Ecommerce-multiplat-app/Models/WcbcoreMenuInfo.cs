using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreMenuInfo
    {
        public WcbcoreMenuInfo()
        {
            InverseLopTren = new HashSet<WcbcoreMenuInfo>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public Guid? LopTrenId { get; set; }
        public string? LoaiMenu { get; set; }
        public byte? HoatDong { get; set; }
        public string? ThamSoLienKet { get; set; }
        public int? SoThuTu { get; set; }
        public string? HinhAnh { get; set; }
        public string? TieuDe { get; set; }
        public string? TieuDeNn { get; set; }
        public string? MoTa { get; set; }
        public string? MoTaNn { get; set; }
        public string? NoiDung { get; set; }
        public string? NoiDungNn { get; set; }
        public string? GhiChu { get; set; }
        public int? SoLuongXem { get; set; }
        public int? SoLuongThich { get; set; }
        public int? SoLuongKhongThich { get; set; }

        public virtual WcbcoreMenuInfo? LopTren { get; set; }
        public virtual ICollection<WcbcoreMenuInfo> InverseLopTren { get; set; }
    }
}
