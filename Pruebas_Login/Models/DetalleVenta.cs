namespace Pruebas_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleVenta")]
    public partial class DetalleVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetalleVenta()
        {
            Bitacora = new HashSet<Bitacora>();
        }

        [Key]
        public int ID_Venta { get; set; }

        public DateTime? FechaVenta { get; set; }

        public int? ID_Empleado { get; set; }

        public int? ID_Cliente { get; set; }

        public int? Id_Producto { get; set; }

        public int? IdPago { get; set; }

        public decimal? Cantidad { get; set; }

        public int? IdFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bitacora> Bitacora { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual DetalleProducto DetalleProducto { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual Pago Pago { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
