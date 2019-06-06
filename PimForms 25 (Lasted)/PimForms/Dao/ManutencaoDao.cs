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
    public class ManutencaoDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public string AdicionarManutencao(Manutencao manutencao)
        {
            cmd.CommandText = "INSERT INTO manutencao (placa, tipo, valor, local, descricao, data, quilometragem, id_veiculo)" +
                "VALUES (@placa, @tipo, @valor, @local, @descricao, @data, @quilometragem, @idVeiculo)";

            //Parametros
            cmd.Parameters.AddWithValue("@tipo", manutencao.Tipo);
            cmd.Parameters.AddWithValue("@valor", manutencao.Valor);
            cmd.Parameters.AddWithValue("@local", manutencao.Local);
            cmd.Parameters.AddWithValue("@descricao", manutencao.Descricao);
            cmd.Parameters.AddWithValue("@data", manutencao.Data);
            cmd.Parameters.AddWithValue("@quilometragem", manutencao.Quilometragem);
            cmd.Parameters.AddWithValue("@placa", manutencao.Placa);
            cmd.Parameters.AddWithValue("@idVeiculo", manutencao.IdVeiculo);


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

        public List<Manutencao> BuscarManutencao(int idManutencao, string data)
        {
            List<Manutencao> manutencoes = new List<Manutencao>();
            MySqlConnection conn = new MySqlConnection(strConn);
            string strMysql = "SELECT id_veiculo, placa, tipo, valor, local, descricao, data, quilometragem FROM manutencao WHERE id_manutencao='"+idManutencao+"'and data='"+data+"';";
            MySqlCommand cmd1 = new MySqlCommand(strMysql.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Manutencao manutencao = new Manutencao()
                    {
                        IdVeiculo = Convert.ToInt16(rdr["id_veiculo"]),
                        Placa = Convert.ToString(rdr["placa"]),
                        Tipo = Convert.ToString(rdr["tipo"]),
                        Valor = Convert.ToDecimal(rdr["valor"]),
                        Local = Convert.ToString(rdr["local"]),
                        Descricao = Convert.ToString(rdr["descricao"]),
                        Data = Convert.ToDateTime(rdr["data"]),
                        Quilometragem = Convert.ToDecimal(rdr["quilometragem"])
                    };

                    manutencoes.Add(manutencao);
                }
            }
            conn.Close();
            return manutencoes;
        }

        public List<Manutencao> ListarManutencao()
        {
            List<Manutencao> manutencoes = new List<Manutencao>();
            MySqlConnection conn = new MySqlConnection(strConn);
            string strMysql = "SELECT * FROM manutencao";
            //cmd.Parameters.AddWithValue("@matricula", matricula);
            MySqlCommand cmd1 = new MySqlCommand(strMysql.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Manutencao manutencao = new Manutencao()
                    {
                        IdVeiculo = Convert.ToInt16(rdr["id_veiculo"]),
                        Placa = Convert.ToString(rdr["placa"]),
                        Tipo = Convert.ToString(rdr["tipo"]),
                        Valor = Convert.ToDecimal(rdr["valor"]),
                        Local = Convert.ToString(rdr["local"]),
                        Descricao = Convert.ToString(rdr["descricao"]),
                        Data = Convert.ToDateTime(rdr["data"]),
                        Quilometragem = Convert.ToDecimal(rdr["quilometragem"])
                    };

                    manutencoes.Add(manutencao);
                }
            }
            conn.Close();
            return manutencoes;
        }

        public string EditarManutencao(Manutencao manutencao, int id)
        {
            cmd.CommandText = "UPDATE manutencao SET placa=@placa, tipo=@tipo, valor=@valor, local=@local, descricao=@descricao, data=@data, quilometragem=@quilometragem WHERE id_manutencao=@idManutencao";

            cmd.Parameters.AddWithValue("@placa", manutencao.Placa);
            cmd.Parameters.AddWithValue("@tipo", manutencao.Tipo);
            cmd.Parameters.AddWithValue("@valor", manutencao.Valor);
            cmd.Parameters.AddWithValue("@local", manutencao.Local);
            cmd.Parameters.AddWithValue("@descricao", manutencao.Descricao);
            cmd.Parameters.AddWithValue("@data", manutencao.Data);
            cmd.Parameters.AddWithValue("@quilometragem", manutencao.Quilometragem);
            cmd.Parameters.AddWithValue("@idManutencao", id);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Cadastro atualizado com sucesso!");
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

        public int BuscarIdManutencao(string placa, string data)
        {
            try
            {
                string strMysql = "SELECT id_manutencao FROM manutencao WHERE placa='"+ placa +"' and data='"+data+"';";

                mySqlConnection = conexao.Conectar();
                cmd = new MySqlCommand(strMysql, mySqlConnection);

                //cmd.Connection = conexao.Conectar();

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
    }
}
