using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double w0 = 0.6, w1 = 0.7, w2 = 0.4, w3=0.8, neti;
        int[,] mat = new int[4, 4];
        int sp,er;
       

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(txtx1.Text);
            int x2 = Convert.ToInt32(txtx2.Text);
            int x3 = Convert.ToInt32(txttxt3.Text);
            w0 = Convert.ToDouble(txtw0.Text);
            w1 = Convert.ToDouble(txtw1.Text);
            w2 = Convert.ToDouble(txtw2.Text);
            w3 = Convert.ToDouble(txtw3.Text);

            if ((x1 * w1 + x2 * w2 + x3*w3+ w0) >= 0)
                txtresult.Text = Convert.ToString(1);
            else
                txtresult.Text = Convert.ToString(0);
        }

        bool entrenado = false;

        private void brnEntrenar_Click(object sender, EventArgs e)
        {
            mat[0, 0] = 0;  mat[1, 0] = 1; mat[2, 0] = 1; mat[3, 0] = 0;    //x1
            mat[0, 1] = 0;  mat[1, 1] = 0; mat[2, 1] = 0; mat[3, 1] = 0;    //x2
            mat[0, 2] = 0;  mat[1, 2] = 1; mat[2, 2] = 0; mat[3, 2] = 0; //x3   
            mat[0, 3] = 0; mat[1, 3] = 1; mat[2, 3] = 0; mat[3, 3] = 0;  //salida deseada

            while (entrenado != true) {
                entrenado = true;
                for (int i=0; i<4; i++)
                {
                    neti = mat[i, 0] * w1 + mat[i, 1] * w2 + mat[i, 2] * w3 + w0;
                    if (neti >= 0) sp = 1;
                    else sp = 0;
                    er = mat[i, 3] - sp;
                    if (er != 0) {
                        entrenado = false;
                        w0 = w0 + er * 1;
                        w1 = w1 + er * mat[i,0];
                        w2 = w2 + er * mat[i, 1];
                        w3 = w3 + er * mat[i, 2];
                    }
                }
                
            }

            txtw0.Text = w0.ToString();
            txtw1.Text = w1.ToString();
            txtw2.Text = w2.ToString();
            txtw3.Text = w3.ToString();


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
