using System;
using PimForms.Formulários;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PimForms.Classes;
using PimForms;
using System.Collections.Generic;

namespace UnitTestProject
{
    //[TestClass]
    public class TesteDeIntegracaoFuncionario
    {
        [TestMethod]
        public void TestAdicionarFuncionario()
        {
            CadastrarFuncionario CadastrarFuncionario = new CadastrarFuncionario();
            CadastrarFuncionario.maskMatricula.Text = "NBG67";
            CadastrarFuncionario.txtNome.Text = "Bruna Ramos";
            CadastrarFuncionario.maskCPF.Text = "55990856008";
            CadastrarFuncionario.maskDataNascimento.Text = "04071997";
            CadastrarFuncionario.maskTelefone.Text = "16922222222";
            CadastrarFuncionario.txtCargo.Text = "Fisiotepia";
            CadastrarFuncionario.txtEmail.Text = "bruna@gmail.com";
            CadastrarFuncionario.maskNumeroCnh.Text = "03093930393";
            CadastrarFuncionario.comboBoxCategoriaCnh.Text = "AB";
            CadastrarFuncionario.maskValidadeCNH.Text = "01012020";

            Funcionario funcionario = new Funcionario(CadastrarFuncionario.maskMatricula.Text,
                CadastrarFuncionario.txtNome.Text,
                CadastrarFuncionario.maskCPF.Text,
                Convert.ToDateTime(CadastrarFuncionario.maskDataNascimento.Text),
                CadastrarFuncionario.maskTelefone.Text,
                CadastrarFuncionario.txtCargo.Text,
                CadastrarFuncionario.txtEmail.Text,
                CadastrarFuncionario.maskNumeroCnh.Text,
                CadastrarFuncionario.comboBoxCategoriaCnh.Text,
                Convert.ToDateTime(CadastrarFuncionario.maskValidadeCNH.Text),
                "Sim",
                "Ativo"
                );

            FuncionarioDao funcionarioDao = new FuncionarioDao();
            string resultado = funcionarioDao.AdicionarFuncionario(funcionario);
            Assert.AreEqual(resultado, "ok");
        }

        [TestMethod]
        public void TestBuscarFuncionario()
        {
            ListarFuncionario listarFuncionario = new ListarFuncionario();
            listarFuncionario.toolStripTextBoxMatricula.Text = "NBG67";
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            List<Funcionario> funcionarios = funcionarioDao.BuscarFuncionario(listarFuncionario.toolStripTextBoxMatricula.Text, "Ativo");
            Assert.AreEqual(listarFuncionario.toolStripTextBoxMatricula.Text, funcionarios[0].Matricula);
        }


        [TestMethod]
        public void TestEditarFuncionario()
        {
            string matricula = "NBG67";

            FuncionarioDao funcionarioDao = new FuncionarioDao();
            List<Funcionario> funcionarios = funcionarioDao.BuscarFuncionario(matricula, "Ativo");
            EditarCadastroFuncionario editarCadastroFuncionario = new EditarCadastroFuncionario();

            editarCadastroFuncionario.txtNome.Text = funcionarios[0].Nome;
            editarCadastroFuncionario.maskCPF.Text = funcionarios[0].CPF;
            editarCadastroFuncionario.maskDataNascimento.Text = Convert.ToString(funcionarios[0].DataDeNascimento);
            editarCadastroFuncionario.maskTelefone.Text = funcionarios[0].Telefone;
            editarCadastroFuncionario.txtCargo.Text = funcionarios[0].Cargo;
            editarCadastroFuncionario.txtEmail.Text = funcionarios[0].Email;
            editarCadastroFuncionario.maskNumeroCnh.Text = funcionarios[0].NumeroCNH;
            editarCadastroFuncionario.comboBoxCategoriaCnh.Text = funcionarios[0].CategoriaCNH;
            editarCadastroFuncionario.maskValidadeCNH.Text = Convert.ToString(funcionarios[0].ValidadeCNH);

            Funcionario funcionario = new Funcionario(editarCadastroFuncionario.maskMatricula.Text,
               "Bruna Ramos Gouvea",
               editarCadastroFuncionario.maskCPF.Text,
               Convert.ToDateTime(editarCadastroFuncionario.maskDataNascimento.Text),
               editarCadastroFuncionario.maskTelefone.Text,
               editarCadastroFuncionario.txtCargo.Text,
               editarCadastroFuncionario.txtEmail.Text,
               editarCadastroFuncionario.maskNumeroCnh.Text,
               editarCadastroFuncionario.comboBoxCategoriaCnh.Text,
               Convert.ToDateTime(editarCadastroFuncionario.maskValidadeCNH.Text),
               string.Empty,
               "Ativo"
               );

            int id = funcionarioDao.BuscarIdFuncionario("matricula", matricula);
            funcionarioDao.EditarFuncionario(funcionario, id);

            List<Funcionario> funcionarios2 = funcionarioDao.BuscarFuncionario(matricula, "Ativo");
            Assert.AreEqual(funcionarios2[0].Nome, funcionario.Nome);
            Assert.AreEqual(funcionarios2[0].CPF, funcionario.CPF);
            Assert.AreEqual(funcionarios2[0].DataDeNascimento, funcionario.DataDeNascimento);
            Assert.AreEqual(funcionarios2[0].Telefone, funcionario.Telefone);
            Assert.AreEqual(funcionarios2[0].Cargo, funcionario.Cargo);
            Assert.AreEqual(funcionarios2[0].Email, funcionario.Email);
            Assert.AreEqual(funcionarios2[0].NumeroCNH, funcionario.NumeroCNH);
            Assert.AreEqual(funcionarios2[0].CategoriaCNH, funcionario.CategoriaCNH);
            Assert.AreEqual(funcionarios2[0].ValidadeCNH, funcionario.ValidadeCNH);
        }

        [TestMethod]
        public void TestExcluirFuncionario()
        {
            string matricula = "NBG67";
            FuncionarioDao funcionarioDao = new FuncionarioDao();
            int id = funcionarioDao.BuscarIdFuncionario("matricula", matricula);
            funcionarioDao.ExcluirFuncionario(id);
            List<Funcionario> funcionarioInativo = funcionarioDao.BuscarFuncionario(matricula, "Inativo");
            Assert.AreEqual(funcionarioInativo[0].Status, "Inativo");
        }
    }
}
