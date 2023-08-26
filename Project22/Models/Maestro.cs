namespace Project22.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Maestro")]
    public partial class Maestro
    {
        [Key]
        public int idMaestro { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre_Completo { get; set; }

        [StringLength(45)]
        public string Direccion { get; set; }

        [StringLength(45)]
        public string Telefono { get; set; }

        [StringLength(45)]
        public string CURP { get; set; }

        public int? RFC { get; set; }

        public int? Asignatura_idAsignatura { get; set; }

        public virtual asignatura asignatura { get; set; }
    }
}
