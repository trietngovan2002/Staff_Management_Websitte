namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhenThuong
    {
        //public KhenThuong() { 
        //    KTDetails = new HashSet<KhenThuongDetails>();
        //}

        [Key]
        [StringLength(30)]
        public string MaNhanVien { get; set; }

        public DateTime ThangThuong { get; set; }

        public string LyDo { get; set; }

        public int? TienThuong { get; set; }

        //public virtual ICollection<KhenThuongDetails> KTDetails { get; set; }

        public virtual NhanVien NhanVien { get; set; }
      
    }
}
