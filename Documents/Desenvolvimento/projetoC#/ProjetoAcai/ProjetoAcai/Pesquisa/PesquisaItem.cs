using ProjetoAcai.Contexto;
using ProjetoAcai.Modelo;
using System.Windows.Forms;

namespace ProjetoAcai.Pesquisa
{
    public partial class PesquisaItem : Form
    {
        public PesquisaItem()
        {
            InitializeComponent();
        }

        List<Adicionais> lstAdicionais;
        private Adicionais adicionalSelecionado;

        private void PesquisaItem_Load(object sender, EventArgs e)
        {
            List<Adicionais> lstAdicionais = new List<Adicionais>();
            CarregaDados();
        }
        #region Carrega dados
        private void CarregaDados()
        {
            using (DataContext context = new DataContext())
            {
                lstAdicionais = context.Adicionais.ToList();
                gridPesquisaItens.DataSource = lstAdicionais.ToList();
            }
        }
        #endregion

        #region Captura dados
        private void gridPesquisaItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridPesquisaItens.Rows.Count)
            {
                adicionalSelecionado = new Adicionais
                {
                    ID = int.Parse(gridPesquisaItens.Rows[e.RowIndex].Cells["ID"].Value.ToString()),
                    Nome = gridPesquisaItens.Rows[gridPesquisaItens.CurrentRow.Index].Cells["Nome"].Value.ToString(),
                    CodigoBarra = gridPesquisaItens.Rows[gridPesquisaItens.CurrentRow.Index].Cells["CodigoBarra"].Value.ToString(),
                    Valor = decimal.Parse(gridPesquisaItens.Rows[gridPesquisaItens.CurrentRow.Index].Cells["Valor"].Value.ToString()),
                };
                this.Close();
            }
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            if (txtItem != null)
            {
                string nomePesquisa = txtItem.Text.Trim();
                using (DataContext context = new DataContext())
                {
                    var resultados = context.Adicionais
                        .Where(adicional => adicional.CodigoBarra.Contains(nomePesquisa))
                    .ToList();

                    gridPesquisaItens.DataSource = resultados;
                }
            }
        }

        public Adicionais AdicionalSelecionado
        {
            get { return adicionalSelecionado; }
        }
        #endregion
    }
}
