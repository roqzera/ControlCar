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
    public partial class FormSubMenuVeiculos : Form
    {
        public FormSubMenuVeiculos()
        {
            InitializeComponent();
        }

        Formularios form = new Formularios();

        public void MudaCorDaFonte(Button button1, Button button2, Button button3, Button button4, Button button5,
            Image image1, Image image2, Image image3, Image image4, Image image5)
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

            button5.BackColor = Color.WhiteSmoke;
            button5.ForeColor = Color.Gray;
            button5.Image = image5;
            button5.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button5.Cursor = Cursors.Hand;
        }

        
        private void BtnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarVeiculo>(pnlFormularios);
            MudaCorDaFonte(btnCadastrarVeiculo, btnConsultarVeiculo, btnCadastrarManutencao, btnConsultarManutencao, btnCadastrarSeguro,
                PimForms.Properties.Resources.img_veiculo_white_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30,
                PimForms.Properties.Resources.img_manutencao_gray_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30,
                PimForms.Properties.Resources.img_seguro_gray_30x30
                );
        }

        
        private void BtnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<ListarVeiculos>(pnlFormularios);
            MudaCorDaFonte(btnConsultarVeiculo, btnCadastrarVeiculo, btnCadastrarManutencao, btnConsultarManutencao, btnCadastrarSeguro,
               PimForms.Properties.Resources.img_consultar_white_30x30,
               PimForms.Properties.Resources.img_veiculo_gray_30x30,
               PimForms.Properties.Resources.img_manutencao_gray_30x30,
               PimForms.Properties.Resources.img_consultar_gray_30x30,
               PimForms.Properties.Resources.img_seguro_gray_30x30
               );
        }

        private void BtnCadastrarManutencao_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarManutencao>(pnlFormularios);

            MudaCorDaFonte(btnCadastrarManutencao, btnConsultarVeiculo, btnCadastrarVeiculo, btnConsultarManutencao, btnCadastrarSeguro,
               PimForms.Properties.Resources.img_manutencao_white_30x30,
               PimForms.Properties.Resources.img_consultar_gray_30x30,
               PimForms.Properties.Resources.img_veiculo_gray_30x30,
               PimForms.Properties.Resources.img_consultar_gray_30x30,
               PimForms.Properties.Resources.img_seguro_gray_30x30
               );
        }

        private void BtnConsultarManutencao_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<ListarManutencao>(pnlFormularios);

            MudaCorDaFonte(btnConsultarManutencao, btnConsultarVeiculo, btnCadastrarVeiculo, btnCadastrarManutencao, btnCadastrarSeguro,
               PimForms.Properties.Resources.img_consultar_white_30x30,
               PimForms.Properties.Resources.img_consultar_gray_30x30,
               PimForms.Properties.Resources.img_veiculo_gray_30x30,
               PimForms.Properties.Resources.img_manutencao_gray_30x30,
               PimForms.Properties.Resources.img_seguro_gray_30x30
               );
        }

        private void BtnCadastrarSeguro_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarSeguro>(pnlFormularios);

            MudaCorDaFonte(btnCadastrarSeguro, btnConsultarManutencao, btnConsultarVeiculo, btnCadastrarVeiculo, btnCadastrarManutencao,
               PimForms.Properties.Resources.img_seguro_white_30x30,
               PimForms.Properties.Resources.img_consultar_gray_30x30,
               PimForms.Properties.Resources.img_consultar_gray_30x30,
               PimForms.Properties.Resources.img_veiculo_gray_30x30,
               PimForms.Properties.Resources.img_manutencao_gray_30x30
               );
        }
    }
}
