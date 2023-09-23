namespace Pruebas_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [Key]
        public int IdUsuario { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(500)]
        public string clave { get; set; }
    }
}
