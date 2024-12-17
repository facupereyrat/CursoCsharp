using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresAritmeticos
{
    public partial class FrmOpAritmeticos : Form
    {
        public FrmOpAritmeticos()
        {
            InitializeComponent();
        }
        double numero1;
        double numero2;
        double resultado;
        private void FrmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma();
        }
        private void Suma()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
            resultado = numero1 + numero2;
            txtresultado.Text = resultado.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Resta();
        }
        private void Resta()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
            resultado = numero1 - numero2;
            txtresultado.Text = resultado.ToString();
        }
        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
            resultado = numero1 * numero2;
            txtresultado.Text = resultado.ToString();
        }
        private void btndividir_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
            resultado = numero1 / numero2;
            txtresultado.Text = resultado.ToString();
        }
    }
}

