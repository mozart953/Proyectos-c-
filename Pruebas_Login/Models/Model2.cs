using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pruebas_Login.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CuentaCliente> CuentaCliente { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetalleProducto> DetalleProducto { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoCompra> TipoCompra { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Primer_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Segundo_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Tercer_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Primer_Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Segundo_Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellido_Casada)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.NIT)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaCliente>()
                .Property(e => e.EstadoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleCompra>()
                .Property(e => e.NombreTienda)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleProducto>()
                .Property(e => e.NombreProducto)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleProducto>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleProducto>()
                .Property(e => e.Precio)
                .HasPrecision(10, 0);

            modelBuilder.Entity<DetalleVenta>()
                .Property(e => e.Cantidad)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Primer_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Segundo_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Tercer_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Primer_Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.TokenSeguridad)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.TipoEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Pago>()
                .Property(e => e.Tipo_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.NombreRol)
                .IsUnicode(false);

            modelBuilder.Entity<Sucursal>()
                .Property(e => e.NombreSucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCompra>()
                .Property(e => e.NombreTipoCompra)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.clave)
                .IsUnicode(false);
        }
    }
}
