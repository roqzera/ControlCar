using PimForms.Classes;
using PimForms.SubMenus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.Formulários
{
    public partial class ListarVeiculos : Form
    {
        public ListarVeiculos()
        {
            InitializeComponent();
            Listar();
            dataGridListar.Columns["placa"].HeaderText = "Placa";
            dataGridListar.Columns["numerorenavam"].HeaderText = "Número RENAVAM";
            dataGridListar.Columns["marca"].HeaderText = "Marca";
            dataGridListar.Columns["modelo"].HeaderText = "Modelo";
            dataGridListar.Columns["motor"].HeaderText = "Motor";
            dataGridListar.Columns["cor"].HeaderText = "Cor";
            dataGridListar.Columns["ano"].HeaderText = "Ano";
            dataGridListar.Columns["quilometragem"].HeaderText = "Quilometragem";
            dataGridListar.Columns["tipodeveiculo"].HeaderText = "Tipo Veículo";
        }

        VeiculoDao veic = new VeiculoDao();

        private void ListarVeiculos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < veic.AutoComplete().Length; i++)
            {
                toolStripTextBoxPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                toolStripTextBoxPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                toolStripTextBoxPlaca.AutoCompleteCustomSource.Add(veic.AutoComplete()[i]);
            }
        }

        private void Listar()
        {
            VeiculoDao veiculoDao = new VeiculoDao();
            dataGridListar.DataSource = veiculoDao.ListarVeiculos();
            //dataGridListar.Columns["id_veiculo"].Visible = false;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void DataGridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            string placa = Convert.ToString(toolStripTextBoxPlaca.Text);

            VeiculoDao veiculoDao = new VeiculoDao();
            dataGridListar.DataSource = veiculoDao.BuscarVeiculo(placa, "Ativo");
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            EditarCadastroVeiculo editarCadastroVeiculo = new EditarCadastroVeiculo();

            if(dataGridListar.SelectedRows.Count > 0)
            {
                editarCadastroVeiculo.maskedPlaca.Text = dataGridListar.CurrentRow.Cells["placa"].Value.ToString();
                editarCadastroVeiculo.maskedRenavam.Text = dataGridListar.CurrentRow.Cells["numerorenavam"].Value.ToString();
                editarCadastroVeiculo.cmbMarca.Text = dataGridListar.CurrentRow.Cells["marca"].Value.ToString();
                editarCadastroVeiculo.cmbModelo.Text = dataGridListar.CurrentRow.Cells["modelo"].Value.ToString();
                editarCadastroVeiculo.cmbMotor.Text = dataGridListar.CurrentRow.Cells["motor"].Value.ToString();
                editarCadastroVeiculo.cmbCor.Text = dataGridListar.CurrentRow.Cells["cor"].Value.ToString();
                editarCadastroVeiculo.cmbAno.Text = dataGridListar.CurrentRow.Cells["ano"].Value.ToString();
                editarCadastroVeiculo.tbxKm.Text = dataGridListar.CurrentRow.Cells["quilometragem"].Value.ToString();
                editarCadastroVeiculo.cmbTipoVeiculo.Text = dataGridListar.CurrentRow.Cells["tipodeveiculo"].Value.ToString();

            }

            editarCadastroVeiculo.ShowDialog();
            Listar();
        }

        private void ToolStripButtonListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void DataGridListar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripTextBoxPlaca_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridListar.SelectedRows.Count > 0)
                {
                    VeiculoDao veiculoDao = new VeiculoDao();
                    int id = veiculoDao.BuscarIdVeiculo("placa", dataGridListar.CurrentRow.Cells["placa"].Value.ToString());
                    veiculoDao.ExcluirVeiculo(id);
                }

                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("Este veículo está sendo utilizado em uma viagem, logo não poderá ser excluído.");
            }
        }
    }
}
