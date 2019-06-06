using System;
using PimForms.Formulários;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PimForms.Classes;
using PimForms;
using PimForms.Dao;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TesteDeUnidadeViagem
{
    [TestClass]
    public class TesteDeIntegracaoViagem
    {
        //[TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestAdicionarViagem()
        {
            CadastrarViagem cadastrarViagem = new CadastrarViagem();
            cadastrarViagem.txtFuncionario.Text = "Bruna Ramos Gouvea";
            cadastrarViagem.tbxPlaca.Text = "BAD-1111";
            cadastrarViagem.tbxDestino.Text = "Los Angeles";
            cadastrarViagem.maskValorAdiantamento.Text = "666";
            cadastrarViagem.maskedDataSaida.Text = "01062019";
            cadastrarViagem.maskedDataRetorno.Text = "02062019";
            cadastrarViagem.tbxKmInicial.Text = "50000";
            cadastrarViagem.tbxKmFinal.Text = "50500";

            VeiculoDao veiculoDao = new VeiculoDao();
            FuncionarioDao funcionarioDao = new FuncionarioDao();


            CadastrarAcompanhante cadastrarAcompanhante = new CadastrarAcompanhante();
            cadastrarAcompanhante.lblOcupante1.Text = "João";
            cadastrarAcompanhante.lblOcupante2.Text = "Alessandra";
            cadastrarAcompanhante.lblOcupante3.Text = "Alex";

            Acompanhante acompanhante = new Acompanhante(cadastrarAcompanhante.lblOcupante1.Text,
                cadastrarAcompanhante.lblOcupante2.Text,
                cadastrarAcompanhante.lblOcupante3.Text
                );

            AcompanhanteDao acompanhanteDao = new AcompanhanteDao();
            cadastrarAcompanhante.lblId.Text = Convert.ToString(acompanhanteDao.BuscarIdAcompanhante());
            string resultadoAcompanhante = acompanhanteDao.AdicionarAcompanhante(acompanhante);
            Assert.AreEqual(resultadoAcompanhante, "ok");


            Viagem viagem = new Viagem(Convert.ToDateTime(cadastrarViagem.maskedDataSaida.Text),
                Convert.ToDateTime(cadastrarViagem.maskedDataRetorno.Text),
                cadastrarViagem.tbxDestino.Text,
                Convert.ToDecimal(cadastrarViagem.maskValorAdiantamento.Text),
                Convert.ToDecimal(cadastrarViagem.tbxKmInicial.Text),
                Convert.ToDecimal(cadastrarViagem.tbxKmFinal.Text),
                veiculoDao.BuscarIdVeiculo("placa", cadastrarViagem.tbxPlaca.Text),
                funcionarioDao.BuscarIdFuncionario("nome", cadastrarViagem.txtFuncionario.Text),
                acompanhanteDao.BuscarIdAcompanhante()
                );

            ViagemDao viagemDao = new ViagemDao();

            string resultado = viagemDao.AdicionarViagem(viagem);
            Assert.AreEqual(resultado, "ok");
        }

        [TestMethod]
        public void TestBuscarViagem()
        {
            string matricula = "NBG67";
            string placa = "BAD-1111";            

            ListarViagem listarViagem = new ListarViagem();
            listarViagem.toolStripTextBoxMatricula.Text = matricula;
            listarViagem.toolStripTextBoxPlaca.Text = placa;

            FuncionarioDao funcionarioDao = new FuncionarioDao();
            int idFuncionario = funcionarioDao.BuscarIdFuncionario("matricula", matricula);

            VeiculoDao veiculoDao = new VeiculoDao();
            int idVeiculo = veiculoDao.BuscarIdVeiculo("placa", placa);

            ViagemDao viagemDao = new ViagemDao();
            List<Viagem> viagens = viagemDao.BuscarViagem(idFuncionario, idVeiculo);
            Assert.AreEqual(idFuncionario, viagens[0].IdFuncionario);
            Assert.AreEqual(idVeiculo, viagens[0].IdVeiculo);
        }

        [TestMethod]
        public void TestEditarViagem()
        {
            string matricula = "NBG67";
            string placa = "BAD-1111";

            FuncionarioDao funcionarioDao = new FuncionarioDao();
            int idFuncionario = funcionarioDao.BuscarIdFuncionario("matricula", matricula);
            MessageBox.Show(idFuncionario.ToString());
            VeiculoDao veiculoDao = new VeiculoDao();
            int idVeiculo = veiculoDao.BuscarIdVeiculo("placa", placa);
            MessageBox.Show(idVeiculo.ToString());
            ViagemDao viagemDao = new ViagemDao();
     
            List<Viagem> viagens1 = viagemDao.BuscarViagem(idFuncionario, idVeiculo);
            EditarCadastroViagem editarCadastroViagem = new EditarCadastroViagem();
            editarCadastroViagem.txtEditarFuncionario.Text = viagens1[0].NomeMotorista;
            editarCadastroViagem.txtEditarPlaca.Text = viagens1[0].PlacaVeiculo;
            editarCadastroViagem.txtEditarDestino.Text = viagens1[0].Destino;
            editarCadastroViagem.maskEditarValorAdiantamento.Text = Convert.ToString(viagens1[0].ValorAdiantamento);
            editarCadastroViagem.maskedEditarDataSaida.Text = Convert.ToString(viagens1[0].DataSaida);
            editarCadastroViagem.maskedEditarDataRetorno.Text = Convert.ToString(viagens1[0].DataRetorno);
            editarCadastroViagem.txtEditarKmInicial.Text = Convert.ToString(viagens1[0].KmInicial);
            editarCadastroViagem.txtEditarKmFinal.Text = Convert.ToString(viagens1[0].KmFinal);
            MessageBox.Show(editarCadastroViagem.txtEditarFuncionario.Text);
            AcompanhanteDao acompanhanteDao = new AcompanhanteDao();
            Viagem viagem = new Viagem(Convert.ToDateTime(editarCadastroViagem.maskedEditarDataSaida.Text),
                Convert.ToDateTime(editarCadastroViagem.maskedEditarDataRetorno.Text),
                "Miami",
                Convert.ToDecimal(editarCadastroViagem.maskEditarValorAdiantamento.Text),
                Convert.ToDecimal(editarCadastroViagem.txtEditarKmInicial.Text),
                Convert.ToDecimal(editarCadastroViagem.txtEditarKmFinal.Text),
                veiculoDao.BuscarIdVeiculo("placa", editarCadastroViagem.txtEditarPlaca.Text),
                funcionarioDao.BuscarIdFuncionario("nome", editarCadastroViagem.txtEditarFuncionario.Text),
                acompanhanteDao.BuscarIdAcompanhante()
                );

            MessageBox.Show("oi");

            MessageBox.Show(editarCadastroViagem.txtEditarFuncionario.Text);
            int id = viagemDao.BuscarIdViagem(idFuncionario, idVeiculo, Convert.ToDateTime(editarCadastroViagem.maskedEditarDataRetorno.Text));
            viagemDao.EditarViagem(viagem, id);

            List<Viagem> viagens2 = viagemDao.BuscarViagem(idFuncionario, idVeiculo);
            Assert.AreEqual(viagens2[0].NomeMotorista, viagem.NomeMotorista);
            Assert.AreEqual(viagens2[0].PlacaVeiculo, viagem.PlacaVeiculo);
            Assert.AreEqual(viagens2[0].Destino, viagem.Destino);
            Assert.AreEqual(viagens2[0].ValorAdiantamento, viagem.ValorAdiantamento);
            Assert.AreEqual(viagens2[0].DataSaida, viagem.DataSaida);
            Assert.AreEqual(viagens2[0].DataRetorno, viagem.DataRetorno);
            Assert.AreEqual(viagens2[0].KmInicial, viagem.KmInicial);
            Assert.AreEqual(viagens2[0].KmFinal, viagem.KmFinal);
        }
    }
}
