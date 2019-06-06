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

namespace PimForms.Formulários
{
    public partial class CadastrarFuncionario : Form
    {
        Funcionario funcionario;

        string dataDeNascimentoEntrada;
        string dataValidadeCnhEntrada;

        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime1 = new DateTime();

                if (DateTime.TryParseExact(maskDataNascimento.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    Convert.ToDateTime(maskDataNascimento.Text);
                }
                else
                {
                    dataDeNascimentoEntrada = maskDataNascimento.Text;
                    maskDataNascimento.Text = Convert.ToString(dateTime1);
                }

                DateTime dateTime2 = new DateTime();

                if (DateTime.TryParseExact(maskValidadeCNH.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
                {
                    Convert.ToDateTime(maskValidadeCNH.Text);
                }
                else
                {
                    dataValidadeCnhEntrada = maskValidadeCNH.Text;
                    maskValidadeCNH.Text = Convert.ToString(dateTime2);
                }

                funcionario = new Funcionario(maskMatricula.Text,
                txtNome.Text,
                maskCPF.Text,
                Convert.ToDateTime(maskDataNascimento.Text),
                maskTelefone.Text,
                txtCargo.Text,
                txtEmail.Text,
                maskNumeroCnh.Text,
                comboBoxCategoriaCnh.Text,
                Convert.ToDateTime(maskValidadeCNH.Text),
                string.Empty,
                "Ativo"
                );

                if(Convert.ToString(funcionario.DataDeNascimento) == "01/01/0001 00:00:00")
                {
                    maskDataNascimento.Text = dataDeNascimentoEntrada;
                }

                if(Convert.ToString(funcionario.ValidadeCNH) == "01/01/0001 00:00:00")
                {
                    maskValidadeCNH.Text = dataValidadeCnhEntrada;
                }

                if (maskMatricula.Text == string.Empty
                || txtNome.Text == string.Empty
                || maskCPF.Text.Replace("-", "").Replace("_", "").Replace(".", "") == string.Empty
                || maskDataNascimento.Text.Replace("/", "").Replace("_", "") == string.Empty
                || maskTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace("_", "") == string.Empty
                || txtCargo.Text == string.Empty
                || txtEmail.Text == string.Empty
                )
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;
                }
                else
                {
                    if (labeltesteErro.Text == string.Empty)
                    {
                        if (funcionario.Matricula == null)
                        {
                            ExibeValidacao("Atenção: Matrícula inválida. O campo Matrícula deve ter 5 caracteres", null, maskMatricula, lblMatricula);
                        }
                        else
                        {
                            if (funcionario.Nome == null)
                            {
                                ExibeValidacao("Atenção: Nome inválido. O campo Nome deve ter de 5 a 100 caracteres", txtNome, null, lblNome);
                            }
                            else
                            {
                                if (funcionario.Telefone == null)
                                {
                                    ExibeValidacao("Atenção: Telefone inválido. Verifique o número e tente novamente.", null, maskTelefone, lblTelefone);
                                }
                                else
                                {
                                    if (funcionario.CPF == null)
                                    {
                                        ExibeValidacao("Atenção: CPF inválido. Verifique o número e tente novamente", null, maskCPF, lblCpf);
                                    }
                                    else
                                    {
                                        if (Convert.ToString(funcionario.DataDeNascimento) == "01/01/0001 00:00:00")
                                        {
                                            ExibeValidacao("Atenção: Data de Nascimento inválida. Verifique a data e tente novamente.", null, maskDataNascimento, lblDataDeNascimento);
                                        }
                                        else
                                        {
                                            if (funcionario.Cargo == null)
                                            {
                                                ExibeValidacao("Atenção: Cargo inválido. O campo Cargo deve ter de 5 a 100 caracteres.", txtCargo, null, lblCargo);
                                            }
                                            else
                                            {
                                                if (funcionario.Email == null)
                                                {
                                                    ExibeValidacao("Atenção: E-mail inválido. Verifique o e-mail e tente novamente.", txtEmail, null, lblEmail);
                                                }
                                                else
                                                {
                                                    if (funcionario.NumeroCNH == null)
                                                    {
                                                        ExibeValidacao("Atenção: Número da CNH inválido. O campo Número da CNH deve ter 11 números.", null, maskNumeroCnh, lblNumeroCnh);
                                                    }
                                                    else
                                                    {
                                                        if (((funcionario.NumeroCNH == "") && (Convert.ToString(funcionario.ValidadeCNH) == "01/01/0001 00:00:00") && (funcionario.CategoriaCNH == ""))
                                                               || ((funcionario.NumeroCNH != "") && (Convert.ToString(funcionario.ValidadeCNH) != "01/01/0001 00:00:00") && (funcionario.CategoriaCNH != "")))
                                                        {
                                                            if (maskNumeroCnh.Text.Replace("_", "") == string.Empty)
                                                            {
                                                                funcionario.Motorista = "Não";
                                                            }
                                                            else
                                                            {
                                                                funcionario.Motorista = "Sim";
                                                            }

                                                            FuncionarioDao funcionarioDao = new FuncionarioDao();
                                                            string ex = funcionarioDao.AdicionarFuncionario(funcionario);

                                                            if (ex.Contains("matricula_UNIQUE"))                //throw ex;
                                                            {
                                                                MessageBox.Show("Matricula já cadastrada.");
                                                            }
                                                            else
                                                            {

                                                                if (ex.Contains("cpf_UNIQUE"))                //throw ex;
                                                                {
                                                                    MessageBox.Show("CPF já cadastrado.");
                                                                }

                                                                else
                                                                {
                                                                    if (labeltesteErro.Text == string.Empty)
                                                                    {
                                                                        if (funcionario.Matricula != null
                                                                         && funcionario.Nome != null
                                                                         && funcionario.CPF != null
                                                                         && funcionario.DataDeNascimento != null
                                                                         && funcionario.Telefone != null
                                                                         && funcionario.Cargo != null
                                                                         && funcionario.Email != null
                                                                         )
                                                                        {
                                                                            labeltesteErro.Text = string.Empty;
                                                                            LimpaTextBox();
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            labeltesteErro.Text = "Atenção: Preencha os campos da CNH. Verifique se estão corretos e tente novamente.";
                                                            lblCategoriaDaCnh.ForeColor = Color.Red;
                                                            lblNumeroCnh.ForeColor = Color.Red;
                                                            lblValidadeCnh.ForeColor = Color.Red;
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
            }
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

        public void LimpaTextBox()
        {
            maskMatricula.Text = string.Empty;
            txtNome.Text = string.Empty;
            maskCPF.Text = string.Empty;
            maskDataNascimento.Text = string.Empty;
            maskTelefone.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            maskNumeroCnh.Text = string.Empty;
            comboBoxCategoriaCnh.SelectedIndex = -1;
            maskValidadeCNH.Text = string.Empty;
        }

        private void MaskMatricula_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblMatricula);
            maskMatricula.Focus();
            maskMatricula.SelectionStart = 0;
        }

        private void TxtNome_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblNome);
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void MaskCPF_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblCpf);
            maskCPF.Focus();
            maskCPF.SelectionStart = 0;
        }

        private void MaskDataNascimento_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblDataDeNascimento);
            maskDataNascimento.Focus();
            maskDataNascimento.SelectionStart = 0;
        }

        private void MaskTelefone_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblTelefone);
            maskTelefone.Focus();
            maskTelefone.SelectionStart = 1;
        }

        private void TxtCargo_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblCargo);
        }

        private void TxtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void TxtEmail_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblEmail);
        }

        private void MaskNumeroCnh_Click(object sender, EventArgs e)
        {
            lblCategoriaDaCnh.ForeColor = Color.DimGray;
            lblNumeroCnh.ForeColor = Color.DimGray;
            lblValidadeCnh.ForeColor = Color.DimGray;
            EscondeValidacao(lblNumeroCnh);
            maskNumeroCnh.Focus();
            maskNumeroCnh.SelectionStart = 0;
        }

        private void ComboBoxCategoriaCnh_Click(object sender, EventArgs e)
        {
            lblCategoriaDaCnh.ForeColor = Color.DimGray;
            lblNumeroCnh.ForeColor = Color.DimGray;
            lblValidadeCnh.ForeColor = Color.DimGray;
        }

        private void MaskValidadeCNH_Click(object sender, EventArgs e)
        {
            lblCategoriaDaCnh.ForeColor = Color.DimGray;
            lblNumeroCnh.ForeColor = Color.DimGray;
            lblValidadeCnh.ForeColor = Color.DimGray;
            EscondeValidacao(lblValidadeCnh);
            maskValidadeCNH.Focus();
            maskValidadeCNH.SelectionStart = 0;
        }

        private void BtnCancelarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
            labeltesteErro.Text = string.Empty;
        }

        private void MaskTelefone_Click_1(object sender, EventArgs e)
        {
            EscondeValidacao(lblTelefone);
            maskTelefone.Focus();
            maskTelefone.SelectionStart = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }
    }
}
