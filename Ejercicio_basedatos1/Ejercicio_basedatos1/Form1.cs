using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Ejercicio_basedatos1
{
    public partial class Form1 : Form
    {
        static string conexionstring = "Data Source= LAPTOP-8VOKSOEH\\SQLEXPRESS; Initial Catalog=JARDINERIA; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexion a la base de datos " + conexion.Database + " ha sido exitosa.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("La desconexion a la base de datos ha sido exitosa.");
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {

                string consulta1 = "select * from cliente";
                SqlCommand comando = new SqlCommand(consulta1, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                tabla1.DataSource = tabla;
            }
            else {
                string consulta1 = "select * from cliente where nombre_cliente= '" +txt1.Text+"'";
                SqlCommand comando = new SqlCommand(consulta1, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                tabla1.DataSource = tabla;
            }
        }
    }
}
