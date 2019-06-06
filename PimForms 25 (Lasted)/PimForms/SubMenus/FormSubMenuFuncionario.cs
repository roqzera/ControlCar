using PimForms.Formulários;
using PimForms.SubMenus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.models
{
    public partial class FormSubMenuFuncionario : Form
    {
        Formularios form = new Formularios();
        public FormSubMenuFuncionario()
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

        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarFuncionario>(pnlFormularios);
            MudaCorDaFonte(btnCadastrarFuncionario, btnConsultarFuncionario, btnCadastrarMulta, btnConsultarMulta, 
                PimForms.Properties.Resources.img_usuario_login_white_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30,
                PimForms.Properties.Resources.img_cadastrar_gray_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30
                );
        }

        private void BtnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<ListarFuncionario>(pnlFormularios);
            MudaCorDaFonte(btnConsultarFuncionario, btnCadastrarFuncionario, btnCadastrarMulta, btnConsultarMulta,
                PimForms.Properties.Resources.img_consultar_white_30x30,
                PimForms.Properties.Resources.img_usuario_login_gray_30x30,
                PimForms.Properties.Resources.img_cadastrar_gray_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30
                );
        }

        private void BtnCadastrarMulta_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<CadastrarMultas>(pnlFormularios);
            MudaCorDaFonte(btnCadastrarMulta, btnCadastrarFuncionario, btnConsultarFuncionario, btnConsultarMulta,
                PimForms.Properties.Resources.img_cadastrar_white_30x30,
                PimForms.Properties.Resources.img_usuario_login_gray_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30
                );
        }

        private void BtnConsultarMulta_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<ListarMulta>(pnlFormularios);
            MudaCorDaFonte(btnConsultarMulta, btnCadastrarFuncionario, btnConsultarFuncionario, btnCadastrarMulta,
                PimForms.Properties.Resources.img_consultar_white_30x30,
                PimForms.Properties.Resources.img_usuario_login_gray_30x30,
                PimForms.Properties.Resources.img_consultar_gray_30x30,
                PimForms.Properties.Resources.img_cadastrar_gray_30x30
                );
        }
    }
}
