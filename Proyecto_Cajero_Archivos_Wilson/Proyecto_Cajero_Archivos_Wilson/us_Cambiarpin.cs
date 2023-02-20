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

namespace Proyecto_Cajero_Archivos_Wilson
{
    public partial class us_Cambiarpin : Form
    {
        public us_Cambiarpin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us_Area regresar = new us_Area();
            this.Hide();
            regresar.Show();
        }

        private void us_Cambiarpin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar validar = new Validar();
            string pin1 = txtPin.Text;
            string pin2 = txtPin2.Text;
            string tarjeta = txtTarjeta.Text;
            int validar1 = 0;
            int valida2 = 0;
            int valida3 = 0; 
            int contador = 0;
            string cont3 = "";
            DateTime fecha = DateTime.Today;
            string fecha1 = fecha.ToShortDateString().ToString();
            validar1 = validar.ValidaPin(pin2);
            valida2 = validar.validarNum(pin1);
            valida3 = validar.validarNum(tarjeta);

            

            if (valida2==1 && valida3==1)
            {
                if (validar1 == 1)
                {

                    conectar.abrir();
                    string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                        pin1 + "' and No_Tarjeta ='" + tarjeta + "'";
                    SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                    contador = Convert.ToInt32(comando.ExecuteScalar());
                    conectar.cerrar();

                    if (contador == 1)
                    {
                        int flag = 0;
                        conectar.abrir();
                        String cadena = "update USUARIOS set No_Pin = '" + pin2
                            + "' where No_Tarjeta ='" + tarjeta + "'";
                        SqlCommand comando1 = new SqlCommand(cadena, conectar.conexion);
                        flag = comando1.ExecuteNonQuery();
                        conectar.cerrar();

                        if (flag==1) {

                            conectar.abrir();
                            string consulta1 = "select Id_User from USUARIOS where No_Tarjeta='" + tarjeta + "'";
                            SqlCommand cmd1 = new SqlCommand(consulta1, conectar.conexion);
                            contador = Convert.ToInt32(cmd1.ExecuteScalar());
                            cont3 = Convert.ToString(contador);

                            string insertar = "insert into CAMBIO_PIN values ('" + pin1 + "', '" + pin2 + "', '" + fecha1
                                    + "', '" + cont3 + "')";
                            SqlCommand comando2 = new SqlCommand(insertar, conectar.conexion);
                            comando2.ExecuteNonQuery();

                            string consulta2 = "select us.Id_User, us.Nombre, us.No_Tarjeta, pn.Pin_Anterior, pn.Pin_Nuevo, pn.Fecha_modificacion " +
                                "from USUARIOS as us, CAMBIO_PIN as pn where us.Id_User = pn.Id_User and us.No_Tarjeta = '"+tarjeta+"'";
                            SqlCommand comando3 = new SqlCommand(consulta2, conectar.conexion);
                            SqlDataAdapter data = new SqlDataAdapter(comando3);
                            DataTable tabla = new DataTable();
                            data.Fill(tabla);
                            tabla1.DataSource = tabla;
                            conectar.cerrar();

                        }
                        else {

                            MessageBox.Show("Error al ingresar datos, intentar nuevamente.");
                        }



                        MessageBox.Show("Todo correcto");
                    }
                    else {
                        MessageBox.Show("El pin o la tarjeta son icorrectos, intelo nuevamente.");
                    }

                }
                else {
                    MessageBox.Show("Verificar que el pin nuevo contenga 4 caracteres numericos.");
                }

            }
            else
            {
                MessageBox.Show("Todos los campos deben ser numericos, intentelo nuevamente.");
            }


        }
    }
}
