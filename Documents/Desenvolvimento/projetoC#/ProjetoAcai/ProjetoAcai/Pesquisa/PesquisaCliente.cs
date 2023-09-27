using ProjetoAcai.Contexto;
using ProjetoAcai.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcai.Pesquisa
{
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente()
        {
            InitializeComponent();
        }
        private Clientes clienteSelecionado;
        private List<Clientes> lstClientes = new List<Clientes>();

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                lstClientes = context.Clientes.ToList();
                gridClientes.DataSource = lstClientes.ToList();
            }
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gridClientes.Rows.Count)
            {
                clienteSelecionado = new Clientes
                {
                    ID = int.Parse(gridClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString()),
                    Nome = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Nome"].Value.ToString(),
                    Telefone = gridClientes.Rows[gridClientes.CurrentRow.Index].Cells["Telefone"].Value.ToString()
                };
            }
            this.Close();
        }
        public Clientes ClienteSelecionado
        {
            get { return clienteSelecionado; }
        }
    }
}



