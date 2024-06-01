namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            CapNhatTrinhDoHocVans = new HashSet<CapNhatTrinhDoHocVan>();
            LuanChuyenNhanViens = new HashSet<LuanChuyenNhanVien>();
        }

        [Key]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string QueQuan { get; set; }

        public string HinhAnh { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(10)]
        public string DanToc { get; set; }

        [StringLength(11)]
        public string sdt_NhanVien { get; set; }

        [StringLength(30)]
        public string MaChucVuNV { get; set; }

        public bool TrangThai { get; set; }

        [StringLength(30)]
        public string MaPhongBan { get; set; }

        [StringLength(30)]
        public string MaHopDong { get; set; }

        [StringLength(30)]
        public string MaChuyenNganh { get; set; }

        [StringLength(30)]
        public string MaTrinhDoHocVan { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CapNhatTrinhDoHocVan> CapNhatTrinhDoHocVans { get; set; }

        public virtual ChucVuNhanVien ChucVuNhanVien { get; set; }

        public virtual ChuyenNganh ChuyenNganh { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual KyLuat KyLuat { get; set; }

        public virtual KhenThuong KhenThuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuanChuyenNhanVien> LuanChuyenNhanViens { get; set; }

        public virtual Luong Luong { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        public virtual ThoiViec ThoiViec { get; set; }

        public virtual TrinhDoHocVan TrinhDoHocVan { get; set; }
    }
}
