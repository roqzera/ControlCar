using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.SubMenus
{
    public class Formularios
    {
        public void AbrirForm<Forms>(Panel painel) where Forms : Form, new()
        {
            Form formulario;
            formulario = painel.Controls.OfType<Forms>().FirstOrDefault();

            //Se o formulário não existe, cria um novo.
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                painel.Controls.Add(formulario);
                painel.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
            }
            else
            {

                //Se o formulário existe, traz pra frente.
                formulario.BringToFront();

                //Se o formulário está minimizado, mostra.
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        public void AbrirSubMenu<Forms>(Panel painel) where Forms : Form, new()
        {
            Form formulario;
            formulario = painel.Controls.OfType<Forms>().FirstOrDefault();

            //Se o formulário não existe, cria um novo.
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                painel.Controls.Add(formulario);
                painel.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //Se o formulário existe, mata ele e cria dnv.
                formulario.Close();

                //Se o formulário está minimizado, mostra.

                    formulario = new Forms();
                    formulario.TopLevel = false;
                    //formulario.FormBorderStyle = FormBorderStyle.None;
                    //formulario.Dock = DockStyle.Fill;
                    painel.Controls.Add(formulario);
                    painel.Tag = formulario;
                    formulario.Show();

                    formulario.BringToFront();
                    // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
                

            }
        }

        public void AbrirForm<Forms>(Form forms) where Forms : Form, new()
        {
            Form formulario;
            formulario = forms.Controls.OfType<Forms>().FirstOrDefault();

            //Se o formulário não existe, cria um novo.
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                //painel.Controls.Add(formulario);
                //painel.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //Se o formulário existe, mata ele e cria dnv.
                formulario.Close();
                
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    //formulario.FormBorderStyle = FormBorderStyle.None;
                    //formulario.Dock = DockStyle.Fill;
                    //painel.Controls.Add(formulario);
                    //painel.Tag = formulario;
                    formulario.Show();

                    formulario.BringToFront();
                    // formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
                

            }
        }

        public void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }



    }
}

