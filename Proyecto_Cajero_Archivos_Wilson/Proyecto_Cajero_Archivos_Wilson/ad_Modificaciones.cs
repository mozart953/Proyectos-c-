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
    public partial class ad_Modificaciones : Form
    {
        public ad_Modificaciones()
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
            Validar val = new Validar();

            string pin = txtpin.Text;
            string tarjeta = txtTarjeta.Text;
            string tarjeta2 = txtTarjeta2.Text;
            string limite = txtlimite.Text;
            int contador = 0;
            int numero = 0;
            int numero2 = 0;
            int numero3 = 0;
            int numero4 = 0;
            int seleccionar = 0;
            int cont2 = 0;
            string cont3 = "";
            string montonuevo = "";
            numero = val.validarNum(pin);
            numero2 = val.validarNum(tarjeta);
            DateTime fecha1 = DateTime.Today;
            string fecha2 = fecha1.ToShortDateString().ToString();

            if (numero == 1 && numero2 == 1)
            {
                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                    pin + "' and No_Tarjeta ='" + tarjeta + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador == 1)
                {
                    seleccionar = txtselec.SelectedIndex;

                    if (seleccionar == 0)
                    {
                        numero3 = val.ValidaTar(tarjeta2);

                        if (numero3 == 1)
                        {
                            MessageBox.Show("Realizando cambios.");
                            int flag = 0;
                            conectar.abrir();
                            String cadena = "update USUARIOS set No_Tarjeta = '" + tarjeta2
                                + "' where No_Pin ='" + pin + "'";
                            SqlCommand comando1 = new SqlCommand(cadena, conectar.conexion);
                            flag = comando1.ExecuteNonQuery();
                            conectar.cerrar();

                            if (flag == 1)
                            {
                                conectar.abrir();
                                string consulta1 = "select Id_User from USUARIOS where No_Pin='"+pin+"'";
                                SqlCommand cmd1 = new SqlCommand(consulta1, conectar.conexion);
                                contador = Convert.ToInt32(cmd1.ExecuteScalar());
                                cont3 = Convert.ToString(contador);

                                string insertar = "insert into CAMBIO_TARJETA values ('"+tarjeta+"', '"+tarjeta2+"', '"+fecha2
                                    +"', '"+cont3+"')";
                                SqlCommand comando2 = new SqlCommand(insertar, conectar.conexion);
                                comando2.ExecuteNonQuery();

                                string consulta2 = "select us.Id_User, us.Nombre, tar.Tarjeta_Anterior, tar.Tarjeta_Nueva, tar.Id_Tarjeta, tar.Fecha_modificacion " +
                                    "from  USUARIOS as us , CAMBIO_TARJETA as tar where us.Id_User = tar.Id_User and us.No_Pin='"+pin+"'";
                                SqlCommand comando3 = new SqlCommand(consulta2, conectar.conexion);
                                SqlDataAdapter data = new SqlDataAdapter(comando3);
                                DataTable tabla = new DataTable();
                                data.Fill(tabla);
                                tabla1.DataSource = tabla;
                                conectar.cerrar();

                            }
                            else
                            {
                                MessageBox.Show("Datos no actualizados.");
                            }


                        }
                        else {
                            MessageBox.Show("Revisar que la tarjeta tenga longitud 16 y caracteres numericos.");
                        }


                    }
                    else if (seleccionar == 1)
                    {
                        numero4 = val.validarNum(limite);

                        if (numero4 == 1)
                        {
                            MessageBox.Show("Realizando cambios.");
                            int flag1 = 0;
                            conectar.abrir();

                            string consulta5 = "select Monto_Max_Retirar from USUARIOS where No_Pin='" + pin + "'";
                            SqlCommand cmd5 = new SqlCommand(consulta5, conectar.conexion);
                            contador = Convert.ToInt32(cmd5.ExecuteScalar());
                            montonuevo = Convert.ToString(contador);


                            String cadena2 = "update USUARIOS set Monto_Max_Retirar = '" + limite
                                + "' where No_Pin ='" + pin + "'";
                            SqlCommand comando2 = new SqlCommand(cadena2, conectar.conexion);
                            flag1 = comando2.ExecuteNonQuery();
                            conectar.cerrar();

                            if (flag1 == 1)
                            {
                                conectar.abrir();
                                string consulta3 = "select Id_User from USUARIOS where No_Pin='" + pin + "'";
                                SqlCommand cmd3 = new SqlCommand(consulta3, conectar.conexion);
                                contador = Convert.ToInt32(cmd3.ExecuteScalar());
                                cont3 = Convert.ToString(contador);


                                string insertar1 = "insert into CAMBIO_MONTO values ('" + montonuevo + "', '" + limite + "', '" + fecha2
                                    + "', '" + cont3 + "')";
                                SqlCommand comando3 = new SqlCommand(insertar1, conectar.conexion);
                                comando3.ExecuteNonQuery();

                                string consulta4 = "select us.Id_User, us.Nombre, tar.Monto_Anterior, tar.Monto_Nuevo, tar.Id_Monto, tar.Fecha_modificacion from  USUARIOS as us , CAMBIO_MONTO as tar "
                                +"where us.Id_User = tar.Id_User and us.No_Pin ='"+pin+"'";
                                SqlCommand comando4 = new SqlCommand(consulta4, conectar.conexion);
                                SqlDataAdapter data = new SqlDataAdapter(comando4);
                                DataTable tabla = new DataTable();
                                data.Fill(tabla);
                                tabla1.DataSource = tabla;
                                conectar.cerrar();

                            }
                            else
                            {
                                MessageBox.Show("Datos no actualizados.");
                            }


                        }
                        else
                        {
                            MessageBox.Show("El limite debe tener caracteres numericos.");
                        }


                    }
                    else { }

                    //MessageBox.Show("Bienvenido al cajero");
                                    }
                else
                {

                    MessageBox.Show("Los datos no son correctos, intentelo nuevamente");

                }


            }
            else
            {

                MessageBox.Show("Los datos no son correctos, deben ser caracteres numericos.");

            }

        }
    }
}
