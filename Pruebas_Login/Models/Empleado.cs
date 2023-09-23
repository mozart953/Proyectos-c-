namespace Pruebas_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
            Factura = new HashSet<Factura>();
        }

        [Key]
        public int ID_Empleado { get; set; }

        [StringLength(50)]
        public string Primer_Nombre { get; set; }

        [StringLength(50)]
        public string Segundo_Nombre { get; set; }

        [StringLength(50)]
        public string Tercer_Nombre { get; set; }

        [StringLength(50)]
        public string Primer_Apellido { get; set; }

        [StringLength(50)]
        public string TokenSeguridad { get; set; }

        public int? ID_Rol { get; set; }

        public int? IdSucursal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Sucursal Sucursal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
