using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo_de_los_empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnsueldo_Click(object sender, EventArgs e)
        {
            string txtN1;
            string txtN2;
            int N1;
            int N2;
            int Resultado;
            int Resultado2;

            txtN1 = txtdias.Text;
            txtN2 = txthora.Text;

            N1 = Convert.ToInt32(txtdias.Text);
            N2 = Convert.ToInt32(txthora.Text);

            Resultado = N2 * 8;
            Resultado2 = Resultado * N1;
            txtinicial.Text = Resultado2.ToString();

        }

        private void btnsueldofinal_Click(object sender, EventArgs e)
        {
            String txtN3;
            string txtN4;
            float N3;
            float N4;
            float Resultado;
            float Resultado2;
            float Resultado3;
            float Resultado4;
            float Resultado5;
            float Resultado6;
            double icr = 0.23;
            double seguro = 0.05;
            double ahorro = 0.10;

            txtN3 = txtinicial.Text;
            txtN4 = txtprestamo.Text;
            N3 = Convert.ToInt32(txtinicial.Text);
            N4 = Convert.ToInt32(txtprestamo.Text);

            Resultado = (float)(N3 * icr);
            txtisr.Text = Resultado.ToString();

            Resultado2 = (float)(N3 * seguro);
            txtseguro.Text = Resultado2.ToString();

            Resultado3 = (float)(N3 * ahorro);
            txtahorro.Text = Resultado3.ToString();

            Resultado4 = N4;
            txtprestamo.Text = Resultado4.ToString(); 

            Resultado5 = Resultado + Resultado2  + Resultado3 + Resultado4;

            Resultado6 = N3 - Resultado5;
            txtfinal.Text = Resultado6.ToString();






            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
