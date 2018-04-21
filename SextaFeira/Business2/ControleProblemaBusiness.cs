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
        public void InserirProblema(ControleProblema controleProblema)
        {
            controleProblema.DataCriacao = DateTime.Now;
            var data = new ControleProblemaData();
            data.InserirProblema(controleProblema);
        }
        public List<ControleProblema> ListarProblema()
        {
            var data = new ControleProblemaData();
            return data.ListarProblema();
        }

        public void InserirTipo(Tipo tipo)
        {
            var data = new ControleProblemaData();
            data.InserirTipo(tipo);
        }
        public List<Tipo> ListarTipo()
        {
            var data = new ControleProblemaData();
            return data.ListarTipo();
        }

        public void InserirNivel(Nivel nivel)
        {
            var data = new ControleProblemaData();
            data.InserirNivel(nivel);
        }
        public List<Nivel> ListarNivel()
        {
            var data = new ControleProblemaData();
            return data.ListarNivel();
        }
    }
}
