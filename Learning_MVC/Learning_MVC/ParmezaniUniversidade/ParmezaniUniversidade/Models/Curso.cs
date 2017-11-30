using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParmezaniUniversidade.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Gera a chave primária, sem que o banco faça isso
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
        public decimal Custo { get; set; }

        public virtual ICollection<Inscricao> Inscricoes { get; set; }
    }
}