using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ControleProblema
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int NivelProblema { get; set; }
        public int TipoProblema { get; set; }


        public ControleProblema() { }

        public ControleProblema(int id, string descricao, DateTime dataCriacao, int nivel, int tipo)
        {
            this.Id = 1;
            this.Descricao = descricao;
            this.DataCriacao = dataCriacao;
            this.NivelProblema = nivel;
            this.TipoProblema = tipo;
        }

        public ControleProblema(string descricao, int nivel, int tipo)
        {
            this.Descricao = descricao;
            this.NivelProblema = nivel;
            this.TipoProblema = tipo;
        }
    }
}
