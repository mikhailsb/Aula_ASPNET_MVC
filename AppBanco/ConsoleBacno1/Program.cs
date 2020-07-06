using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoDLL;
using AppBancoDominio;

namespace ConsoleBacno1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBancoDLL.UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario bjUsuario = new Usuario();

            //Banco.Dispose();

            //Console.WriteLine("Digite o ID do Usuário: ");
            //bjUsuario.IdUsu = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o Nome do Usuário: ");
            //bjUsuario.NomeUsu = Console.ReadLine();
            //Console.WriteLine("Digite o Cargo do usuário: ");
            //bjUsuario.Cargo = Console.ReadLine();
            //Console.WriteLine("Digite o data de nascimento (MM/dd/AAAA) do Usuário: ");
            //bjUsuario.DataNasc = DateTime.Parse(Console.ReadLine());
            
            //Console.Clear();

            //Banco.AbreDb();

            //usuarioDAO.Salvar(bjUsuario);

            var leito = usuarioDAO.Listar();

            foreach(var usuarios in leito)
            {
                Console.WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", usuarios.IdUsu, usuarios.NomeUsu, usuarios.Cargo, usuarios.DataNasc);
            }

            Console.ReadLine();
        }
    }
}





////            string strAtualiza = "UPDATE tbUsuario SET NomeUsu = 'Draw' WHERE IdUsu = 2";
////            SqlCommand comando = new SqlCommand(strAtualiza, conexao);
////            comando.ExecuteNonQuery();

////            comando.CommandText = "SELECT * FROM tbUsuario";
////            SqlDataReader leitor = comando.ExecuteReader();

////            while (leitor.Read())
////            {
////                Console.WriteLine("ID: {0} ,Nome: {1} ,Cargo: {2} ,Data: {3}", leitor["IdUsu"], leitor["NomeUsu"], leitor["Cargo"], leitor["DataNasc"]);
////            }
////            conexao.Close();

////            conexao.Open();
////            comando.CommandText = "DELETE FROM tbUsuario WHERE IdUsu = 2";
////            comando.ExecuteNonQuery();

////            comando.CommandText = "SELECT * FROM tbUsuario";
////            leitor = comando.ExecuteReader();

////            while (leitor.Read())
////            {
////                Console.WriteLine("ID: {0} ,Nome: {1} ,Cargo: {2} ,Data: {3}", leitor["IdUsu"], leitor["NomeUsu"], leitor["Cargo"], leitor["DataNasc"]);
////            }
////            conexao.Close();

////            conexao.Open();
////            comando.CommandText = "INSERT INTO tbUsuario (NomeUsu, Cargo, DataNasc) VALUES('Corleone', 'Gangster','02/28/2000');";
////            comando.ExecuteNonQuery();

////            comando.CommandText = "SELECT * FROM tbUsuario";
////            leitor = comando.ExecuteReader();

////            while (leitor.Read())
////            {
////                Console.WriteLine("ID: {0} ,Nome: {1} ,Cargo: {2} ,Data: {3}", leitor["IdUsu"], leitor["NomeUsu"], leitor["Cargo"], leitor["DataNasc"]);
////            }
////            conexao.Close();