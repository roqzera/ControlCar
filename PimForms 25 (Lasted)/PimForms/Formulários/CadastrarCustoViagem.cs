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
    public partial class CadastrarCustoViagem : Form
    {
        public CadastrarCustoViagem()
        {
            InitializeComponent();
        }

        private void LblValor_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                CustoDao custoDao = new CustoDao();

                if (custoDao.BuscarTipoVeiculo("id_viagem", txtIdViagem.Text) == "Veículo Locado") ;
                {
                    txtCustoAluguel.Text = Convert.ToString((Convert.ToInt32(custoDao.BuscarQuantidadeDias(txtIdViagem.Text)) * 150));
                }

                Custo custo = new Custo
                (
                    Convert.ToInt32(txtIdViagem.Text),
                    Convert.ToDecimal(txtCustoAbastecimento.Text),
                    Convert.ToDecimal(txtCustoEstacionamento.Text),
                    Convert.ToDecimal(txtCustoPedagio.Text),
                    Convert.ToDecimal(txtCustoAluguel.Text)
                );

                string ex = custoDao.AdicionarCusto(custo);
                txtCustoAluguel.Text = string.Empty;
                if (ex.Contains("fk_custoviagem"))                //throw ex;
                {
                    MessageBox.Show("ID da Viagem não cadastrado.");
                }
                if (ex.Contains("id_viagem_unique"))                //throw ex;
                {
                    MessageBox.Show("Custo de Viagem já cadastrado. Por favor, vá em editar.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos.");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CustoDao custoDao = new CustoDao();
            MessageBox.Show(Convert.ToString(custoDao.BuscarQuantidadeDias(txtIdViagem.Text)));

        }

        private void TxtCustoAluguel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse valor é atribuido automaticamente.");
        }
    }
}
