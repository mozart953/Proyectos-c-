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
    public partial class us_Transacciones : Form
    {
        public us_Transacciones()
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
            Validar validar = new Validar();
            string pin1 = txtpin.Text;
            string tarjeta = txtTarjeta.Text;
            string cantidad = txtcantidad.Text;
            int valida2 = 0;
            int valida3 = 0;
            int valida4 = 0; 
            int contador = 0;
            int dep = 0;
            string dep1 = "";
            string saldo = "";
            string cont3 = "";
            DateTime fecha = DateTime.Today;
            string fecha1 = fecha.ToShortDateString().ToString();
            valida2 = validar.validarNum(pin1);
            valida3 = validar.validarNum(tarjeta);
            valida4 = validar.validarNum(cantidad);

            

            if (valida2 == 1 && valida3 == 1 && valida4 ==1)
            {
                //MessageBox.Show("Todo correcto");

                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                    pin1 + "' and No_Tarjeta ='" + tarjeta + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador==1)
                {
                    conectar.abrir();
                    string consulta1 = "select Saldo_Actual from USUARIOS " +
                        "where No_Tarjeta='" + tarjeta + "' and No_Pin ='"+pin1+"'";
                    SqlCommand cmd1 = new SqlCommand(consulta1, conectar.conexion);
                    contador = Convert.ToInt32(cmd1.ExecuteScalar());
                    cont3 = Convert.ToString(contador);
                    conectar.cerrar();

                    if (cantidad.Equals("")) {
                        dep = 0;
                        dep1 = Convert.ToString(dep);
                    }
                    else {
                        dep =Convert.ToInt32(cantidad);
                        dep1= Convert.ToString(dep);
                    }

                    dep = dep + contador;
                    saldo = Convert.ToString(dep);

                    conectar.abrir();
                    consulta1 = "select Id_User from USUARIOS " +
                        "where No_Tarjeta='" + tarjeta + "' and No_Pin ='" + pin1 + "'";
                    SqlCommand cmd2 = new SqlCommand(consulta1, conectar.conexion);
                    contador = Convert.ToInt32(cmd2.ExecuteScalar());
                    cont3 = Convert.ToString(contador);

               
                    string insertar = "insert into Ver_Transacciones values ('"+fecha1+"', '3', '"+cont3+"')";
                    SqlCommand comando2 = new SqlCommand(insertar, conectar.conexion);
                    comando2.ExecuteNonQuery();

                    string insertar2 = "insert into DEPOSITOS values ('" + dep1 + "', '"+fecha1+"', '" + cont3 + "')";
                    SqlCommand comando3 = new SqlCommand(insertar2, conectar.conexion);
                    comando3.ExecuteNonQuery();
                    conectar.cerrar();

                    int flag = 0;
                    conectar.abrir();
                    String cadena = "update USUARIOS set Saldo_Actual = '" + saldo
                        + "' where No_Tarjeta ='" + tarjeta + "' and No_Pin= '"+pin1 +"'";
                    SqlCommand comando1 = new SqlCommand(cadena, conectar.conexion);
                    flag = comando1.ExecuteNonQuery();
                    conectar.cerrar();


                    if (flag == 1)
                    {
                        conectar.abrir();
                        string consulta2 = "select us.Id_User, us.Nombre, us.No_Pin, us.Saldo_Actual,dep.Id_Deposito, dep.Deposito_Total, dep.Fecha " 
                        +"from USUARIOS as us , DEPOSITOS as dep where us.Id_User = dep.Id_User and us.Id_User='"+cont3+"'";
                        SqlCommand comando4 = new SqlCommand(consulta2, conectar.conexion);
                        SqlDataAdapter data = new SqlDataAdapter(comando4);
                        DataTable tabla = new DataTable();
                        data.Fill(tabla);
                        tabla1.DataSource = tabla;
                        conectar.cerrar();
                        MessageBox.Show("Saldo actualizado correctamente.");
                    }
                    else {
                        MessageBox.Show("El saldo no pudo actualizarse...");
                    }


                    //MessageBox.Show(cont3 , Convert.ToString(dep));

                }
                else
                {
                    MessageBox.Show("El pin o la tarjeta son incorrectos, intentelo nuevamente.");
                }

            }
            else 
            {
                MessageBox.Show("Todos los campos deben ser numericos, intentelo nuevamente.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar validar = new Validar();
            string pin1 = txtpin.Text;
            string tarjeta = txtTarjeta.Text;
            string cantidad = txtcantidad.Text;
            int valida2 = 0;
            int valida3 = 0;
            int valida4 = 0;
            int contador = 0;
            int contador2 = 0;
            int dep = 0;
            string dep1 = "";
            string saldo = "";
            string cont3 = "";
            string cont4 = "";
            DateTime fecha = DateTime.Today;
            string fecha1 = fecha.ToShortDateString().ToString();
            valida2 = validar.validarNum(pin1);
            valida3 = validar.validarNum(tarjeta);
            valida4 = validar.validarNum(cantidad);


            if (valida2 == 1 && valida3 == 1 && valida4 == 1)
            {
                //MessageBox.Show("Todo correcto");

                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                    pin1 + "' and No_Tarjeta ='" + tarjeta + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador == 1)
                {
                    conectar.abrir();
                    string consulta1 = "select Saldo_Actual from USUARIOS " +
                        "where No_Tarjeta='" + tarjeta + "' and No_Pin ='" + pin1 + "'";
                    SqlCommand cmd1 = new SqlCommand(consulta1, conectar.conexion);
                    contador = Convert.ToInt32(cmd1.ExecuteScalar());
                    cont3 = Convert.ToString(contador);

                    string consulta9 = "select Monto_Max_Retirar from USUARIOS " +
                        "where No_Tarjeta='" + tarjeta + "' and No_Pin ='" + pin1 + "'";
                    SqlCommand cmd9 = new SqlCommand(consulta9, conectar.conexion);
                    contador2 = Convert.ToInt32(cmd9.ExecuteScalar());
                    cont4 = Convert.ToString(contador);

                    conectar.cerrar();

                    if (cantidad.Equals(""))
                    {
                        dep = 0;
                        dep1 = Convert.ToString(dep);
                    }
                    else
                    {
                        dep = Convert.ToInt32(cantidad);
                        dep1 = Convert.ToString(dep);
                    }

                    if (dep <= contador && dep<=contador2)
                    {

                        dep = contador-dep;
                        saldo = Convert.ToString(dep);

                        conectar.abrir();
                        consulta1 = "select Id_User from USUARIOS " +
                            "where No_Tarjeta='" + tarjeta + "' and No_Pin ='" + pin1 + "'";
                        SqlCommand cmd2 = new SqlCommand(consulta1, conectar.conexion);
                        contador = Convert.ToInt32(cmd2.ExecuteScalar());
                        cont3 = Convert.ToString(contador);


                        string insertar = "insert into Ver_Transacciones values ('" + fecha1 + "', '4', '" + cont3 + "')";
                        SqlCommand comando2 = new SqlCommand(insertar, conectar.conexion);
                        comando2.ExecuteNonQuery();

                        string insertar2 = "insert into RETIROS values ('" + dep1 + "', '" + fecha1 + "', '" + cont3 + "')";
                        SqlCommand comando3 = new SqlCommand(insertar2, conectar.conexion);
                        comando3.ExecuteNonQuery();
                        conectar.cerrar();

                        int flag = 0;
                        conectar.abrir();
                        String cadena = "update USUARIOS set Saldo_Actual = '" + saldo
                            + "' where No_Tarjeta ='" + tarjeta + "' and No_Pin= '" + pin1 + "'";
                        SqlCommand comando1 = new SqlCommand(cadena, conectar.conexion);
                        flag = comando1.ExecuteNonQuery();
                        conectar.cerrar();


                        if (flag == 1)
                        {
                            conectar.abrir();
                            string consulta2 = "select us.Id_User, us.Nombre, us.No_Pin, us.Saldo_Actual,ret.Id_Retiro, ret.Retiro_Total, ret.Fecha " 
                            +"from USUARIOS as us , RETIROS as ret where us.Id_User = ret.Id_User and us.Id_User= '"+cont3+"'";
                            SqlCommand comando4 = new SqlCommand(consulta2, conectar.conexion);
                            SqlDataAdapter data = new SqlDataAdapter(comando4);
                            DataTable tabla = new DataTable();
                            data.Fill(tabla);
                            tabla1.DataSource = tabla;
                            conectar.cerrar();
                            MessageBox.Show("Saldo actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El saldo no pudo actualizarse...");
                        }



                    }
                    else {
                        MessageBox.Show("El saldo o el limite son insuficientes para realizar el retiro.");
                    }


                }
                else
                {
                    MessageBox.Show("El pin o la tarjeta son incorrectos, intentelo nuevamente.");
                }
            }
            else 
            {
                MessageBox.Show("Todos los campos deben ser numericos, intentelo nuevamente.");
            }

        }
    }
}
