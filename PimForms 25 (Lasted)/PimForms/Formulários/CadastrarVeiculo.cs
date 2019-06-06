using PimForms.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PimForms
{
    public partial class CadastrarVeiculo : Form
    {


        public CadastrarVeiculo()
        {
            InitializeComponent();
        }

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
            else
            {
                if (textBox == null)
                {
                    maskedTextBox.Text = string.Empty;
                }
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
            maskedPlaca.Text = string.Empty;
            cmbMarca.SelectedIndex = -1;
            cmbModelo.SelectedIndex = -1;
            cmbMotor.SelectedIndex = -1;
            cmbCor.SelectedIndex = -1;
            cmbAno.SelectedIndex = -1;
            cmbTipoVeiculo.SelectedIndex = -1;
            maskedRenavam.Text = string.Empty;
            tbxKm.Text = string.Empty;
        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo cad = new Veiculo(maskedPlaca.Text,
                    maskedRenavam.Text,
                    cmbMarca.Text,
                    cmbModelo.Text,
                    cmbMotor.Text,
                    cmbCor.Text,
                    cmbAno.Text,
                    Convert.ToDecimal(tbxKm.Text),
                    Convert.ToString(cmbTipoVeiculo.Text),
                    "Ativo"
                    );

                if (labeltesteErro.Text == string.Empty)
                {
                    if (cad.Placa == null)
                    {
                        ExibeValidacao("* Placa incorreta. É necessário ter 3 letras e 4 números para obter uma Placa válida.", null, maskedPlaca, lblPlaca);
                    }
                    else
                    {
                        if (cad.NumeroRenavam == null)
                        {
                            ExibeValidacao("* Renavam incorreto. É necessário inserir um Renavam válido.", null, maskedRenavam, lblRenavam);
                        }
                        else
                        {
                            if (cad.Marca == string.Empty)
                            {
                                ExibeValidacao("* Marca não selecionada. É necessário inserir uma Marca.", null, null, lblMarca);
                            }
                            else
                            {
                                if (cad.Modelo == string.Empty)
                                {
                                    ExibeValidacao("* Modelo não selecionado. É necessário inserir uma Marca.", null, null, lblModelo);
                                }
                                else
                                {
                                    if (cad.Motor == string.Empty)
                                    {
                                        ExibeValidacao("* Motor não selecionado. É necessário inserir um Motor.", null, null, lblMotor);
                                    }
                                    else
                                    {
                                        if (cad.Cor == string.Empty)
                                        {
                                            ExibeValidacao("* Cor não selecionada. É necessário inserir uma cor.", null, null, lblCor);
                                        }
                                        else
                                        {
                                            if (cad.Ano == string.Empty)
                                            {
                                                ExibeValidacao("* Ano não selecionado. É necessário inserir um Ano;", null, null, lblAno);
                                            }
                                            else
                                            {
                                                if (cad.Quilometragem < 0)
                                                {
                                                    ExibeValidacao("* Quilometragem inválida. É necessário inserir um valor igual ou maior que 0.", tbxKm, null, lblKm);
                                                }
                                                else
                                                {
                                                    if (cad.TipoDeVeiculo == string.Empty)
                                                    {
                                                        ExibeValidacao("* É necessário inserir um Tipo.", null, null, lblTipoDeVeiculo);
                                                    }
                                                    else
                                                    {

                                                        VeiculoDao veiculoDao = new VeiculoDao();
                                                        string ex = veiculoDao.AdicionarVeiculo(cad);

                                                        if (ex.Contains("numero_renavam_UNIQUE"))                //throw ex;
                                                        {
                                                            MessageBox.Show("Número do Renavam já cadastrado.");
                                                        }
                                                        else
                                                        {
                                                            if (ex.Contains("placa_UNIQUE"))                //throw ex;
                                                            {
                                                                MessageBox.Show("Placa já cadastrado.");
                                                            }
                                                            else
                                                            {

                                                                if (labeltesteErro.Text == string.Empty)
                                                                {

                                                                    if (cad.Placa != null
                                                                    && cad.NumeroRenavam != null
                                                                    && cad.Marca != null
                                                                    && cad.Modelo != null
                                                                    && cad.Motor != null
                                                                    && cad.Cor != null
                                                                    && cad.Ano != null
                                                                    && cad.TipoDeVeiculo != null
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
                    }
                }
            }
            catch (Exception)
            {
                if (maskedPlaca.Text.Replace("-", "").Replace("_", "") == string.Empty
                        || maskedRenavam.Text.Replace("_", "") == string.Empty
                        || tbxKm.Text == string.Empty
                        || cmbMarca.Text == string.Empty
                        || cmbModelo.Text == string.Empty
                        || cmbMotor.Text == string.Empty
                        || cmbCor.Text == string.Empty
                        || cmbAno.Text == string.Empty
                        || cmbTipoVeiculo.Text == string.Empty
                )
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;
                }
            }
        }
 
        private void MaskedPlaca_Click(object sender, EventArgs e)
        {
            maskedPlaca.Focus();
            maskedPlaca.SelectionStart = 0;
            EscondeValidacao(lblPlaca);
        }

        private void MaskedRenavam_Click(object sender, EventArgs e)
        {
            maskedRenavam.Focus();
            maskedRenavam.SelectionStart = 0;
            EscondeValidacao(lblRenavam);

        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeValidacao(lblMarca);
        }

        private void CmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeValidacao(lblModelo);
        }

        private void CmbMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeValidacao(lblMotor);
        }

        private void CmbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeValidacao(lblCor);
        }

        private void CmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscondeValidacao(lblAno);
        }

        private void TbxKm_TextChanged(object sender, EventArgs e)
        {
            EscondeValidacao(lblKm);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }

        private void LblMesagemObrigatoriedade_Click(object sender, EventArgs e)
        {

        }

        private void MaskedRenavam_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaskedPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
