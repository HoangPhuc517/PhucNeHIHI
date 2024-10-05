using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OrchidBusinessObjects;

namespace OrchidDAOs;

public partial class OrchidContext : DbContext
{
    public OrchidContext()
    {
    }

    public OrchidContext(DbContextOptions<OrchidContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Orchid> Orchids { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;uid=sa;pwd=123;database=Orchid;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Orchid>(entity =>
        {
            entity.HasKey(e => e.OrchidId).HasName("PK__Orchid__9153F874E3261AD4");

            entity.ToTable("Orchid");

            entity.Property(e => e.OrchidId).ValueGeneratedNever();
            entity.Property(e => e.OrchidName).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
