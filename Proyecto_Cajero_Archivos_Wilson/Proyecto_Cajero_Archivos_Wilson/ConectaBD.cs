using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Proyecto_Cajero_Archivos_Wilson
{
    class ConectaBD
    {
        string conexionstring = "Data Source= LAPTOP-8VOKSOEH\\SQLEXPRESS; Initial Catalog=Proyecto_Cajero2; integrated security = true";
        public SqlConnection conexion = new SqlConnection();


        public ConectaBD() {
            conexion.ConnectionString = conexionstring;
        }

        public void abrir() {
            try
            {
                conexion.Open();
                Console.WriteLine("CONECTADO");
            }
            catch(Exception ex) {

                Console.Write("Error al momento de conectar> " + ex.Message);
            }

        }

        public void cerrar() {
            conexion.Close();
        }



    }
}
