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
    public partial class ad_trans : Form
    {
        public ad_trans()
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
            Validar valor = new Validar();
            ConectaBD conectar = new ConectaBD();
            string b200 = txtdos.Text;
            string b100 = txtcien.Text;
            string b50 = txtcincuenta.Text;
            string b20 = txtveinte.Text;
            string b10 = txtdiez.Text;
            string b5 = txtcinco.Text;
            string b1 = txtuno.Text;
            int bdocs = 0;
            int bcien = 0;
            int bcincuenta =0;
            int bvein = 0;
            int bdiez = 0;
            int bcinco = 0; 
            int buno = 0;
            int val1 = valor.validarNum(b200);
            int val2 = valor.validarNum(b100);
            int val3 = valor.validarNum(b50);
            int val4 = valor.validarNum(b20);
            int val5 = valor.validarNum(b10);
            int val6 = valor.validarNum(b5);
            int val7 = valor.validarNum(b1);
            int elegir = -1;
            string total ="";
            int tot1 = 0;
            int contador = 0;
            DateTime fecha = DateTime.Today;
            string fecha1 = fecha.ToShortDateString().ToString();
            string elegir2 = "";
            string cont2 = "";
            if (val1 ==2 || val2==2 || val3==2 || val4 ==2 || val5==2 || val6==2 || val7==2) {

                MessageBox.Show("Todos los campos deben ser numericos");
            }
            else
            {
                bdocs = Convert.ToInt32(b200);
                bcien = Convert.ToInt32(b100);
                bcincuenta = Convert.ToInt32(b50);
                bvein = Convert.ToInt32(b20);
                bdiez = Convert.ToInt32(b10);
                bcinco = Convert.ToInt32(b5);
                buno = Convert.ToInt32(b1);

                tot1 = bdocs*200 + bcien*100+bcincuenta*50+bvein*20+bdiez*10+bcinco*5+buno*1;

                elegir=txtselec.SelectedIndex;

                elegir2 = Convert.ToString(elegir+1);

                if ((elegir == 0 && tot1 <= 10000) || (elegir == 1 && tot1 <= 30000))
                {
                    total = Convert.ToString(tot1);

                    conectar.abrir();

                    string insertar1 = "insert into FECHA_TRANSACCION values ('" + fecha1
                        + "','" + elegir2 + "','1')";
                    SqlCommand comando = new SqlCommand(insertar1, conectar.conexion);
                    comando.ExecuteNonQuery();


                    string consulta = "select top(1)Id_Fecha from FECHA_TRANSACCION order by Id_Fecha desc";
                    SqlCommand comando1 = new SqlCommand(consulta, conectar.conexion);
                    contador = Convert.ToInt32(comando1.ExecuteScalar());
                    cont2 = Convert.ToString(contador);

                    string insertar = "insert into CAJERO values ('" + b200
                        + "','" + b100 + "','" + b50 + "','"+b20+"', '"+b10+"','"+b5+"', '"+b1
                        +"','"+total+"', '"+cont2+"')";
                    SqlCommand comando2 = new SqlCommand(insertar, conectar.conexion);
                    comando2.ExecuteNonQuery();

                    string consulta1 = "select c.*, f.Fecha, t.Descripcion from CAJERO as c, FECHA_TRANSACCION as f, TRANSACCION as t" 
                    +" where c.Id_Fecha = f.Id_Fecha  and f.Id_Transaccion = t.Id_Transaccion";
                    SqlCommand comando3 = new SqlCommand(consulta1, conectar.conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando3);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    tabla1.DataSource = tabla;


                    conectar.cerrar();

                    MessageBox.Show(Convert.ToString("Correcto"));
                }
                else {

                    MessageBox.Show("La suma total excede lo permitido por el cajero.");
                }

            }





        }
    }
}
