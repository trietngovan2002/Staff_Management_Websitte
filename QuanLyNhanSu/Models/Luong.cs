namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Luong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Luong()
        {
            CapNhatLuongs = new HashSet<CapNhatLuong>();
            ChiTietLuongs = new HashSet<ChiTietLuong>();
        }

        [Key]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public int LuongToiThieu { get; set; }

        public double? HeSoLuong { get; set; }

        public double? BHXH { get; set; }

        public double? BHYT { get; set; }

        public double? BHTN { get; set; }

        public double? PhuCap { get; set; }

        public double? ThueThuNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapNhatLuong> CapNhatLuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLuong> ChiTietLuongs { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
