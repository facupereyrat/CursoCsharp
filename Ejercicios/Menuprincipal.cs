using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CursoCsharp.Ejercicios;


namespace CursoCsharp.Ejercicios
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
        }

        private void Ejercicio1()
        {
            Ejercicio1 ctl = new Ejercicio1();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
