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

namespace PimForms.Formulários
{
    public partial class EditarCadastroManutencao : Form
    {
        public EditarCadastroManutencao()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditarCadastroManutencao_Load(object sender, EventArgs e)
        {
            VeiculoDao veiculoDao = new VeiculoDao();

            /*
            for (int i = 0; i < veiculoDao.AutoComplete().Length; i++)
            {
                txtPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtPlaca.AutoCompleteCustomSource.Add(veiculoDao.AutoComplete()[i]);
            }
            */
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

        public void EscondeValidacao(Label label)
        {
            labeltesteErro.Text = string.Empty;
            label.ForeColor = Color.DimGray;
        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                labeltesteErro.Text = string.Empty;

                if (DateTime.TryParseExact(maskData.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    Convert.ToDateTime(maskData.Text);
                }

                VeiculoDao veiculoDao = new VeiculoDao();
                Manutencao manutencao = new Manutencao(veiculoDao.BuscarIdVeiculo("placa", txtPlaca.Text),
                    txtPlaca.Text,
                    comboBoxTipo.Text,
                    Convert.ToDecimal(txtValor.Text),
                    txtLocal.Text,
                    txtDescricao.Text,
                    Convert.ToDateTime(maskData.Text),
                    Convert.ToDecimal(txtQuilometragem.Text)
                    );

                if (txtPlaca.Text == string.Empty
                || comboBoxTipo.Text == string.Empty
                || txtValor.Text == string.Empty
                || txtLocal.Text == string.Empty
                || maskData.Text.Replace("/", "").Replace("_", "") == string.Empty
                || txtQuilometragem.Text == string.Empty)
                {
                    labeltesteErro.Text = "Atenção: Preencha os campos obrigatórios.";
                    labeltesteErro.ForeColor = Color.Red;

                }
                else
                {
                    if (labeltesteErro.Text == string.Empty)
                    {
                        if (manutencao.Placa == null)
                        {
                            ExibeValidacao("Atenção: Placa inválida. Tente novamente", txtPlaca, null, lblPlaca);
                        }
                        else
                        {
                            if (manutencao.Tipo == string.Empty)
                            {
                                ExibeValidacao("Atenção: Tipo inválido. Tente novamente", null, null, lblTipo);
                            }
                            else
                            {
                                if (manutencao.Valor < 0)
                                {
                                    ExibeValidacao("Atenção: O valor não pode ser negativo.", txtValor, null, lblValor);
                                }
                                else
                                {
                                    if (manutencao.Local == null)
                                    {
                                        ExibeValidacao("Atenção: Local inválido. O campo Local deve ter de 5 a 100 caracteres", txtLocal, null, lblLocal);
                                    }
                                    else
                                    {
                                        if (manutencao.Descricao == null)
                                        {
                                            ExibeValidacao("Atenção: Descrição inválida. O campo Local deve ter de 5 a 500 caracteres", txtLocal, null, lblLocal);
                                        }
                                        else
                                        {
                                            if (manutencao.Data == null)
                                            {
                                                ExibeValidacao("Atenção: Data inválida. Tente novamente.", null, maskData, lblData);
                                            }
                                            else
                                            {
                                                if (manutencao.Quilometragem <= 0)
                                                {
                                                    ExibeValidacao("Atenção: Quilometragem inválida. Tente novamente.", txtQuilometragem, null, lblQuilometragem);
                                                }
                                                else
                                                {
                                                    lblPlaca.ForeColor = Color.DimGray;
                                                    lblTipo.ForeColor = Color.DimGray;
                                                    lblValor.ForeColor = Color.DimGray;
                                                    lblLocal.ForeColor = Color.DimGray;
                                                    lblDescricao.ForeColor = Color.DimGray;
                                                    lblData.ForeColor = Color.DimGray;
                                                    lblQuilometragem.ForeColor = Color.DimGray;

                                                    ManutencaoDao manutencaoDao = new ManutencaoDao();
                                                    string data = manutencao.Data.ToString("yyyy/MM/dd HH:mm:ss").Replace("/", "-");                                                    
                                                    int id = manutencaoDao.BuscarIdManutencao(manutencao.Placa, data);
                                                    manutencaoDao.EditarManutencao(manutencao, id);

                                                    if (manutencao.Placa != null
                                                        && manutencao.Tipo != null
                                                        && manutencao.Valor != 0
                                                        && manutencao.Local != null
                                                        && manutencao.Descricao != null
                                                        && manutencao.Data != null
                                                        && manutencao.Quilometragem != 0
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
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
