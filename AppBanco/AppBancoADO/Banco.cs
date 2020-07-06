using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppBancoADO
{
    public class Banco : IDisposable
    {
        private readonly SqlConnection conexao;

        public Banco()
        {
            conexao = new SqlConnection(@"Data Source=DESKTOP-JQLG7H5; Initial Catalog=dbEXEMPLO; User Id=userBanco; Password=12345678");
            conexao.Open();
        }
        public void Dispose()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();
        }

        public void AbreDb()
        {
            conexao.Open();
        }

        public void ExecutaComando(string strComando)
        {
            var vComando = new SqlCommand
            {
                CommandText = strComando,
                CommandType = System.Data.CommandType.Text,
                Connection = conexao
            };
            vComando.ExecuteNonQuery();
        }

        public SqlDataReader RetornaComando(string strComando)
        {
            var vComando = new SqlCommand(strComando, conexao);

            return vComando.ExecuteReader();
        }

        
    }
}
