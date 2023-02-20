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
    public partial class us_Resgistro : Form
    {
        public us_Resgistro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_Area regresar = new ad_Area();
            this.Hide();
            regresar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Validar val = new Validar();
            ConectaBD conectar = new ConectaBD();
            string nombre = txtNombre.Text;
            string Tarjeta = txtTarjeta.Text;
            string pin = txtPin.Text;
            string Monto = txtMonto.Text;
            int decision = 0;
            int decision2 = 0;
            int decision3 = 0;
            decision = val.ValidaPin(pin);
            decision2 = val.ValidaTar(Tarjeta);
            decision3 = val.validarNum(Monto);

            if ((decision == 1 && decision2 == 1) && decision3==1)
            {
                conectar.abrir();
                string insertar = "insert into USUARIOS values ('" + nombre
                    + "','" + Tarjeta + "', '" + pin + "', '0', '" + Monto + "','2')";
                SqlCommand comando = new SqlCommand(insertar, conectar.conexion);
                comando.ExecuteNonQuery();
                conectar.cerrar();


                MessageBox.Show("Datos registrados correctamente");

            }
            else if (decision == 0)
            {
                MessageBox.Show("La longitud del pin debe ser igual a 4.");
                txtPin.Focus();
                return;
            }
            else if (decision == 2)
            {
                MessageBox.Show("El pin necesita solo caracteres numericos.");
                txtPin.Focus();
                return;
            }
            else if (decision2 == 0)
            {
                MessageBox.Show("La longitud de la tarjeta debe ser igual a 16.");
                txtTarjeta.Focus();
                return;
            }
            else if (decision2 == 2)
            {
                MessageBox.Show("La tarjeta necesita solo caracteres numericos.");
                txtTarjeta.Focus();
                return;
            }
            else if (decision3 == 2)
            {
                MessageBox.Show("El monto necesita caracteres numericos.");
                txtMonto.Focus();
                return;
            }
            else { }

        }
    }
}
