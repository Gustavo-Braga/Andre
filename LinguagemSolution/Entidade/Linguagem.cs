using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Linguagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Pontuacao { get; set; }

        public Linguagem() { }

        public Linguagem(int id, string nome, int pontuacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Pontuacao = pontuacao;
        }
    }
}
