namespace PrjSistemaescolar
{
    partial class FormTurmas
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
            label1 = new Label();
            txtNomeT = new TextBox();
            cbxAnoLetivo = new ComboBox();
            label8 = new Label();
            cbxProfResp = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            nudQuantMax = new NumericUpDown();
            btnDetT = new Button();
            btnCadT = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantMax).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(421, 143);
            label9.Name = "label9";
            label9.Size = new Size(200, 31);
            label9.TabIndex = 20;
            label9.Text = "Cadastro Turma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 240);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 22;
            label1.Text = "Nome da Turma:";
            // 
            // txtNomeT
            // 
            txtNomeT.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeT.Location = new Point(399, 228);
            txtNomeT.Name = "txtNomeT";
            txtNomeT.Size = new Size(397, 33);
            txtNomeT.TabIndex = 21;
            // 
            // cbxAnoLetivo
            // 
            cbxAnoLetivo.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxAnoLetivo.FormattingEnabled = true;
            cbxAnoLetivo.Items.AddRange(new object[] { "Sexto Ano", "Sétimo Ano", "Oitavo Ano", "Nono Ano", "Primeiro Ano (Ensino-Médio)", "Segundo Ano (Ensino-Médio)", "Terceiro Ano (Ensino-Médio)" });
            cbxAnoLetivo.Location = new Point(357, 288);
            cbxAnoLetivo.Name = "cbxAnoLetivo";
            cbxAnoLetivo.Size = new Size(439, 29);
            cbxAnoLetivo.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(246, 296);
            label8.Name = "label8";
            label8.Size = new Size(105, 21);
            label8.TabIndex = 23;
            label8.Text = "Ano Letivo:";
            // 
            // cbxProfResp
            // 
            cbxProfResp.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxProfResp.FormattingEnabled = true;
            cbxProfResp.Items.AddRange(new object[] { "Prof 1", "Prof 2", "Prof 3", "Prof 4" });
            cbxProfResp.Location = new Point(458, 344);
            cbxProfResp.Name = "cbxProfResp";
            cbxProfResp.Size = new Size(338, 29);
            cbxProfResp.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(246, 352);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 25;
            label2.Text = "Professor Responsável:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(246, 408);
            label3.Name = "label3";
            label3.Size = new Size(267, 21);
            label3.TabIndex = 27;
            label3.Text = "Quantidade máxima de alunos:";
            // 
            // nudQuantMax
            // 
            nudQuantMax.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudQuantMax.Location = new Point(519, 396);
            nudQuantMax.Name = "nudQuantMax";
            nudQuantMax.Size = new Size(277, 33);
            nudQuantMax.TabIndex = 28;
            // 
            // btnDetT
            // 
            btnDetT.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetT.Location = new Point(544, 481);
            btnDetT.Name = "btnDetT";
            btnDetT.Size = new Size(210, 32);
            btnDetT.TabIndex = 30;
            btnDetT.Text = "Ver Detalhes";
            btnDetT.UseVisualStyleBackColor = true;
            btnDetT.Click += btnDetT_Click;
            // 
            // btnCadT
            // 
            btnCadT.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadT.Location = new Point(246, 481);
            btnCadT.Name = "btnCadT";
            btnCadT.Size = new Size(210, 32);
            btnCadT.TabIndex = 29;
            btnCadT.Text = "Cadastrar Turma";
            btnCadT.UseVisualStyleBackColor = true;
            btnCadT.Click += btnCadT_Click;
            // 
            // FormTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 656);
            Controls.Add(btnDetT);
            Controls.Add(btnCadT);
            Controls.Add(nudQuantMax);
            Controls.Add(label3);
            Controls.Add(cbxProfResp);
            Controls.Add(label2);
            Controls.Add(cbxAnoLetivo);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(txtNomeT);
            Controls.Add(label9);
            Name = "FormTurmas";
            Text = "FormTurmas";
            ((System.ComponentModel.ISupportInitialize)nudQuantMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private TextBox txtNomeT;
        private ComboBox cbxAnoLetivo;
        private Label label8;
        private ComboBox cbxProfResp;
        private Label label2;
        private Label label3;
        private NumericUpDown nudQuantMax;
        private Button btnDetT;
        private Button btnCadT;
    }
}