namespace ProjetoAcai
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            txtValorTotal = new Label();
            btnConfig = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtProduto = new TextBox();
            gridItens = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            CodigoBarras = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            btnPesquisarItem = new Button();
            label1 = new Label();
            panelPagamento = new Panel();
            btnFim = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtDescontoPerc = new TextBox();
            lblDescPerc = new Label();
            txtDescontoReais = new TextBox();
            lblDescReais = new Label();
            txtTroco = new TextBox();
            lblTroco = new Label();
            txtRecebendo = new TextBox();
            lblRecebendo = new Label();
            txtSubtotal = new TextBox();
            labelPagamentoST = new Label();
            labelPagamento = new Label();
            boxPagamento = new ComboBox();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridItens).BeginInit();
            panelPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // txtValorTotal
            // 
            txtValorTotal.AutoSize = true;
            txtValorTotal.BackColor = Color.FromArgb(139, 4, 124);
            txtValorTotal.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorTotal.ForeColor = Color.White;
            txtValorTotal.Location = new Point(848, 625);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(183, 90);
            txtValorTotal.TabIndex = 32;
            txtValorTotal.Text = "0,00";
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(139, 4, 124);
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfig.ForeColor = SystemColors.ControlText;
            btnConfig.Image = Properties.Resources.setting;
            btnConfig.Location = new Point(21, 21);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(97, 88);
            btnConfig.TabIndex = 33;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TelaPrincipal;
            pictureBox1.Location = new Point(-13, -302);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1079, 1071);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(139, 4, 124);
            label2.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(500, 21);
            label2.Name = "label2";
            label2.Size = new Size(559, 90);
            label2.TabIndex = 34;
            label2.Text = "MONTE O AÇAÍ";
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProduto.Location = new Point(500, 126);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(465, 46);
            txtProduto.TabIndex = 35;
            txtProduto.KeyDown += txtProduto_KeyDown;
            // 
            // gridItens
            // 
            gridItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridItens.BackgroundColor = Color.White;
            gridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridItens.Columns.AddRange(new DataGridViewColumn[] { ID, Item, CodigoBarras, Valor });
            gridItens.Location = new Point(500, 187);
            gridItens.Name = "gridItens";
            gridItens.RowTemplate.Height = 25;
            gridItens.Size = new Size(531, 435);
            gridItens.TabIndex = 36;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Item
            // 
            Item.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item.DataPropertyName = "Nome";
            Item.HeaderText = "Adicional";
            Item.Name = "Item";
            Item.Width = 400;
            // 
            // CodigoBarras
            // 
            CodigoBarras.DataPropertyName = "CodigoBarras";
            CodigoBarras.HeaderText = "CodigoBarras";
            CodigoBarras.Name = "CodigoBarras";
            CodigoBarras.Visible = false;
            // 
            // Valor
            // 
            Valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.Width = 85;
            // 
            // btnPesquisarItem
            // 
            btnPesquisarItem.BackColor = Color.FromArgb(139, 4, 124);
            btnPesquisarItem.Cursor = Cursors.Hand;
            btnPesquisarItem.FlatAppearance.BorderSize = 0;
            btnPesquisarItem.FlatStyle = FlatStyle.Flat;
            btnPesquisarItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisarItem.ForeColor = SystemColors.ControlText;
            btnPesquisarItem.Image = (Image)resources.GetObject("btnPesquisarItem.Image");
            btnPesquisarItem.Location = new Point(980, 126);
            btnPesquisarItem.Name = "btnPesquisarItem";
            btnPesquisarItem.Size = new Size(51, 46);
            btnPesquisarItem.TabIndex = 37;
            btnPesquisarItem.UseVisualStyleBackColor = false;
            btnPesquisarItem.Click += btnPesquisarItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 4, 124);
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-13, 207);
            label1.Name = "label1";
            label1.Size = new Size(0, 90);
            label1.TabIndex = 38;
            // 
            // panelPagamento
            // 
            panelPagamento.BackColor = Color.FromArgb(139, 4, 124);
            panelPagamento.BorderStyle = BorderStyle.FixedSingle;
            panelPagamento.Controls.Add(btnFim);
            panelPagamento.Controls.Add(txtTotal);
            panelPagamento.Controls.Add(lblTotal);
            panelPagamento.Controls.Add(txtDescontoPerc);
            panelPagamento.Controls.Add(lblDescPerc);
            panelPagamento.Controls.Add(txtDescontoReais);
            panelPagamento.Controls.Add(lblDescReais);
            panelPagamento.Controls.Add(txtTroco);
            panelPagamento.Controls.Add(lblTroco);
            panelPagamento.Controls.Add(txtRecebendo);
            panelPagamento.Controls.Add(lblRecebendo);
            panelPagamento.Controls.Add(txtSubtotal);
            panelPagamento.Controls.Add(labelPagamentoST);
            panelPagamento.Controls.Add(labelPagamento);
            panelPagamento.Controls.Add(boxPagamento);
            panelPagamento.Location = new Point(561, 21);
            panelPagamento.Name = "panelPagamento";
            panelPagamento.Size = new Size(492, 601);
            panelPagamento.TabIndex = 49;
            // 
            // btnFim
            // 
            btnFim.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFim.ForeColor = Color.FromArgb(139, 4, 124);
            btnFim.Location = new Point(139, 504);
            btnFim.Name = "btnFim";
            btnFim.Size = new Size(261, 69);
            btnFim.TabIndex = 53;
            btnFim.Text = "Finalizar";
            btnFim.UseVisualStyleBackColor = true;
            btnFim.Click += btnFim_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(41, 238);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(97, 33);
            txtTotal.TabIndex = 51;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(139, 4, 124);
            lblTotal.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(35, 210);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 26);
            lblTotal.TabIndex = 52;
            lblTotal.Text = "Total";
            // 
            // txtDescontoPerc
            // 
            txtDescontoPerc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoPerc.Location = new Point(339, 144);
            txtDescontoPerc.Name = "txtDescontoPerc";
            txtDescontoPerc.Size = new Size(150, 33);
            txtDescontoPerc.TabIndex = 49;
            txtDescontoPerc.KeyDown += txtDescontoPerc_KeyDown;
            txtDescontoPerc.Leave += txtDescontoPerc_Leave;
            // 
            // lblDescPerc
            // 
            lblDescPerc.AutoSize = true;
            lblDescPerc.BackColor = Color.FromArgb(139, 4, 124);
            lblDescPerc.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescPerc.ForeColor = Color.White;
            lblDescPerc.Location = new Point(336, 115);
            lblDescPerc.Name = "lblDescPerc";
            lblDescPerc.Size = new Size(141, 26);
            lblDescPerc.TabIndex = 50;
            lblDescPerc.Text = "Desconto ( % )";
            // 
            // txtDescontoReais
            // 
            txtDescontoReais.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoReais.Location = new Point(166, 144);
            txtDescontoReais.Name = "txtDescontoReais";
            txtDescontoReais.Size = new Size(145, 33);
            txtDescontoReais.TabIndex = 47;
            txtDescontoReais.KeyDown += txtDescontoReais_KeyDown;
            txtDescontoReais.Leave += txtDescontoReais_Leave;
            // 
            // lblDescReais
            // 
            lblDescReais.AutoSize = true;
            lblDescReais.BackColor = Color.FromArgb(139, 4, 124);
            lblDescReais.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescReais.ForeColor = Color.White;
            lblDescReais.Location = new Point(162, 115);
            lblDescReais.Name = "lblDescReais";
            lblDescReais.Size = new Size(150, 26);
            lblDescReais.TabIndex = 48;
            lblDescReais.Text = "Desconto ( R$ )";
            // 
            // txtTroco
            // 
            txtTroco.Enabled = false;
            txtTroco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTroco.Location = new Point(339, 238);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(150, 33);
            txtTroco.TabIndex = 45;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.FromArgb(139, 4, 124);
            lblTroco.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTroco.ForeColor = Color.White;
            lblTroco.Location = new Point(336, 209);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(64, 26);
            lblTroco.TabIndex = 46;
            lblTroco.Text = "Troco";
            // 
            // txtRecebendo
            // 
            txtRecebendo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecebendo.Location = new Point(166, 238);
            txtRecebendo.Name = "txtRecebendo";
            txtRecebendo.Size = new Size(145, 33);
            txtRecebendo.TabIndex = 43;
            txtRecebendo.KeyDown += txtRecebendo_KeyDown;
            txtRecebendo.Leave += txtRecebendo_Leave;
            // 
            // lblRecebendo
            // 
            lblRecebendo.AutoSize = true;
            lblRecebendo.BackColor = Color.FromArgb(139, 4, 124);
            lblRecebendo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecebendo.ForeColor = Color.White;
            lblRecebendo.Location = new Point(164, 209);
            lblRecebendo.Name = "lblRecebendo";
            lblRecebendo.Size = new Size(106, 26);
            lblRecebendo.TabIndex = 44;
            lblRecebendo.Text = "Recebendo";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubtotal.Location = new Point(41, 144);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(97, 33);
            txtSubtotal.TabIndex = 41;
            // 
            // labelPagamentoST
            // 
            labelPagamentoST.AutoSize = true;
            labelPagamentoST.BackColor = Color.FromArgb(139, 4, 124);
            labelPagamentoST.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPagamentoST.ForeColor = Color.White;
            labelPagamentoST.Location = new Point(35, 116);
            labelPagamentoST.Name = "labelPagamentoST";
            labelPagamentoST.Size = new Size(87, 26);
            labelPagamentoST.TabIndex = 42;
            labelPagamentoST.Text = "Subtotal";
            // 
            // labelPagamento
            // 
            labelPagamento.AutoSize = true;
            labelPagamento.BackColor = Color.FromArgb(139, 4, 124);
            labelPagamento.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPagamento.ForeColor = Color.White;
            labelPagamento.Location = new Point(41, 20);
            labelPagamento.Name = "labelPagamento";
            labelPagamento.Size = new Size(194, 26);
            labelPagamento.TabIndex = 41;
            labelPagamento.Text = "Forma de pagamento";
            // 
            // boxPagamento
            // 
            boxPagamento.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            boxPagamento.ForeColor = Color.FromArgb(139, 4, 124);
            boxPagamento.FormattingEnabled = true;
            boxPagamento.Items.AddRange(new object[] { "1. DINHEIRO", "2. CARTÃO DE CRÉDITO", "3. CARTÃO DE DÉBITO", "4. PIX" });
            boxPagamento.Location = new Point(41, 49);
            boxPagamento.Name = "boxPagamento";
            boxPagamento.Size = new Size(448, 43);
            boxPagamento.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = SystemColors.Control;
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.ForeColor = Color.FromArgb(139, 4, 124);
            btnFinalizar.Location = new Point(500, 641);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(139, 64);
            btnFinalizar.TabIndex = 50;
            btnFinalizar.Text = "Receber";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 746);
            Controls.Add(btnFinalizar);
            Controls.Add(panelPagamento);
            Controls.Add(label1);
            Controls.Add(btnPesquisarItem);
            Controls.Add(gridItens);
            Controls.Add(txtProduto);
            Controls.Add(label2);
            Controls.Add(btnConfig);
            Controls.Add(txtValorTotal);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA PARA AÇAITERIAS";
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridItens).EndInit();
            panelPagamento.ResumeLayout(false);
            panelPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtValorTotal;
        private Button btnConfig;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtProduto;
        private DataGridView gridItens;
        private Button btnPesquisarItem;
        private Label label1;
        private Panel panelPagamento;
        private TextBox txtDescontoPerc;
        private Label lblDescPerc;
        private TextBox txtDescontoReais;
        private Label lblDescReais;
        private TextBox txtTroco;
        private Label lblTroco;
        private TextBox txtRecebendo;
        private Label lblRecebendo;
        private TextBox txtSubtotal;
        private Label labelPagamentoST;
        private Label labelPagamento;
        private ComboBox boxPagamento;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnFinalizar;
        private Button btnFim;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn CodigoBarras;
        private DataGridViewTextBoxColumn Valor;
    }
}