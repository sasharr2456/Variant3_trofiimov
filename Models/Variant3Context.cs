using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Variant3_trofimov.Models;

public partial class Variant3Context : DbContext
{
    public Variant3Context()
    {
    }

    public Variant3Context(DbContextOptions<Variant3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=dbsrv\\dub2024;Database=Variant3_Trofimov;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Requests__3214EC0768757E7A");

            entity.HasIndex(e => e.RequestNumber, "UQ__Requests__9ADA6BE0BFBF4857").IsUnique();

            entity.Property(e => e.RequestNumber).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.Type).HasMaxLength(100);

            entity.HasOne(d => d.Master).WithMany(p => p.Requests)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK__Requests__Master__3B75D760");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07339FE91D");

            entity.HasIndex(e => e.Login, "UQ__Users__5E55825B85D8E0B0").IsUnique();

            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.Login).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
