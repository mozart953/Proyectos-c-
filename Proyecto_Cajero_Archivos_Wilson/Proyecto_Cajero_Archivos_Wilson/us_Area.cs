using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cajero_Archivos_Wilson
{
    public partial class us_Area : Form
    {
        public us_Area()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Log_usuarios regresar = new Log_usuarios();
            this.Hide();
            regresar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us_Cambiarpin cambiar = new us_Cambiarpin();
            this.Hide();
            cambiar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            us_Transacciones ir = new us_Transacciones();
            this.Hide();
            ir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            us_Consultas ir = new us_Consultas();
            this.Hide();
            ir.Show();
        }
    }
}
