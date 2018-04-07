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

        public List<Linguagem> Listar()
        {
            var linguagens = new List<Linguagem>();
            var conect = ConectionString;
            using (var conn = new SqlConnection(conect))
            {
               conn.Open();

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"
                    SELECT Id, Nome, Pontuacao FROM Linguagem 
                    order by Id";
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            linguagens.Add(new Linguagem()
                            {
                                Id = (int)reader["Id"],
                                Nome = reader["Nome"].ToString(),
                                Pontuacao = (int)reader["Pontuacao"]
                            });
                        }
                    }
                }
                conn.Close();

            }
            return linguagens;
        }

        public void Inserir(Linguagem linguagem)
        {
            var conect = ConectionString;
            using (var conn = new SqlConnection(conect))
            {
                conn.Open();

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"Insert into Linguagem(Id,Nome,Pontuacao)
                                        values(@id,@nome,@pontuacao)";

                    comm.Parameters.AddWithValue("Id", linguagem.Id);
                    comm.Parameters.AddWithValue("Nome", linguagem.Nome);
                    comm.Parameters.AddWithValue("Pontuacao", linguagem.Pontuacao);

                    comm.ExecuteNonQuery();
                }
                conn.Close();

            }
        }
    }
}