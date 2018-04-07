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
        public void Inserir(Linguagem linguagem)
        {
            var data = new LinguagemData();
            linguagem.Id = data.Listar().Count() + 1;
           
            data.Inserir(linguagem);
        }

        public List<Linguagem> Listar()
        {
            var data = new LinguagemData();
            return data.Listar();
        }
    }
}