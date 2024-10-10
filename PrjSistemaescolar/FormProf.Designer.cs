namespace PrjSistemaescolar
{
    partial class FormProf
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
            label1 = new Label();
            txtNomeP = new TextBox();
            mtbCPFP = new MaskedTextBox();
            label3 = new Label();
            mtbTelP = new MaskedTextBox();
            label5 = new Label();
            txtEnderecoP = new TextBox();
            label4 = new Label();
            txtEmailP = new TextBox();
            label6 = new Label();
            cbxDisc = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            btnDetP = new Button();
            btnCadP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 214);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 3;
            label1.Text = "Nome Completo:";
            // 
            // txtNomeP
            // 
            txtNomeP.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeP.Location = new Point(398, 202);
            txtNomeP.Name = "txtNomeP";
            txtNomeP.Size = new Size(353, 33);
            txtNomeP.TabIndex = 2;
            // 
            // mtbCPFP
            // 
            mtbCPFP.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbCPFP.Location = new Point(300, 252);
            mtbCPFP.Mask = "999.999.999-99";
            mtbCPFP.Name = "mtbCPFP";
            mtbCPFP.Size = new Size(451, 33);
            mtbCPFP.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(243, 264);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 7;
            label3.Text = "CPF:";
            // 
            // mtbTelP
            // 
            mtbTelP.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTelP.Location = new Point(335, 352);
            mtbTelP.Mask = "(99) 99999-9999";
            mtbTelP.Name = "mtbTelP";
            mtbTelP.Size = new Size(416, 33);
            mtbTelP.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(243, 364);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 13;
            label5.Text = "Telefone:";
            // 
            // txtEnderecoP
            // 
            txtEnderecoP.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnderecoP.Location = new Point(342, 302);
            txtEnderecoP.Name = "txtEnderecoP";
            txtEnderecoP.Size = new Size(409, 33);
            txtEnderecoP.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(243, 314);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 11;
            label4.Text = "Endereço:";
            // 
            // txtEmailP
            // 
            txtEmailP.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailP.Location = new Point(311, 402);
            txtEmailP.Name = "txtEmailP";
            txtEmailP.Size = new Size(440, 33);
            txtEmailP.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(243, 414);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 15;
            label6.Text = "Email:";
            // 
            // cbxDisc
            // 
            cbxDisc.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDisc.FormattingEnabled = true;
            cbxDisc.Items.AddRange(new object[] { "Português", "Inglês", "Espanhol", "Artes", "Educação Física", "Matemática", "Biologia", "Física", "Química", "História", "Geografia", "Sociologia", "Filosofia" });
            cbxDisc.Location = new Point(340, 456);
            cbxDisc.Name = "cbxDisc";
            cbxDisc.Size = new Size(411, 29);
            cbxDisc.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(243, 464);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 17;
            label8.Text = "Disciplina";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(378, 95);
            label9.Name = "label9";
            label9.Size = new Size(238, 31);
            label9.TabIndex = 19;
            label9.Text = "Cadastro Professor";
            // 
            // btnDetP
            // 
            btnDetP.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetP.Location = new Point(541, 528);
            btnDetP.Name = "btnDetP";
            btnDetP.Size = new Size(210, 32);
            btnDetP.TabIndex = 21;
            btnDetP.Text = "Ver Detalhes";
            btnDetP.UseVisualStyleBackColor = true;
            btnDetP.Click += btnDetP_Click;
            // 
            // btnCadP
            // 
            btnCadP.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadP.Location = new Point(243, 528);
            btnCadP.Name = "btnCadP";
            btnCadP.Size = new Size(210, 32);
            btnCadP.TabIndex = 20;
            btnCadP.Text = "Cadastrar Professor";
            btnCadP.UseVisualStyleBackColor = true;
            btnCadP.Click += btnCadA_Click;
            // 
            // FormProf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 655);
            Controls.Add(btnDetP);
            Controls.Add(btnCadP);
            Controls.Add(label9);
            Controls.Add(cbxDisc);
            Controls.Add(label8);
            Controls.Add(txtEmailP);
            Controls.Add(label6);
            Controls.Add(mtbTelP);
            Controls.Add(label5);
            Controls.Add(txtEnderecoP);
            Controls.Add(label4);
            Controls.Add(mtbCPFP);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNomeP);
            Name = "FormProf";
            Text = "FormProf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeP;
        private MaskedTextBox mtbCPFP;
        private Label label3;
        private MaskedTextBox mtbTelP;
        private Label label5;
        private TextBox txtEnderecoP;
        private Label label4;
        private TextBox txtEmailP;
        private Label label6;
        private ComboBox cbxDisc;
        private Label label8;
        private Label label9;
        private Button btnDetP;
        private Button btnCadP;
    }
}