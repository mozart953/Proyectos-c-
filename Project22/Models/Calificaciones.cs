namespace Project22.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Calificaciones
    {
        [Key]
        public int idCalificacion { get; set; }

        public int? Bimestre { get; set; }

        [StringLength(45)]
        public string Calificacion { get; set; }

        public int? Asignatura_idAsignatura { get; set; }

        public virtual asignatura asignatura { get; set; }
    }
}
