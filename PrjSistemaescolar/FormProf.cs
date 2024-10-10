using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjSistemaescolar
{
    public partial class FormProf : Form
    {
        public FormProf()
        {
            InitializeComponent();
        }

        private void btnCadA_Click(object sender, EventArgs e)
        {
            if (txtNomeP.Text == string.Empty || mtbCPFP.Text == string.Empty || txtEnderecoP.Text == string.Empty || mtbTelP.Text == string.Empty || txtEmailP.Text == string.Empty || cbxDisc.Text == string.Empty)
            {
                MessageBox.Show("Cadastro não realizado, verifique todos os campos necessários", "Cadastro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDetP_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome: {txtNomeP.Text};\nCPF: {mtbCPFP.Text};\nEndereço: {txtEnderecoP.Text};\nTelefone: {mtbTelP.Text};\nEmail: {txtEmailP.Text};\nDisciplina: {cbxDisc.Text}.","Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
