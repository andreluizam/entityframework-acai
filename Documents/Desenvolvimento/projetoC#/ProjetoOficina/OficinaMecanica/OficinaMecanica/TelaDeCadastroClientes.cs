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
using Correios;


namespace OficinaMecanica
{
    public partial class TelaDeCadastroClientes : Form
    {
        public TelaDeCadastroClientes()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCep.Text))
                {
                    MessageBox.Show("Preencha o CEP para fazer a busca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCep.TextLength < 8)
                {
                    MessageBox.Show("Preencha todos os números do CEP.", "Falta de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(txtCep.Text);

                    txtEstado.Text = retorno.uf;
                    txtCidade.Text = retorno.cidade;
                    txtRua.Text = retorno.end;
                    txtBairro.Text = retorno.bairro;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("CEP Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
