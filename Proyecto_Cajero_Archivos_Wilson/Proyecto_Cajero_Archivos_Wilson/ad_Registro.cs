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
    public partial class ad_Registro : Form
    {
        public ad_Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_adminnistradores re = new Log_adminnistradores();
            this.Hide();
            re.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validar val = new Validar();
            ConectaBD conectar = new ConectaBD();
            string pin = txtpin.Text;
            string clave = txtclave.Text;
            string nombre = txtnombre.Text;
            int decision = 0;

            decision = val.ValidaPin(pin);

            if (decision == 0)
            {
                MessageBox.Show("El pin no tiene 4 caracteres");
                txtpin.Focus();
                return;
            }
            else if (decision == 2)
            {
                MessageBox.Show("El pin debe tener caracteres numericos");
                txtpin.Focus();
                return;
            }
            else{
                conectar.abrir();
                string insertar = "insert into ADMINISTRADORES values ('"+nombre
                    +"','"+pin+"','"+clave+"','1')";
                SqlCommand comando = new SqlCommand(insertar,conectar.conexion);
                comando.ExecuteNonQuery();
                conectar.cerrar();


                MessageBox.Show("Datos registrados correctamente");
            }
            
        }
    }
}
