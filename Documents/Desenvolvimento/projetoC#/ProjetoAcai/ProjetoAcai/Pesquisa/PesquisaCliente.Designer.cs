namespace ProjetoAcai.Pesquisa
{
    partial class PesquisaCliente
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
            txtItem = new TextBox();
            lblCliente = new Label();
            gridClientes = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Location = new Point(12, 49);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(501, 23);
            txtItem.TabIndex = 2;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(12, 17);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(68, 29);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nome";
            // 
            // gridClientes
            // 
            gridClientes.BackgroundColor = Color.White;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(12, 78);
            gridClientes.Name = "gridClientes";
            gridClientes.RowTemplate.Height = 25;
            gridClientes.Size = new Size(502, 360);
            gridClientes.TabIndex = 1;
            gridClientes.CellDoubleClick += gridClientes_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 4, 124);
            panel1.Controls.Add(gridClientes);
            panel1.Controls.Add(lblCliente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 449);
            panel1.TabIndex = 4;
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 449);
            Controls.Add(txtItem);
            Controls.Add(panel1);
            Name = "PesquisaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += PesquisaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItem;
        private Label lblCliente;
        private DataGridView gridClientes;
        private Panel panel1;
    }
}