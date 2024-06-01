namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CapNhatTrinhDoHocVan
    {
        [Key]
        public int MaCapNhat { get; set; }

        [Required]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public DateTime NgayCapNhat { get; set; }

        [Required]
        [StringLength(30)]
        public string MaTrinhDoTruoc { get; set; }

        [Required]
        [StringLength(30)]
        public string MaTrinhDoCapNhat { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
