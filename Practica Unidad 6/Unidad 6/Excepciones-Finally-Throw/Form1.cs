using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones_Finally_Throw
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;

            try
            {
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese solo números...");
            }
            finally
            {
                //instrucciones
                //operación sensible
            }
        }

       private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtPrimero.Text);
                b = int.Parse(txtSegundo.Text);
                r = a + b;
                return r;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
