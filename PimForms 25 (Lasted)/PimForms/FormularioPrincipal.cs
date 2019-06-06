using PimForms.models;
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

namespace PimForms
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        Formularios form = new Formularios();

        public void MudaCorBtn(Button button1, Button button2, Button button3, Image img1, Image img2, Image img3)
        {
            button1.Enabled = true;

            if (Enabled == true)
            {
                button1.BackColor = Color.WhiteSmoke;
                button1.Image = img1;
                button1.ForeColor = Color.DarkGray;
                button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button1.Cursor = Cursors.Arrow;

                button2.BackColor = Color.DarkSeaGreen;
                button2.Image = img2;
                button2.ForeColor = Color.White;
                button2.FlatAppearance.MouseOverBackColor = Color.Gray;
                button2.Cursor = Cursors.Hand;

                button3.BackColor = Color.DarkSeaGreen;
                button3.Image = img3;
                button3.ForeColor = Color.White;
                button3.FlatAppearance.MouseOverBackColor = Color.Gray;
                button3.Cursor = Cursors.Hand;
            }
        }

        private void BtnViagem_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<FormSubMenuViagem>(painelFormPrincipal);
            MudaCorBtn(btnViagem, btnVeiculo, btnFuncionario, PimForms.Properties.Resources.Icone_Viagem_DarkGray_85x80, PimForms.Properties.Resources.iconecarro85x80, PimForms.Properties.Resources.iconeusuarioBranco85x80);
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<FormSubMenuVeiculos>(painelFormPrincipal);
            MudaCorBtn(btnVeiculo, btnViagem, btnFuncionario, PimForms.Properties.Resources.Icone_Veiculo_DarkGray_85x80, PimForms.Properties.Resources.iconeviagem85x80, PimForms.Properties.Resources.iconeusuarioBranco85x80);
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            form.AbrirSubMenu<FormSubMenuFuncionario>(painelFormPrincipal);
            MudaCorBtn(btnFuncionario, btnViagem, btnVeiculo, PimForms.Properties.Resources.Icone_Funcionario_DarkGray_85x80, PimForms.Properties.Resources.iconeviagem85x80, PimForms.Properties.Resources.iconecarro85x80);

        }

        private void BtnViagem_MouseHover(object sender, EventArgs e)
        {
            btnViagem.Cursor = Cursors.Hand;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }            
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
