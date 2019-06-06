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
using PimForms.SubMenus;
using PimForms.Formulários;

namespace PimForms.Formulários
{
    public partial class ListarMulta : Form
    {
        public ListarMulta()
        {
            InitializeComponent();
            Listar();
        }

        Formularios form = new Formularios();
        MultaDAO mult = new MultaDAO();
        VeiculoDao veic = new VeiculoDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        private void ListarMulta_Load(object sender, EventArgs e)
        {
        }

        public void Listar()
        {
            MultaDAO multaDAO = new MultaDAO();
            //strMysql armazena o retorno do método BuscarFuncionario(), que é uma string de comando MySql. 
            string strMysql = multaDAO.ListarMulta();
            // A string strMysql é passada por parâmetro para que o método ExibirNoDataGridView() possa fazer a conexão com o banco e exibir os dados buscados no DataGridView
            dataGridListar.DataSource = multaDAO.ExibirNoDataGridView(strMysql);
            //dataGridListar.Columns["id_funcionario"].Visible = false;
        }
        private void ToolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            string placa = Convert.ToString(txtPesquisa.Text);

            MultaDAO multaDAO = new MultaDAO();
            dataGridListar.DataSource = multaDAO.BuscarMultaLista(placa);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStripButtonListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

       

        private void ToolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            int idMulta;

            if (dataGridListar.SelectedRows.Count > 0)
            {
                MultaDAO multaDAO = new MultaDAO();
                idMulta = multaDAO.BuscarIdMulta("id_multa", dataGridListar.CurrentRow.Cells["id_multa"].Value.ToString());
                multaDAO.ExcluirMulta(idMulta);
            }

            Listar();
        }

        private void ToolStripButtonListar_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStripButtonPesquisar_Click_1(object sender, EventArgs e)
        {
            string placa = Convert.ToString(txtPesquisa.Text);

            MultaDAO multaDAO = new MultaDAO();
            dataGridListar.DataSource = multaDAO.BuscarMultaLista(placa);
        }

        private void ToolStripTextBoxPlacaMulta_Click(object sender, EventArgs e)
        {

        }

        private void ListarMulta_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < veic.AutoComplete().Length; i++)
            {
                txtPesquisa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPesquisa.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtPesquisa.AutoCompleteCustomSource.Add(veic.AutoComplete()[i]);
            }
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            EditarCadastroMulta editarCadastroMulta = new EditarCadastroMulta();

            if (dataGridListar.SelectedRows.Count > 0)
            {
                //ViagemDao viagemDao = new ViagemDao();
                editarCadastroMulta.tbxFuncionario.Text = dataGridListar.CurrentRow.Cells["nome"].Value.ToString();
                editarCadastroMulta.maskedPlaca.Text = dataGridListar.CurrentRow.Cells["placa"].Value.ToString();
                editarCadastroMulta.MaskNumInfracao.Text = dataGridListar.CurrentRow.Cells["numero_infracao"].Value.ToString();
                editarCadastroMulta.maskData.Text = dataGridListar.CurrentRow.Cells["data_multa"].Value.ToString();
                editarCadastroMulta.txtValor.Text = dataGridListar.CurrentRow.Cells["valor"].Value.ToString();
                editarCadastroMulta.lblId.Text = dataGridListar.CurrentRow.Cells["id_multa"].Value.ToString();
            }

            editarCadastroMulta.ShowDialog();
            Listar();
        }
    }
}
