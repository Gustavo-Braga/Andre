using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Repositorio
    {
        public Repositorio()
        {
        }

        public Repositorio(int id, string nome, int linguagem, DateTime dataCriacao)
        {
            Id = id;
            Nome = nome;
            IdLinguagem = linguagem;
            DataCriacao = dataCriacao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdLinguagem { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
