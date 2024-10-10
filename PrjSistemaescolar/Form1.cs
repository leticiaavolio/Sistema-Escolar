namespace PrjSistemaescolar
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno obj = new FormAluno();
            obj.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProf obj = new FormProf();
            obj.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTurmas obj = new FormTurmas();
            obj.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisc obj = new FormDisc();
            obj.ShowDialog();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LancNotas obj = new LancNotas();
            obj.ShowDialog();
        }
    }
}