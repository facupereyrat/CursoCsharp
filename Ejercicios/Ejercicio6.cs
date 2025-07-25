using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        public string titulo;
        string operacion;
        double num1;
        double num2;
        double resultado;
        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
            DibujarTecladoNumerico();
        }
        private void DibujarTecladoNumerico()
        {
            char[] numeros;
            numeros = "7894563210.".ToCharArray();
            panelnumerico.Controls.Clear();
            foreach (char numero in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(40, 40);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.Transparent;
                btnnumero.BackgroundImage = Properties.Resources.circuloGrisoscuro;
                btnnumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnnumero.FlatAppearance.BorderSize = 0;
                btnnumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnnumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                panelnumerico.Controls.Add(btnnumero);
                btnnumero.Click += Btnnumero_Click;
            }
        }

        private void Btnnumero_Click(object sender, EventArgs e)
        {
            string numerostring = ((Button)sender).Text;

            if (txtpantalla.Text == "0")
            {
                txtpantalla.Clear();
            }
            txtpantalla.Text += numerostring;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = btndiv.Text;
            DefinirOperacion();
        }
        private void DefinirOperacion()
        {
            AsignarDatos();
            if (num2 > 0)
            {
                lblnum1.Text = txtpantalla.Text;
                lbloperacion.Text = operacion;
                txtpantalla.Text = "0";
            }
        }
        private void AsignarDatos()
        {
            num1 = Convert.ToDouble(lblnum1.Text);
            num2 = Convert.ToDouble(txtpantalla.Text);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        private void Calcular()
        {
            AsignarDatos();
            if (lbloperacion.Text == btndiv.Text) 
            {
                Dividir();
            }
        }
        private void Dividir()
        {
            resultado = num1 / num2;
            txtpantalla.Text = resultado.ToString();
            lbloperacion.Text = "0";
            lblnum1.Text = "0";
        }
    }
}
