using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PimForms.Classes
{
    public class ConexaoBanco
    {
        MySqlConnection con = new MySqlConnection();

        public ConexaoBanco()
        {
            con.ConnectionString = @"server=localhost;database=controlcar;userid=root;password=password;";
        }

        public MySqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}
