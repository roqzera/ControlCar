using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimForms.Dao;
using PimForms.models;

namespace PimForms.Formulários
{
    public partial class ListarCustoViagem : Form
    {
        

        public ListarCustoViagem()
        {
            InitializeComponent();
            Listar();
            dataGridListar.Columns["id_custo"].HeaderText = "Id";
            dataGridListar.Columns["custo_abastecimento"].HeaderText = "Custo Abastecimento";
            dataGridListar.Columns["custo_estacionamento"].HeaderText = "Custo Estacionamento";
            dataGridListar.Columns["custo_pedagio"].HeaderText = "Custo Pedágio";
            dataGridListar.Columns["custo_veiculo"].HeaderText = "Custo Aluguel";
        }

        private void LblTituloForm_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            int idCusto = Convert.ToInt32(txtPesquisa.Text);
            CustoDao custoDao = new CustoDao();
            string strMysql = custoDao.PesquisarCusto(idCusto);
            dataGridListar.DataSource = custoDao.ExibirNoDataGridView(strMysql);
        }

        public void Listar()
        {
            CustoDao custoDao = new CustoDao();
            string strMysql = custoDao.ListarCusto();
            dataGridListar.DataSource = custoDao.ExibirNoDataGridView(strMysql);
        }

        private void ToolStripButtonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            EditarCadastroCustoViagem editarCadastroCustoViagem = new EditarCadastroCustoViagem();

            if (dataGridListar.SelectedRows.Count > 0)
            {
                editarCadastroCustoViagem.txtIdViagem.Text = dataGridListar.CurrentRow.Cells["id_custo"].Value.ToString();
                editarCadastroCustoViagem.txtCustoAbastecimento.Text = dataGridListar.CurrentRow.Cells["custo_abastecimento"].Value.ToString();
                editarCadastroCustoViagem.txtCustoEstacionamento.Text = dataGridListar.CurrentRow.Cells["custo_estacionamento"].Value.ToString();
                editarCadastroCustoViagem.txtCustoPedagio.Text = dataGridListar.CurrentRow.Cells["custo_pedagio"].Value.ToString();
                editarCadastroCustoViagem.txtCustoAluguel.Text = dataGridListar.CurrentRow.Cells["custo_veiculo"].Value.ToString();
            }

            editarCadastroCustoViagem.ShowDialog();
            Listar();
        }

        private void DataGridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
