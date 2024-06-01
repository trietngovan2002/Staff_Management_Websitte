using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Areas.admin.Controllers
{
    public class ChiTietLuongsController : Controller
    {
        private QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();

        // GET: admin/ChiTietLuongs
        public ActionResult DanhSachNhanLuong()
        {
            var chiTietLuongList = db.ChiTietLuongs.OrderBy(c => c.NgayNhanLuong).ToList();
            return View(chiTietLuongList);
        }

        // GET: admin/ChiTietLuongs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietLuong chiTietLuong = db.ChiTietLuongs.Find(id);
            if (chiTietLuong == null)
            {
                return HttpNotFound();
            }
            return View(chiTietLuong);
        }

        // GET: admin/ChiTietLuongs/Create
        public ActionResult Create()
        {
            ViewBag.MaNhanVien = new SelectList(db.Luongs, "MaNhanVien", "MaNhanVien");
            return View();
        }

        // POST: admin/ChiTietLuongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChiTietBangLuong,MaNhanVien,LuongCoBan,BHXH,BHYT,BHTN,PhuCap,ThueThuNhap,TienThuong,TienPhat,NgayNhanLuong,TongTienLuong")] ChiTietLuong chiTietLuong)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietLuongs.Add(chiTietLuong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhanVien = new SelectList(db.Luongs, "MaNhanVien", "MaNhanVien", chiTietLuong.MaNhanVien);
            return View(chiTietLuong);
        }

        // GET: admin/ChiTietLuongs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietLuong chiTietLuong = db.ChiTietLuongs.Find(id);
            if (chiTietLuong == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhanVien = new SelectList(db.Luongs, "MaNhanVien", "MaNhanVien", chiTietLuong.MaNhanVien);
            return View(chiTietLuong);
        }

        // POST: admin/ChiTietLuongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChiTietBangLuong,MaNhanVien,LuongCoBan,BHXH,BHYT,BHTN,PhuCap,ThueThuNhap,TienThuong,TienPhat,NgayNhanLuong,TongTienLuong")] ChiTietLuong chiTietLuong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietLuong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhanVien = new SelectList(db.Luongs, "MaNhanVien", "MaNhanVien", chiTietLuong.MaNhanVien);
            return View(chiTietLuong);
        }

        // GET: admin/ChiTietLuongs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietLuong chiTietLuong = db.ChiTietLuongs.Find(id);
            if (chiTietLuong == null)
            {
                return HttpNotFound();
            }
            return View(chiTietLuong);
        }

        // POST: admin/ChiTietLuongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChiTietLuong chiTietLuong = db.ChiTietLuongs.Find(id);
            db.ChiTietLuongs.Remove(chiTietLuong);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
