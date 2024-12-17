using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresAritmeticos
{
    public partial class FrmOpAritmeticos : Form
    {
        public FrmOpAritmeticos()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        int resultado;
        private void FrmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);


        }
    }
}
