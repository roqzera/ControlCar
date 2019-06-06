using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PimForms;
using PimForms.Classes;
using PimForms.Formulários;

namespace TesteDeUnidadeVeiculo
{
    //[TestClass]
    public class TesteDeIntegracaoVeiculo
    {
        [TestMethod]
        public void TestAdicionarVeiculo()
        {
            CadastrarVeiculo cadastrarVeiculo = new CadastrarVeiculo();

            cadastrarVeiculo.maskedPlaca.Text = "BAD3333";
            cadastrarVeiculo.maskedRenavam.Text = "93441470459";
            cadastrarVeiculo.cmbMarca.Text = "Froid";
            cadastrarVeiculo.cmbModelo.Text = "Potássio Sedan";
            cadastrarVeiculo.cmbMotor.Text = "Flex";
            cadastrarVeiculo.cmbCor.Text = "Branco";
            cadastrarVeiculo.cmbAno.Text = "2019";
            cadastrarVeiculo.tbxKm.Text = "11298";
            cadastrarVeiculo.cmbTipoVeiculo.Text = "Veículo Próprio";

            Veiculo veiculo = new Veiculo(cadastrarVeiculo.maskedPlaca.Text,
                cadastrarVeiculo.maskedRenavam.Text,
                cadastrarVeiculo.cmbMarca.Text,
                cadastrarVeiculo.cmbModelo.Text,
                cadastrarVeiculo.cmbMotor.Text,
                cadastrarVeiculo.cmbCor.Text,
                cadastrarVeiculo.cmbAno.Text,
                Convert.ToDecimal(cadastrarVeiculo.tbxKm.Text),
                cadastrarVeiculo.cmbTipoVeiculo.Text,
                "Ativo"
                );

            VeiculoDao veiculoDao = new VeiculoDao();
            string resultado = veiculoDao.AdicionarVeiculo(veiculo);
            Assert.AreEqual(resultado, "ok");
        }

        [TestMethod]
        public void TestBuscarVeiculo()
        {
            ListarVeiculos listarVeiculos = new ListarVeiculos();
            listarVeiculos.toolStripTextBoxPlaca.Text = "BAD-3333";
            VeiculoDao veiculoDao = new VeiculoDao();
            List<Veiculo> veiculos = veiculoDao.BuscarVeiculo(listarVeiculos.toolStripTextBoxPlaca.Text, "Ativo");
            Assert.AreEqual(listarVeiculos.toolStripTextBoxPlaca.Text, veiculos[0].Placa);
        }

        [TestMethod]
        public void TestEditarVeiculo()
        {
            string placa = "BAD-3333";

            VeiculoDao veiculoDao = new VeiculoDao();
            List<Veiculo> veiculos = veiculoDao.BuscarVeiculo(placa, "Ativo");
            EditarCadastroVeiculo editarCadastroVeiculo = new EditarCadastroVeiculo();

            editarCadastroVeiculo.maskedPlaca.Text = veiculos[0].Placa;
            editarCadastroVeiculo.maskedRenavam.Text = veiculos[0].NumeroRenavam;
            editarCadastroVeiculo.cmbMarca.Text = veiculos[0].Marca;
            editarCadastroVeiculo.cmbModelo.Text = veiculos[0].Modelo;
            editarCadastroVeiculo.cmbMotor.Text = veiculos[0].Motor;
            editarCadastroVeiculo.cmbCor.Text = veiculos[0].Cor;
            editarCadastroVeiculo.cmbAno.Text = veiculos[0].Ano;
            editarCadastroVeiculo.tbxKm.Text = Convert.ToString(veiculos[0].Quilometragem);
            editarCadastroVeiculo.cmbTipoVeiculo.Text = veiculos[0].TipoDeVeiculo;

            Veiculo veiculo = new Veiculo(editarCadastroVeiculo.maskedPlaca.Text,
                    editarCadastroVeiculo.maskedRenavam.Text,
                    editarCadastroVeiculo.cmbMarca.Text,
                    editarCadastroVeiculo.cmbModelo.Text,
                    editarCadastroVeiculo.cmbMotor.Text,
                    editarCadastroVeiculo.cmbCor.Text,
                    editarCadastroVeiculo.cmbAno.Text,
                    Convert.ToDecimal(editarCadastroVeiculo.tbxKm.Text),
                    editarCadastroVeiculo.cmbTipoVeiculo.Text,
                    "Ativo"
                    );

            int id = veiculoDao.BuscarIdVeiculo("placa", placa);
            veiculoDao.EditarVeiculo(veiculo, id);

            List<Veiculo> veiculos2 = veiculoDao.BuscarVeiculo(placa, "Ativo");
            Assert.AreEqual(veiculos2[0].Placa, veiculo.Placa);
            Assert.AreEqual(veiculos2[0].NumeroRenavam, veiculo.NumeroRenavam);
            Assert.AreEqual(veiculos2[0].Marca, veiculo.Marca);
            Assert.AreEqual(veiculos2[0].Modelo, veiculo.Modelo);
            Assert.AreEqual(veiculos2[0].Motor, veiculo.Motor);
            Assert.AreEqual(veiculos2[0].Cor, veiculo.Cor);
            Assert.AreEqual(veiculos2[0].Ano, veiculo.Ano);
            Assert.AreEqual(veiculos2[0].Quilometragem, veiculo.Quilometragem);
            Assert.AreEqual(veiculos2[0].TipoDeVeiculo, veiculo.TipoDeVeiculo);
        }

        [TestMethod]
        public void TestExcluirVeiculo()
        {
            string placa = "BAD-3333";
            VeiculoDao veiculoDao = new VeiculoDao();
            int id = veiculoDao.BuscarIdVeiculo("placa", placa);
            veiculoDao.ExcluirVeiculo(id);
            List<Veiculo> veiculoInativo = veiculoDao.BuscarVeiculo(placa, "Inativo");
            Assert.AreEqual(veiculoInativo[0].Status, "Inativo");
        }
    }
}
