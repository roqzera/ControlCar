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
using PimForms.Classes;

namespace PimForms.Formulários
{
    public partial class ListarManutencao : Form
    {
        public ListarManutencao()
        {
            InitializeComponent();
            Listar();
            dataGridListar.Columns["placa"].HeaderText = "Placa";
            dataGridListar.Columns["tipo"].HeaderText = "Tipo";
            dataGridListar.Columns["valor"].HeaderText = "Valor";
            dataGridListar.Columns["local"].HeaderText = "Local";
            dataGridListar.Columns["descricao"].HeaderText = "Descrição";
            dataGridListar.Columns["data"].HeaderText = "Data";
            dataGridListar.Columns["quilometragem"].HeaderText = "Quilometragem";
            dataGridListar.Columns["idVeiculo"].Visible = false;
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            EditarCadastroManutencao editarCadastroManutencao = new EditarCadastroManutencao();

            if (dataGridListar.SelectedRows.Count > 0)
            {
                editarCadastroManutencao.txtPlaca.Text = dataGridListar.CurrentRow.Cells["placa"].Value.ToString();
                editarCadastroManutencao.comboBoxTipo.Text = dataGridListar.CurrentRow.Cells["tipo"].Value.ToString();
                editarCadastroManutencao.txtLocal.Text = dataGridListar.CurrentRow.Cells["local"].Value.ToString();
                editarCadastroManutencao.txtValor.Text = dataGridListar.CurrentRow.Cells["valor"].Value.ToString();
                editarCadastroManutencao.txtDescricao.Text = dataGridListar.CurrentRow.Cells["descricao"].Value.ToString();
                editarCadastroManutencao.maskData.Text = dataGridListar.CurrentRow.Cells["data"].Value.ToString();
                editarCadastroManutencao.txtQuilometragem.Text = dataGridListar.CurrentRow.Cells["quilometragem"].Value.ToString();

            }

            editarCadastroManutencao.ShowDialog();
            Listar();
        }

        public void Listar()
        {
            ManutencaoDao manutencaoDao = new ManutencaoDao();
            dataGridListar.DataSource = manutencaoDao.ListarManutencao();
        }

        private void ToolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            ManutencaoDao manutencaoDao = new ManutencaoDao();
            DateTime dataTime = Convert.ToDateTime(toolStripTextBoxData.Text);
            string data = dataTime.ToString("yyyy/MM/dd HH:mm:ss").Replace("/", "-");
            int idManutencao = Convert.ToInt32(manutencaoDao.BuscarIdManutencao(toolStripTextBoxPlaca.Text, data));
            dataGridListar.DataSource = manutencaoDao.BuscarManutencao(idManutencao, data);
        }

        private void ToolStripButtonListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ListarManutencao_Load(object sender, EventArgs e)
        {
            VeiculoDao veiculoDao = new VeiculoDao();

            for (int i = 0; i < veiculoDao.AutoComplete().Length; i++)
            {
                toolStripTextBoxPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                toolStripTextBoxPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                toolStripTextBoxPlaca.AutoCompleteCustomSource.Add(veiculoDao.AutoComplete()[i]);
            }
        }
    }
}
