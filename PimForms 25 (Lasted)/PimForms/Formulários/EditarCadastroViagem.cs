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
using PimForms.Formulários;

namespace PimForms.Formulários
{
    public partial class EditarCadastroViagem : Form
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
        public EditarCadastroViagem()
        {
            InitializeComponent();
        }

        VeiculoDao veic = new VeiculoDao();
        FuncionarioDao fun = new FuncionarioDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

        private void TxtEditarAcompanhante2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoDao veiculoDao = new VeiculoDao();
                FuncionarioDao funcionarioDao = new FuncionarioDao();
                ViagemDao viagemDao = new ViagemDao();

                Viagem viagem = new Viagem(
                Convert.ToDateTime(maskedEditarDataSaida.Text),
                Convert.ToDateTime(maskedEditarDataRetorno.Text),
                txtEditarDestino.Text,
                Convert.ToDecimal(maskEditarValorAdiantamento.Text),
                Convert.ToDecimal(txtEditarKmInicial.Text),
                Convert.ToDecimal(txtEditarKmFinal.Text),
                veiculoDao.BuscarIdVeiculo("placa", txtEditarPlaca.Text),
                Convert.ToInt32(funcionarioDao.BuscarIdFuncionario("nome", txtEditarFuncionario.Text)),
                0
                );
                
                if (labeltesteErro.Text == string.Empty)
                {
                    if (viagem.DataSaida == null)
                    {
                        ExibeValidacao("* A data inserida é inválida. É necessário inserir uma Data válida.", null, maskedEditarDataSaida, lblDataSaida);
                    }
                    else
                    {
                        if (viagem.DataRetorno == null)
                        {
                            ExibeValidacao("* A data inserida é inválida. É necessário inserir uma Data válida.", null, maskedEditarDataRetorno, lblDataRetorno);
                        }
                        else
                        {
                            if (viagem.Destino == string.Empty)
                            {
                                ExibeValidacao("* Preencha o destino.", txtEditarDestino, null, lblDestino);
                            }
                            else
                            {
                                if (viagem.ValorAdiantamento < 0)
                                {
                                    ExibeValidacao("* O valor do Adiantamento não pode ser negativo.", null, maskEditarValorAdiantamento, lblValorAdiantamento);
                                }
                                else
                                {
                                    if (viagem.KmInicial < 0)
                                    {
                                        ExibeValidacao("* Motor não selecionado. É necessário inserir um Motor.", txtEditarKmInicial, null, lblKmInicial);
                                    }
                                    else
                                    {
                                        if (viagem.KmFinal < viagem.KmInicial)
                                        {
                                            ExibeValidacao("* Cor não selecionada. É necessário inserir uma cor.", txtEditarKmFinal, null, lblKmFinal);
                                        }
                                        else
                                        {
                                            if (viagem.IdFuncionario == 0)
                                            {
                                                ExibeValidacao("* Funcionario não encontrado. Respeite o autopreenchimento.", txtEditarFuncionario, null, lblNome);
                                            }
                                            else
                                            {
                                                if (viagem.IdVeiculo == 0)
                                                {
                                                    ExibeValidacao("* Veículo não encontrado. Respeite o autopreenchimento", txtEditarPlaca, null, lblPlacaVeiculo);
                                                }
                                                else
                                                {

                                                   string ex = viagemDao.EditarViagem(viagem, Convert.ToInt32(lblId.Text));

                                                    if (labeltesteErro.Text == string.Empty)
                                                    {
                                                        if (viagem.IdFuncionario != 0
                                                        && viagem.IdVeiculo != 0
                                                        && viagem.Destino != null
                                                        && viagem.ValorAdiantamento != 0
                                                        && viagem.DataRetorno != null
                                                        && viagem.DataSaida != null
                                                        && viagem.KmFinal != 0
                                                        && viagem.KmInicial != 0
                                                        )
                                                        {
                                                            labeltesteErro.Text = string.Empty;
                                              
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
                if (txtEditarPlaca.Text == string.Empty
                        || txtEditarFuncionario.Text == string.Empty
                        || txtEditarDestino.Text == string.Empty
                        || maskEditarValorAdiantamento.Text == string.Empty
                        || maskedEditarDataRetorno.Text.Replace("/", "").Replace("_", "").Replace(" ", "") == string.Empty
                        || maskedEditarDataSaida.Text.Replace("/", "").Replace("_", "").Replace(" ", "") == string.Empty
                        || txtEditarKmFinal.Text == string.Empty
                        || txtEditarKmInicial.Text == string.Empty
                )
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;
                }
            }
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarCadastroViagem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < fun.AutoComplete("nome").Length; i++)
            {
                txtEditarFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtEditarFuncionario.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtEditarFuncionario.AutoCompleteCustomSource.Add(fun.AutoComplete("nome")[i]);
            }

            for (int i = 0; i < veic.AutoComplete().Length; i++)
            {
                txtEditarPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtEditarPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtEditarPlaca.AutoCompleteCustomSource.Add(veic.AutoComplete()[i]);
            }
        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}