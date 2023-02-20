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
    public partial class us_Consultas : Form
    {
        public us_Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us_Area regresar = new us_Area();
            this.Hide();
            regresar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar valida = new Validar();
            string pin1 = txtPin.Text;
            string tarjeta = txtTarjeta.Text;
            int validar1 = 0;
            int validar2 = 0;
            int contador = 0; 
            validar1 = valida.ValidaPin(pin1);
            validar2 = valida.ValidaTar(tarjeta);

            if (validar1 == 1 && validar2 == 1)
            {
                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                    pin1 + "' and No_Tarjeta ='" + tarjeta + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador == 1)
                {
                    conectar.abrir();
                    string consulta2 = "select top(5)us.Id_User, us.No_Tarjeta, us.No_Pin, ver.Fecha, tr.Descripcion "
                     +"from USUARIOS as us, Ver_Transacciones as ver, TRANSACCION as tr where us.Id_User = ver.Id_User and ver.Id_Transaccion = tr.Id_Transaccion "
                     +"and us.No_Pin = '"+pin1+"' and us.No_Tarjeta ='"+tarjeta+"' order by ver.Fecha desc";
                    SqlCommand comando4 = new SqlCommand(consulta2, conectar.conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando4);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    tabla1.DataSource = tabla;


                    string consulta4 = "select us.Id_User, dep.Deposito_Total, dep.Fecha, dep.Id_Deposito " 
                    +"from USUARIOS as us, DEPOSITOS as dep where us.Id_User = dep.Id_User and us.No_Pin='"+pin1+"' and us.No_Tarjeta = '"+tarjeta+"' order by dep.Fecha desc";
                    SqlCommand comando6 = new SqlCommand(consulta4, conectar.conexion);
                    SqlDataAdapter data1 = new SqlDataAdapter(comando6);
                    DataTable ta = new DataTable();
                    data1.Fill(ta);
                    tabla2.DataSource = ta;

                    string consulta6 = "select us.Id_User, ret.Retiro_Total, ret.Fecha, ret.Id_Retiro " 
                    +"from USUARIOS as us, RETIROS as ret where us.Id_User = ret.Id_User and us.No_Pin = '"+pin1+"' and us.No_Tarjeta='"+tarjeta+"' order by ret.Fecha desc";
                    SqlCommand comando8 = new SqlCommand(consulta6, conectar.conexion);
                    SqlDataAdapter data2 = new SqlDataAdapter(comando8);
                    DataTable tab = new DataTable();
                    data2.Fill(tab);
                    tabla3.DataSource = tab;
                    conectar.cerrar();
                    MessageBox.Show("Todos correcto.");
                }
                else {

                    MessageBox.Show("Datos incorrectos, intentelo nuevamente.");
                }
                
            }
            else {

                MessageBox.Show("La tarjeta o el pin no son validos, intentelo nuevamente.");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar valida = new Validar();
            string pin1 = txtPin.Text;
            string tarjeta = txtTarjeta.Text;
            int validar1 = 0;
            int validar2 = 0;
            int contador = 0;
            validar1 = valida.ValidaPin(pin1);
            validar2 = valida.ValidaTar(tarjeta);

            if (validar1 == 1 && validar2 == 1)
            {

                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                    pin1 + "' and No_Tarjeta ='" + tarjeta + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador == 1)
                {
                    conectar.abrir();
                    string consulta2 = "select * "
                     + "from USUARIOS as us where us.No_Pin = '" + pin1 + "' and us.No_Tarjeta ='" + tarjeta + "'";
                    SqlCommand comando4 = new SqlCommand(consulta2, conectar.conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando4);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    tabla1.DataSource = tabla;
                    conectar.cerrar();
                    MessageBox.Show("Todos correcto.");
                }
                else
                {

                    MessageBox.Show("Datos incorrectos, intentelo nuevamente.");
                }
            }
            else
            {

                MessageBox.Show("La tarjeta o el pin no son validos, intentelo nuevamente.");
            }

        }
    }
}
