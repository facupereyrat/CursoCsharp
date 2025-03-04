using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Listas
{
    public partial class Frmlistas : Form
    {
        public Frmlistas()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void Agregar()
        {
            
            List<string> nombres= new List<string>();
            nombres.Add("Frank");
            nombres.Add("Pablo");
            nombres.Add("Carlos");
            nombres.Add("5"); 
            
            for (int i=0;i<nombres.Count();i++)
            {
                listadatos.Items.Add(nombres[i]);
            }
        }
    }
}
