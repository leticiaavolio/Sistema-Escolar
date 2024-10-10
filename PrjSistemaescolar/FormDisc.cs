using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjSistemaescolar
{
    public partial class FormDisc : Form
    {
        public FormDisc()
        {
            InitializeComponent();
        }

        private void btnDetD_Click(object sender, EventArgs e)
        {
            if (txtNomeD.Text == string.Empty || txtDescD.Text == string.Empty || nudCargaHor.Value == null)
            {
                MessageBox.Show("Cadastro não realizado, verifique todos os campos necessários", "Cadastro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCadD_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {txtNomeD.Text};\nDescrição: {txtDescD.Text};\nCarga Horária: {nudCargaHor.Value} horas.", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
