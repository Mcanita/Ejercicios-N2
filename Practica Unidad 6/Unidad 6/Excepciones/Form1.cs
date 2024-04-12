using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, resultado;
            try
            {
                a = int.Parse(txtPrimero.Text);
                b = int.Parse(txtSegundo.Text);
                resultado = a + b;

                lblResultado.Text = "= " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hubo un error al ejecutar, intente luego");
            }

        }
    }
}
