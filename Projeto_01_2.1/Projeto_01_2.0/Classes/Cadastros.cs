using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01_2._0.Classes
{
    class Cadastros
    {
        public static void inserir(string nome_usuario, string login_usuario, string senha_usuario, string tipo_usuario)
        {
            string sql = @"insert into usuario values (@nome_usuario, @login_usuario, @senha_usuario, @tipo_usuario)";

            SqlCommand cmd = new SqlCommand(sql, Classes.Conexão.conect);

            cmd.Parameters.AddWithValue("nome_usuario", nome_usuario);
            cmd.Parameters.AddWithValue("login_usuario", login_usuario);
            cmd.Parameters.AddWithValue("senha_usuario", senha_usuario);
            cmd.Parameters.AddWithValue("tipo_usuario", tipo_usuario);
            cmd.ExecuteNonQuery();
        }
    }
}
