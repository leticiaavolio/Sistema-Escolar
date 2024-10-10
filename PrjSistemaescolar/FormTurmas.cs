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
    public partial class FormTurmas : Form
    {
        public FormTurmas()
        {
            InitializeComponent();
        }
        private void btnCadT_Click(object sender, EventArgs e)
        {
            if (txtNomeT.Text == string.Empty || cbxAnoLetivo.Text == string.Empty || cbxProfResp.Text == string.Empty || nudQuantMax.Value == null)
            {
                MessageBox.Show("Cadastro não realizado, verifique todos os campos necessários", "Cadastro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDetT_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {txtNomeT.Text};\nAno Letivo: {cbxAnoLetivo.Text};\nProfessor Responsável: {cbxProfResp.Text};\nQuantidade Máxima de Alunos: {nudQuantMax.Value}.", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
