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
    public partial class CadastrarAcompanhante : Form
    {
        public int cont = 0;

        public CadastrarAcompanhante()
        {
            InitializeComponent();    
        }

        FuncionarioDao fun = new FuncionarioDao();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

        private void CadastrarOcupantes_Load(object sender, EventArgs e)
        {
            btnFechar.Enabled = true;

            for (int i = 0; i < fun.AutoComplete("matricula").Length; i++)
            {
                txtMatriculaOcupante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMatriculaOcupante.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMatriculaOcupante.AutoCompleteCustomSource.Add(fun.AutoComplete("matricula")[i]);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdicionarOcupante_Click(object sender, EventArgs e)
        {
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            string nome = funcionarioDao.BuscarAcompanhante(txtMatriculaOcupante.Text);
            
            if(cont == 0)
            {
                lblOcupante1.Text = nome;
                cont++;
            }
            else
            {
                if(cont == 1)
                {
                    if (nome == lblOcupante1.Text)
                    {
                        MessageBox.Show("Esse acompanhante já foi cadastrado.");
                    }
                    else
                    {
                        lblOcupante2.Text = nome;
                        cont++;
                    }
                }
                else
                {
                    if(cont == 2)
                    {
                        if (nome == lblOcupante1.Text || nome == lblOcupante2.Text)
                        {
                            MessageBox.Show("Esse acompanhante já foi cadastrado.");
                        }
                        else
                        {
                            lblOcupante3.Text = nome;
                            cont++;
                        }
                    }
                }
            }

            
            if(cont == 3)
            {
                MessageBox.Show("Não é possível adicionar mais acompanhantes. Apenas três acompanhantes são permitidos por viagem.");
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                lblQuantidadeDeAcompanhantes.ForeColor = Color.OliveDrab;
                lblQuantidadeDeAcompanhantes.Text = "Um acompanhante foi adicionado a esta viagem.";
            }
            else
            {
                if (cont == 2)
                {
                    lblQuantidadeDeAcompanhantes.ForeColor = Color.OliveDrab;
                    lblQuantidadeDeAcompanhantes.Text = "Dois acompanhantes foram adicionados a esta viagem.";
                }
                else
                {
                    if (cont == 3)
                    {
                        lblQuantidadeDeAcompanhantes.ForeColor = Color.OliveDrab;
                        lblQuantidadeDeAcompanhantes.Text = "Três acompanhantes foram adicionados a esta viagem.";
                    }
                }
            }

            Acompanhante acompanhante = new Acompanhante(
                lblOcupante1.Text,
                lblOcupante2.Text,
                lblOcupante3.Text
                );

            AcompanhanteDao acompanhanteDao = new AcompanhanteDao();
            acompanhanteDao.AdicionarAcompanhante(acompanhante);

            lblId.Text = Convert.ToString(acompanhanteDao.BuscarIdAcompanhante());
            btnConfirmar.Enabled = false;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {         
                Acompanhante acompanhante = new Acompanhante(
                    lblOcupante1.Text,
                    lblOcupante2.Text,
                    lblOcupante3.Text
                    );

                AcompanhanteDao acompanhanteDao = new AcompanhanteDao();
                acompanhanteDao.AdicionarAcompanhante(acompanhante);

                lblId.Text = Convert.ToString(acompanhanteDao.BuscarIdAcompanhante());
            }
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
