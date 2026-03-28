using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salarioMinimo = float.Parse(textBox1.Text);
            float consumoKw = float.Parse(textBox2.Text);
            float valorKw = salarioMinimo / 5;
            float valorPagar = consumoKw * valorKw;
            float valorPagarDesconto = valorPagar - (valorPagar * 0.15f);

            label3.Text = "Valor do quilowatt: " + valorKw.ToString("C");
            label4.Text = "Valor a ser pago pela residência: " + valorPagar.ToString("C");
            label5.Text = "Valor a ser pago com desconto: " + valorPagarDesconto.ToString("C");

        }
    }
}
