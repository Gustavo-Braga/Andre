using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace Data2
{
    public class ControleProblemaData
    {
        public List<ControleProblema> Mock { get; set; }

        public ControleProblemaData()
        {
            this.Mock = new List<ControleProblema>();
        }

        public void Inserir(ControleProblema controleProblema)
        {
            Mock.Add(controleProblema);
        }

        public List<ControleProblema> Listar()
        {
            for(var i = 0; i < 3; i++)
            {
                Mock.Add(new ControleProblema
                {
                    Id = i,
                    Descricao = "descricao " + i,
                    DataCriacao = DateTime.Now,
                    Nivel = i + 10,
                    TipoProblema = new Tipo
                    {
                        Id = i+20,
                        Descricao = "tipo descricao "+i
                    }
                    
                });
            }
            return Mock;
        }
    }
}
