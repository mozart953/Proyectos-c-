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
    public partial class ad_Area : Form
    {
        public ad_Area()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Log_adminnistradores regresar = new Log_adminnistradores();
            this.Hide();
            regresar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            us_Resgistro registrar = new us_Resgistro();
            this.Hide();
            registrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_trans ir = new ad_trans();
            this.Hide();
            ir.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ad_Modificaciones ir = new ad_Modificaciones();
            this.Hide();
            ir.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ad_Consultas ir = new ad_Consultas();
            this.Hide();
            ir.Show();
        }
    }
}
