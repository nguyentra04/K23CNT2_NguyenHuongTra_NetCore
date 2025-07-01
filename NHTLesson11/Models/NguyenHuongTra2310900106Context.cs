using Microsoft.EntityFrameworkCore;

namespace NHTLesson11.Models;

public partial class NguyenHuongTra2310900106Context : DbContext
{
    public NguyenHuongTra2310900106Context()
    {
    }

    public NguyenHuongTra2310900106Context(DbContextOptions<NguyenHuongTra2310900106Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Nhtemployee> Nhtemployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=FENXIHALIN-2412\\SQLEXPRESS;Database=NguyenHuongTra_2310900106;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nhtemployee>(entity =>
        {
            entity.HasKey(e => e.NhtempId).HasName("PK__NHTEmplo__7CE9170116EA5DB2");

            entity.ToTable("NHTEmployee");

            entity.Property(e => e.NhtempId)
                .ValueGeneratedNever()
                .HasColumnName("NHTEmpId");
            entity.Property(e => e.NhtempLevel)
                .HasMaxLength(50)
                .HasColumnName("NHTEmpLevel");
            entity.Property(e => e.NhtempName)
                .HasMaxLength(100)
                .HasColumnName("NHTEmpName");
            entity.Property(e => e.NhtempStartDate).HasColumnName("NHTEmpStartDate");
            entity.Property(e => e.NhtempStatus).HasColumnName("NHTEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
