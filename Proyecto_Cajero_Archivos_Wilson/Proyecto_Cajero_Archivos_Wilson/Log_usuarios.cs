using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cajero_Archivos_Wilson
{
    public partial class Log_usuarios : Form
    {
        public Log_usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 re = new Form1();
            this.Hide();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            us_Resgistro ir = new us_Resgistro();
            this.Hide();
            ir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            ConectaBD conectar = new ConectaBD();
            Validar val = new Validar();

            string pin = txtPin.Text;
            string tarjeta = txtTarjeta.Text;
            int contador = 0;
            int numero = 0;
            int numero2 = 0;
            numero = val.validarNum(pin);
            numero2 = val.validarNum(tarjeta);

            if(numero==1 && numero2 == 1)
            {
                conectar.abrir();
                string consulta = "select count(*) from USUARIOS where No_Pin ='" +
                    pin + "' and No_Tarjeta ='" + tarjeta + "'";
                SqlCommand comando = new SqlCommand(consulta, conectar.conexion);
                contador = Convert.ToInt32(comando.ExecuteScalar());
                conectar.cerrar();
                if (contador == 1)
                {
                    MessageBox.Show("Bienvenido al cajero");
                    us_Area entrar = new us_Area();
                    this.Hide();
                    entrar.Show();

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
