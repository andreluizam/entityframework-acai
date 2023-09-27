namespace ProjetoAcai.Telas
{
    partial class Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            bntProdutos = new Button();
            btnClientes = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 4, 124);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bntProdutos);
            panel1.Controls.Add(btnClientes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 204);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(215, 7);
            label2.Name = "label2";
            label2.Size = new Size(198, 30);
            label2.TabIndex = 3;
            label2.Text = "Copos / Adicionais";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 7);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 2;
            label1.Text = "Clientes";
            // 
            // bntProdutos
            // 
            bntProdutos.Cursor = Cursors.Hand;
            bntProdutos.FlatAppearance.BorderSize = 0;
            bntProdutos.FlatStyle = FlatStyle.Flat;
            bntProdutos.Image = Properties.Resources.tijela128;
            bntProdutos.Location = new Point(228, 40);
            bntProdutos.Name = "bntProdutos";
            bntProdutos.Size = new Size(157, 152);
            bntProdutos.TabIndex = 1;
            bntProdutos.UseVisualStyleBackColor = true;
            bntProdutos.Click += bntProdutos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(11, 40);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(157, 152);
            btnClientes.TabIndex = 0;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 204);
            Controls.Add(panel1);
            Name = "Configuracoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações / Cadastros";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bntProdutos;
        private Button btnClientes;
        private Label label1;
        private Label label2;
    }
}