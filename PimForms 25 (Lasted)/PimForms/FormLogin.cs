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

namespace PimForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Validacao()
        {
            Login login = new Login();

            if (txtUsuario.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                lblErroLogin.Text = "Atenção: Preencha os campos Usuário e Senha.";
                lblErroLogin.ForeColor = Color.OrangeRed;
                lblUsuario.ForeColor = Color.White;
                lblSenha.ForeColor = Color.White;
            }
            else
            {
                if (lblErroLogin.Text == string.Empty)
                {
                    if ((login.Usuario != txtUsuario.Text) && (login.Senha == txtSenha.Text))
                    {
                        ExibeValidacao("Atenção: Usuário inválido. Tente novamente.", txtUsuario, lblUsuario);
                    }
                    else
                    {
                        if ((login.Senha != txtSenha.Text) && (login.Usuario == txtUsuario.Text))
                        {
                            ExibeValidacao("Atenção: Senha inválida. Tente novamente.", txtSenha, lblSenha);
                        }
                        else
                        {
                            if ((login.Usuario != txtUsuario.Text) && (txtUsuario.Text != string.Empty) && (login.Senha != txtSenha.Text) && (txtSenha.Text != string.Empty))
                            {
                                lblErroLogin.Text = "Atenção: Usuário e senha inválidos. Tente novamente.";
                                lblUsuario.ForeColor = Color.OrangeRed;
                                lblSenha.ForeColor = Color.OrangeRed;
                                txtUsuario.Text = string.Empty;
                                txtSenha.Text = string.Empty;
                            }
                            else
                            {
                                if ((login.Usuario == txtUsuario.Text) && (login.Senha == txtSenha.Text))
                                {
                                    FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
                                    formularioPrincipal.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                }
            }
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            Validacao();
        }

        public void ExibeValidacao(string mensagem, TextBox textBox, Label label)
        {
            lblErroLogin.Text = mensagem;
            lblErroLogin.ForeColor = Color.OrangeRed;
            label.ForeColor = Color.OrangeRed;
            textBox.Text = string.Empty;
        }

        public void EscondeValidacao(Label label)
        {
            lblErroLogin.Text = string.Empty;
            label.ForeColor = Color.White;
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblUsuario);
        }

        private void TxtSenha_Click(object sender, EventArgs e)
        {
            EscondeValidacao(lblSenha);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                EscondeValidacao(lblUsuario);
                Validacao();

            }

        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EscondeValidacao(lblSenha);
                Validacao();
            }

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
