namespace Pruebas_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleCompra")]
    public partial class DetalleCompra
    {
        [Key]
        public int id_Compra { get; set; }

        public DateTime? FechaCompra { get; set; }

        [StringLength(50)]
        public string NombreTienda { get; set; }

        public int? Id_Producto { get; set; }

        public int? ID_Proveedor { get; set; }

        public int? IdTipoCompra { get; set; }

        public virtual DetalleProducto DetalleProducto { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual TipoCompra TipoCompra { get; set; }
    }
}
