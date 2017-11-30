using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.Models
{
    public class CursoRepositorio : ICurso
    {
        private List<Curso> cursos = new List<Curso>();
        private int _indexId = 1;

        public CursoRepositorio()
        {
            Incluir(new Curso { Titulo = "Química", Creditos = 3, Custo = 222.99M });
            Incluir(new Curso { Titulo = "Economia", Creditos = 3, Custo = 336.50M });
            Incluir(new Curso { Titulo = "Filosofia", Creditos = 3, Custo = 11.63M });
            Incluir(new Curso { Titulo = "Calculos", Creditos = 4, Custo = 15743.59M });
            Incluir(new Curso { Titulo = "Trigonometria", Creditos = 4, Custo = 45.49M });
            Incluir(new Curso { Titulo = "Ciencia", Creditos = 3, Custo = 114.00M });
            Incluir(new Curso { Titulo = "Literatura", Creditos = 4, Custo = 144.12M  });
        }

        public IEnumerable<Curso> RetornaTodos()
        {
            return cursos;
        }

        public Curso RetornaCurso(int cursoID)
        {
            return cursos.Find(c => c.CursoID == cursoID);
        }
        public Curso Incluir(Curso curso)
        {
            if (curso == null)
                throw new ArgumentNullException("curso");

            curso.CursoID = _indexId++;
            cursos.Add(curso);

            return curso;
        }

        public bool Atualizar(Curso curso)
        {
            if (curso == null)
                throw new ArgumentNullException("curso");

            int index = cursos.FindIndex(c => c.CursoID == curso.CursoID);
            if (index == -1)
                return false;

            cursos.RemoveAt(index);
            cursos.Add(curso);

            return true;
        }

        public bool Excluir(int cursoID)
        {
            cursos.RemoveAll(c => c.CursoID == cursoID);
            return true;
        }
    }
}