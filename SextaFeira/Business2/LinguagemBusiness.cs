using Data;
using Entidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business
{
    public class LinguagemBusiness
    {
        public void InserirLinguagem(Linguagem linguagem)
        {
            var data = new LinguagemData();
            linguagem.Id = data.ListarLinguagem().Count() + 1;
           
            data.InserirLinguagem(linguagem);
        }

        public List<Linguagem> ListarLinguagem()
        {
            var data = new LinguagemData();
            return data.ListarLinguagem();
        }

        public void InserirRepositorio(Repositorio repositorio)
        {
            var data = new LinguagemData();
            data.InserirRepositorio(repositorio);
        }

        public List<Repositorio> ListarRepositorio()
        {
            var data = new LinguagemData();
            return data.ListarRepositorio();
        }
    }
}