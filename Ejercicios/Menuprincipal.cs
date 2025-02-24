using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            panelVisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE2_Click_1(object sender, EventArgs e)
        {
            Ejercicio2();
        }

        private void Ejercicio2()
        {
            panelVisor.Controls.Clear();
            Ejercicio2 ctl = new Ejercicio2();
            ctl.titulo = btnE2.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Ejercicio3();
        }
        private void Ejercicio3()
        {
            panelVisor.Controls.Clear();
            Ejercicio3 ctl = new Ejercicio3();
            ctl.titulo = btnE3.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
