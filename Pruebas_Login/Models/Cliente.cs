namespace Pruebas_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
            Factura = new HashSet<Factura>();
        }

        [Key]
        public int ID_Cliente { get; set; }

        [StringLength(50)]
        public string Primer_Nombre { get; set; }

        [StringLength(50)]
        public string Segundo_Nombre { get; set; }

        [StringLength(50)]
        public string Tercer_Nombre { get; set; }

        [StringLength(50)]
        public string Primer_Apellido { get; set; }

        [StringLength(50)]
        public string Segundo_Apellido { get; set; }

        [StringLength(50)]
        public string Apellido_Casada { get; set; }

        [StringLength(50)]
        public string NIT { get; set; }

        public int? IdCuentaCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }

        public virtual CuentaCliente CuentaCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
