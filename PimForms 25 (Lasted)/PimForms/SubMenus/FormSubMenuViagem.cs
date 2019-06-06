using PimForms.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.SubMenus
{
    public partial class FormSubMenuViagem : Form
    {
        public FormSubMenuViagem()
        {
            InitializeComponent();
        }

        public void MudaCorDaFonte(Button button1, Button button2, Button button3, Button button4,
           Image image1, Image image2, Image image3, Image image4)
        {
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
            button1.Image = image1;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.Cursor = Cursors.Arrow;

            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Gray;
            button2.Image = image2;
            button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button2.Cursor = Cursors.Hand;

            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = Color.Gray;
            button3.Image = image3;
            button3.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button3.Cursor = Cursors.Hand;

            button4.BackColor = Color.WhiteSmoke;
            button4.ForeColor = Color.Gray;
            button4.Image = image4;
            button4.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button4.Cursor = Cursors.Hand;
        }

        Formularios form = new Formularios();

        private void BtnCadastrarViagem_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarViagem>(pnlFormulariosViagem);
            MudaCorDaFonte(btnCadastrarViagem, btnConsultarViagem, btnCadastrarCusto, btnConsultarCusto,
              PimForms.Properties.Resources.img_viagem_white_30x30,
              PimForms.Properties.Resources.img_consultar_gray_30x30,
              PimForms.Properties.Resources.img_custo_gray_30x30,
              PimForms.Properties.Resources.img_consultar_gray_30x30
              );
        }

        private void BtnConsultarViagem_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<ListarViagem>(pnlFormulariosViagem);
            MudaCorDaFonte(btnConsultarViagem, btnCadastrarViagem, btnCadastrarCusto, btnConsultarCusto,
              PimForms.Properties.Resources.img_consultar_white_30x30,
              PimForms.Properties.Resources.img_viagem_gray_30x30,
              PimForms.Properties.Resources.img_custo_gray_30x30,
              PimForms.Properties.Resources.img_consultar_gray_30x30
              );
        }

        private void BtnCadastrarCusto_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarCustoViagem>(pnlFormulariosViagem);

            MudaCorDaFonte(btnCadastrarCusto, btnConsultarViagem, btnCadastrarViagem, btnConsultarCusto,
              PimForms.Properties.Resources.img_custo_white_30x30,
              PimForms.Properties.Resources.img_consultar_gray_30x30,
              PimForms.Properties.Resources.img_viagem_gray_30x30,
              PimForms.Properties.Resources.img_consultar_gray_30x30
              );
        }

        private void BtnConsultarCusto_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<ListarCustoViagem>(pnlFormulariosViagem);

            MudaCorDaFonte(btnConsultarCusto, btnCadastrarCusto, btnConsultarViagem, btnCadastrarViagem,
             PimForms.Properties.Resources.img_consultar_white_30x30,
             PimForms.Properties.Resources.img_custo_gray_30x30,
             PimForms.Properties.Resources.img_consultar_gray_30x30,
             PimForms.Properties.Resources.img_viagem_gray_30x30
             );
        }
    }
}
