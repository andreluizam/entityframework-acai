namespace ProjetoAcai.Telas
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes cadastroClientes = new CadastroClientes();
            cadastroClientes.ShowDialog();
        }

        private void bntProdutos_Click(object sender, EventArgs e)
        {
            CadastroItens cadastroItens = new CadastroItens();
            cadastroItens.ShowDialog();
        }
    }
}
