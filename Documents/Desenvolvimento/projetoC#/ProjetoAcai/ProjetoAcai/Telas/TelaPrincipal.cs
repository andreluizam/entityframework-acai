using ProjetoAcai.Contexto;
using ProjetoAcai.Modelo;
using ProjetoAcai.Pesquisa;
using ProjetoAcai.Telas;

namespace ProjetoAcai
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        #region Variáveis
        Adicionais adicional;
        List<Adicionais> lstAdicionais = new List<Adicionais>();
        private decimal valorOriginal;
        private decimal valorItem;
        private decimal subtotal;
        private decimal troco;
        private int adicionalID;
        private string codigoBarra;
        #endregion

        #region Carrega Dados
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lstAdicionais = new List<Adicionais>();
            DesativaPagamento();
            Finalizando();
        }
        #endregion

        #region Manipula campos
        private void AtivaPagamento()
        {
            panelPagamento.Visible = true;
            boxPagamento.Visible = true;
            labelPagamento.Visible = true;
            labelPagamentoST.Visible = true;
            lblDescPerc.Visible = true;
            lblDescReais.Visible = true;
            lblRecebendo.Visible = true;
            lblTroco.Visible = true;
            lblTotal.Visible = true;
            txtDescontoPerc.Visible = true;
            txtDescontoReais.Visible = true;
            txtRecebendo.Visible = true;
            txtTotal.Visible = true;
            txtSubtotal.Visible = true;
            txtTroco.Visible = true;
            lstAdicionais.Clear();
            gridItens.DataSource = lstAdicionais.ToList();
        }

        private void DesativaPagamento()
        {
            panelPagamento.Visible = false;
            boxPagamento.Visible = false;
            labelPagamento.Visible = false;
            labelPagamentoST.Visible = false;
            lblDescPerc.Visible = false;
            lblDescReais.Visible = false;
            lblRecebendo.Visible = false;
            lblTroco.Visible = false;
            lblTotal.Visible = false;
            txtDescontoPerc.Visible = false;
            txtDescontoReais.Visible = false;
            txtRecebendo.Visible = false;
            txtTotal.Visible = false;
            txtSubtotal.Visible = false;
            txtTroco.Visible = false;
            subtotal = 0;
            lstAdicionais.Clear();
            gridItens.DataSource = lstAdicionais.ToList();
        }

        private void Finalizando()
        {
            boxPagamento.Focus();
            txtDescontoPerc.Text = "0";
            txtDescontoReais.Text = "0.00";
            txtTroco.Text = "0.00";
            txtRecebendo.Text = "0.00";
        }

        #endregion

        #region Abre cadastros
        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new Configuracoes();
            configuracoes.ShowDialog();
        }
        #endregion

        #region Seleciona item
        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            PesquisaItem pesquisa = new PesquisaItem();
            pesquisa.ShowDialog();
            if (pesquisa.AdicionalSelecionado != null)
            {
                adicionalID = pesquisa.AdicionalSelecionado.ID;
                codigoBarra = pesquisa.AdicionalSelecionado.CodigoBarra;
                txtProduto.Text = pesquisa.AdicionalSelecionado.Nome;
                valorItem = pesquisa.AdicionalSelecionado.Valor;
            }
            txtProduto.Focus();
        }

        #endregion

        #region Adiciona Produto
        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adicional = new Adicionais();
                adicional.ID = adicionalID;
                adicional.CodigoBarra = codigoBarra;
                adicional.Nome = txtProduto.Text;
                adicional.Valor = valorItem;
                subtotal = subtotal + valorItem;
                txtValorTotal.Text = subtotal.ToString();

                lstAdicionais.Add(adicional);
                gridItens.DataSource = lstAdicionais.ToList();
                gridItens.Refresh();
                txtProduto.Clear();
                btnPesquisarItem.Focus();
                valorOriginal = subtotal;
            }
        }
        #endregion

        #region Desconto
        private void calculaDesconto()
        {
            try
            {
                decimal descontoPercentual = decimal.Parse(txtDescontoPerc.Text);
                decimal descontoReais = (descontoPercentual / 100) * valorOriginal;
                decimal totalGeral = ((100 - descontoPercentual) / 100) * valorOriginal;

                if (totalGeral > valorOriginal)
                {
                    MessageBox.Show("Não é possível dar um desconto maior que o valor total.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                txtTotal.Text = totalGeral.ToString("0.00");
                txtDescontoReais.Text = descontoReais.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Os valores inseridos não são válidos.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDescontoPerc.Text = "0";
                txtDescontoReais.Text = "0";
                txtTotal.Text = valorOriginal.ToString();
            }
        }

        private void calculaDescontoReais()
        {
            try
            {
                decimal descontoReais = decimal.Parse(txtDescontoReais.Text);
                decimal descontoPercentual = (descontoReais / valorOriginal) * 100;
                decimal totalGeral = descontoReais - valorOriginal;

                if (descontoReais > valorOriginal)
                {
                    MessageBox.Show("Não é possível dar um desconto maior que o valor total.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                txtTotal.Text = Math.Abs(totalGeral).ToString("0.00");
                txtDescontoPerc.Text = descontoPercentual.ToString("0");
            }
            catch (FormatException)
            {
                MessageBox.Show("Os valores inseridos não são válidos.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescontoReais.Text = "0";
                txtDescontoPerc.Text = "0.00";
                txtTotal.Text = valorOriginal.ToString();
            }
        }
        private void txtDescontoReais_Leave(object sender, EventArgs e)
        {
            calculaDescontoReais();
        }

        private void txtDescontoPerc_Leave(object sender, EventArgs e)
        {
            calculaDesconto();
        }

        #endregion

        #region Recebendo e troco
        private void txtRecebendo_Leave(object sender, EventArgs e)
        {
            CalculaTroco();
        }
        private void CalculaTroco()
        {
            decimal recebendo = decimal.Parse(txtRecebendo.Text);
            troco = recebendo - subtotal;
            txtTroco.Text = troco.ToString();
        }
        #endregion

        #region Finalizando pagamento
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            AtivaPagamento();
            txtSubtotal.Text = txtValorTotal.Text;
            txtTotal.Text = subtotal.ToString();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            DesativaPagamento();
            gridItens.DataSource = null;
            txtValorTotal.Text = "0,00";
        }
        #endregion

        #region Teclas
        private void txtRecebendo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CalculaTroco();
        }
        private void txtDescontoReais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculaDescontoReais();
        }

        private void txtDescontoPerc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                calculaDesconto();
        }
        #endregion
    }
}