using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.Classes
{
    public class VeiculoDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public string AdicionarVeiculo(Veiculo veiculo)
        {

            //Comando Sql: insert, update, delete

            cmd.CommandText = "INSERT INTO veiculo (placa, numero_renavam, marca, modelo, motor, cor, ano, quilometragem, tipoveiculo, status) " +
                "VALUES (@Placa, @NumeroRenavam, @Marca, @Modelo, @Motor, @Cor, @Ano, @Quilometragem, @TipoDeVeiculo, @Status)";

            //Parametros

            cmd.Parameters.AddWithValue("@Placa", veiculo.Placa);
            cmd.Parameters.AddWithValue("@NumeroRenavam", veiculo.NumeroRenavam);
            cmd.Parameters.AddWithValue("@Marca", veiculo.Marca);
            cmd.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
            cmd.Parameters.AddWithValue("@Motor", veiculo.Motor);
            cmd.Parameters.AddWithValue("@Cor", veiculo.Cor);
            cmd.Parameters.AddWithValue("@Ano", veiculo.Ano);
            cmd.Parameters.AddWithValue("@Quilometragem", veiculo.Quilometragem);
            cmd.Parameters.AddWithValue("@TipoDeVeiculo", veiculo.TipoDeVeiculo);
            cmd.Parameters.AddWithValue("@Status", veiculo.Status);

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
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public List<Veiculo> BuscarVeiculo(string placa, string status)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            MySqlConnection conn = new MySqlConnection(strConn);
            string strMysql = "SELECT * FROM veiculo WHERE placa = '" + placa + "' and status='" + status + "';";
            //cmd.Parameters.AddWithValue("@placa", placa);
            MySqlCommand cmd1 = new MySqlCommand(strMysql.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Veiculo v = new Veiculo()
                    {
                        Placa = Convert.ToString(rdr["placa"]),
                        NumeroRenavam = Convert.ToString(rdr["numero_renavam"]),
                        Marca = Convert.ToString(rdr["marca"]),
                        Modelo = Convert.ToString(rdr["modelo"]),
                        Motor = Convert.ToString(rdr["motor"]),
                        Cor = Convert.ToString(rdr["cor"]),
                        Ano = Convert.ToString(rdr["ano"]),
                        Quilometragem = Convert.ToDecimal(rdr["quilometragem"]),
                        TipoDeVeiculo = Convert.ToString(rdr["tipoveiculo"]),
                        Status = Convert.ToString(rdr["status"])
                    };
                    veiculos.Add(v);
                }
            }
            conn.Close();
            return veiculos;
        }

        public void EditarVeiculo
            (Veiculo veic, int id_veiculo)
            {

            cmd.CommandText = "UPDATE veiculo SET placa=@placa, numero_renavam=@numero_renavam, marca=@marca, modelo=@modelo, motor=@motor, cor=@cor, ano=@ano, quilometragem=@quilometragem WHERE id_veiculo=@id_veiculo and status=@status;";

            cmd.Parameters.AddWithValue("@placa", veic.Placa);
            cmd.Parameters.AddWithValue("@numero_renavam", veic.NumeroRenavam);
            cmd.Parameters.AddWithValue("@marca", veic.Marca);
            cmd.Parameters.AddWithValue("@modelo", veic.Modelo);
            cmd.Parameters.AddWithValue("@motor", veic.Motor);
            cmd.Parameters.AddWithValue("@cor", veic.Cor);
            cmd.Parameters.AddWithValue("@ano", veic.Ano);
            cmd.Parameters.AddWithValue("@quilometragem", veic.Quilometragem);
            cmd.Parameters.AddWithValue("@status", veic.Status);
            cmd.Parameters.AddWithValue("@id_veiculo", id_veiculo);

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

        public void ExcluirVeiculo(int id_veiculo)
        {
            cmd.CommandText = "UPDATE veiculo SET status='"+"Inativo"+"' WHERE id_veiculo='"+id_veiculo+"';";

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

        public List<Veiculo> ListarVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            MySqlConnection conn = new MySqlConnection(strConn); //comando para obter o número de linhas                                                                                                                               //existentes no BD      
            string sql1 = "SELECT placa, numero_renavam, marca, modelo, motor, cor, ano, quilometragem, tipoveiculo, status From veiculo WHERE status='"+"Ativo"+"';";
            MySqlCommand cmd1 = new MySqlCommand(sql1.ToString(), conn);                       
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Veiculo v = new Veiculo()
                    {
                        Placa = Convert.ToString(rdr["placa"]),
                        NumeroRenavam = Convert.ToString(rdr["numero_renavam"]),
                        Marca = Convert.ToString(rdr["marca"]),
                        Modelo = Convert.ToString(rdr["modelo"]),
                        Motor = Convert.ToString(rdr["motor"]),
                        Cor = Convert.ToString(rdr["cor"]),
                        Ano = Convert.ToString(rdr["ano"]),
                        Quilometragem = Convert.ToDecimal(rdr["quilometragem"]),
                        TipoDeVeiculo = Convert.ToString(rdr["tipoveiculo"]),
                        Status = Convert.ToString(rdr["status"])
                    };

                    veiculos.Add(v);
                }
            }
            conn.Close();
            return veiculos;
        }
        public string[] AutoComplete()
        {
            MySqlConnection conn = new MySqlConnection(strConn); //comando para obter o número de linhas
                                                                                                                                //existentes no BD      
            string sql1 = "Select count(id_veiculo) From veiculo";
            //comando para ler os DADos do BD
            string sql2 = "Select (placa) From veiculo";
            MySqlCommand cmd1 = new MySqlCommand(sql1.ToString(), conn);
            MySqlCommand cmd2 = new MySqlCommand(sql2.ToString(), conn);
            //Instância do contador do array
            int i = 0;
            conn.Open();
            //Instância do Array que recebrá os dados,
            //E recebe o resultado da primeira consulta para 
            //delimitar seu tamanho
            string[] Dados = new string[Convert.ToInt32(cmd1.ExecuteScalar())];
            //segunda consulta 
            MySqlDataReader rdr = cmd2.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    //Enquanto o rdr estiver lendo algo
                    //O array de string recebe os dados
                    Dados[i] = rdr["placa"].ToString();
                    i++;
                }
            }
            conn.Close();
            return Dados;
        }

        public int BuscarIdVeiculo(string coluna, string valor)
        {
            try
            {
                string strMysql = "SELECT id_veiculo FROM veiculo WHERE "+coluna+" ='"+valor+"';";
                //cmd.Parameters.AddWithValue("@placa", placa);
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
    }
}
