using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploEventos.Formulario
{
    public partial class FormCalculo : Form
    {
        public FormCalculo()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2, total;
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            if (valor2 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero!", "Calcular Divisão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor2.Clear();
                txtValor2.Select();
            } else {
                total = valor1 / valor2;
                txtResultado.Text = total.ToString();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtValor2.Select();
            }
            if ((char.IsDigit(e.KeyChar) || ((e.KeyChar) == ',') || (e.KeyChar == 13)) == false)
            {
                e.Handled = true;
                MessageBox.Show("Digite só números!");
                txtValor1.Clear();
                txtValor1.Select();
            }
        }
    }
}
