namespace Project22.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Colegiatura")]
    public partial class Colegiatura
    {
        [Key]
        public int idColegiatura { get; set; }

        [StringLength(45)]
        public string Monto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Mes { get; set; }

        public int? Pagado { get; set; }
    }
}
