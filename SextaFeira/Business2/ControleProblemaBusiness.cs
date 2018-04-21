using Data2;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business2
{
    public class ControleProblemaBusiness
    {
        public void Inserir(ControleProblema controleProblema)
        {
            controleProblema.DataCriacao = DateTime.Now;
            var data = new ControleProblemaData();
            data.Inserir(controleProblema);
        }

        public List<ControleProblema> Listar()
        {
            var data = new ControleProblemaData();
            return data.Listar();
        }
    }
}
