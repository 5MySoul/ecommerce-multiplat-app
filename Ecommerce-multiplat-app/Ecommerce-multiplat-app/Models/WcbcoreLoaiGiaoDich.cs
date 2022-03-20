using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreLoaiGiaoDich
    {
        public WcbcoreLoaiGiaoDich()
        {
            WcbcoreGiaoDichVoiKhachHangs = new HashSet<WcbcoreGiaoDichVoiKhachHang>();
        }

        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public string Ten { get; set; } = null!;
        public string? GhiChu { get; set; }

        public virtual ICollection<WcbcoreGiaoDichVoiKhachHang> WcbcoreGiaoDichVoiKhachHangs { get; set; }
    }
}
