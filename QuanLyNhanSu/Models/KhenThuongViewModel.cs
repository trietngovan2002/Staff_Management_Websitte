using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    public class KhenThuongViewModel
    {
        public List<string> Thang { get; set; }
        public List<int> SoLuongKhenThuong { get; set; }
        public List<int> SoLuongKyLuat { get; set; }
        public List<string> TenNhanVien { get; set; }
        public List<int?> SoTienThuong { get; set; }
    }
}