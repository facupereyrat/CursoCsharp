using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Listas
{
    public partial class Frmlistas_arrays : Form
    {
        public Frmlistas_arrays()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarArray();
        }
        private void AgregarListas()
        {
            
            List<string> nombres= new List<string>();
            nombres.Add("Frank");
            nombres.Add("Pablo");
            nombres.Add("Carlos");
            nombres.Add("5"); 
            
            foreach (string data in nombres )
            {
                listadatos.Items.Add(data);
            }
        }
        private void AgregarArray()
        {
            string[] nombres = new string[4] { "Frank", "Pablo", "Carlos", "5" };
            foreach (string data in nombres)
            {
                listadatos.Items.Add(data);
            }
        }
    }
}
