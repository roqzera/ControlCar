using PimForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PimForms.SubMenus;
using PimForms.Dao;

namespace PimForms.Formulários
{
    public partial class CadastrarViagem : Form
    {

        // Exibe uma mensagem em vermelho dizendo que um determinado campo de preenchimento foi preenchido incorretamente, além de trocar a cor da fonte da label para vermelho e apagar o texto da TextBox.
        // Esse método orienta o usuário a verificar em que campo de preechimento a inserção de dados foi incorreta.
        public void ExibeValidacao(string mensagem, TextBox textBox, MaskedTextBox maskedTextBox, Label label)
        {
            labeltesteErro.Text = mensagem;
            label.ForeColor = Color.Red;

            if (maskedTextBox == null)
            {
                textBox.Text = string.Empty;
            }

                if (textBox == null)
                {
                    maskedTextBox.Text = string.Empty;
                }
            
        }

        // Apaga a mensagem de texto e retorna a cor da fonte da label para DimGray quando o usuário clica na TextBox.
        public void EscondeValidacao(Label label)
        {
            labeltesteErro.Text = string.Empty;
            label.ForeColor = Color.DimGray;
        }

        // Limpa todos os campos do formulário.
        public void LimpaTextBox()
        {
            maskedDataRetorno.Text = string.Empty;
            maskedDataSaida.Text =  string.Empty;
            tbxPlaca.Text =  string.Empty; 
            txtFuncionario.Text = string.Empty;
            tbxDestino.Text = string.Empty;
            tbxKmFinal.Text = string.Empty;
            tbxKmInicial.Text = string.Empty;
            maskValorAdiantamento.Text = string.Empty;
        }

        public CadastrarViagem()
        {
            InitializeComponent();
        }

        AcompanhanteDao acompanhanteDao = new AcompanhanteDao();
        Formularios formularios = new Formularios();
        VeiculoDao veic = new VeiculoDao();
        FuncionarioDao fun = new FuncionarioDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        CadastrarAcompanhante CadastrarOcupantes = new CadastrarAcompanhante();

        public void CadastrarViagem_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < fun.AutoComplete("nome").Length; i++)
            {
                txtFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtFuncionario.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtFuncionario.AutoCompleteCustomSource.Add(fun.AutoComplete("nome")[i]);
            }

            for (int i = 0; i < veic.AutoComplete().Length; i++)
            {
                tbxPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbxPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbxPlaca.AutoCompleteCustomSource.Add(veic.AutoComplete()[i]);
            }
        }
                   
        private void LblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Viagem viagem = new Viagem(
                    Convert.ToDateTime(maskedDataSaida.Text),
                    Convert.ToDateTime(maskedDataRetorno.Text),
                    Convert.ToString(tbxDestino.Text),
                    Convert.ToDecimal(maskValorAdiantamento.Text),
                    Convert.ToDecimal(tbxKmInicial.Text),
                    Convert.ToDecimal(tbxKmFinal.Text),
                    Convert.ToInt32(veic.BuscarIdVeiculo("placa", tbxPlaca.Text)),
                    Convert.ToInt32(fun.BuscarIdFuncionario("nome", txtFuncionario.Text)),
                    Convert.ToInt32(acompanhanteDao.BuscarIdAcompanhante())
                    );

                if (labeltesteErro.Text == string.Empty)
                {
                    if (viagem.DataSaida == null)
                    {
                        ExibeValidacao("Atenção: A data inserida é inválida. É necessário inserir uma Data válida.", null, maskedDataSaida, lblDataSaida);
                    }
                    else
                    {
                        if (viagem.DataRetorno == null)
                        {
                            ExibeValidacao("Atenção: A data inserida é inválida. É necessário inserir uma Data válida.", null, maskedDataRetorno, lblDataRetorno);
                        }
                        else
                        {
                            if (viagem.Destino == string.Empty)
                            {
                                ExibeValidacao("Atenção: Preencha o destino.", tbxDestino, null, lblDestino);
                            }
                            else
                            {
                                if (viagem.ValorAdiantamento < 0)
                                {
                                    ExibeValidacao("Atenção: O valor do Adiantamento não pode ser negativo.", null, maskValorAdiantamento, lblValorAdiantamento);
                                }
                                else
                                {
                                    if (viagem.KmInicial < 0)
                                    {
                                        ExibeValidacao("Atenção: Motor não selecionado. É necessário inserir um Motor.", tbxKmInicial, null, lblKmInicial);
                                    }
                                    else
                                    {
                                        if (viagem.KmFinal < viagem.KmInicial)
                                        {
                                            ExibeValidacao("Atenção: Cor não selecionada. É necessário inserir uma cor.", tbxKmFinal, null, lblKmFinal);
                                        }
                                        else
                                        {
                                            if (viagem.IdFuncionario == 0)
                                            {
                                                ExibeValidacao("Atenção: Funcionario não encontrado. Respeite o autopreenchimento.", txtFuncionario, null, lblNome);

                                            }
                                            else
                                            {
                                                if (viagem.IdVeiculo == 0)
                                                {
                                                    ExibeValidacao("Atenção: Veículo não encontrado. Respeite o autopreenchimento", tbxPlaca, null, lblPlacaVeiculo);

                                                }
                                                else
                                                {
                                                    CadastrarAcompanhante cadastrarOcupantes = new CadastrarAcompanhante();
                                                    cadastrarOcupantes.ShowDialog();

                                                    ViagemDao viagemDao = new ViagemDao();
                                                    viagemDao.AdicionarViagem(viagem);

                                                    if (labeltesteErro.Text == string.Empty)
                                                    {
                                                        if (viagem.IdFuncionario != 0
                                                        && viagem.IdVeiculo != 0
                                                        && viagem.Destino != null
                                                        && viagem.ValorAdiantamento != 0
                                                        && viagem.DataRetorno!= null
                                                        && viagem.DataSaida != null
                                                        && viagem.KmFinal != 0
                                                        && viagem.KmInicial != 0
                                                        )
                                                        {
                                                            labeltesteErro.Text = string.Empty;
                                                            LimpaTextBox();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                if (tbxPlaca.Text == string.Empty
                        || txtFuncionario.Text == string.Empty
                        || tbxDestino.Text == string.Empty
                        || maskValorAdiantamento.Text == string.Empty
                        || maskedDataRetorno.Text.Replace("/", "").Replace("_", "").Replace(" ", "") == string.Empty
                        || maskedDataSaida.Text.Replace("/", "").Replace("_", "").Replace(" ", "") == string.Empty
                        || tbxKmFinal.Text == string.Empty
                        || tbxKmInicial.Text == string.Empty
                )
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;
                }
            }
        }

        private void TbxMatricula_TextChanged(object sender, EventArgs e)
        {
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbxPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMatriculaFuncionario_TextChanged(object sender, EventArgs e)
        {

        }



        private void MaskedDataSaida_Click(object sender, EventArgs e)
        {
            maskedDataSaida.Focus();
            maskedDataSaida.SelectionStart = 0;
            EscondeValidacao(lblDataSaida);
        }

        private void MaskedDataRetorno_Click(object sender, EventArgs e)
        {
            maskedDataRetorno.Focus();
            maskedDataRetorno.SelectionStart = 0;
            EscondeValidacao(lblDataRetorno);
        }

        private void TxtFuncionario_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblNome);
        }

        private void TbxPlaca_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblPlacaVeiculo);
        }

        private void TbxDestino_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblDestino);
        }

        private void MaskValorAdiantamento_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblValorAdiantamento);
        }

        private void TbxKmInicial_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblKmInicial);

        }

        private void TbxKmFinal_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblKmFinal);

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
