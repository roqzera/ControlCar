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

namespace PimForms.Formulários
{
    public partial class EditarCadastroCustoViagem : Form
    {
        public EditarCadastroCustoViagem()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CustoDao custoDao = new CustoDao();
            custoDao.EditarCusto(Convert.ToInt32(txtIdViagem.Text),
                Convert.ToDecimal(txtCustoAbastecimento.Text),
                Convert.ToDecimal(txtCustoEstacionamento.Text),
                Convert.ToDecimal(txtCustoPedagio.Text),
                Convert.ToDecimal(txtCustoAluguel.Text)
                );
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
