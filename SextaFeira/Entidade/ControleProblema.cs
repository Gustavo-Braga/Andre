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
        public int Nivel { get; set; }
        public Tipo TipoProblema { get; set; }


        public ControleProblema() { }

        public ControleProblema(int id, string descricao, DateTime dataCriacao, int nivel, Tipo tipo)
        {
            this.Id = 1;
            this.Descricao = descricao;
            this.DataCriacao = dataCriacao;
            this.Nivel = nivel;
            this.TipoProblema = tipo;
        }
    }
}
