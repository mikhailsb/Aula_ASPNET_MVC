using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AppRoute66.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia{
                    NoticiaId = 1,
                    Categoria="Esportes",
                    Titulo="O time da escola ganha dos catados",
                    Conteudo="O time da escola ganha por 10x2 de time montado com os alunos sem time",
                    Data = new DateTime(22/03/2020)
                },
                new Noticia{
                    NoticiaId = 2,
                    Categoria="Esportes",
                    Titulo="Ônibus da seleção masculina em blitz",
                    Conteudo="O ônibus da seleção foi parado pela blitz por alguns motivos: Sem volante, sem lateral."+
                    " Grandes problemas na frente. E ainda transportando todos tipos de droga, menos crack.",
                    Data = new DateTime(15/02/2020)
                },
                new Noticia{
                    NoticiaId = 3,
                    Categoria="Escola",
                    Titulo="Custo da Escola",
                    Conteudo="Pai vai pagar de boleto de pagamento da escola do Jãozinho , "+
                    "-Se ele é o que menos estuda na turma, a mensalidade tem que ser menor!",
                    Data = new DateTime(02/03/2020)
                },
                new Noticia{
                    NoticiaId = 4,
                    Categoria="Escola",
                    Titulo="Diário de um Nerd",
                    Conteudo="Querido diário, estou tão feliz... "+
                    "Hoje eu dei o meu primeiro beijo! Tudo aconteceu quando eu estava de bomeira, "+
                    "andando na rua e quando olho mais a frente, lá está el, o cara mais popular da escola. "+
                    "Fomos nos aproximando , e ele sorriu pra mim ... Foi nesse momento que tudo aconteceu: "+
                    "Fiquei tão emocionada que esqueci de olhar pro chão, tropecei e ... beijei o chão.",
                    Data = new DateTime(22/02/2020)
                }
            };

            return retorno;
        }
    }
}