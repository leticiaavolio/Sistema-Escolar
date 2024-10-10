namespace PrjSistemaescolar
{
    partial class LancNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label9 = new Label();
            cbxAluno = new ComboBox();
            label8 = new Label();
            cbxDiscLN = new ComboBox();
            label1 = new Label();
            nudNota1 = new NumericUpDown();
            label3 = new Label();
            nudNota2 = new NumericUpDown();
            label2 = new Label();
            nudNota3 = new NumericUpDown();
            label4 = new Label();
            btnDetA = new Button();
            btnCadA = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNota1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNota2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNota3).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(394, 107);
            label9.Name = "label9";
            label9.Size = new Size(271, 31);
            label9.TabIndex = 22;
            label9.Text = "Lançamento de Notas";
            // 
            // cbxAluno
            // 
            cbxAluno.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxAluno.FormattingEnabled = true;
            cbxAluno.Items.AddRange(new object[] { "Aluno 1", "Aluno 2", "Aluno 3", "Aluno 4" });
            cbxAluno.Location = new Point(326, 205);
            cbxAluno.Name = "cbxAluno";
            cbxAluno.Size = new Size(439, 29);
            cbxAluno.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(258, 213);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 25;
            label8.Text = "Aluno:";
            // 
            // cbxDiscLN
            // 
            cbxDiscLN.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDiscLN.FormattingEnabled = true;
            cbxDiscLN.Items.AddRange(new object[] { "Disciplina 1", "Disciplina 2", "Disciplina 3", "Disciplina 4" });
            cbxDiscLN.Location = new Point(361, 262);
            cbxDiscLN.Name = "cbxDiscLN";
            cbxDiscLN.Size = new Size(404, 29);
            cbxDiscLN.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 270);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 27;
            label1.Text = "Disciplina:";
            // 
            // nudNota1
            // 
            nudNota1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudNota1.Location = new Point(336, 314);
            nudNota1.Name = "nudNota1";
            nudNota1.Size = new Size(429, 33);
            nudNota1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(258, 326);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 31;
            label3.Text = "Nota 1:";
            // 
            // nudNota2
            // 
            nudNota2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudNota2.Location = new Point(336, 365);
            nudNota2.Name = "nudNota2";
            nudNota2.Size = new Size(429, 33);
            nudNota2.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(258, 377);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 33;
            label2.Text = "Nota 2:";
            // 
            // nudNota3
            // 
            nudNota3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudNota3.Location = new Point(336, 421);
            nudNota3.Name = "nudNota3";
            nudNota3.Size = new Size(429, 33);
            nudNota3.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(258, 433);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 35;
            label4.Text = "Nota 3:";
            // 
            // btnDetA
            // 
            btnDetA.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetA.Location = new Point(556, 511);
            btnDetA.Name = "btnDetA";
            btnDetA.Size = new Size(210, 32);
            btnDetA.TabIndex = 40;
            btnDetA.Text = "Ver Nota Final";
            btnDetA.UseVisualStyleBackColor = true;
            btnDetA.Click += btnDetA_Click;
            // 
            // btnCadA
            // 
            btnCadA.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadA.Location = new Point(258, 511);
            btnCadA.Name = "btnCadA";
            btnCadA.Size = new Size(210, 32);
            btnCadA.TabIndex = 39;
            btnCadA.Text = "Lançar Notas";
            btnCadA.UseVisualStyleBackColor = true;
            btnCadA.Click += btnCadA_Click;
            // 
            // LancNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 650);
            Controls.Add(btnDetA);
            Controls.Add(btnCadA);
            Controls.Add(nudNota3);
            Controls.Add(label4);
            Controls.Add(nudNota2);
            Controls.Add(label2);
            Controls.Add(nudNota1);
            Controls.Add(label3);
            Controls.Add(cbxDiscLN);
            Controls.Add(label1);
            Controls.Add(cbxAluno);
            Controls.Add(label8);
            Controls.Add(label9);
            Name = "LancNotas";
            Text = "LancNotas";
            ((System.ComponentModel.ISupportInitialize)nudNota1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNota2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNota3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private ComboBox cbxAluno;
        private Label label8;
        private ComboBox cbxDiscLN;
        private Label label1;
        private NumericUpDown nudNota1;
        private Label label3;
        private NumericUpDown nudNota2;
        private Label label2;
        private NumericUpDown nudNota3;
        private Label label4;
        private Button btnDetA;
        private Button btnCadA;
    }
}