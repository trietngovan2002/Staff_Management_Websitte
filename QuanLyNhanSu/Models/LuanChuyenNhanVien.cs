namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LuanChuyenNhanVien
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        [Key]
        [Column(Order = 1)]
        public int id { get; set; }

        public DateTime NgayChuyen { get; set; }

        public string LyDoChuyen { get; set; }

        [StringLength(30)]
        public string PhongBanChuyen { get; set; }

        [StringLength(30)]
        public string PhongBanDen { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
