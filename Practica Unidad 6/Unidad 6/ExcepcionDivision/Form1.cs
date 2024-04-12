using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcepcionDivision
{
    public partial class CalculadoraDivision : Form
    {
        public CalculadoraDivision()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;

            try
            {
                a = int.Parse(txtDividendo.Text);
                b = int.Parse(txtDivisor.Text);
                r = a / b;

                lblResultado.Text = "= " + r;

            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("No se puede dividir por cero ...");
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Por favor cargar solo números ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido ...");
            }
        }
    }
}
