namespace PrjSistemaescolar
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            professoresToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            lançamentosToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, lançamentosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(957, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, professoresToolStripMenuItem, turmasToolStripMenuItem, disciplinasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(100, 25);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Font = new Font("Yu Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            alunosToolStripMenuItem.Size = new Size(216, 26);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // professoresToolStripMenuItem
            // 
            professoresToolStripMenuItem.Font = new Font("Yu Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            professoresToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            professoresToolStripMenuItem.Size = new Size(216, 26);
            professoresToolStripMenuItem.Text = "Professores";
            professoresToolStripMenuItem.Click += professoresToolStripMenuItem_Click;
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Font = new Font("Yu Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            turmasToolStripMenuItem.Size = new Size(216, 26);
            turmasToolStripMenuItem.Text = "Turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Font = new Font("Yu Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            disciplinasToolStripMenuItem.Size = new Size(216, 26);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += disciplinasToolStripMenuItem_Click;
            // 
            // lançamentosToolStripMenuItem
            // 
            lançamentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notasToolStripMenuItem });
            lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            lançamentosToolStripMenuItem.Size = new Size(127, 25);
            lançamentosToolStripMenuItem.Text = "Lançamentos";
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.Font = new Font("Yu Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            notasToolStripMenuItem.Size = new Size(180, 26);
            notasToolStripMenuItem.Text = "Notas";
            notasToolStripMenuItem.Click += notasToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 565);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem lançamentosToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
    }
}