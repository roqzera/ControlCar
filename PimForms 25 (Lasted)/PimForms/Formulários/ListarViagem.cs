using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimForms.Classes;
using PimForms.Dao;
using PimForms.Formulários;

namespace PimForms.Formulários
{
    public partial class ListarViagem : Form
    {
        public ListarViagem()
        {
            InitializeComponent();
            Listar();
            dataGridListar.Columns["placa"].HeaderText = "Placa";
            dataGridListar.Columns["nome"].HeaderText = "Nome";
            dataGridListar.Columns["destino"].HeaderText = "Destino";
            dataGridListar.Columns["valor_adiantamento"].HeaderText = "Valor Adiantamento";
            dataGridListar.Columns["data_saida"].HeaderText = "Data Saída";
            dataGridListar.Columns["data_retorno"].HeaderText = "Data Retorno";
            dataGridListar.Columns["km_inicial"].HeaderText = "Km Inicial";
            dataGridListar.Columns["km_final"].HeaderText = "Km Final";
            dataGridListar.Columns["acompanhante1"].HeaderText = "Acompanhante 1";
            dataGridListar.Columns["acompanhante2"].HeaderText = "Acompanhante 2";
            dataGridListar.Columns["acompanhante3"].HeaderText = "Acompanhante 3";
            dataGridListar.Columns["id_viagem"].HeaderText = "Id";
        }

        public void Pesquisar()
        {
            //FuncionarioDao funcionarios = new FuncionarioDao();
            //dataGridListar.DataSource = funcionarios.BuscarFuncionario(matricula);
        }
        

        public void Listar()
        {
            ViagemDao viagemDao = new ViagemDao();
            //strMysql armazena o retorno do método BuscarFuncionario(), que é uma string de comando MySql. 
            string strMysql = viagemDao.ListarViagens();
            // A string strMysql é passada por parâmetro para que o método ExibirNoDataGridView() possa fazer a conexão com o banco e exibir os dados buscados no DataGridView
            dataGridListar.DataSource = viagemDao.ExibirNoDataGridView(strMysql);
            //dataGridListar.Columns["id_funcionario"].Visible = false;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            int idFuncionario = Convert.ToInt32(funcionarioDao.BuscarIdFuncionario("matricula", toolStripTextBoxMatricula.Text));

            VeiculoDao veiculoDao = new VeiculoDao();
            int idVeiculo = Convert.ToInt32(veiculoDao.BuscarIdVeiculo("placa", toolStripTextBoxPlaca.Text));

            ViagemDao viagemDao = new ViagemDao();
            string strMysql = viagemDao.PesquisarViagem(idFuncionario, idVeiculo);

            // A string strMysql é passada por parâmetro para que o método ExibirNoDataGridView() possa fazer a conexão com o banco e exibir os dados buscados no DataGridView
            dataGridListar.DataSource = viagemDao.ExibirNoDataGridView(strMysql);
            //dataGridListar.Columns["id_funcionario"].Visible = false;
        }

        private void ToolStripButtonListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            EditarCadastroViagem editarCadastroViagem = new EditarCadastroViagem();
            try
            {
                if (dataGridListar.SelectedRows.Count > 0)
                {
                    //ViagemDao viagemDao = new ViagemDao();
                    editarCadastroViagem.txtEditarPlaca.Text = dataGridListar.CurrentRow.Cells["placa"].Value.ToString();
                    editarCadastroViagem.txtEditarFuncionario.Text = dataGridListar.CurrentRow.Cells["nome"].Value.ToString();
                    editarCadastroViagem.txtEditarDestino.Text = dataGridListar.CurrentRow.Cells["destino"].Value.ToString();
                    editarCadastroViagem.maskEditarValorAdiantamento.Text = dataGridListar.CurrentRow.Cells["valor_adiantamento"].Value.ToString();
                    editarCadastroViagem.maskedEditarDataSaida.Text = dataGridListar.CurrentRow.Cells["data_saida"].Value.ToString();
                    editarCadastroViagem.maskedEditarDataRetorno.Text = dataGridListar.CurrentRow.Cells["data_retorno"].Value.ToString();
                    editarCadastroViagem.txtEditarKmInicial.Text = dataGridListar.CurrentRow.Cells["km_inicial"].Value.ToString();
                    editarCadastroViagem.txtEditarKmFinal.Text = dataGridListar.CurrentRow.Cells["km_final"].Value.ToString();
                    editarCadastroViagem.txtEditarAcompanhante1.Text = dataGridListar.CurrentRow.Cells["acompanhante1"].Value.ToString();
                    editarCadastroViagem.txtEditarAcompanhante2.Text = dataGridListar.CurrentRow.Cells["acompanhante2"].Value.ToString();
                    editarCadastroViagem.txtEditarAcompanhante3.Text = dataGridListar.CurrentRow.Cells["acompanhante3"].Value.ToString();
                    editarCadastroViagem.lblId.Text = dataGridListar.CurrentRow.Cells["id_viagem"].Value.ToString();
                }

                editarCadastroViagem.ShowDialog();
                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("Esta função será disponibilizada nas próximas versões.");
            }
        }

        VeiculoDao veic = new VeiculoDao();
        FuncionarioDao fun = new FuncionarioDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        private void ListarViagem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < fun.AutoComplete("matricula").Length; i++)
            {
                toolStripTextBoxMatricula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                toolStripTextBoxMatricula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                toolStripTextBoxMatricula.AutoCompleteCustomSource.Add(fun.AutoComplete("matricula")[i]);
            }

            for (int i = 0; i < veic.AutoComplete().Length; i++)
            {
                toolStripTextBoxPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                toolStripTextBoxPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                toolStripTextBoxPlaca.AutoCompleteCustomSource.Add(veic.AutoComplete()[i]);
            }
        }

        private void ToolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            string idViagem = (dataGridListar.CurrentRow.Cells["id_viagem"].Value.ToString());
            ;
            try
            {
                if (dataGridListar.SelectedRows.Count > 0)
                {
                    ViagemDao viagemDao = new ViagemDao();
                    viagemDao.ExcluirViagem(Convert.ToString(idViagem));
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
