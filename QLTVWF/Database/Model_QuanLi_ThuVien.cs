using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTVWF.Database
{
    public partial class Model_QuanLi_ThuVien : DbContext
    {
        public Model_QuanLi_ThuVien()
            : base("name=Model_QuanLi_ThuVien_MTA")
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CuonSach> CuonSaches { get; set; }
        public virtual DbSet<DauSach> DauSaches { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<MuonTra> MuonTras { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SangTac> SangTacs { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }
        public virtual DbSet<TaiKhoanDG> TaiKhoanDGs { get; set; }
        public virtual DbSet<TaiKhoanNV> TaiKhoanNVs { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TheLoaiDauSach> TheLoaiDauSaches { get; set; }
        public virtual DbSet<ViTriSach> ViTriSaches { get; set; }
        public virtual DbSet<XuLyViPham> XuLyViPhams { get; set; }
        public virtual DbSet<SoSachMuon> SoSachMuons { get; set; }
        public virtual DbSet<TacGia_DauSach> TacGia_DauSach { get; set; }
        public virtual DbSet<TaiLieuMuonTra> TaiLieuMuonTras { get; set; }
        public virtual DbSet<TanXuatMuon> TanXuatMuons { get; set; }
        public virtual DbSet<TheLoai_DauSach> TheLoai_DauSach { get; set; }
        public virtual DbSet<ThongTinCuonSach> ThongTinCuonSaches { get; set; }
        public virtual DbSet<ThongTinDauSach> ThongTinDauSaches { get; set; }
        public virtual DbSet<ThongTinDocGia> ThongTinDocGias { get; set; }
        public virtual DbSet<ThongTinMuonTra> ThongTinMuonTras { get; set; }
        public virtual DbSet<ThongTinNhanVien> ThongTinNhanViens { get; set; }
        public virtual DbSet<ThongTinNopPhat> ThongTinNopPhats { get; set; }
        public virtual DbSet<ViPham> ViPhams { get; set; }
        public virtual DbSet<ViPhamCaNhan> ViPhamCaNhans { get; set; }
        public virtual DbSet<XuLyViPham1> XuLyViPham1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CuonSach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<CuonSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<CuonSach>()
                .Property(e => e.MaViTri)
                .IsUnicode(false);

            modelBuilder.Entity<CuonSach>()
                .HasMany(e => e.MuonTras)
                .WithRequired(e => e.CuonSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DauSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<DauSach>()
                .Property(e => e.GiaTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.SangTacs)
                .WithRequired(e => e.DauSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.TheLoaiDauSaches)
                .WithRequired(e => e.DauSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.MuonTras)
                .WithRequired(e => e.DocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocGia>()
                .HasOptional(e => e.TaiKhoanDG)
                .WithRequired(e => e.DocGia);

            modelBuilder.Entity<MuonTra>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<MuonTra>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<MuonTra>()
                .Property(e => e.MaNVmuon)
                .IsUnicode(false);

            modelBuilder.Entity<MuonTra>()
                .Property(e => e.MaNVtra)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.MuonTras)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaNVmuon);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.MuonTras1)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.MaNVtra);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.TaiKhoanNV)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<SangTac>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<SangTac>()
                .Property(e => e.MaTacGia)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.MaTacGia)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.SangTacs)
                .WithRequired(e => e.TacGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanDG>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanDG>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanDG>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNV>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.TheLoaiDauSaches)
                .WithRequired(e => e.TheLoai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheLoaiDauSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoaiDauSach>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<ViTriSach>()
                .Property(e => e.MaViTri)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham>()
                .Property(e => e.MaXuLy)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham>()
                .Property(e => e.TienPhat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SoSachMuon>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia_DauSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia_DauSach>()
                .Property(e => e.MaTacGia)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieuMuonTra>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieuMuonTra>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieuMuonTra>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<TanXuatMuon>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai_DauSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai_DauSach>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinCuonSach>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinCuonSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDauSach>()
                .Property(e => e.MaDauSach)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDauSach>()
                .Property(e => e.GiaTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThongTinDocGia>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDocGia>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinMuonTra>()
                .Property(e => e.MaSach)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinMuonTra>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinMuonTra>()
                .Property(e => e.MaNVmuon)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinMuonTra>()
                .Property(e => e.MaNVtra)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNopPhat>()
                .Property(e => e.MaXuLy)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNopPhat>()
                .Property(e => e.TienPhat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ViPham>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<ViPhamCaNhan>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham1>()
                .Property(e => e.MaXuLy)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham1>()
                .Property(e => e.MaDocGia)
                .IsUnicode(false);

            modelBuilder.Entity<XuLyViPham1>()
                .Property(e => e.TienPhat)
                .HasPrecision(18, 0);
        }
    }
}
