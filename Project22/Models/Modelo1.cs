using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Project22.Models
{
    public partial class Modelo1 : DbContext
    {
        public Modelo1()
            : base("name=Modelo1")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<asignatura> asignatura { get; set; }
        public virtual DbSet<Calificaciones> Calificaciones { get; set; }
        public virtual DbSet<Colegiatura> Colegiatura { get; set; }
        public virtual DbSet<grado> grado { get; set; }
        public virtual DbSet<grupo> grupo { get; set; }
        public virtual DbSet<Maestro> Maestro { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoParentesco> TipoParentesco { get; set; }
        public virtual DbSet<Tutor> Tutor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombre_completo)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Fecha_nac)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<asignatura>()
                .Property(e => e.Nombre_Materia)
                .IsUnicode(false);

            modelBuilder.Entity<asignatura>()
                .HasMany(e => e.Maestro)
                .WithOptional(e => e.asignatura)
                .HasForeignKey(e => e.Asignatura_idAsignatura);

            modelBuilder.Entity<asignatura>()
                .HasMany(e => e.Calificaciones)
                .WithOptional(e => e.asignatura)
                .HasForeignKey(e => e.Asignatura_idAsignatura);

            modelBuilder.Entity<Calificaciones>()
                .Property(e => e.Calificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Colegiatura>()
                .Property(e => e.Monto)
                .IsUnicode(false);

            modelBuilder.Entity<grado>()
                .Property(e => e.Grado1)
                .IsUnicode(false);

            modelBuilder.Entity<grado>()
                .HasMany(e => e.grupo)
                .WithOptional(e => e.grado)
                .HasForeignKey(e => e.Grado_idGrado);

            modelBuilder.Entity<grupo>()
                .HasMany(e => e.Alumno)
                .WithOptional(e => e.grupo)
                .HasForeignKey(e => e.Grupo_idGrupo);

            modelBuilder.Entity<Maestro>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<Maestro>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Maestro>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Maestro>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<TipoParentesco>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoParentesco>()
                .HasMany(e => e.Tutor)
                .WithOptional(e => e.TipoParentesco)
                .HasForeignKey(e => e.TipoParentesco_idTipoParentesco);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Apellido_Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Apellido_Materno)
                .IsUnicode(false);

            modelBuilder.Entity<Tutor>()
                .Property(e => e.Telefono)
                .IsUnicode(false);
        }
    }
}
