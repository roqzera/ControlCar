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

namespace PimForms.Formulários
{
    public partial class EditarCadastroMulta : Form
    {
        Multa multa;
        public EditarCadastroMulta()
        {
            InitializeComponent();
        }

        MultaDAO mult = new MultaDAO();
        FuncionarioDao fun = new FuncionarioDao();
        VeiculoDao vei = new VeiculoDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        



        private void EditarCadastroMulta_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < fun.AutoComplete("nome").Length; i++)
            {
                tbxFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbxFuncionario.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbxFuncionario.AutoCompleteCustomSource.Add(fun.AutoComplete("nome")[i]);
            }
            for (int i = 0; i < vei.AutoComplete().Length; i++)
            {
                maskedPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                maskedPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                maskedPlaca.AutoCompleteCustomSource.Add(vei.AutoComplete()[i]);
            }
        }


        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void LblRenavam_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                labeltesteErro.Text = string.Empty;


                DateTime dateTime = new DateTime();

                if (DateTime.TryParseExact(maskData.Text, "dd / MM / yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    Convert.ToDateTime(maskData.Text);
                }
                else
                {
                    //maskData.Text = Convert.ToString(dateTime);
                }

                multa = new Multa(MaskNumInfracao.Text, Convert.ToDecimal(txtValor.Text), Convert.ToDateTime(maskData.Text), Convert.ToInt32(fun.BuscarIdFuncionario("nome", tbxFuncionario.Text)), Convert.ToInt32(vei.BuscarIdVeiculo("placa", maskedPlaca.Text)));


                if (tbxFuncionario.Text == string.Empty
                || txtValor.Text == string.Empty
                || maskedPlaca.Text.Replace("-", "").Replace(" ", "") == string.Empty
                || maskData.Text.Replace("/", "").Replace("_", "").Replace(" ", "") == string.Empty
                || MaskNumInfracao.Text.Replace("-", "").Replace(" ", "") == string.Empty)
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;

                }
                else
                {
                    if (labeltesteErro.Text == string.Empty)
                    {
                        if (fun.BuscarIdFuncionario("nome", tbxFuncionario.Text) == 0)
                        {
                            ExibeValidacao("Atenção: Nome inválido. Digite novamente", tbxFuncionario, null, lblFuncionario);
                        }
                        else
                        {
                            if (vei.BuscarIdVeiculo("placa", maskedPlaca.Text) == 0)
                            {
                                ExibeValidacao("Atenção: Placa do veiculo inválida. Digite novamente", maskedPlaca, null, lblPlaca);
                            }
                            else
                            {
                                if (multa.NumeroDaInfracao == null)
                                {
                                    ExibeValidacao("Atenção: Numero da infração incorreta. Digite novamente", null, MaskNumInfracao, lblNumeroDaInfracao);
                                }
                                else
                                {
                                    if (multa.Valor < 0)
                                    {
                                        ExibeValidacao("Atenção: Valor inválido. Digite um valor maior que zero.", txtValor, null, lblValor);
                                    }
                                    else
                                    {
                                        lblFuncionario.ForeColor = Color.DimGray;
                                        lblData.ForeColor = Color.DimGray;
                                        lblNumeroDaInfracao.ForeColor = Color.DimGray;
                                        lblPlaca.ForeColor = Color.DimGray;
                                        lblValor.ForeColor = Color.DimGray;

                                        MultaDAO multaDAO = new MultaDAO();
                                        multaDAO.EditarMulta(multa, Convert.ToInt32(lblId.Text));


                                        if (multa.Funcionario != 0
                                            && multa.NumeroDaInfracao != null
                                            && multa.Valor != 0
                                            && multa.Data != null)
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
            catch (Exception)
            {

                if (tbxFuncionario.Text == string.Empty
                || txtValor.Text == string.Empty
                || maskedPlaca.Text.Replace("-", "").Replace(" ", "") == string.Empty
                || maskData.Text.Replace("/", "").Replace("_", "").Replace(" ", "") == string.Empty
                || MaskNumInfracao.Text.Replace("-", "").Replace(" ", "") == string.Empty)
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;
                }
                else
                {
                    ExibeValidacao("Atenção: Data inválida. Verifique a data e tente novamente.", null, maskData, lblData);
                }
            }
        }

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


        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }
        }
        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValor);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaskedPlaca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
