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
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        private void btnCadA_Click(object sender, EventArgs e)
        {
            if (txtNomeA.Text == string.Empty || dtpNascimentoA.Text == string.Empty || mtbCPFA.Text == string.Empty || txtEnderecoA.Text == string.Empty || mtbTelA.Text == string.Empty || cbxSexoA.Text == string.Empty || cbxTurmaA.Text == string.Empty)
            {
                MessageBox.Show("Cadastro não realizado, verifique todos os campos necessários", "Cadastro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDetA_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {txtNomeA.Text};\nData de Nascimento: {dtpNascimentoA.Text};\nCPF: {mtbCPFA.Text};\nEndereço: {txtEnderecoA.Text};\nTelefone: {mtbTelA.Text};\nSexo: {cbxSexoA.Text};\nTurma: {cbxTurmaA.Text}.", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
