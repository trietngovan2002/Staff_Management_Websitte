namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KyLuat
    {
        [Key]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public string LyDo { get; set; }

        public DateTime ThangKiLuat { get; set; }

        public int? TienKyLuat { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
