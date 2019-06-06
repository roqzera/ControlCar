using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PimForms.Classes;
using System.Data;
using System.Windows.Forms;

namespace PimForms.Dao
{
    class CustoDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public string AdicionarCusto(Custo custo)
        {
            //Comando Sql: insert, update, delete

            cmd.CommandText = "INSERT INTO custo (id_viagem, custo_abastecimento, custo_pedagio, custo_veiculo, custo_estacionamento) " +
                "VALUES (@IdViagem, @CustoAbastecimento, @CustoPedagio, @CustoVeiculo, @CustoEstacionamento)";

            //Parametros
            cmd.Parameters.AddWithValue("@IdViagem", custo.IdViagem);
            cmd.Parameters.AddWithValue("@CustoAbastecimento", custo.CustoAbastecimento);
            cmd.Parameters.AddWithValue("@CustoPedagio", custo.CustoPedagio);
            cmd.Parameters.AddWithValue("@CustoEstacionamento", custo.CustoEstacionamento);
            cmd.Parameters.AddWithValue("@CustoVeiculo", custo.CustoAluguel);

            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.Conectar();
                //Executar Comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.Desconectar();
                //Mostrar mensagem de sucesso/erro
                MessageBox.Show("Cadastro realizado com sucesso!");
                return "ok";
            }
            
            catch (MySqlException ex)
            {
                return Convert.ToString(ex);
                //throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public void EditarCusto(int idCusto,
            decimal custoAbastecimento,
            decimal custoEstacionamento,
            decimal custoPedagio,
            decimal custoVeiculo
            )
        {
            cmd.CommandText = "UPDATE custo SET custo_abastecimento=@custoAbastecimento, custo_estacionamento=@custoEstacionamento, custo_pedagio=@custoPedagio, custo_veiculo=@custoVeiculo WHERE id_custo=@idCusto;";

            cmd.Parameters.AddWithValue("@idCusto", idCusto);
            cmd.Parameters.AddWithValue("@custoAbastecimento", custoAbastecimento);
            cmd.Parameters.AddWithValue("@custoEstacionamento", custoEstacionamento);
            cmd.Parameters.AddWithValue("@custoPedagio", custoPedagio);
            cmd.Parameters.AddWithValue("@custoVeiculo", custoVeiculo);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
                throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public string ListarCusto()
        {
            string strMysql = "select id_custo, custo_abastecimento, custo_pedagio, custo_veiculo, custo_estacionamento FROM custo";

            return strMysql;
        }
        public string PesquisarCusto(int idCusto)
        {
            string strMysql = "select custo_abastecimento, custo_pedagio, custo_veiculo, custo_estacionamento FROM custo WHERE id_custo= '"+idCusto+"';";

            return strMysql;
        }

        public string BuscarTipoVeiculo(string coluna, string valor)
        {
            try
            {
                string strMysql1 = "SELECT id_veiculo FROM viagem WHERE " + coluna + " = '" + valor + "';";
                //cmd.Parameters.AddWithValue("@nome", nome);
                mySqlConnection = conexao.Conectar();
                cmd = new MySqlCommand(strMysql1, mySqlConnection);

                // Seleciona os dados do banco e preenche o DataAdapter com esses dados
                var result = cmd.ExecuteScalar();


                // Armazena no DataTable os dados que foram buscados no banco com o uso do SelectCommand
                int idveiculo = Convert.ToInt32(result);


                string strMysql2 = "SELECT tipoveiculo from veiculo where id_veiculo = '" + idveiculo + ";";

                //cmd.Parameters.AddWithValue("@nome", nome);
                mySqlConnection = conexao.Conectar();
                cmd = new MySqlCommand(strMysql1, mySqlConnection);

                // Seleciona os dados do banco e preenche o DataAdapter com esses dados
                result = cmd.ExecuteScalar();

                // Armazena no DataTable os dados que foram buscados no banco com o uso do SelectCommand
                string tipoveiculo = Convert.ToString(result);
                return tipoveiculo;
            }

            catch (MySqlException ex)
            {
                return null;
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public int BuscarQuantidadeDias(string idViagem)
        {
            try
            {
                string strMysql = "Select DateDIFF(data_retorno, data_saida) from viagem where id_viagem = '" + idViagem + "';";
                mySqlConnection = conexao.Conectar();

                // Seleciona os dados do banco e preenche o DataAdapter com esses dados

                cmd = new MySqlCommand(strMysql, mySqlConnection);
                var result = cmd.ExecuteScalar();
               

                int qtdDias = Convert.ToInt32(result);
                // Armazena no DataTable os dados que foram buscados no banco com o uso do SelectCommand
                return qtdDias;
            }

            catch (MySqlException ex)
            {
                return 0;
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable ExibirNoDataGridView(string strCon)
        {
            try
            {
                mySqlConnection = conexao.Conectar();
                cmd = new MySqlCommand(strCon, mySqlConnection);

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                // Seleciona os dados do banco e preenche o DataAdapter com esses dados
                mySqlDataAdapter.SelectCommand = cmd;

                DataTable dataTable = new DataTable();
                // Armazena no DataTable os dados que foram buscados no banco com o uso do SelectCommand
                mySqlDataAdapter.Fill(dataTable);

                return dataTable;
            }

            catch (MySqlException ex)
            {
                throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
