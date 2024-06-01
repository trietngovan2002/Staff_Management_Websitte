using System.Web.Mvc;
using System.Web.Routing;
namespace QuanLyNhanSu.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {


            context.MapRoute(
                "admin_Quan Ly Luong",
                "admin/quan-ly-luong",
                new { controller = "QuanLyLuong", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_sua_luong",
                "admin/quan-ly-luong/sua-bang-luong",
                new { controller = "QuanLyLuong", action = "SuaBangLuong", id = UrlParameter.Optional }
            );
            context.MapRoute(
               "admin_ds_luong",
               "admin/quan-ly-luong/danh-sach-nhan-luong",
                new { controller = "QuanLyLuong", action = "DanhSachNhanLuong", id = UrlParameter.Optional }
           );

            context.MapRoute(
               "admin_tang_luong",
               "admin/quan-ly-luong/qua-trinh-tang-luong",
                new { controller = "QuanLyLuong", action = "QuaTrinhTangLuong", id = UrlParameter.Optional }
           );
            //================quan ly phong ban===========================================
            context.MapRoute(
                "admin_Quan Ly Phong Ban",
                "admin/quan-ly-phong-ban",
                new { controller = "QuanLyPhongBan", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_sua_phong_ban",
                "admin/quan-ly-phong-ban/sua-thong-tin-phong-ban",
                new { controller = "QuanLyPhongBan", action = "SuaPhongBan", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "admin_them_phong_ban",
                "admin/quan-ly-phong-ban/them-phong-ban",
                new { controller = "QuanLyPhongBan", action = "ThemPhongBan", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_nhan_vien_phong_ban",
                "admin/quan-ly-phong-ban/nhan-vien-phong-ban",
                new { controller = "QuanLyPhongBan", action = "DanhSachNhanVien", id = UrlParameter.Optional }
             );

            context.MapRoute(
                "admin_chuyen-nhan-vien",
                "admin/quan-ly-phong-ban/chuyen-nhan-vien",
                new { controller = "QuanLyPhongBan", action = "ChuyenNhanVien", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_phu-cap-chuc-vu",
                "admin/quan-ly-phong-ban/phu-cap-chuc-vu",
                new { controller = "QuanLyPhongBan", action = "CapNhatPhuCap", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_them-nhan-viev-phongban",
                "admin/quan-ly-phong-ban/them-nhan-vien-phongban",
                new { controller = "QuanLyPhongBan", action = "ThemUserPhongBan", id = UrlParameter.Optional }
            );

            //========================quan ly tai khoan=================================
            context.MapRoute(
                "admin_Quan Ly Tai Khoan",
                "admin/quan-ly-nhan-vien",
                new { controller = "QuanLyUser", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_sua-thong-tin",
                "admin/quan-ly-nhan-vien/sua-thong-tin",
                new { controller = "QuanLyUser", action = "UpdateUser", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_them-tai-khoan",
                "admin/quan-ly-nhan-vien/them-nhan-vien",
                new { controller = "QuanLyUser", action = "ThemUser", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "admin_qua-trinh-cong-tac",
                "admin/quan-ly-nhan-vien/qua-trinh-cong-tac",
                new { controller = "QuanLyUser", action = "QuaTrinhCongTac", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "admin_qua-trinh-hoc-tap",
                "admin/quan-ly-nhan-vien/qua-trinh-hoc-tap",
                new { controller = "QuanLyUser", action = "QuaTrinhHoc", id = UrlParameter.Optional }
            );

            //==========================default===================================
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}