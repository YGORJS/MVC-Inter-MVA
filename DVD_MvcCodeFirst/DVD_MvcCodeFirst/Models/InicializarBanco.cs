using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DVD_MvcCodeFirst.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {

            /*

            //criar alugns dados no banco
            new List<Professor>
            {
                new Professor
                {
                     Nome = "Renato Haddad",
                     Materia = "Asp.net mvc",
                     Salario = 4000,
                     Telefone = "654564654654",
                     TwitterBlog = "http://weblogs.asp.net/renatohaddad",
                     Disponivel = true,
                     Admissao = new DateTime(2012,05,01),
                     Alunos = new List<Aluno>
                     {
                         new Aluno
                         {
                             NomeAluno = "Bruno",
                             Email = "bruno@bruno.com",
                             Aprovado = false,
                             Ano = 2011,
                             Inscricao = new DateTime(2011,8,12),
                         },

                          new Aluno
                         {
                             NomeAluno = "Jão",
                             Email = "joao@joao.com",
                             Aprovado = true,
                             Ano = 2021,
                             Inscricao = new DateTime(2021,8,12),
                         }
                     },
                     Topicos = new List<Topico>
                     {
                         new Topico
                         {
                             Descricao = "topico 1"

                         },
                         new Topico
                         {
                             Descricao = "Topico 2"
                         }
                     },

                }
            }.ForEach(p => context.Professores.Add(p));



            base.Seed(context);
            */
  
        }

    }
}