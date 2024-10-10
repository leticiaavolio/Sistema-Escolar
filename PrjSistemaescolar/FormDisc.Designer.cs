namespace PrjSistemaescolar
{
    partial class FormDisc
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
            txtNomeD = new TextBox();
            label2 = new Label();
            txtDescD = new TextBox();
            nudCargaHor = new NumericUpDown();
            label3 = new Label();
            btnDetD = new Button();
            btnCadD = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCargaHor).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(380, 167);
            label9.Name = "label9";
            label9.Size = new Size(243, 31);
            label9.TabIndex = 21;
            label9.Text = "Cadastro Disciplina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 269);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 24;
            label1.Text = "Nome da Disciplina:";
            // 
            // txtNomeD
            // 
            txtNomeD.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeD.Location = new Point(409, 257);
            txtNomeD.Name = "txtNomeD";
            txtNomeD.Size = new Size(367, 33);
            txtNomeD.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 330);
            label2.Name = "label2";
            label2.Size = new Size(211, 21);
            label2.TabIndex = 26;
            label2.Text = "Descrição da Disciplina:";
            // 
            // txtDescD
            // 
            txtDescD.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescD.Location = new Point(444, 318);
            txtDescD.Name = "txtDescD";
            txtDescD.Size = new Size(333, 33);
            txtDescD.TabIndex = 25;
            // 
            // nudCargaHor
            // 
            nudCargaHor.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCargaHor.Location = new Point(365, 374);
            nudCargaHor.Name = "nudCargaHor";
            nudCargaHor.Size = new Size(411, 33);
            nudCargaHor.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(226, 386);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 29;
            label3.Text = "Carga Horária:";
            // 
            // btnDetD
            // 
            btnDetD.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetD.Location = new Point(524, 455);
            btnDetD.Name = "btnDetD";
            btnDetD.Size = new Size(210, 32);
            btnDetD.TabIndex = 32;
            btnDetD.Text = "Ver Detalhes";
            btnDetD.UseVisualStyleBackColor = true;
            btnDetD.Click += btnDetD_Click;
            // 
            // btnCadD
            // 
            btnCadD.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadD.Location = new Point(226, 455);
            btnCadD.Name = "btnCadD";
            btnCadD.Size = new Size(210, 32);
            btnCadD.TabIndex = 31;
            btnCadD.Text = "Cadastrar Disciplina";
            btnCadD.UseVisualStyleBackColor = true;
            btnCadD.Click += btnCadD_Click;
            // 
            // FormDisc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 654);
            Controls.Add(btnDetD);
            Controls.Add(btnCadD);
            Controls.Add(nudCargaHor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescD);
            Controls.Add(label1);
            Controls.Add(txtNomeD);
            Controls.Add(label9);
            Name = "FormDisc";
            Text = "FormDisc";
            ((System.ComponentModel.ISupportInitialize)nudCargaHor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private TextBox txtNomeD;
        private Label label2;
        private TextBox txtDescD;
        private NumericUpDown nudCargaHor;
        private Label label3;
        private Button btnDetD;
        private Button btnCadD;
    }
}