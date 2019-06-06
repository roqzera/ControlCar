using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PimForms.Classes
{
    public class MultaDAO
    {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection = new MySqlConnection();

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public void AdcionarMulta(Multa multa)
        {
            cmd.CommandText = "INSERT INTO multa (numero_infracao, data_multa, valor, id_funcionario, id_veiculo) VALUES (@numDaInfracao, @datamulta, @valor, @id_funcionario, @id_veiculo)";
            cmd.Parameters.AddWithValue("@numDaInfracao", multa.NumeroDaInfracao);
            cmd.Parameters.AddWithValue("@datamulta", multa.Data);
            cmd.Parameters.AddWithValue("@valor", multa.Valor);
            cmd.Parameters.AddWithValue("@id_funcionario", multa.Funcionario);
            cmd.Parameters.AddWithValue("@id_veiculo", multa.Veiculo);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("CADASTRADO COM SUCESSO");
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO COM O BANCO DE DADOS");
            }

        }

        public void ExcluirMulta(int id_multa)
        {
            cmd.CommandText = "UPDATE multa SET controle_multa = 0 WHERE controle_multa = 1 and id_multa = '" + id_multa + "';";
            //cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
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


        public void EditarMulta(Multa mult, int id_multa)
        {

            cmd.CommandText = "UPDATE multa SET id_funcionario=@id_funcionario, id_veiculo=@id_veiculo, numero_infracao=@numero_infracao, data_multa=@data_multa, valor=@valor WHERE id_multa = @id_multa;";

            cmd.Parameters.AddWithValue("@id_funcionario", mult.Funcionario);
            cmd.Parameters.AddWithValue("@id_veiculo", mult.Veiculo);
            cmd.Parameters.AddWithValue("@numero_infracao", mult.NumeroDaInfracao);
            cmd.Parameters.AddWithValue("@data_multa", mult.Data);
            cmd.Parameters.AddWithValue("@valor", mult.Valor);
            cmd.Parameters.AddWithValue("@id_multa", id_multa);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                throw ex;
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

        public List<Multa> BuscarMultaLista(string placa)
        {
            List<Multa> multas = new List<Multa>();
            MySqlConnection conn = new MySqlConnection(strConn);
            string strMysql = "SELECT * FROM multa WHERE placa ='" + placa + "';";
            MySqlCommand cmd1 = new MySqlCommand(strMysql.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Multa m = new Multa()
                    {
                        
                        //Placa = Convert.ToString(rdr["placa"]),
                        NumeroDaInfracao = Convert.ToString(rdr["numero_infracao"]),
                        Valor = Convert.ToDecimal(rdr["valor"]),
                        Data = Convert.ToDateTime(rdr["data_multa"])
                    };
                    multas.Add(m);
                }
            }
            conn.Close();
            return multas;
        }
        public List<Multa> ListarMultas()
        {
            List<Multa> multa = new List<Multa>();
            MySqlConnection conn = new MySqlConnection(strConn);
            string sql1 = "SELECT multa.id_multa, multa.numero_infracao, multa.valor, multa.data_multa, funcionario.nome, veiculo.placa FROM multa INNER JOIN funcionario ON ( multa.id_funcionario = funcionario.id_funcionario) INNER JOIN veiculo ON (multa.id_veiculo = veiculo.id_veiculo);";
            MySqlCommand cmd1 = new MySqlCommand(sql1.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Multa m = new Multa()
                    {
                        //Placa = Convert.ToString(rdr["placa"]),
                        NumeroDaInfracao = Convert.ToString(rdr["numero_infracao"]),
                        Valor = Convert.ToDecimal(rdr["valor"]),
                        Data = Convert.ToDateTime(rdr["data_multa"]),
                        Funcionario = Convert.ToInt16(rdr["id_funcionario"])
                    };

                    multa.Add(m);
                }
            }
            conn.Close();
            return multa;
        }

        public int BuscarIdMulta(string coluna, string valor)
        {
            try
            {
                string strMysql = "SELECT id_multa FROM multa WHERE " + coluna + " = '" + valor + "';";
                //cmd.Parameters.AddWithValue("@nome", nome);
                mySqlConnection = conexao.Conectar();
                cmd = new MySqlCommand(strMysql, mySqlConnection);

                // Seleciona os dados do banco e preenche o DataAdapter com esses dados
                var result = cmd.ExecuteScalar();


                // Armazena no DataTable os dados que foram buscados no banco com o uso do SelectCommand
                int id = Convert.ToInt32(result);

                return id;
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


        public string ListarMulta()
        {
            string strMysql = "SELECT multa.id_multa, multa.numero_infracao, multa.valor, multa.data_multa, funcionario.nome, veiculo.placa FROM multa INNER JOIN funcionario ON(multa.id_funcionario = funcionario.id_funcionario) INNER JOIN veiculo ON(multa.id_veiculo = veiculo.id_veiculo) where controle_multa =1;";

            return strMysql;
        }

    }
}

