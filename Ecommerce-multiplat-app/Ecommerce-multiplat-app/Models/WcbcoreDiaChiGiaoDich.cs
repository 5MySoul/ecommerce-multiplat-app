using System;
using System.Collections.Generic;

namespace Ecommerce_multiplat_app.Models
{
    public partial class WcbcoreDiaChiGiaoDich
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTime? CreateTs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateTs { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? DeleteTs { get; set; }
        public string? DeletedBy { get; set; }
        public Guid? TaiKhoanId { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? Loai { get; set; }
        public string? HoTen { get; set; }
        public string? DienThoai { get; set; }
        public Guid? TinhThanhId { get; set; }
        public Guid? QuanHuyenId { get; set; }
        public Guid? XaPhuongId { get; set; }
        public string? TenXaPhuong { get; set; }
        public string? DiaChi { get; set; }
        public string? GhiChu { get; set; }

        public virtual WcbcoreQuanHuyen? QuanHuyen { get; set; }
        public virtual SecUser? TaiKhoan { get; set; }
        public virtual WcbcoreTinhThanh? TinhThanh { get; set; }
        public virtual WcbcoreXaPhuong? XaPhuong { get; set; }
    }
}
