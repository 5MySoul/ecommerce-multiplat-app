using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreHangSanXuat
    {
        public WcbcoreHangSanXuat()
        {
            WcbcoreSanPhams = new HashSet<WcbcoreSanPham>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string Ten { get; set; } = null!;
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }
        public string? HinhAnh { get; set; }
        public string? SeoUrl { get; set; }

        public virtual ICollection<WcbcoreSanPham> WcbcoreSanPhams { get; set; }
    }
}
