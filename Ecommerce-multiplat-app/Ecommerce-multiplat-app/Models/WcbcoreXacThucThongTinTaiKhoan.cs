using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreXacThucThongTinTaiKhoan
    {
        public Guid Id { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public int Version { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public int? Loai { get; set; }
        public string? MaXacThuc { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public DateTime? ThoiGianHetHan { get; set; }
        public string? DuLieu { get; set; }
        public string? TaiKhoanId { get; set; }
        public int? TrangThai { get; set; }
        public int? SoLanXacThuc { get; set; }
        public DateTime? ThoiGianXacThuc { get; set; }
    }
}
