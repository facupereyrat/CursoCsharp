using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Condicionales
{
    public partial class Frmcondicionales : Form
    {
        public Frmcondicionales()
        {
            InitializeComponent();
        }
        int numero;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            Asignarvalores();
            Calcular();
        }
        private void Calcular()
        {
            if(numero>0)
            {
                lblresultado.Text = "Es un numero positivo";
            }
            else if(numero==0)
            {
                lblresultado.Text = "Es un valor 0";
            }
            else
            {
                lblresultado.Text = "Es un numero negativo";
            }
        }
        private void Asignarvalores()
        {
            numero = Convert.ToInt32(txtnumero.Text);
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
