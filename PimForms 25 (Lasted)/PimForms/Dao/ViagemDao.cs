using MySql.Data.MySqlClient;
using PimForms.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.Dao
{
    public class ViagemDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;
        FuncionarioDao funcionarioDao = new FuncionarioDao();

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public string AdicionarViagem(Viagem viagem)
        {
            //Comando Sql: insert, update, delete

            cmd.CommandText = "INSERT INTO viagem (data_saida, data_retorno, destino, valor_adiantamento, km_inicial, km_final, id_veiculo, id_funcionario, id_acompanhante) " +
                "VALUES (@data_saida, @data_retorno, @destino, @valor_adiantamento, @km_inicial, @km_final, @id_veiculo, @id_funcionario, @id_acompanhante)";

            //Parametros
            cmd.Parameters.AddWithValue("@data_saida", viagem.DataSaida);
            cmd.Parameters.AddWithValue("@data_retorno", viagem.DataRetorno);
            cmd.Parameters.AddWithValue("@destino", viagem.Destino);
            cmd.Parameters.AddWithValue("@valor_adiantamento", viagem.ValorAdiantamento);
            cmd.Parameters.AddWithValue("@km_inicial", viagem.KmInicial);
            cmd.Parameters.AddWithValue("@km_final", viagem.KmFinal);
            cmd.Parameters.AddWithValue("@id_veiculo", viagem.IdVeiculo);
            cmd.Parameters.AddWithValue("@id_funcionario", viagem.IdFuncionario);
            cmd.Parameters.AddWithValue("@id_acompanhante", viagem.IdAcompanhante);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Cadastro realizado com sucesso!");
                return "ok";
            }

            catch (MySqlException ex)
            {

                return Convert.ToString(ex);
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public void ExcluirViagem(string id_viagem)
        {
            cmd.CommandText = "DELETE FROM viagem WHERE id_viagem = @id_viagem;";
            cmd.Parameters.AddWithValue("@id_viagem", id_viagem);

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

        public List<Viagem> BuscarViagem(int id_funcionario, int id_veiculo)
        {
            MessageBox.Show("não acredito");
            MessageBox.Show(id_funcionario.ToString());
            MessageBox.Show(id_veiculo.ToString());
            List<Viagem> viagens = new List<Viagem>();
            MySqlConnection conn = new MySqlConnection(strConn); //comando para obter o número de linhas                                                                                                                               //existentes no BD      
            string sql1 = "select * from viagem where id_funcionario ='"+id_funcionario+"' and id_veiculo ='"+id_veiculo+"';";
            MessageBox.Show(sql1);
            MySqlCommand cmd1 = new MySqlCommand(sql1.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Viagem v = new Viagem()
                    {
                        DataSaida = Convert.ToDateTime(rdr["data_saida"]),
                        DataRetorno = Convert.ToDateTime(rdr["data_retorno"]),
                        Destino = Convert.ToString(rdr["destino"]),
                        ValorAdiantamento = Convert.ToDecimal(rdr["valor_adiantamento"]),
                        KmInicial = Convert.ToDecimal(rdr["km_inicial"]),
                        KmFinal = Convert.ToDecimal(rdr["km_final"]),
                        IdVeiculo = Convert.ToInt32(rdr["id_veiculo"]),
                        IdFuncionario = Convert.ToInt32(rdr["id_funcionario"]),
                        IdAcompanhante = Convert.ToInt32(rdr["id_acompanhante"])
                    };

                    viagens.Add(v);
                }
            }
            conn.Close();
            return viagens;
        }


        public List<Viagem> ListarViagem()
        {
            List<Viagem> viagens = new List<Viagem>();
            MySqlConnection conn = new MySqlConnection(strConn); //comando para obter o número de linhas                                                                                                                               //existentes no BD      
            string sql1 = "select v.id_funcionario, v.id_veiculo, v.data_saida, v.data_retorno, v.destino, v.valor_adiantamento, v.km_inicial, v.km_final, f.nome as motorista, veic.Placa, a.acompanhante1, a.acompanhante2, a.acompanhante3 from viagem v inner join funcionario f on v.id_funcionario = f.id_funcionario inner join veiculo veic on v.id_veiculo = veic.id_veiculo inner join acompanhante a on v.id_acompanhante = a.id_acompanhante;";
            MySqlCommand cmd1 = new MySqlCommand(sql1.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Viagem v = new Viagem()
                    {
                        DataSaida = Convert.ToDateTime(rdr["data_saida"]),
                        DataRetorno = Convert.ToDateTime(rdr["data_retorno"]),
                        Destino = Convert.ToString(rdr["destino"]),
                        ValorAdiantamento = Convert.ToDecimal(rdr["valor_adiantamento"]),
                        KmInicial = Convert.ToDecimal(rdr["km_inicial"]),
                        KmFinal = Convert.ToDecimal(rdr["km_final"]),
                        IdFuncionario = Convert.ToInt32(rdr["id_funcionario"]),
                        IdVeiculo = Convert.ToInt32(rdr["id_veiculo"]),
                    };

                    viagens.Add(v);
                }
            }
            conn.Close();
            return viagens;
        }

        public int BuscarIdViagem(int idFuncionario, int idVeiculo, DateTime dataSaida)
        {
            try
            {
                string strMysql = "SELECT id_viagem FROM viagem WHERE id_funcionario ='" + idFuncionario + "' and id_veiculo ='" + idVeiculo + "' and data_saida ='" + dataSaida + "';";
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

        public string ListarViagens()
        {
            string strMysql = "select id_viagem, f.nome, veic.Placa, v.data_saida, v.data_retorno, v.destino, v.valor_adiantamento, v.km_inicial, v.km_final, a.acompanhante1, a.acompanhante2, a.acompanhante3 from viagem v inner join funcionario f on v.id_funcionario = f.id_funcionario inner join veiculo veic on v.id_veiculo = veic.id_veiculo inner join acompanhante a on v.id_acompanhante = a.id_acompanhante;";
       
            return strMysql;
        }
        public string PesquisarViagem(int idFuncionario, int idVeiculo)
        {
            string strMysql = "SELECT id_viagem, f.nome, veic.Placa, v.data_saida, v.data_retorno, v.destino, v.valor_adiantamento, v.km_inicial, v.km_final, a.acompanhante1, a.acompanhante2, a.acompanhante3 FROM viagem v inner join funcionario f on v.id_funcionario = f.id_funcionario inner join veiculo veic on v.id_veiculo = veic.id_veiculo inner join acompanhante a on v.id_acompanhante = a.id_acompanhante WHERE veic.id_veiculo = v.id_veiculo and f.id_funcionario = v.id_funcionario and f.id_funcionario = '" + idFuncionario + "' AND veic.id_veiculo = '" + idVeiculo + "';";
            
            return strMysql;
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



        public string FiltrarViagemVeiculo(string placa)
        {

            string strMysql = "SELECT * FROM veiculo_viagem WHERE placa = '"+placa+"';";
            //cmd.Parameters.AddWithValue("@placa", placa);

            return strMysql;
        }

        public string FiltrarViagemFuncionario(string matricula)
        {

            string strMysql = "SELECT * FROM funcionario_viagem WHERE matricula = '"+matricula+"';";
            //cmd.Parameters.AddWithValue("@matricula", matricula);

            return strMysql;
        }

        public string EditarViagem(Viagem viagem, int id)
        {
            cmd.CommandText = "UPDATE viagem SET data_saida=@data_saida, data_retorno=@data_retorno, destino=@destino, valor_adiantamento=@valor_adiantamento, km_inicial=@km_inicial, km_final=@km_final, id_veiculo=@id_veiculo, id_funcionario=@id_funcionario, id_acompanhante=@id_acompanhante WHERE id_viagem=@id_viagem";

            cmd.Parameters.AddWithValue("@data_saida", viagem.DataSaida);
            cmd.Parameters.AddWithValue("@data_retorno", viagem.DataRetorno);
            cmd.Parameters.AddWithValue("@destino", viagem.Destino);
            cmd.Parameters.AddWithValue("@valor_adiantamento", viagem.ValorAdiantamento);
            cmd.Parameters.AddWithValue("@km_inicial", viagem.KmInicial);
            cmd.Parameters.AddWithValue("@km_final", viagem.KmFinal);
            cmd.Parameters.AddWithValue("@id_veiculo", viagem.IdVeiculo);
            cmd.Parameters.AddWithValue("@id_funcionario", viagem.IdFuncionario);
            cmd.Parameters.AddWithValue("@id_acompanhante", viagem.IdAcompanhante);
            cmd.Parameters.AddWithValue("@id_viagem", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Cadastro atualizado com sucesso!");
                return null;
            }

            catch (MySqlException ex)
            {
                return Convert.ToString(ex);
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
                throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
