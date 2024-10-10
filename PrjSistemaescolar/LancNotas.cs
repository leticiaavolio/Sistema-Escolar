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
    public partial class LancNotas : Form
    {
        public LancNotas()
        {
            InitializeComponent();
        }
        private void btnCadA_Click(object sender, EventArgs e)
        {
            if (cbxAluno.Text == string.Empty || cbxDiscLN.Text == string.Empty || nudNota1.Value == null || nudNota2.Value == null || nudNota3.Value == null)
            {
                MessageBox.Show("Lançamento não realizado, verifique todos os campos necessários", "Lançamento Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lançamento realizado com sucesso!", "Lançamento Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDetA_Click(object sender, EventArgs e)
        {
            decimal nota1 = nudNota1.Value;
            decimal nota2 = nudNota2.Value;
            decimal nota3 = nudNota3.Value;

            decimal notaFinal = (nota1 + nota2 + nota3) / 3;


            MessageBox.Show($"Aluno: {cbxAluno.Text};\nDisciplina: {cbxDiscLN.Text};\nNota 1: {nudNota1.Value};\nNota 2: {nudNota2.Value};\nNota 3: {nudNota3.Value};\nNota Final: {notaFinal}.", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
