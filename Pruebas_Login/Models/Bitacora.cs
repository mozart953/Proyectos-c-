namespace Pruebas_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bitacora")]
    public partial class Bitacora
    {
        [Key]
        public int Id_Registro { get; set; }

        public DateTime? Fecha_Altas { get; set; }

        public DateTime? Fecha_Bajas { get; set; }

        public int? ID_Venta { get; set; }

        public virtual DetalleVenta DetalleVenta { get; set; }
    }
}
