using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnTapBaiKtraSo2.Models;

public partial class QlspBkt2Context : DbContext
{
    public QlspBkt2Context()
    {
    }

    public QlspBkt2Context(DbContextOptions<QlspBkt2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-UTIESKD\\SQLEXPRESS;Initial Catalog=qlsp_bkt2;Integrated Security=True;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoai);

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.MaLoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp);

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenSp)
                .HasMaxLength(50)
                .HasColumnName("TenSP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
