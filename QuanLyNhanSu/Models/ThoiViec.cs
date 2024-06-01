namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThoiViec
    {
        [Key]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public string Lydo { get; set; }

        public DateTime NgayThoiViec { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
