using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Clima
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Pronostico> Pronostico { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudad>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ciudad>()
                .HasMany(e => e.Pronostico)
                .WithOptional(e => e.Ciudad)
                .HasForeignKey(e => e.municipio_id);

            modelBuilder.Entity<Departamento>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.Ciudad)
                .WithOptional(e => e.Departamento)
                .HasForeignKey(e => e.departamento_id);

            modelBuilder.Entity<Pais>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Departamento)
                .WithOptional(e => e.Pais)
                .HasForeignKey(e => e.pais_id);

            modelBuilder.Entity<Pronostico>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Pronostico>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);
        }
    }
}
