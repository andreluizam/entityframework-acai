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
using System.Windows.Media;

namespace OficinaMecanica
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        // ESTABELECENDO CONEXAO COM O BANCO DE DADOS SQL SERVER
        SqlConnection conexao = new SqlConnection(@"Data Source=ANDRÉ\SQLEXPRESS;integrated security =SSPI;initial Catalog=SAOLAZARO");
        // INSTANCIANDO COMANDOS DO SQL
        SqlCommand comandoSql = new SqlCommand();

        SqlDataReader bancoDeDados;

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            logar();
        }

        private void logar()
        {
            // condicao caso campo login e senha esteja vazio
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório o preenchimento de todos os dados", "Cuidado !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLogin.Focus();
            }
            else
            {
                try
                {
                    // aqui acontece a verificacao com o banco de dados
                    conexao.Open();
                    comandoSql.CommandText = "select * from tbl_Usuarios where db_LoginDoUsuario =('" + txtLogin.Text + "') and db_SenhaDoUsuario=('" + txtSenha.Text + "')";
                    comandoSql.Connection = conexao;
                    bancoDeDados = comandoSql.ExecuteReader();


                    if (bancoDeDados.HasRows)
                    {
                        // SE ENTRAR NESSA CONDICAO ABRE A TELA PRINCIPAL
                        TelaPrincipal telaPrincipal = new TelaPrincipal();
                        telaPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                logar();
            }
        }
    }
}

