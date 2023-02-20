using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OnTapKtrB2_So2.Models
{
    public partial class quanlysinhvienContext : DbContext
    {
        public quanlysinhvienContext()
        {
        }

        public quanlysinhvienContext(DbContextOptions<quanlysinhvienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-UTIESKD\\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.Makhoa)
                    .HasName("PK__Khoa__5E7F13835D25C3D7");

                entity.ToTable("Khoa");

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Tenkhoa).HasMaxLength(40);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.Masv)
                    .HasName("PK__SinhVien__27240C22CEC9AFC9");

                entity.ToTable("SinhVien");

                entity.Property(e => e.Masv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Quequan).HasMaxLength(40);

                entity.Property(e => e.Tensv).HasMaxLength(40);

                entity.HasOne(d => d.MakhoaNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.Makhoa)
                    .HasConstraintName("FK__SinhVien__Makhoa__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
