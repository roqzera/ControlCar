using PimForms.Classes;
using PimForms.Dao;
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
    public partial class CadastrarSeguro : Form
    {
        public CadastrarSeguro()
        {
            InitializeComponent();
        }
        VeiculoDao veic = new VeiculoDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();


        private void CadastrarSeguro_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < veic.AutoComplete().Length; i++)
            {
                tbxPlaca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbxPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbxPlaca.AutoCompleteCustomSource.Add(veic.AutoComplete()[i]);
            }
        }



        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                Seguros seg = new Seguros(Convert.ToDateTime(maskDataInicio.Text),
                    Convert.ToDateTime(maskDataVencimento.Text),
                    Convert.ToDecimal(txtValor.Text),
                    tbxNomeSeguradora.Text,
                    Convert.ToInt32(veic.BuscarIdVeiculo("placa", tbxPlaca.Text))
                    );
                SegurosDao segurosDao = new SegurosDao();
                segurosDao.AdicionarSeguro(seg);
            }
            catch
            {
                MessageBox.Show("erro");
            }
        }

        private void TbxPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskDataInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaskDataInicio_Click(object sender, EventArgs e)
        {
            maskDataInicio.Focus();
            maskDataInicio.SelectionStart = 0;
        }

        private void MaskDataVencimento_Click(object sender, EventArgs e)
        {
            maskDataVencimento.Focus(); 
            maskDataVencimento.SelectionStart = 0;
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            txtValor.Focus();
            txtValor.SelectionStart = 0;
        }
    }   
}
