using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    public class UserValidate
    {
        [Required(ErrorMessage = "Nhập mã giáo viên")]
        [RegularExpression(@"[A-Za-z0-9]*$", ErrorMessage = "Tài khoản chứa kí tự đặc biệt")]
        [MaxLength(30, ErrorMessage = "Vượt quá số kí tự 30")]
        public string MaNhanVien { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Nhập mật khẩu")]
        [MaxLength(20, ErrorMessage = "Vượt quá số kí tự 20")]
        public string MatKhau { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Nhập xác nhận mật khẩu")]
        [MaxLength(20, ErrorMessage = "Vượt quá số kí tự 20")]
        [Compare("MatKhau", ErrorMessage = "Xác nhận không khớp")]
        public string XacNhanMatKhau { get; set; }

        [MaxLength(50, ErrorMessage = "Vượt quá số kí tự 50")]
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public string DanToc { get; set; }

        [MaxLength(10, ErrorMessage = "Tối đa 10 số")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "Chỉ nhập số")]
        public string sdt_NhanVien { get; set; }
        public string MaChucVuNV { get; set; }
        public bool TrangThai { get; set; }
        public string MaPhongBan { get; set; }
        public string MaHopDong { get; set; }
        public string MaChuyenNganh { get; set; }
        public string MaTrinhDoHocVan { get; set; }

        [RegularExpression(@"[A-Za-z0-9]*$", ErrorMessage = "Chứa kí tự đặc biệt")]
        [MaxLength(12, ErrorMessage = "Tối đa 12 số")]
        public string CMND { get; set; }
    }
}