namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LuongA31GS
    {
        [Key]
        public int BacLuong { get; set; }

        public double? HeSo { get; set; }
    }
}
