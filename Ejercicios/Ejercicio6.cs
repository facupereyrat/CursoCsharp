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
    public partial class Ejercicio6: UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public string titulo;
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
            foreach(char numero in numeros)
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
            }
        }
    }
}
