using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DiiscoverTaza.Models;

public partial class TourismContext : DbContext
{
    public TourismContext()
    {
    }

    public TourismContext(DbContextOptions<TourismContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FormulaireDatum> FormulaireData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=tourismContextConnexion");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FormulaireDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__formulai__3213E83FBA7D0BCB");

            entity.ToTable("formulaire_data");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Question)
                .HasColumnType("text")
                .HasColumnName("question");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subject");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
