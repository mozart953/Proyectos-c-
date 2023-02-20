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
    public partial class ad_Consultas : Form
    {
        public ad_Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad_Area regresar = new ad_Area();
            this.Hide();
            regresar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar valida = new Validar();
            string idus = txtid.Text;
            int valid = 0;
            int contador = 0;
            valid = valida.validarNum(idus);

            if (valid==1) {
                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where Id_User ='"+idus+"'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador == 1)
                {
                    conectar.abrir();
                    string consulta2 = "select us.Id_User,us.Nombre,us.No_Pin as Pin, us.No_Tarjeta as Tarjeta,SUM(ret.Retiro_Total) as Retiro_Total, us.Saldo_Actual as Saldo, us.Monto_Max_Retirar as Limite "
                    +"from RETIROS as ret, USUARIOS as us where ret.Id_User = us.Id_User and us.Id_User = '"+idus+"' group by us.Id_User, us.Nombre, us.No_Pin, us.No_Tarjeta, us.Saldo_Actual, us.Monto_Max_Retirar";
                    SqlCommand comando4 = new SqlCommand(consulta2, conectar.conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando4);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    tabla1.DataSource = tabla;

                    string consulta6 = "select top(1) us.Id_User , us.Nombre, us.No_Pin, us.No_Tarjeta,  ver.Fecha as Ultimo_acceso from USUARIOS as us, Ver_Transacciones as ver " 
                    +"where us.Id_User = ver.Id_User and us.Id_User = '"+idus+"' order by ver.Fecha desc";
                    SqlCommand comando8 = new SqlCommand(consulta6, conectar.conexion);
                    SqlDataAdapter data2 = new SqlDataAdapter(comando8);
                    DataTable tab = new DataTable();
                    data2.Fill(tab);
                    tabla3.DataSource = tab;
                    conectar.cerrar();

                    MessageBox.Show("Todo correcto");

                }
                else {
                    MessageBox.Show("El id ingresado no coincide con ninguno.");
                }

            }
            else {

                MessageBox.Show("La id debe tener caracteres numericos.");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar valida = new Validar();

            conectar.abrir();
            string consulta2 = "select distinct (select sum(ret.Retiro_Total) from RETIROS as ret) as RETIRO_TOTAL,(select sum(dep.Deposito_Total) from DEPOSITOS as dep ) as DEPOSITO_TOTAL,(select avg(dep.Deposito_Total) from DEPOSITOS as dep ) as PROMEDIO_DEPOSITADO " 
            +"from RETIROS as ret, DEPOSITOS as dep, USUARIOS as us where us.Id_User = ret.Id_User and us.Id_User = dep.Id_User";
            SqlCommand comando4 = new SqlCommand(consulta2, conectar.conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando4);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            tabla1.DataSource = tabla;

            string consulta4 = "select us.Id_User, us.Nombre, us.No_Pin as Pin_actual, us.No_Tarjeta, cpin.Pin_Anterior, cpin.Pin_Nuevo, cpin.Fecha_modificacion "
            +"from USUARIOS as us, CAMBIO_PIN as cpin where us.Id_User = cpin.Id_User";
            SqlCommand comando6 = new SqlCommand(consulta4, conectar.conexion);
            SqlDataAdapter data1 = new SqlDataAdapter(comando6);
            DataTable ta = new DataTable();
            data1.Fill(ta);
            tabla2.DataSource = ta;


            string consulta6 = "select distinct us.Id_User , us.Nombre, us.No_Pin, us.No_Tarjeta,  ver.Fecha as Ultimo_acceso from USUARIOS as us, Ver_Transacciones as ver "
            + "where us.Id_User = ver.Id_User order by ver.Fecha desc";
            SqlCommand comando8 = new SqlCommand(consulta6, conectar.conexion);
            SqlDataAdapter data2 = new SqlDataAdapter(comando8);
            DataTable tab = new DataTable();
            data2.Fill(tab);
            tabla3.DataSource = tab;
            conectar.cerrar();

            MessageBox.Show("Todo correcto");

        }
    }
}
