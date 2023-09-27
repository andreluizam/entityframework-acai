using Microsoft.EntityFrameworkCore.Query.Internal;
using ProjetoAcai.Contexto;
using ProjetoAcai.Modelo;
using ProjetoAcai.Pesquisa;

namespace ProjetoAcai.Telas
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private int clienteID;

        private void LimpaCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
        }
        #region Manipulação de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente;
            using (DataContext context = new DataContext())
            {
                cliente = new Clientes();
                cliente.Nome = txtNome.Text;
                cliente.Telefone = txtTelefone.Text;
                context.Add(cliente);
                context.SaveChanges();
            }
            MessageBox.Show("Gravação realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Clientes cliente;
            using (DataContext context = new DataContext())
            {
                cliente = context.Clientes.FirstOrDefault(o => o.ID == clienteID);
                cliente.Nome = txtNome.Text;
                cliente.Telefone = txtTelefone.Text;
                context.SaveChanges();
            }
            MessageBox.Show("Alteração realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesquisa = new PesquisaCliente();
            pesquisa.ShowDialog();

            if (pesquisa.ClienteSelecionado != null)
            {
                clienteID = pesquisa.ClienteSelecionado.ID;
                txtNome.Text = pesquisa.ClienteSelecionado.Nome;
                txtTelefone.Text = pesquisa.ClienteSelecionado.Telefone;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Clientes cliente = null;
            using (DataContext context = new DataContext())
            {
                cliente = context.Clientes.FirstOrDefault(o => o.ID == clienteID);
                context.Remove(cliente);
                context.SaveChanges();
            }
            MessageBox.Show("Exclusão realizada com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpaCampos();
        }
        #endregion

    }
}
