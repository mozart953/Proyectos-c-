namespace Project22.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tutor")]
    public partial class Tutor
    {
        [Key]
        public int idTutor { get; set; }

        [StringLength(45)]
        public string Nombre { get; set; }

        [StringLength(45)]
        public string Apellido_Paterno { get; set; }

        [StringLength(45)]
        public string Apellido_Materno { get; set; }

        [StringLength(45)]
        public string Telefono { get; set; }

        public int? TipoParentesco_idTipoParentesco { get; set; }

        public virtual TipoParentesco TipoParentesco { get; set; }
    }
}
