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
        bool reiniciar = false;
        bool punto = true;
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
            ReiniciarProcesos();
            string numerostring = ((Button)sender).Text;
            if (numerostring == ".")
            {
                punto = true;
                if (txtpantalla.Text.Contains("."))
                {
                    punto = false;
                }
                if (punto == true)
                {
                    if (txtpantalla.Text != "")
                    {
                        txtpantalla.Text += ".";
                    }
                }
            }
            else
            {
                if (txtpantalla.Text == "0")
                {
                    txtpantalla.Clear();
                }
                txtpantalla.Text += numerostring;
            }

        }
        private void ReiniciarProcesos()
        {
            if (reiniciar == true)
            {
                txtpantalla.Text = "0";
                reiniciar = false;
            }
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
                lblnum1.Visible = true;
                lbloperacion.Visible = true;
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
            if (lbloperacion.Text == btnmult.Text)
            {
                Multiplicar();
            }
            if (lbloperacion.Text == btnresta.Text)
            {
                Resta();
            }
            if (lbloperacion.Text == btnsuma.Text)
            {
                Suma();
            }
            if (lbloperacion.Text == btnporcent.Text)
            {
                Porcentaje();
            }
        }
        private void Porcentaje()
        {
            resultado = num1 * num2 / 100;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Resta()
        {
            resultado = num1 - num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Suma()
        {
            resultado = num1 + num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Multiplicar()
        {
            resultado = num1 * num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Limpiar()
        {
            reiniciar = true;
            lbloperacion.Text = "0";
            lblnum1.Text = "0";
            lbloperacion.Visible = false;
            lblnum1.Visible = false;
        }
        private void Dividir()
        {
            resultado = num1 / num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            operacion = btnmult.Text;
            DefinirOperacion();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = btnmult.Text;
            DefinirOperacion();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = btnsuma.Text;
            DefinirOperacion();
        }

        private void btnporcent_Click(object sender, EventArgs e)
        {
            operacion = btnporcent.Text;
            DefinirOperacion();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }
        private void Borrar()
        {
            txtpantalla.Text = "0";
            lblnum1.Text = "0";
            lblnum1.Text = "0";
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtpantalla.Text);
        }
    }
}
