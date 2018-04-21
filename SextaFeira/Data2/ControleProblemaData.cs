using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;

namespace Data2
{
    public class ControleProblemaData
    {
        public const string ConectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ControleProblema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ControleProblemaData()
        {
        }

        public void Inserir(ControleProblema controleProblema)
        {
            var conect = ConectionString;
            using (var conn = new SqlConnection(conect))
            {
                conn.Open();

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"Insert into Problema(
                                            descricao,
                                            nivel,
                                            tipo,
                                            dataCriacao
                                        )
                                        values(
                                            @Descricao,
                                            @NivelProblema,
                                            @TipoProblema,
                                            @DataCriacao
                                        )";

                    comm.Parameters.AddWithValue("Descricao", controleProblema.Descricao);
                    comm.Parameters.AddWithValue("NivelProblema", controleProblema.NivelProblema);
                    comm.Parameters.AddWithValue("TipoProblema", controleProblema.TipoProblema);
                    comm.Parameters.AddWithValue("DataCriacao", controleProblema.DataCriacao);

                    comm.ExecuteNonQuery();
                }
                conn.Close();
            }

        }

        public List<ControleProblema> Listar()
        {
            var controleProblemas = new List<ControleProblema>();
            using (var conn = new SqlConnection(ConectionString))
            {
                conn.Open();

                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"
                    SELECT Id, Descricao, DataCriacao, tipo, nivel  FROM Problema 
                    order by Id";
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            controleProblemas.Add(new ControleProblema()
                            {
                                Id = (int)reader["Id"],
                                Descricao = reader["Descricao"].ToString(),
                                DataCriacao = (DateTime)reader["DataCriacao"],
                                TipoProblema = (int)reader["tipo"],
                                NivelProblema = (int)reader["nivel"]
                            });
                        }
                    }
                }
                conn.Close();

            }
            return controleProblemas;
        }
    }
}
