using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PL;

public partial class EsantiagoRegistroDeEntrevistasContext : DbContext
{
    public EsantiagoRegistroDeEntrevistasContext()
    {
    }

    public EsantiagoRegistroDeEntrevistasContext(DbContextOptions<EsantiagoRegistroDeEntrevistasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Candidato> Candidatos { get; set; }

    public virtual DbSet<Entrevistum> Entrevista { get; set; }

    public virtual DbSet<Universidad> Universidads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Database= ESantiagoRegistroDeEntrevistas; TrustServerCertificate=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Candidato>(entity =>
        {
            entity.HasKey(e => e.IdCandidato).HasName("PK__Candidat__D5598905CB8A013D");

            entity.ToTable("Candidato");

            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PretensionEconomica).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.IdUniversidadNavigation).WithMany(p => p.Candidatos)
                .HasForeignKey(d => d.IdUniversidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Candidato__IdUni__1273C1CD");
        });

        modelBuilder.Entity<Entrevistum>(entity =>
        {
            entity.HasKey(e => e.IdEntrevista).HasName("PK__Entrevis__EE6CE9C7C86ADCF7");

            entity.Property(e => e.FechaEntrevista).HasColumnType("date");

            entity.HasOne(d => d.IdCandidatoNavigation).WithMany(p => p.Entrevista)
                .HasForeignKey(d => d.IdCandidato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Entrevist__IdCan__15502E78");
        });

        modelBuilder.Entity<Universidad>(entity =>
        {
            entity.HasKey(e => e.IdUniversidad).HasName("PK__Universi__3AB492511CBDC193");

            entity.ToTable("Universidad");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
