namespace ProjetoAcai.Telas
{
    partial class CadastroItens
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
            btnSalvar = new Button();
            txtNome = new TextBox();
            btnAlterar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtCodiBarra = new TextBox();
            label3 = new Label();
            txtValor = new TextBox();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ButtonFace;
            btnSalvar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.FromArgb(139, 4, 124);
            btnSalvar.Location = new Point(24, 20);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 38);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 108);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(459, 26);
            txtNome.TabIndex = 1;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = SystemColors.ButtonFace;
            btnAlterar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.FromArgb(139, 4, 124);
            btnAlterar.Location = new Point(149, 20);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(86, 38);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.ButtonFace;
            btnPesquisar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.FromArgb(139, 4, 124);
            btnPesquisar.Location = new Point(274, 20);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(86, 38);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ButtonFace;
            btnExcluir.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.FromArgb(139, 4, 124);
            btnExcluir.Location = new Point(398, 20);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 38);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-6, 71);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 1);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 4, 124);
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(139, 4, 124);
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 142);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 8;
            label2.Text = "Código de barras";
            // 
            // txtCodiBarra
            // 
            txtCodiBarra.Location = new Point(24, 169);
            txtCodiBarra.Margin = new Padding(3, 4, 3, 4);
            txtCodiBarra.Name = "txtCodiBarra";
            txtCodiBarra.Size = new Size(224, 26);
            txtCodiBarra.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(139, 4, 124);
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(274, 142);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 10;
            label3.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(274, 169);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(209, 26);
            txtValor.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(139, 4, 124);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 212);
            panel2.TabIndex = 11;
            // 
            // CadastroItens
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 212);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtCodiBarra);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAlterar);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(panel2);
            Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroItens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNome;
        private Button btnAlterar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtCodiBarra;
        private Label label3;
        private TextBox txtValor;
        private Panel panel2;
    }
}