using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Areas.admin.Controllers
{
    public class KyLuatController : Controller
    {
        private QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        // GET: admin/KyLuat
        public ActionResult Index()
        {
            var kyLuats = db.KyLuats.ToList();
            return View(kyLuats);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var nv = db.NhanViens.ToList();
            return View(new KyLuat());
        }
        [HttpPost]
        public ActionResult Create(KyLuat kl)
        {
            KyLuat ad = new KyLuat();
            ad.MaNhanVien = kl.MaNhanVien;
            ad.ThangKiLuat = kl.ThangKiLuat;
            ad.LyDo = kl.LyDo;
            ad.TienKyLuat = kl.TienKyLuat;

            var thangKiLuatM = kl.ThangKiLuat.Month;
            var thangKiLuatY = kl.ThangKiLuat.Year;


            var ct = db.ChiTietLuongs.Where(n => n.MaNhanVien == kl.MaNhanVien && n.NgayNhanLuong.Month == thangKiLuatM && n.NgayNhanLuong.Year == thangKiLuatY).FirstOrDefault();
            if (ct == null)
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

                int tienkyluatValue = kl.TienKyLuat ?? 0;

                int updatedTongTienLuong = currentTongTienLuong - tienkyluatValue;

                ct.TienPhat = (ct.TienPhat ?? 0) + tienkyluatValue;
                ct.TongTienLuong = updatedTongTienLuong.ToString();

                // Lưu thay đổi vào cơ sở dữ liệu
                db.Entry(ct).State = EntityState.Modified;
            }

            db.KyLuats.Add(ad);
            db.SaveChanges();
            return Redirect("/admin/KyLuat");
        }

        public ActionResult xoaKyLuat(String id)
        {
            var kl = db.KyLuats.Where(x => x.MaNhanVien == id).FirstOrDefault();

            //--Xoa ky luat
            var ct = db.ChiTietLuongs.Where(n => n.MaNhanVien == id).FirstOrDefault();
            int currentTongTienLuong = 0;
            if (!string.IsNullOrEmpty(ct.TongTienLuong))
            {
                int.TryParse(ct.TongTienLuong, out currentTongTienLuong);
            }

            int tienkyluatValue = kl.TienKyLuat ?? 0;

            int updatedTongTienLuong = currentTongTienLuong - tienkyluatValue;

            ct.TienPhat = 0;
            ct.TongTienLuong = updatedTongTienLuong.ToString();

            // Lưu thay đổi vào cơ sở dữ liệu
            db.Entry(ct).State = EntityState.Modified;
            ct.TienPhat = 0;

            db.KyLuats.Remove(kl);
            db.SaveChanges();
            return Redirect("~/admin/KyLuat");

        }
    }
}


