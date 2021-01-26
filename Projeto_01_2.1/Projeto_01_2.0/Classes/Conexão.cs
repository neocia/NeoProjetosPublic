using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01_2._0.Classes
{
    class Conexão
    {
        public static SqlConnection conect;
        private static string conexao = @"Data Source = DESKTOP-59DF77L\SQLEXPRESS; Initial Catalog =  cyberbank; User ID = sa; Password = M@rkstan";

        public static void Conectar()
        {
            conect = new SqlConnection(conexao);
            conect.Open();
        }
        public static void Desconectar()
        {
            conect.Close();
        }
    }
}
