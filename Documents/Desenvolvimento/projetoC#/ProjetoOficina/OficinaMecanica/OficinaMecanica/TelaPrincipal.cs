using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            TelaDeCadastroFuncionarios telaDeCadastroFuncionarios = new TelaDeCadastroFuncionarios();
            telaDeCadastroFuncionarios.Show();
        }

        private void btnClientesTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaDeCadastroClientes telaDeCadastroClientes = new TelaDeCadastroClientes();
            telaDeCadastroClientes.Show();
        }

        private void btnSairDoSistema_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja sair do sistema ?", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
