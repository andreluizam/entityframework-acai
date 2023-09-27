using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OficinaMecanica
{
    public partial class TelaDeCadastroFuncionarios : Form
    {
        public TelaDeCadastroFuncionarios()
        {
            InitializeComponent();
            desabilitaBotao();
        }
        // ESTABELECENDO CONEXAO COM O BANCO DE DADOS SQL SERVER
        SqlConnection conexao = new SqlConnection(@"Data Source=ANDRÉ\SQLEXPRESS;integrated security =SSPI;initial Catalog=SAOLAZARO");
        // INSTANCIANDO COMANDOS DO SQL

        SqlCommand comandoSql = new SqlCommand();

        SqlDataReader bancoDeDados;

        private void desabilitaBotao()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;

            btnNovo.Enabled = true;
            lblNovo.Enabled = true;

            btnSalvar.Enabled = false;
            lblSalvar.Enabled = false;

            btnCancelar.Visible = false;
            lblCancelar.Visible = false;

        }
        private void habilitaBotao()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;

            btnNovo.Enabled = true;
            lblNovo.Enabled = true;

            btnSalvar.Enabled = true;
            lblSalvar.Enabled = true;
        }

        private void limparCampos()
        {
            lblCodi.Text = "";
            txtNome.Text = "";
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaBotao();
            btnNovo.Visible = false;
            lblNovo.Visible = false;
            btnCancelar.Visible = true;
            lblCancelar.Visible = true;
            txtNome.Focus();
            txtPesquisa.Text = "";
            dataGridView1.DataSource = null;
        }

        private void manipulaDados()
        {
            btnAlterar.Enabled = true;
            btnApagar.Enabled = true;

            btnNovo.Enabled = false;
            lblNovo.Enabled = false;

            btnSalvar.Enabled = false;
            lblSalvar.Enabled = false;

            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtNome.Enabled = true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaBotao();
            btnNovo.Visible = true;
            lblNovo.Visible = true;
            txtPesquisa.Text = "";
            dataGridView1.DataSource = null;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                try
                {
                    conexao.Open();
                    comandoSql.CommandText = "select * from tbl_Usuarios where db_NomeDoAtendente like ('%" + txtPesquisa.Text + "%')";
                    comandoSql.Connection = conexao;

                    // recebe os dados de uma tabela depois do select
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    // pode apresentar uma ou mais tabelas de dados alocadas na memoria
                    DataTable dataTable = new DataTable();

                    // pega o select e joga dentro do adapter
                    adapter.SelectCommand = comandoSql;
                    adapter.Fill(dataTable);
                    // preenche a tabela

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].Width = 50;
                    dataGridView1.Columns[0].HeaderText = "Código";

                    dataGridView1.Columns[1].Width = 200;
                    dataGridView1.Columns[1].HeaderText = "Login";

                    dataGridView1.Columns[2].Visible = false;
                    

                    dataGridView1.Columns[3].Width = 300;
                    dataGridView1.Columns[3].HeaderText = "Nome";

                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
        private void carregaUsuario()
        {
            lblCodi.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtLogin.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            manipulaDados();

            btnCancelar.Visible = true;
            lblCancelar.Visible = true;
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaUsuario();
        }
    }
}