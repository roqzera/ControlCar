using System;
using PimForms.Formulários;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PimForms.Classes;
using PimForms;
using System.Collections.Generic;
using PimForms.Dao;

namespace TesteDeUnidadeManutencao
{
    //[TestClass]
    public class TesteDeIntegracaoManutencao
    {
        //[TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TesteAdicionarManutencao()
        {
            CadastrarManutencao cadastrarManutencao = new CadastrarManutencao();

            cadastrarManutencao.txtPlaca.Text = "UUR-5252";
            cadastrarManutencao.comboBoxTipo.Text = "Corretiva";
            cadastrarManutencao.txtLocal.Text = "Oficina de Deus";
            cadastrarManutencao.txtValor.Text = "100";
            cadastrarManutencao.txtDescricao.Text = "Tudo certo";
            cadastrarManutencao.maskData.Text = "20/05/2019";
            cadastrarManutencao.txtQuilometragem.Text = "50000";
            cadastrarManutencao.txtValor.Text = "2300";

            VeiculoDao veiculoDao = new VeiculoDao();
            Manutencao manutencao = new Manutencao(veiculoDao.BuscarIdVeiculo("placa", cadastrarManutencao.txtPlaca.Text),
                   cadastrarManutencao.txtPlaca.Text,
                   cadastrarManutencao.comboBoxTipo.Text,
                   Convert.ToDecimal(cadastrarManutencao.txtValor.Text),
                   cadastrarManutencao.txtLocal.Text,
                   cadastrarManutencao.txtDescricao.Text,
                   Convert.ToDateTime(cadastrarManutencao.maskData.Text),
                   Convert.ToDecimal(cadastrarManutencao.txtQuilometragem.Text)
                   );

            ManutencaoDao manutencaoDao = new ManutencaoDao();
            string resultado = manutencaoDao.AdicionarManutencao(manutencao);
            Assert.AreEqual(resultado, "ok");
        }

        [TestMethod]
        public void TesteBuscarManutencao()
        {
            ListarManutencao listarManutencao = new ListarManutencao();
            listarManutencao.toolStripTextBoxPlaca.Text = "UUR-5252";
            listarManutencao.toolStripTextBoxData.Text = "20/05/2019";
            DateTime dataTime = Convert.ToDateTime(listarManutencao.toolStripTextBoxData.Text);
            string data = dataTime.ToString("yyyy/MM/dd HH:mm:ss").Replace("/", "-");
            ManutencaoDao manutencaoDao = new ManutencaoDao();
            int idManutencao = Convert.ToInt32(manutencaoDao.BuscarIdManutencao(listarManutencao.toolStripTextBoxPlaca.Text, data));
            List<Manutencao> manutencoes = manutencaoDao.BuscarManutencao(idManutencao, data);
            Assert.AreEqual(listarManutencao.toolStripTextBoxPlaca.Text, manutencoes[0].Placa);
            Assert.AreEqual(Convert.ToDateTime(listarManutencao.toolStripTextBoxData.Text), manutencoes[0].Data);
        }

        [TestMethod]
        public void TesteEditarManutencao()
        {
            ListarManutencao listarManutencao = new ListarManutencao();
            listarManutencao.toolStripTextBoxPlaca.Text = "UUR-5252";
            listarManutencao.toolStripTextBoxData.Text = "20/05/2019";
            DateTime dataTime = Convert.ToDateTime(listarManutencao.toolStripTextBoxData.Text);
            string data = dataTime.ToString("yyyy/MM/dd HH:mm:ss").Replace("/", "-");
            ManutencaoDao manutencaoDao = new ManutencaoDao();
            int id = Convert.ToInt32(manutencaoDao.BuscarIdManutencao(listarManutencao.toolStripTextBoxPlaca.Text, data));
            List<Manutencao> manutencoes = manutencaoDao.BuscarManutencao(id, data);
            EditarCadastroManutencao editarCadastroManutencao = new EditarCadastroManutencao();

            editarCadastroManutencao.txtPlaca.Text = manutencoes[0].Placa;
            editarCadastroManutencao.comboBoxTipo.Text = manutencoes[0].Tipo;
            editarCadastroManutencao.txtLocal.Text = manutencoes[0].Local;
            editarCadastroManutencao.txtValor.Text = manutencoes[0].Valor.ToString();
            editarCadastroManutencao.txtDescricao.Text = manutencoes[0].Descricao;
            editarCadastroManutencao.maskData.Text = manutencoes[0].Data.ToString();
            editarCadastroManutencao.txtQuilometragem.Text = manutencoes[0].Quilometragem.ToString();

            VeiculoDao veiculoDao = new VeiculoDao();
            Manutencao manutencao = new Manutencao(veiculoDao.BuscarIdVeiculo("placa", editarCadastroManutencao.txtPlaca.Text),
                   editarCadastroManutencao.txtPlaca.Text,
                   editarCadastroManutencao.comboBoxTipo.Text,
                   Convert.ToDecimal(editarCadastroManutencao.txtValor.Text),
                   editarCadastroManutencao.txtLocal.Text,
                   editarCadastroManutencao.txtDescricao.Text,
                   Convert.ToDateTime(editarCadastroManutencao.maskData.Text),
                   Convert.ToDecimal(editarCadastroManutencao.txtQuilometragem.Text)
                   );

            manutencaoDao.EditarManutencao(manutencao, id);
            List<Manutencao> manutencoes2 = manutencaoDao.BuscarManutencao(id, data); 
            Assert.AreEqual(manutencoes2[0].Placa, manutencao.Placa);
            Assert.AreEqual(manutencoes2[0].Tipo, manutencao.Tipo);
            Assert.AreEqual(manutencoes2[0].Local, manutencao.Local);
            Assert.AreEqual(manutencoes2[0].Valor, manutencao.Valor);
            Assert.AreEqual(manutencoes2[0].Descricao, manutencao.Descricao);
            Assert.AreEqual(manutencoes2[0].Data, manutencao.Data);
            Assert.AreEqual(manutencoes2[0].Quilometragem, manutencao.Quilometragem);
        }
    }
}
