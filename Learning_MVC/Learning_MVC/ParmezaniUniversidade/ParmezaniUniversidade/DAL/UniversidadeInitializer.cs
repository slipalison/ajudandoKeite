using ParmezaniUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.DAL
{
    public class UniversidadeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var alunos = new List<Aluno> {

                 new Aluno{Nome="João", Sobrenome="Silva", DataInscricao=DateTime.Parse("2005-10-25") },
                 new Aluno{Nome="Maria", Sobrenome="Souza", DataInscricao=DateTime.Parse("2002-11-19") },
                 new Aluno{Nome="Sofia", Sobrenome="Carvalho", DataInscricao=DateTime.Parse("2001-01-23") },
                 new Aluno{Nome="Rafael", Sobrenome="Lima", DataInscricao=DateTime.Parse("2002-01-09") },
                 new Aluno{Nome="Matheus", Sobrenome="Viana", DataInscricao=DateTime.Parse("2002-01-09") },
                 new Aluno{Nome="José", Sobrenome="Soares", DataInscricao=DateTime.Parse("2003-12-15") },
                 new Aluno{Nome="Fernanda", Sobrenome="Nunes", DataInscricao=DateTime.Parse("2001-02-13") },
                 new Aluno{Nome="Mariana", Sobrenome="Oliveira", DataInscricao=DateTime.Parse("2004-03-07") },
                 new Aluno{Nome="Ruy", Sobrenome="Santana", DataInscricao=DateTime.Parse("2000-06-15") },
                 new Aluno{Nome="Julia", Sobrenome="Pinto", DataInscricao=DateTime.Parse("2002-05-18") },
            };

            alunos.ForEach(a => contexto.Alunos.Add(a));
            contexto.SaveChanges();

            var cursos = new List<Curso>
            {
                new Curso{ CursoID=1050, Titulo="Química", Creditos=3 },
                new Curso{ CursoID=4022, Titulo="Economia", Creditos=3 },
                new Curso{ CursoID=4041, Titulo="Filosofia", Creditos=3 },
                new Curso{ CursoID=1045, Titulo="Calculos", Creditos=4 },
                new Curso{ CursoID=3141, Titulo="Trigonometria", Creditos=4 },
                new Curso{ CursoID=2021, Titulo="Ciencia", Creditos=3 },
                new Curso{ CursoID=2042, Titulo="Literatura", Creditos=4 },
            };

            cursos.ForEach(c => contexto.Cursos.Add(c));
            contexto.SaveChanges();

            var inscricoes = new List<Inscricao>
            {
                new Inscricao{ AlunoID=1 ,CursoID=1050, Grade=Grade.A},
                new Inscricao{ AlunoID=1 ,CursoID=4022, Grade=Grade.C},
                new Inscricao{ AlunoID=1 ,CursoID=4041, Grade=Grade.B},
                new Inscricao{ AlunoID=2 ,CursoID=1045, Grade=Grade.B},
                new Inscricao{ AlunoID=2 ,CursoID=3141, Grade=Grade.F},
                new Inscricao{ AlunoID=2 ,CursoID=2021, Grade=Grade.F},
                new Inscricao{ AlunoID=3 ,CursoID=1050 },
                new Inscricao{ AlunoID=3 ,CursoID=1050 }
            };

            inscricoes.ForEach(i => contexto.Inscricoes.Add(i));
            contexto.SaveChanges();
        }
    }
}