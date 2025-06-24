using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NHTLesson10.Models;

public partial class Nhtlesson10K23cnt2Context : DbContext
{
    public Nhtlesson10K23cnt2Context()
    {
    }

    public Nhtlesson10K23cnt2Context(DbContextOptions<Nhtlesson10K23cnt2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Nhtcate> Nhtcates { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=FENXIHALIN-2412\\SQLEXPRESS;Database=NHTLesson10K23CNT2;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nhtcate>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("NHTCate");

            entity.Property(e => e.CateId).ValueGeneratedNever();
            entity.Property(e => e.CateName).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
