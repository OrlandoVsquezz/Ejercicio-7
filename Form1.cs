using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class fmrPesosADolares : Form
    {

        /// <summary>
        /// Conversion de dolares a pesos mexicanos
        /// Escribe un programa que lea una cantidad de dolares y luego la convierta a pesos.
        /// Luego muestra la cantidad convertida ( 1 dolar = 18 pesos aproximadamente)
        /// </summary>

        public fmrPesosADolares()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidadDolares.Text))
            {
                lblError.Text = "Ingrese un valor en dolares";
            }
            else
            {
                double dolares, conversionPesos;
                dolares = double.Parse(txtCantidadDolares.Text);
                if (dolares <= 0)
                {
                    lblError.Text = "Por favor ingrese un valor positivo o m ayor a 0";
                }
                else
                {
                    conversionPesos = dolares * 18.92;
                    txtResultado.Text = conversionPesos.ToString();
                    lblError.Text = "";
                    txtCantidadDolares.ReadOnly = true;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOtraConversion_Click(object sender, EventArgs e)
        {
            txtCantidadDolares.ReadOnly = false;
            txtCantidadDolares.Clear();
            txtResultado.Clear();
        }
    }
}
