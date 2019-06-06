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
    public class AcompanhanteDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBanco conexao = new ConexaoBanco();
        MySqlConnection mySqlConnection;

        private string strConn = @"server=localhost;database=controlcar;userid=root;password=password;";

        public string AdicionarAcompanhante(Acompanhante acompanhante)
        {
            cmd.CommandText = "INSERT INTO acompanhante(acompanhante1, acompanhante2, acompanhante3) values(@acompanhante1, @acompanhante2, @acompanhante3)";

            // Cria um novo objeto do tipo MySqlCommand recebendo como parâmetro a string de acesso e o objeto de conexão. 

            cmd.Parameters.AddWithValue("@acompanhante1", acompanhante.Acompanhante1);
            cmd.Parameters.AddWithValue("@acompanhante2", acompanhante.Acompanhante2);
            cmd.Parameters.AddWithValue("@acompanhante3", acompanhante.Acompanhante3);

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

        public int BuscarIdAcompanhante()
        {
            try
            {
                string strMysql = "SELECT id_acompanhante FROM acompanhante ORDER BY id_acompanhante DESC LIMIT 1;";
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
