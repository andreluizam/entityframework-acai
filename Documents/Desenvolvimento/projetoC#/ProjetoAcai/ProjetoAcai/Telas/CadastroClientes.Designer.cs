namespace ProjetoAcai.Telas
{
    partial class CadastroClientes
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
            btnAlterar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            label2 = new Label();
            txtTelefone = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ButtonFace;
            btnSalvar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.FromArgb(139, 4, 124);
            btnSalvar.Location = new Point(26, 18);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 38);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = SystemColors.ButtonFace;
            btnAlterar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.FromArgb(139, 4, 124);
            btnAlterar.Location = new Point(145, 18);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(86, 38);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.ButtonFace;
            btnPesquisar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.FromArgb(139, 4, 124);
            btnPesquisar.Location = new Point(276, 18);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(86, 38);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ButtonFace;
            btnExcluir.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.FromArgb(139, 4, 124);
            btnExcluir.Location = new Point(399, 18);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 38);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(139, 4, 124);
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 138);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 15;
            label2.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(26, 165);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(224, 23);
            txtTelefone.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 4, 124);
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 77);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 13;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 104);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(459, 23);
            txtNome.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 4, 124);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnExcluir);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 206);
            panel1.TabIndex = 16;
            // 
            // CadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 206);
            Controls.Add(label2);
            Controls.Add(txtTelefone);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(panel1);
            Name = "CadastroClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Label label2;
        private TextBox txtTelefone;
        private Label label1;
        private TextBox txtNome;
        private Panel panel1;
    }
}