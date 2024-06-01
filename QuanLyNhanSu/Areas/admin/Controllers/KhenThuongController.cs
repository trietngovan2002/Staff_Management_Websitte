using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocumentFormat.OpenXml.Bibliography;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Areas.admin.Controllers
{
    public class KhenThuongController : Controller
    {

        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        //
        // GET: /admin/KhenThuong/
        public ActionResult Index()
        {
            var t = db.KhenThuongs.ToList();
            return View(t);
        }
        [HttpGet]
        public ActionResult khen()
        {
            var nv = db.NhanViens.ToList();

            return View(new KhenThuong());
        }
        [HttpPost]
        public ActionResult khen(KhenThuong kt)
        { 
            KhenThuong ad = new KhenThuong();
            ad.MaNhanVien = kt.MaNhanVien;
            ad.ThangThuong = kt.ThangThuong;
            ad.TienThuong = kt.TienThuong;
            ad.LyDo = kt.LyDo;
            //--Thêm tiền thưởng
            var thangThuongM = kt.ThangThuong.Month;
            var thangThuongY = kt.ThangThuong.Year;

           
            var ct = db.ChiTietLuongs.Where(n => n.MaNhanVien == kt.MaNhanVien && n.NgayNhanLuong.Month == kt.ThangThuong.Month && n.NgayNhanLuong.Year == kt.ThangThuong.Year).FirstOrDefault();
            if(ct == null )
            {
                ViewBag.error = "Tháng này chưa có lương";
            }
            else
            {
                int currentTongTienLuong = 0;
                if (!string.IsNullOrEmpty(ct.TongTienLuong))
                {
                    int.TryParse(ct.TongTienLuong, out currentTongTienLuong);
                }

                int tienthuongValue = kt.TienThuong ?? 0; 
               
                int updatedTongTienLuong = currentTongTienLuong + tienthuongValue;
            
                ct.TienThuong = (ct.TienThuong ?? 0) + tienthuongValue;
                ct.TongTienLuong = updatedTongTienLuong.ToString();

                // Lưu thay đổi vào cơ sở dữ liệu
                db.Entry(ct).State = EntityState.Modified;
            }
            

            db.KhenThuongs.Add(ad);
            db.SaveChanges();
            return Redirect("/admin/KhenThuong");
        }

        public ActionResult xoaKhenThuong(String id)
        {
            var kt = db.KhenThuongs.Where(x => x.MaNhanVien == id).FirstOrDefault();
            
            //--Xoa tien thuong 
            var ct = db.ChiTietLuongs.Where(n => n.MaNhanVien == id).FirstOrDefault();

            if (ct == null)
            {
                ViewBag.error = "Không tìm thấy thông tin chi tiết lương.";
                return Redirect("~/admin/KhenThuong");
            }

            int currentTongTienLuong = 0;
            if (!string.IsNullOrEmpty(ct.TongTienLuong))
            {
                int.TryParse(ct.TongTienLuong, out currentTongTienLuong);
            }

            int tienthuongValue = kt.TienThuong ?? 0;
            int updatedTongTienLuong = currentTongTienLuong - tienthuongValue;

            // Đặt TienThuong về 0
            ct.TienThuong = 0;
            ct.TongTienLuong = updatedTongTienLuong.ToString();

            // Lưu thay đổi vào cơ sở dữ liệu
            db.Entry(ct).State = EntityState.Modified;
            //
            db.KhenThuongs.Remove(kt);
            db.SaveChanges();
            return Redirect("~/admin/KhenThuong");

        }
        public ActionResult KhenThuongChart()
        {
            var khenThuongData = db.KhenThuongs
                 .GroupBy(k => new { k.ThangThuong.Year, k.ThangThuong.Month })
                 .Select(g => new
                 {
                     Thang = g.Key.Month + "/" + g.Key.Year,
                     SoLuongKhenThuong = g.Count(),
                 })
                 .OrderBy(x => x.Thang)
                 .ToList();

            var kyLuatData = db.KyLuats
                .GroupBy(k => new { k.ThangKiLuat.Year, k.ThangKiLuat.Month })
                .Select(g => new
                {
                    Thang = g.Key.Month + "/" + g.Key.Year,
                    SoLuongKyLuat = g.Count(),
                })
                .OrderBy(x => x.Thang)
                .ToList();

            var allMonths = khenThuongData.Select(x => x.Thang)
                .Union(kyLuatData.Select(x => x.Thang))
                .Where(x => !string.IsNullOrEmpty(x)) // Lọc bỏ các chuỗi rỗng
                .OrderBy(x =>
                {
                    DateTime dateTime;
                    if (DateTime.TryParseExact(x, "mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                    {
                        return dateTime;
                    }
                    return DateTime.MinValue; // Trả về giá trị mặc định nếu không thể chuyển đổi
                })
                .ToList();

            var viewModel = new KhenThuongViewModel
            {
                Thang = allMonths,
                SoLuongKhenThuong = new List<int>(),
                SoLuongKyLuat = new List<int>()
            };

            foreach (var month in allMonths)
            {
                var khenThuongCount = khenThuongData.FirstOrDefault(x => x.Thang == month)?.SoLuongKhenThuong ?? 0;
                var kyLuatCount = kyLuatData.FirstOrDefault(x => x.Thang == month)?.SoLuongKyLuat ?? 0;

                viewModel.SoLuongKhenThuong.Add(khenThuongCount);
                viewModel.SoLuongKyLuat.Add(kyLuatCount);
            }

            return View(viewModel);
        }


    }
}
