using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PimForms.Classes;

namespace PimForms.Dao
{
    class SegurosDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;

        public void AdicionarSeguro(Seguros seguro)
        {

            //Comando Sql: insert, update, delete

            cmd.CommandText = "INSERT INTO seguros (data_inicio, data_vencimento, valor, seguradora, id_veiculo) " +
                "VALUES (@DataInicio, @DataVencimento, @Valor, @Seguradora, @IdVeiculo)";

            //Parametros
            cmd.Parameters.AddWithValue("@DataInicio", seguro.DataInicio);
            cmd.Parameters.AddWithValue("@DataVencimento", seguro.DataVencimento);
            cmd.Parameters.AddWithValue("@Valor", seguro.Valor);
            cmd.Parameters.AddWithValue("@Seguradora", seguro.Seguradora);
            cmd.Parameters.AddWithValue("@IdVeiculo", seguro.IdVeiculo);


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
            }

            catch (MySqlException)
            {
                //MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
                //throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public string ListarSeguros()
        {
            string strMysql = "SELECT * FROM seguros";

            return strMysql;
        }

        public string FiltrarSeguroVeiculo(string idveiculo)
        {

            string strMysql = "SELECT * FROM seguros WHERE id_veiculo = '" + idveiculo + "';";
            //cmd.Parameters.AddWithValue("@placa", placa);

            return strMysql;
        }
    }
}
