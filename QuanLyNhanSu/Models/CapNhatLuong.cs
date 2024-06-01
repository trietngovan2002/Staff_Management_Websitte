namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CapNhatLuong
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public int LuongHienTai { get; set; }

        public int LuongSauCapNhat { get; set; }

        public double? BHXH { get; set; }

        public double? BHYT { get; set; }

        public double? BHTN { get; set; }

        public double? PhuCap { get; set; }

        public double? ThueThuNhap { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public double? HeSoLuong { get; set; }

        public virtual Luong Luong { get; set; }
    }
}
