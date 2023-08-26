namespace Project22.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Linq;

    [Table("Alumno")]
    public partial class Alumno
    {
        [Key]
        public int idAlumno { get; set; }

        [StringLength(45)]
        public string Nombre_completo { get; set; }

        [StringLength(45)]
        public string Genero { get; set; }

        [StringLength(45)]
        public string CURP { get; set; }

        [StringLength(45)]
        public string Fecha_nac { get; set; }

        [StringLength(45)]
        public string Direccion { get; set; }

        [StringLength(45)]
        public string Telefono { get; set; }

        public int? Grupo_idGrupo { get; set; }

        public virtual grupo grupo { get; set; }


        public bool ValidarUsuario(string nombre, int id)
        {
            bool estado = false;

            try
            {
                using (var conexion = new Modelo1())
                {
                    // Utilizar parámetros para evitar inyección de SQL
                    //int consulta = conexion.Database.ExecuteSqlCommand(
                    //    "EXEC autenticar_Usuario @id=" + id + "@NombreCompleto=" + nombre + ";"

                    //);

                    //int consulta = conexion.Database.ExecuteSqlCommand("Select idAlumno from Alumno where idAlumno="+id+ "and Nombre_completo like "+ nombre+";");

                    string consulta = "SELECT idAlumno FROM Alumno WHERE idAlumno = @id AND Nombre_completo LIKE @nombre";
                    int resultado = conexion.Database.SqlQuery<int>(consulta,
                        new SqlParameter("@id", id),
                        new SqlParameter("@nombre", nombre)
                    ).FirstOrDefault();


                    estado = false;

                    if (resultado==1) {

                        estado = true;
                    }
                }
            }
            catch (Exception)
            {
                // Manejar o registrar la excepción adecuadamente
                estado = false;
            }

            return estado;
        }



    }


}



