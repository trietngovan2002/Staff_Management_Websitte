using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyNhanSu.Models
{
    public partial class QuanLyNhanSuEntities : DbContext
    {
        public QuanLyNhanSuEntities()
            : base("name=QuanLyNhanSuEntities")
        {
        }

        public virtual DbSet<CapNhatLuong> CapNhatLuongs { get; set; }
        public virtual DbSet<CapNhatTrinhDoHocVan> CapNhatTrinhDoHocVans { get; set; }
        public virtual DbSet<ChiTietLuong> ChiTietLuongs { get; set; }
        public virtual DbSet<ChucVuNhanVien> ChucVuNhanViens { get; set; }
        public virtual DbSet<ChuyenNganh> ChuyenNganhs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KyLuat> KyLuats { get; set; }
        public virtual DbSet<KhenThuong> KhenThuongs { get; set; }
        public virtual DbSet<LuanChuyenNhanVien> LuanChuyenNhanViens { get; set; }
        public virtual DbSet<LuongA1GV> LuongA1GV { get; set; }
        public virtual DbSet<LuongA21PGS> LuongA21PGS { get; set; }
        public virtual DbSet<LuongA31GS> LuongA31GS { get; set; }
        public virtual DbSet<Luong> Luongs { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<SlideImage> SlideImages { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThoiViec> ThoiViecs { get; set; }
        public virtual DbSet<TrinhDoHocVan> TrinhDoHocVans { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
     

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapNhatLuong>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CapNhatTrinhDoHocVan>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CapNhatTrinhDoHocVan>()
                .Property(e => e.MaTrinhDoTruoc)
                .IsUnicode(false);

            modelBuilder.Entity<CapNhatTrinhDoHocVan>()
                .Property(e => e.MaTrinhDoCapNhat)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLuong>()
                .Property(e => e.MaChiTietBangLuong)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLuong>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLuong>()
                .Property(e => e.TongTienLuong)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVuNhanVien>()
                .Property(e => e.MaChucVuNV)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenNganh>()
                .Property(e => e.MaChuyenNganh)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.MaHopDong)
                .IsUnicode(false);

            modelBuilder.Entity<HopDong>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.HopDong)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KyLuat>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<KhenThuong>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<LuanChuyenNhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<LuanChuyenNhanVien>()
                .Property(e => e.PhongBanChuyen)
                .IsUnicode(false);

            modelBuilder.Entity<LuanChuyenNhanVien>()
                .Property(e => e.PhongBanDen)
                .IsUnicode(false);

            modelBuilder.Entity<Luong>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sdt_NhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucVuNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaPhongBan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaHopDong)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChuyenNganh)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaTrinhDoHocVan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.KyLuat)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.KhenThuong)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.Luong)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.ThoiViec)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<PhongBan>()
                .Property(e => e.MaPhongBan)
                .IsUnicode(false);

            modelBuilder.Entity<PhongBan>()
                .Property(e => e.sdt_PhongBan)
                .IsUnicode(false);

            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.PhongBan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SlideImage>()
                .Property(e => e.displayFlg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThoiViec>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<TrinhDoHocVan>()
                .Property(e => e.MaTrinhDoHocVan)
                .IsUnicode(false);

            modelBuilder.Entity<UserRole>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
