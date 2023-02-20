using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BTVN_UseLNIQToSelect.Models;

public partial class QuanlyluongContext : DbContext
{
    public QuanlyluongContext()
    {
    }

    public QuanlyluongContext(DbContextOptions<QuanlyluongContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Donvi> Donvis { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-UTIESKD\\SQLEXPRESS;Initial Catalog=quanlyluong;Integrated Security=True;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Macv).HasName("PK__chucvu__7A21F84867A5442C");

            entity.ToTable("chucvu");

            entity.Property(e => e.Macv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("macv");
            entity.Property(e => e.Phucap).HasColumnName("phucap");
            entity.Property(e => e.Tencv)
                .HasMaxLength(30)
                .HasColumnName("tencv");
        });

        modelBuilder.Entity<Donvi>(entity =>
        {
            entity.HasKey(e => e.Madv).HasName("PK__donvi__7A21E029575427A1");

            entity.ToTable("donvi");

            entity.Property(e => e.Madv)
                .HasMaxLength(30)
                .HasColumnName("madv");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dienthoai");
            entity.Property(e => e.Tendv)
                .HasMaxLength(40)
                .HasColumnName("tendv");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__nhanvien__7A21B37DA4437494");

            entity.ToTable("nhanvien");

            entity.Property(e => e.Manv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("manv");
            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Hesoluong).HasColumnName("hesoluong");
            entity.Property(e => e.Hoten)
                .HasMaxLength(40)
                .HasColumnName("hoten");
            entity.Property(e => e.Macv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("macv");
            entity.Property(e => e.Madv)
                .HasMaxLength(30)
                .HasColumnName("madv");
            entity.Property(e => e.Ngaysinh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ngaysinh");
            entity.Property(e => e.Trinhdo)
                .HasMaxLength(30)
                .HasColumnName("trinhdo");

            entity.HasOne(d => d.MacvNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Macv)
                .HasConstraintName("FK__nhanvien__macv__3C69FB99");

            entity.HasOne(d => d.MadvNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Madv)
                .HasConstraintName("FK__nhanvien__madv__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
