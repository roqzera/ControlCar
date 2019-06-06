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
    public partial class EditarCadastroVeiculo : Form
    {
        public EditarCadastroVeiculo()
        {
            InitializeComponent();
        }

        private int id;
        VeiculoDao veiculoDao = new VeiculoDao();


        private void EditarCadastroVeiculo_Load(object sender, EventArgs e)
        {
            id = veiculoDao.BuscarIdVeiculo("placa", maskedPlaca.Text);
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

        // Apaga a mensagem de texto e retorna a cor da fonte da label para DimGray quando o usuário clica na TextBox.
        public void EscondeValidacao(Label label)
        {
            labeltesteErro.Text = string.Empty;
            label.ForeColor = Color.DimGray;
        }

        // Limpa todos os campos do formulário.

        private void BtnSalvar_Click(object sender, EventArgs e)
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
                    cmbTipoVeiculo.Text,
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
                                                    veiculoDao.EditarVeiculo(cad, this.id);

                                                    if (labeltesteErro.Text == string.Empty)
                                                    {

                                                        if (cad.Placa != null
                                                        && cad.NumeroRenavam != null
                                                        && cad.Marca != null
                                                        && cad.Modelo != null
                                                        && cad.Motor != null
                                                        && cad.Cor != null
                                                        && cad.Ano != null
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
                if (maskedPlaca.Text.Replace("-", "").Replace("_", "") == string.Empty
                        || maskedRenavam.Text.Replace("_", "") == string.Empty
                        || tbxKm.Text == string.Empty
                        || cmbMarca.Text == string.Empty
                        || cmbModelo.Text == string.Empty
                        || cmbMotor.Text == string.Empty
                        || cmbCor.Text == string.Empty
                        || cmbAno.Text == string.Empty
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
    }
    
}
    

