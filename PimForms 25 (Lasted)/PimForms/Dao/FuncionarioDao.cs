using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace PimForms.Classes
{
    public class FuncionarioDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public string AdicionarFuncionario(Funcionario funcionario)
        {

            cmd.CommandText = "INSERT INTO funcionario(" +
                "matricula, nome, cpf, data_nascimento, telefone, cargo, email, numero_cnh, categoria_cnh, validade_cnh, motorista, status)" +
                "VALUES (@matricula, @nome, @cpf, @data_nascimento, @telefone, @cargo, @email, @numero_cnh, @categoria_cnh, @validade_cnh, @motorista, @status)";

            // Cria um novo objeto do tipo MySqlCommand recebendo como parâmetro a string de acesso e o objeto de conexão. 

            cmd.Parameters.AddWithValue("@matricula", funcionario.Matricula);
            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
            cmd.Parameters.AddWithValue("@data_nascimento", funcionario.DataDeNascimento);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@numero_cnh", funcionario.NumeroCNH);
            cmd.Parameters.AddWithValue("@categoria_cnh", funcionario.CategoriaCNH);
            cmd.Parameters.AddWithValue("@validade_cnh", funcionario.ValidadeCNH);
            cmd.Parameters.AddWithValue("@motorista", funcionario.Motorista);
            cmd.Parameters.AddWithValue("@status", funcionario.Status);

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

        public List<Funcionario> BuscarFuncionario(string matricula, string status)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            MySqlConnection conn = new MySqlConnection(strConn);
            string strMysql = "SELECT * FROM funcionario WHERE matricula = '" + matricula+ "' and status='" + status + "';";
            //cmd.Parameters.AddWithValue("@matricula", matricula);
            MySqlCommand cmd1 = new MySqlCommand(strMysql.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                       Funcionario f = new Funcionario()
                    {
                        Matricula = Convert.ToString(rdr["matricula"]),
                        Nome = Convert.ToString(rdr["nome"]),
                        CPF = Convert.ToString(rdr["cpf"]),
                        DataDeNascimento =Convert.ToDateTime(rdr["data_nascimento"]),
                        Telefone = Convert.ToString(rdr["telefone"]),
                        Cargo = Convert.ToString(rdr["cargo"]),
                        Email = Convert.ToString(rdr["email"]),
                        NumeroCNH = Convert.ToString(rdr["numero_cnh"]),
                        CategoriaCNH = Convert.ToString(rdr["categoria_cnh"]),
                        ValidadeCNH = Convert.ToDateTime(rdr["validade_cnh"]),
                        Motorista = Convert.ToString(rdr["motorista"]),
                        Status = Convert.ToString(rdr["status"])
                       };

                    funcionarios.Add(f);
                }
            }
            conn.Close();
            return funcionarios;
        }

        public string EditarFuncionario(Funcionario funcionario, int id)
        {
            cmd.CommandText = "UPDATE funcionario SET nome=@nome, cpf=@cpf, data_nascimento=@data_nascimento, telefone=@telefone, cargo=@cargo, email=@email, numero_cnh=@numero_cnh, categoria_cnh=@categoria_cnh, validade_cnh=@validade_cnh WHERE id_funcionario=@id_funcionario and status=@status;";

            cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
            cmd.Parameters.AddWithValue("@data_nascimento", funcionario.DataDeNascimento);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
            cmd.Parameters.AddWithValue("@email", funcionario.Email);
            cmd.Parameters.AddWithValue("@numero_cnh", funcionario.NumeroCNH);
            cmd.Parameters.AddWithValue("@categoria_cnh", funcionario.CategoriaCNH);
            cmd.Parameters.AddWithValue("@validade_cnh", funcionario.ValidadeCNH);
            cmd.Parameters.AddWithValue("@status", funcionario.Status);
            cmd.Parameters.AddWithValue("@id_funcionario", id);

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

        public void ExcluirFuncionario(int id_funcionario)
        {
            cmd.CommandText = "UPDATE funcionario SET status='" + "Inativo" + "' WHERE id_funcionario='" + id_funcionario+"';";

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

        public List<Funcionario> ListarFuncionario()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            MySqlConnection conn = new MySqlConnection(strConn); //comando para obter o número de linhas                                                                                                                               //existentes no BD      
            string sql1 = "SELECT matricula, nome, cpf, data_nascimento, telefone, cargo, email, numero_cnh, categoria_cnh, validade_cnh, motorista, status From funcionario WHERE status='" + "Ativo" + "';";
            MySqlCommand cmd1 = new MySqlCommand(sql1.ToString(), conn);
            conn.Open();
            MySqlDataReader rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Funcionario f = new Funcionario()
                    {
                        Matricula = Convert.ToString(rdr["matricula"]),
                        Nome = Convert.ToString(rdr["nome"]),
                        CPF = Convert.ToString(rdr["cpf"]),
                        DataDeNascimento = Convert.ToDateTime(rdr["data_nascimento"]),
                        Telefone = Convert.ToString(rdr["telefone"]),
                        Cargo = Convert.ToString(rdr["cargo"]),
                        Email = Convert.ToString(rdr["email"]),
                        NumeroCNH = Convert.ToString(rdr["numero_cnh"]),
                        CategoriaCNH = Convert.ToString(rdr["categoria_cnh"]),
                        ValidadeCNH = Convert.ToDateTime(rdr["validade_cnh"]),
                        Motorista = Convert.ToString(rdr["motorista"]),
                        Status = Convert.ToString(rdr["status"])
                    };

                    funcionarios.Add(f);
                }
            }
            conn.Close();
            return funcionarios;
        }

        public string[] AutoComplete(string coluna)
        {
            MySqlConnection conn = new MySqlConnection(strConn); //comando para obter o número de linhas
                                                                                                                                //existentes no BD      
            string sql1 = "Select count(id_funcionario) From funcionario";
            //comando para ler os DADos do BD
            string sql2 = "Select ("+coluna+") From funcionario";
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
                    Dados[i] = rdr[coluna].ToString();
                    i++;
                }
            }
            conn.Close();
            return Dados;
        }

        public string BuscarAcompanhante(string matricula)
        {
            try
            {
                string strMysql = "SELECT nome FROM funcionario WHERE matricula= '" + matricula + "';";
                //cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);
                mySqlConnection = conexao.Conectar();
                cmd = new MySqlCommand(strMysql, mySqlConnection);

                return cmd.ExecuteScalar().ToString(); 
            }
            catch (MySqlException)
            {
                return "Acompanhante não encontrado";
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public int BuscarIdFuncionario(string coluna, string valor)
        {
            try
            {
                string strMysql = "SELECT id_funcionario FROM funcionario WHERE "+coluna+"='"+valor+"';";
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
    }
}
    


