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
    public partial class ListarFuncionario : Form
    {
        public ListarFuncionario()
        {
            InitializeComponent();
            Listar();
            dataGridListar.Columns["matricula"].HeaderText = "Matrícula";
            dataGridListar.Columns["nome"].HeaderText = "Nome";
            dataGridListar.Columns["cpf"].HeaderText = "CPF";
            dataGridListar.Columns["datadenascimento"].HeaderText = "Data Nascimento";
            dataGridListar.Columns["telefone"].HeaderText = "Telefone";
            dataGridListar.Columns["cargo"].HeaderText = "Cargo";
            dataGridListar.Columns["email"].HeaderText = "E-mail";
            dataGridListar.Columns["numerocnh"].HeaderText = "Número CNH";
            dataGridListar.Columns["CategoriaCNH"].HeaderText = "Categoria CNH";
            dataGridListar.Columns["validadecnh"].HeaderText = "Validade CNH";

        }

        Formularios form = new Formularios();
        FuncionarioDao fun = new FuncionarioDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        private void ListarFuncionario_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < fun.AutoComplete("matricula").Length; i++)
            {
                toolStripTextBoxMatricula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                toolStripTextBoxMatricula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                toolStripTextBoxMatricula.AutoCompleteCustomSource.Add(fun.AutoComplete("matricula")[i]);
            }
        }
        // Método usado para listar todos os funcionários cadastrados no DataGridView assim que o form EditarCadastroFuncionario é inicializado
        public void Listar()
        {
            FuncionarioDao funcionarios = new FuncionarioDao();
            dataGridListar.DataSource = funcionarios.ListarFuncionario();

        }

        private void ToolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            string matricula = Convert.ToString(toolStripTextBoxMatricula.Text);

            FuncionarioDao funcionarios = new FuncionarioDao();
            dataGridListar.DataSource = funcionarios.BuscarFuncionario(matricula, "Ativo");
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            // Abre o form EditarCadastroFuncionario
            EditarCadastroFuncionario editarCadastroFuncionario = new EditarCadastroFuncionario();

            if (dataGridListar.SelectedRows.Count > 0)
            {
                FuncionarioDao funcionarios = new FuncionarioDao();

                editarCadastroFuncionario.maskMatricula.Text = dataGridListar.CurrentRow.Cells["matricula"].Value.ToString();
                editarCadastroFuncionario.txtNome.Text = dataGridListar.CurrentRow.Cells["nome"].Value.ToString();
                editarCadastroFuncionario.maskCPF.Text = dataGridListar.CurrentRow.Cells["cpf"].Value.ToString();
                editarCadastroFuncionario.maskDataNascimento.Text = dataGridListar.CurrentRow.Cells["datadenascimento"].Value.ToString();
                editarCadastroFuncionario.maskTelefone.Text = dataGridListar.CurrentRow.Cells["telefone"].Value.ToString();
                editarCadastroFuncionario.txtCargo.Text = dataGridListar.CurrentRow.Cells["cargo"].Value.ToString();
                editarCadastroFuncionario.txtEmail.Text = dataGridListar.CurrentRow.Cells["email"].Value.ToString();
                editarCadastroFuncionario.maskNumeroCnh.Text = dataGridListar.CurrentRow.Cells["numerocnh"].Value.ToString();
                editarCadastroFuncionario.comboBoxCategoriaCnh.Text = dataGridListar.CurrentRow.Cells["CategoriaCNH"].Value.ToString();
                editarCadastroFuncionario.maskValidadeCNH.Text = dataGridListar.CurrentRow.Cells["validadecnh"].Value.ToString();
            }

            editarCadastroFuncionario.ShowDialog();
            Listar();
        }

        private void ToolStripButtonListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void DataGridListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LblTituloForm_Click(object sender, EventArgs e)
        {

        }



        private void DataGridListar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            int idFuncionario;
            try
            {
                if (dataGridListar.SelectedRows.Count > 0)
                {
                    FuncionarioDao funcionarioDao = new FuncionarioDao();
                    idFuncionario = funcionarioDao.BuscarIdFuncionario("matricula", dataGridListar.CurrentRow.Cells["matricula"].Value.ToString());
                    funcionarioDao.ExcluirFuncionario(idFuncionario);
                }

                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("Este funcionário está sendo utilizado em uma viagem, logo não poderá ser excluído.");
            }
        }
    }
}
