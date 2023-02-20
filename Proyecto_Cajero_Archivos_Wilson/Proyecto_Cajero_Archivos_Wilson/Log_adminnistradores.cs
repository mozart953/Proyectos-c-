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
    public partial class Log_adminnistradores : Form
    {
        public Log_adminnistradores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 regresar = new Form1();
            this.Hide();
            regresar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_Registro registrar = new ad_Registro();
            this.Hide();
            registrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConectaBD conectar = new ConectaBD();
            Validar val = new Validar();
            string pin = txtpin.Text;
            string clave = txtclave.Text;
            int contador = 0;
            int numero = 0;
            int numero2 = 0;
            numero = val.validarNum(pin);
            //numero2 = val.validarNum(clave);

            if (numero == 1)
            {
                conectar.abrir();
                string consulta = "select count(*) from ADMINISTRADORES where No_Pin ='" +
                    pin + "' and Clave_Ingreso ='" + clave + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();

                if (contador == 1)
                {
                    MessageBox.Show("Bienvenido al cajero");

                    ad_Area entrar = new ad_Area();
                    this.Hide();
                    entrar.Show();


                }
                else
                {

                    MessageBox.Show("Los datos no son correctos, intentelo nuevamente");

                }



            }
            else {
                MessageBox.Show("El pin no es correcto, deben ser de caracteres numericos.");


            }



        }
    }
}
