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
            data.Inserir(linguagem);
        }
        
    }
}