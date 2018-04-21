using Business;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            var linguagem = new Linguagem();
            linguagem.Id = 1;
            linguagem.Nome = "portugues";
            linguagem.Pontuacao = 3;

            try
            {
                var linguagemBusiness = new LinguagemBusiness();
                //linguagemBusiness.Inserir(linguagem);
                //Console.WriteLine("Success");
                var teste = linguagemBusiness.Listar();
                Console.Write("foi");
                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine("Erro - " + e);
            }



        }
    }
}
