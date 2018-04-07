using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Entidade;

namespace Data
{
    public class LinguagemData
    {
        public const string ConectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PROJETOLINGUAGEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        

        public void Inserir(Linguagem linguagem)
        {
            var conect = ConectionString;
            using (var conn = new SqlConnection(conect))
            {
                conn.Open();

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"Insert into Linguagem(Nome,Pontuacao)
                                        values(@nome,@cpf,@salario)";

                    comm.Parameters.AddWithValue("Nome", linguagem.Nome);
                    comm.Parameters.AddWithValue("Pontuacao", linguagem.Pontuacao);

                    comm.ExecuteNonQuery();
                }

            }
        }
    }
}