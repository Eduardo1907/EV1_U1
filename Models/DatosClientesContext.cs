using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MisClientes.Models;

public partial class DatosClientesContext : DbContext
{
    public DatosClientesContext()
    {
    }

    public DatosClientesContext(DbContextOptions<DatosClientesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClientesId).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.ClientesId)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("clientes_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Correo).HasMaxLength(255);
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Hora");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Rut).HasColumnName("RUT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
