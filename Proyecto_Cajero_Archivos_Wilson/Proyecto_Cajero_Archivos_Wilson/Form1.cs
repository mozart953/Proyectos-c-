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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_adminnistradores ad = new Log_adminnistradores();
            this.Hide();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_usuarios us = new Log_usuarios();
            this.Hide();
            us.Show();
        }
    }
}
