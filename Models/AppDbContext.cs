using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Template5.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<tAnhChiTietSP> tAnhChiTietSPs { get; set; }

    public virtual DbSet<tAnhSP> tAnhSPs { get; set; }

    public virtual DbSet<tChatLieu> tChatLieus { get; set; }

    public virtual DbSet<tChiTietHDB> tChiTietHDBs { get; set; }

    public virtual DbSet<tChiTietSanPham> tChiTietSanPhams { get; set; }

    public virtual DbSet<tDanhMucSP> tDanhMucSPs { get; set; }

    public virtual DbSet<tHangSX> tHangSXes { get; set; }

    public virtual DbSet<tHoaDonBan> tHoaDonBans { get; set; }

    public virtual DbSet<tKhachHang> tKhachHangs { get; set; }

    public virtual DbSet<tKichThuoc> tKichThuocs { get; set; }

    public virtual DbSet<tLoaiDT> tLoaiDTs { get; set; }

    public virtual DbSet<tLoaiSP> tLoaiSPs { get; set; }

    public virtual DbSet<tMauSac> tMauSacs { get; set; }

    public virtual DbSet<tNhanVien> tNhanViens { get; set; }

    public virtual DbSet<tQuocGium> tQuocGia { get; set; }

    public virtual DbSet<tUser> tUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tAnhChiTietSP>(entity =>
        {
            entity.HasKey(e => new { e.MaChiTietSP, e.TenFileAnh });

            entity.ToTable("tAnhChiTietSP");

            entity.Property(e => e.MaChiTietSP)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenFileAnh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.MaChiTietSPNavigation).WithMany(p => p.tAnhChiTietSPs)
                .HasForeignKey(d => d.MaChiTietSP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAnhChiTietSP_tChiTietSanPham");
        });

        modelBuilder.Entity<tAnhSP>(entity =>
        {
            entity.HasKey(e => new { e.MaSP, e.TenFileAnh });

            entity.ToTable("tAnhSP");

            entity.Property(e => e.MaSP)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenFileAnh)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.MaSPNavigation).WithMany(p => p.tAnhSPs)
                .HasForeignKey(d => d.MaSP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAnhSP_tDanhMucSP");
        });

        modelBuilder.Entity<tChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu);

            entity.ToTable("tChatLieu");

            entity.Property(e => e.MaChatLieu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChatLieu).HasMaxLength(150);
        });

        modelBuilder.Entity<tChiTietHDB>(entity =>
        {
            entity.HasKey(e => new { e.MaHoaDon, e.MaChiTietSP });

            entity.ToTable("tChiTietHDB");

            entity.Property(e => e.MaHoaDon)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaChiTietSP)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DonGiaBan).HasColumnType("money");
            entity.Property(e => e.GhiChu).HasMaxLength(100);

            entity.HasOne(d => d.MaChiTietSPNavigation).WithMany(p => p.tChiTietHDBs)
                .HasForeignKey(d => d.MaChiTietSP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDB_tChiTietSanPham");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.tChiTietHDBs)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDB_tHoaDonBan");
        });

        modelBuilder.Entity<tChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.MaChiTietSP);

            entity.ToTable("tChiTietSanPham");

            entity.Property(e => e.MaChiTietSP)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnhDaiDien)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaKichThuoc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaMauSac)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaSP)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Video)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.MaKichThuocNavigation).WithMany(p => p.tChiTietSanPhams)
                .HasForeignKey(d => d.MaKichThuoc)
                .HasConstraintName("FK_tChiTietSanPham_tKichThuoc");

            entity.HasOne(d => d.MaMauSacNavigation).WithMany(p => p.tChiTietSanPhams)
                .HasForeignKey(d => d.MaMauSac)
                .HasConstraintName("FK_tChiTietSanPham_tMauSac");

            entity.HasOne(d => d.MaSPNavigation).WithMany(p => p.tChiTietSanPhams)
                .HasForeignKey(d => d.MaSP)
                .HasConstraintName("FK_tChiTietSanPham_tDanhMucSP");
        });

        modelBuilder.Entity<tDanhMucSP>(entity =>
        {
            entity.HasKey(e => e.MaSP);

            entity.ToTable("tDanhMucSP");

            entity.Property(e => e.MaSP)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnhDaiDien)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GiaLonNhat).HasColumnType("money");
            entity.Property(e => e.GiaNhoNhat).HasColumnType("money");
            entity.Property(e => e.GioiThieuSP).HasMaxLength(255);
            entity.Property(e => e.MaChatLieu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaDT)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaDacTinh)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaHangSX)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaLoai)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaNuocSX)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Model).HasMaxLength(55);
            entity.Property(e => e.NganLapTop).HasMaxLength(55);
            entity.Property(e => e.TenSP).HasMaxLength(150);
            entity.Property(e => e.Website)
                .HasMaxLength(155)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.tDanhMucSPs)
                .HasForeignKey(d => d.MaChatLieu)
                .HasConstraintName("FK_tDanhMucSP_tChatLieu");

            entity.HasOne(d => d.MaDTNavigation).WithMany(p => p.tDanhMucSPs)
                .HasForeignKey(d => d.MaDT)
                .HasConstraintName("FK_tDanhMucSP_tLoaiDT");

            entity.HasOne(d => d.MaHangSXNavigation).WithMany(p => p.tDanhMucSPs)
                .HasForeignKey(d => d.MaHangSX)
                .HasConstraintName("FK_tDanhMucSP_tHangSX");

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.tDanhMucSPs)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("FK_tDanhMucSP_tLoaiSP");

            entity.HasOne(d => d.MaNuocSXNavigation).WithMany(p => p.tDanhMucSPs)
                .HasForeignKey(d => d.MaNuocSX)
                .HasConstraintName("FK_tDanhMucSP_tQuocGia");
        });

        modelBuilder.Entity<tHangSX>(entity =>
        {
            entity.HasKey(e => e.MaHangSX);

            entity.ToTable("tHangSX");

            entity.Property(e => e.MaHangSX)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HangSX).HasMaxLength(100);
            entity.Property(e => e.MaNuocThuongHieu)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<tHoaDonBan>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon);

            entity.ToTable("tHoaDonBan");

            entity.Property(e => e.MaHoaDon)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GhiChu).HasMaxLength(100);
            entity.Property(e => e.MaKhachHang)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NgayHoaDon).HasColumnType("datetime");
            entity.Property(e => e.ThongTinThue).HasMaxLength(250);
            entity.Property(e => e.TongTienHD).HasColumnType("money");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.tHoaDonBans)
                .HasForeignKey(d => d.MaKhachHang)
                .HasConstraintName("FK_tHoaDonBan_tKhachHang");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.tHoaDonBans)
                .HasForeignKey(d => d.MaNhanVien)
                .HasConstraintName("FK_tHoaDonBan_tNhanVien");
        });

        modelBuilder.Entity<tKhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhanhHang);

            entity.ToTable("tKhachHang");

            entity.Property(e => e.MaKhanhHang)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnhDaiDien)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.GhiChu).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenKhachHang).HasMaxLength(100);
            entity.Property(e => e.username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.usernameNavigation).WithMany(p => p.tKhachHangs)
                .HasForeignKey(d => d.username)
                .HasConstraintName("FK_tKhachHang_tUser");
        });

        modelBuilder.Entity<tKichThuoc>(entity =>
        {
            entity.HasKey(e => e.MaKichThuoc);

            entity.ToTable("tKichThuoc");

            entity.Property(e => e.MaKichThuoc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.KichThuoc)
                .HasMaxLength(150)
                .IsFixedLength();
        });

        modelBuilder.Entity<tLoaiDT>(entity =>
        {
            entity.HasKey(e => e.MaDT);

            entity.ToTable("tLoaiDT");

            entity.Property(e => e.MaDT)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenLoai).HasMaxLength(100);
        });

        modelBuilder.Entity<tLoaiSP>(entity =>
        {
            entity.HasKey(e => e.MaLoai);

            entity.ToTable("tLoaiSP");

            entity.Property(e => e.MaLoai)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Loai).HasMaxLength(100);
        });

        modelBuilder.Entity<tMauSac>(entity =>
        {
            entity.HasKey(e => e.MaMauSac);

            entity.ToTable("tMauSac");

            entity.Property(e => e.MaMauSac)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenMauSac).HasMaxLength(100);
        });

        modelBuilder.Entity<tNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien);

            entity.ToTable("tNhanVien");

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AnhDaiDien)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChucVu).HasMaxLength(100);
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.GhiChu).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SoDienThoai2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenNhanVien).HasMaxLength(100);
            entity.Property(e => e.username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.usernameNavigation).WithMany(p => p.tNhanViens)
                .HasForeignKey(d => d.username)
                .HasConstraintName("FK_tNhanVien_tUser");
        });

        modelBuilder.Entity<tQuocGium>(entity =>
        {
            entity.HasKey(e => e.MaNuoc);

            entity.Property(e => e.MaNuoc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenNuoc).HasMaxLength(100);
        });

        modelBuilder.Entity<tUser>(entity =>
        {
            entity.HasKey(e => e.username);

            entity.ToTable("tUser");

            entity.Property(e => e.username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.password)
                .HasMaxLength(256)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
