using ProjetoAcai.Contexto;
using ProjetoAcai.Modelo;
using ProjetoAcai.Pesquisa;

namespace ProjetoAcai.Telas
{
    public partial class CadastroItens : Form
    {
        public CadastroItens()
        {
            InitializeComponent();
        }
        #region Variáveis
        private int adicionalID;
        #endregion

        #region Limpa campo
        private void LimpaCampos()
        {
            txtNome.Clear();
            txtCodiBarra.Clear();
            txtValor.Clear();
        }
        #endregion

        #region Manipulação de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Adicionais adicional;
            using (DataContext context = new DataContext())
            {
                adicional = new Adicionais();

                adicional.Nome = txtNome.Text;
                adicional.CodigoBarra = txtCodiBarra.Text;
                adicional.Valor = Convert.ToDecimal(txtValor.Text);

                context.Add(adicional);
                context.SaveChanges();
            }
            MessageBox.Show("Gravação feita com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Adicionais adicional = null;
            using (DataContext context = new DataContext())
            {
                adicional = context.Adicionais.FirstOrDefault(o => o.ID == adicionalID);
                adicional.Nome = txtNome.Text;
                adicional.CodigoBarra = txtCodiBarra.Text;
                adicional.Valor = Convert.ToDecimal(txtValor.Text);
                context.SaveChanges();
            }
            MessageBox.Show("Alteração realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            LimpaCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaItem pesquisa = new PesquisaItem();
            pesquisa.ShowDialog();

            if (pesquisa.AdicionalSelecionado != null)
            {
                adicionalID = pesquisa.AdicionalSelecionado.ID;
                txtNome.Text = pesquisa.AdicionalSelecionado.Nome;
                txtCodiBarra.Text = pesquisa.AdicionalSelecionado.CodigoBarra;
                txtValor.Text = pesquisa.AdicionalSelecionado.Valor.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Adicionais adicional = null;
            using (DataContext context = new DataContext())
            {
                adicional = context.Adicionais.FirstOrDefault(o => o.ID == adicionalID);
                context.Remove(adicional);
                context.SaveChanges();
            }
            MessageBox.Show("Exclusão realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }
        #endregion
    }
}