namespace OficinaMecanica
{
    partial class TelaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSairDoSistema = new System.Windows.Forms.Button();
            this.btnFornecedoresTelaPrincipal = new System.Windows.Forms.Button();
            this.btnClientesTelaPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnSairDoSistema);
            this.panel1.Controls.Add(this.btnFornecedoresTelaPrincipal);
            this.panel1.Controls.Add(this.btnClientesTelaPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 630);
            this.panel1.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::OficinaMecanica.Properties.Resources.funcionario__1_;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(-3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(245, 63);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "   Usuários";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSairDoSistema
            // 
            this.btnSairDoSistema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSairDoSistema.FlatAppearance.BorderSize = 0;
            this.btnSairDoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairDoSistema.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairDoSistema.ForeColor = System.Drawing.Color.White;
            this.btnSairDoSistema.Image = global::OficinaMecanica.Properties.Resources.Sair;
            this.btnSairDoSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairDoSistema.Location = new System.Drawing.Point(0, 546);
            this.btnSairDoSistema.Name = "btnSairDoSistema";
            this.btnSairDoSistema.Size = new System.Drawing.Size(241, 84);
            this.btnSairDoSistema.TabIndex = 5;
            this.btnSairDoSistema.Text = "Sair";
            this.btnSairDoSistema.UseVisualStyleBackColor = true;
            this.btnSairDoSistema.Click += new System.EventHandler(this.btnSairDoSistema_Click);
            // 
            // btnFornecedoresTelaPrincipal
            // 
            this.btnFornecedoresTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnFornecedoresTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedoresTelaPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedoresTelaPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnFornecedoresTelaPrincipal.Image = global::OficinaMecanica.Properties.Resources.Fornecedores;
            this.btnFornecedoresTelaPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFornecedoresTelaPrincipal.Location = new System.Drawing.Point(0, 135);
            this.btnFornecedoresTelaPrincipal.Name = "btnFornecedoresTelaPrincipal";
            this.btnFornecedoresTelaPrincipal.Size = new System.Drawing.Size(238, 64);
            this.btnFornecedoresTelaPrincipal.TabIndex = 1;
            this.btnFornecedoresTelaPrincipal.Text = "  Fornecedores";
            this.btnFornecedoresTelaPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFornecedoresTelaPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnClientesTelaPrincipal
            // 
            this.btnClientesTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnClientesTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesTelaPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesTelaPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnClientesTelaPrincipal.Image = global::OficinaMecanica.Properties.Resources.Cliente;
            this.btnClientesTelaPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesTelaPrincipal.Location = new System.Drawing.Point(-3, 72);
            this.btnClientesTelaPrincipal.Name = "btnClientesTelaPrincipal";
            this.btnClientesTelaPrincipal.Size = new System.Drawing.Size(238, 63);
            this.btnClientesTelaPrincipal.TabIndex = 0;
            this.btnClientesTelaPrincipal.Text = "Clientes";
            this.btnClientesTelaPrincipal.UseVisualStyleBackColor = true;
            this.btnClientesTelaPrincipal.Click += new System.EventHandler(this.btnClientesTelaPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OficinaMecanica.Properties.Resources.engrenagem;
            this.pictureBox1.Location = new System.Drawing.Point(241, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipal";
            this.Text = "OFICINA MECÂNICA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSairDoSistema;
        private System.Windows.Forms.Button btnFornecedoresTelaPrincipal;
        private System.Windows.Forms.Button btnClientesTelaPrincipal;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}