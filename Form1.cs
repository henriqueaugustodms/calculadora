using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = string.Empty;

        public calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void buttonponto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void buttonmais_Click(object sender, EventArgs e)
        {
            buttonigual_Click(null, null);
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = string.Empty;
            operacao = "soma";
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            buttonigual_Click(null, null);
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = string.Empty;
            operacao = "subtracao";
        }

        private void buttonvezes_Click(object sender, EventArgs e)
        {
            buttonigual_Click(null, null);
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = string.Empty;
            operacao = "multiplicacao";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            buttonigual_Click(null,null);
            valor1 = decimal.Parse(txtResultado.Text);
            txtResultado.Text = string.Empty;
            operacao = "divisao";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            valor1 = 0;
            valor2 = 0;
            operacao = string.Empty;
        }
        private void buttonigual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text);

            switch (operacao)
            {
                case "soma": txtResultado.Text = (valor1 + valor2).ToString();
                    break;
                case "subtracao": txtResultado.Text = (valor1 - valor2).ToString();
                    break;
                case "multiplicacao": txtResultado.Text = (valor1 * valor2).ToString();
                    break ;
                case "divisao": txtResultado.Text = (valor1 / valor2).ToString();
                    break;
            }
            operacao = string.Empty;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
