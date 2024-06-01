namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChiTietLuong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MaChiTietBangLuong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public double LuongCoBan { get; set; }

        public double? BHXH { get; set; }

        public double? BHYT { get; set; }

        public double? BHTN { get; set; }

        public double? PhuCap { get; set; }

        public double? ThueThuNhap { get; set; }

        public int? TienThuong { get; set; }

        public int? TienPhat { get; set; }

        public DateTime NgayNhanLuong { get; set; }

        [StringLength(30)]
        public string TongTienLuong { get; set; }

        public virtual Luong Luong { get; set; }
    }
}
