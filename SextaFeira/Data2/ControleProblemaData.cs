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

        public void InserirProblema(ControleProblema controleProblema)
        {
            using (var conn = new SqlConnection(ConectionString))
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
        public void InserirTipo(Tipo tipo)
        {
            using (var conn = new SqlConnection(ConectionString))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"Insert into Tipo(
                                            descricao
                                        )
                                        values(
                                            @Descricao
                                        )";

                    comm.Parameters.AddWithValue("Descricao", tipo.Descricao);
                    comm.ExecuteNonQuery();
                }
                conn.Close();
            }

        }
        public void InserirNivel(Nivel nivel)
        {
            using (var conn = new SqlConnection(ConectionString))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"Insert into Nivel(
                                            descricao
                                        )
                                        values(
                                            @Descricao
                                        )";

                    comm.Parameters.AddWithValue("Descricao", nivel.Descricao);
                    comm.ExecuteNonQuery();
                }
                conn.Close();
            }

        }

        public List<ControleProblema> ListarProblema()
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
        public List<Tipo> ListarTipo()
        {
            var tipos = new List<Tipo>();
            using (var conn = new SqlConnection(ConectionString))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"
                    SELECT Id, Descricao FROM Tipo 
                    order by Id";
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tipos.Add(new Tipo()
                            {
                                Id = (int)reader["Id"],
                                Descricao = reader["Descricao"].ToString(),
                            });
                        }
                    }
                }
                conn.Close();
            }
            return tipos;
        }
        public List<Nivel> ListarNivel()
        {
            var niveis = new List<Nivel>();
            using (var conn = new SqlConnection(ConectionString))
            {
                conn.Open();
                using (var comm = conn.CreateCommand())
                {
                    comm.CommandText = @"
                    SELECT Id, Descricao FROM Nivel 
                    order by Id";
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            niveis.Add(new Nivel()
                            {
                                Id = (int)reader["Id"],
                                Descricao = reader["Descricao"].ToString(),
                            });
                        }
                    }
                }
                conn.Close();
            }
            return niveis;
        }
    }
}
