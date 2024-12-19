using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresRelacionales
{
    public partial class FrmOpRelacionales : Form
    {
        public FrmOpRelacionales()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        bool resultado;
        private void btnmayor_Click(object sender, EventArgs e)
        {
            Mayorque();
        }
        private void Mayorque()
        {
            asignacion();
            if (numero1 >numero2)
            {
                resultado = true;
            }
            else 
            {
                resultado = false;
            }
            txtresultado.Text = resultado.ToString();
        }
        private void asignacion()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
        }
        private void FrmOpRelacionales_Load(object sender, EventArgs e)
        {

        }
    }
}
