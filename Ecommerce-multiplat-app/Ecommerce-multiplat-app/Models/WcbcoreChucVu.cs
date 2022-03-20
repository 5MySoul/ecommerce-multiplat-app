using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreChucVu
    {
        public WcbcoreChucVu()
        {
            WcbcoreNhaCungCaps = new HashSet<WcbcoreNhaCungCap>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string? Ten { get; set; }
        public string? MaLienKet { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<WcbcoreNhaCungCap> WcbcoreNhaCungCaps { get; set; }
    }
}
