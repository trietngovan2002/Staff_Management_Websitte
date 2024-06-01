namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class news
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        public string contens { get; set; }

        [StringLength(128)]
        public string image { get; set; }

        public bool? is_active { get; set; }

        public int? reg_staff_id { get; set; }

        public int? update_staff_id { get; set; }

        public DateTime? create_date { get; set; }

        public DateTime? update_date { get; set; }
    }
}
