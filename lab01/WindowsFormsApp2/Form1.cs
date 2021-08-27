using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToInt32(txtNumero1.Text);
            Double valor2 = Convert.ToInt32(txtNumero2.Text);
            Double suma = valor1 + valor2;
            txtSuma.Text = Convert.ToString(suma);

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToInt32(txtNumero1.Text);
            Double valor2 = Convert.ToInt32(txtNumero2.Text);
            Double resta = valor1 - valor2;
            txtResta.Text = Convert.ToString(resta);

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToInt32(txtNumero1.Text);
            Double valor2 = Convert.ToInt32(txtNumero2.Text);
            Double multiplicacion = valor1 * valor2;
            txtMultiplicacion.Text = Convert.ToString(multiplicacion);

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToInt32(txtNumero1.Text);
            Double valor2 = Convert.ToInt32(txtNumero2.Text);
            Double division = valor1 / valor2;
            txtDivision.Text = Convert.ToString(division);

        }

        private void btnCelFar_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToInt32(txtTemperatura.Text);
            double res = ((9 * valor1) / 5) + 32;
            ResulTemp.Text = Convert.ToString(res);

        }

        private void btnFarCel_Click(object sender, EventArgs e)
        {
            Double valor1 = Convert.ToInt32(txtTemperatura.Text);
            double res = (5 * (valor1 - 32)) / 9;
            ResulTemp.Text = Convert.ToString(res);

        }
    }
}
