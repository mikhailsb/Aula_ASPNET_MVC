using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoADO;
using AppBancoDominio;

namespace AppBancoDLL
{
    public class UsuarioDAO
    {
        private Banco db;

        public void Insert(Usuario bjUsuario)
        {
            string Inserir = string.Format("INSERT INTO tbUsuario (NomeUsu, Cargo, DataNasc) VALUES('{0}', '{1}',convert(datetime,'{2}',103));", bjUsuario.NomeUsu, bjUsuario.Cargo, bjUsuario.DataNasc);

            using (db = new Banco())
            {
                db.ExecutaComando(Inserir);
            }
        }

        public void Atualiza(Usuario bjUsuario)
        {
            //UPDATE tbUsuario SET NomeUsu = 'Draw', Cargo = '', DataNasc = '' WHERE IdUsu = 2"
            string strAtualiza = "";
            strAtualiza += "UPDATE tbUsuario SET ";
            strAtualiza += string.Format("NomeUsu = '{0}',", bjUsuario.NomeUsu);
            strAtualiza += string.Format("Cargo = '{0}',", bjUsuario.Cargo);
            strAtualiza += string.Format("DataNasc = '{0}' ", bjUsuario.DataNasc);
            strAtualiza += string.Format(" WHERE IdUsu = {0}", bjUsuario.IdUsu);

            using (db = new Banco())
            {
                db.ExecutaComando(strAtualiza);
            }
        }

        public void Salvar(Usuario usuario)
        {
            if(usuario.IdUsu > 0)
            {
                Atualiza(usuario);
            }
            else
            {
                Insert(usuario);
            }
        }

        public void Excluir(int Id)
        {
            string strDelete = "";
            strDelete += "DELETE FROM tbUsuario ";
            strDelete += string.Format("Where IdUsu = {0}", Id);

            using (db = new Banco())
            {
                db.ExecutaComando(strDelete);
            }
        }


        public List<Usuario> Listar()
        {
            var db = new Banco();
            var sqlQuery = "SELECT * FROM tbUsuario";
            var retorno = db.RetornaComando(sqlQuery);

            return ListaDeUsuario(retorno);
        }

        public List<Usuario> ListaDeUsuario(SqlDataReader retorno)
        {
            var usuarios = new List<Usuario>();

            while(retorno.Read())
            {
                var TempUsuario = new Usuario()
                {
                    IdUsu = int.Parse(retorno["IdUsu"].ToString()),
                    NomeUsu = retorno["NomeUsu"].ToString(),
                    Cargo = retorno["Cargo"].ToString(),
                    DataNasc = DateTime.Parse(retorno["DataNasc"].ToString())
                };

                usuarios.Add(TempUsuario);
            }
            return usuarios;

        }
        
    }
}
