namespace ProjetoAcai.Pesquisa
{
    partial class PesquisaItem
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
            gridPesquisaItens = new DataGridView();
            panel1 = new Panel();
            lblDesc = new Label();
            txtItem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridPesquisaItens).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPesquisaItens
            // 
            gridPesquisaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPesquisaItens.BackgroundColor = Color.White;
            gridPesquisaItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPesquisaItens.GridColor = Color.White;
            gridPesquisaItens.Location = new Point(12, 79);
            gridPesquisaItens.Name = "gridPesquisaItens";
            gridPesquisaItens.RowTemplate.Height = 25;
            gridPesquisaItens.Size = new Size(501, 359);
            gridPesquisaItens.TabIndex = 0;
            gridPesquisaItens.CellDoubleClick += gridPesquisaItens_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 4, 124);
            panel1.Controls.Add(lblDesc);
            panel1.Controls.Add(txtItem);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 450);
            panel1.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = Color.White;
            lblDesc.Location = new Point(12, 20);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(98, 26);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Descrição";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(12, 50);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(501, 23);
            txtItem.TabIndex = 0;
            txtItem.TextChanged += txtItem_TextChanged;
            // 
            // PesquisaItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(gridPesquisaItens);
            Controls.Add(panel1);
            Name = "PesquisaItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Copos / Adicionais";
            Load += PesquisaItem_Load;
            ((System.ComponentModel.ISupportInitialize)gridPesquisaItens).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPesquisaItens;
        private Panel panel1;
        private Label lblDesc;
        private TextBox txtItem;
    }
}