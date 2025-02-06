using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresLogicos
{
    public partial class frmOperadoresLogicos : Form
    {
        public frmOperadoresLogicos()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        bool resultado;
        private void btnY_Click(object sender, EventArgs e)
        {
            Y();
        }
        private void Y()
        {
            Asignar();
            if (numero1 > 5 && numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            txtresultado.Text = resultado.ToString();
        }
        private void Asignar()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            O();
        }
        private void O()
        {
            Asignar();
            if (numero1 > 5 || numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            txtresultado.Text = resultado.ToString();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            No();
        }
        private void No()
        {

            Asignar();
            if (!(numero1 > 5) && numero2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            txtresultado.Text = resultado.ToString();
        }
    }
}
