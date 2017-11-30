using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParmezaniUniversidade.Models
{
    interface ICurso
    {
        IEnumerable<Curso> RetornaTodos();
        Curso RetornaCurso(int cursoID);
        Curso Incluir(Curso curso);
        bool Atualizar(Curso curso);
        bool Excluir(int cursoID);
    }
}
