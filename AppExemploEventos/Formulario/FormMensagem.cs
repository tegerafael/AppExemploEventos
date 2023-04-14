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
    public partial class FormMensagem : Form
    {
        public FormMensagem()
        {
            InitializeComponent();
        }

        private void btAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem da caixa", "Título da caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btRespostas_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string pergunta = "Palmeiras tem mundial?";
            string titulo = "ADS 2022-2";
            string resposta;
            resp = MessageBox.Show(pergunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                resposta = "Sim! O palmeiras tem mundial!";
                MessageBox.Show(resposta, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                resposta = "Não! O palmeiras não tem mundial!";
                MessageBox.Show(resposta, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
