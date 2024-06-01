namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SlideImage
    {
        public int id { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string src { get; set; }

        [Column(TypeName = "ntext")]
        public string alt { get; set; }

        [Column(TypeName = "ntext")]
        public string title { get; set; }

        public DateTime? create_date { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(1)]
        public string displayFlg { get; set; }
    }
}
