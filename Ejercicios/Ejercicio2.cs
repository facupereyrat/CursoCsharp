using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        double radio;
        double area;
        double pi = Math.PI;
        double longitud;
        public string titulo;
        private object lblEjercicio;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignacionDatos();
            ObtenerRadio();
            ObtenerLongitud();
        }
        private void AsignacionDatos()
        {
            area = Convert.ToDouble(txtarea.Text);
        }
        private void ObtenerRadio()
        {
            radio = Math.Sqrt(area / pi);
            lblradio1.Text = radio.ToString(("N2"));
            lblradio2.Text = radio.ToString(("N2"));
            lblradioResult.Text = radio.ToString(("N2"));
            //Sirve para darle un formato ya que el resultado sin el mismo seria un total, 
            //lo que haria un numero demasiado largo , si queremos manejar mas decimales incrementamos el numero
            //ejemplo N4,N6 y asi sucesivamente (decimales)
        }
        private void ObtenerLongitud()
        {
            longitud = 2 * pi * radio;
            lbllongitudResult.Text = longitud.ToString();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblEjercicio = titulo;
        }
    }
}
