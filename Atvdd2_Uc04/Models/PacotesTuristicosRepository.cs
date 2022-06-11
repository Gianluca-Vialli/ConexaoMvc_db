using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atvdd2_Uc04.Models
{
    public class PacotesTuristicosRepository
    {
        private const string ConexaoPacotes = "Database=AgTurismo;Data Source=localhost;User Id=root";

        public void TestarConexaoPacotes()
        {

            MySqlConnection Conexao = new MySqlConnection(ConexaoPacotes);

            Conexao.Open();
            Console.WriteLine("Conexão de PacotesTuristicos com o DB realizada com sucesso!!!");
            Conexao.Close();
        }


        public List<PacotesTuristicos> ListarPacotes(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(ConexaoPacotes);

            Conexao.Open();

            List<PacotesTuristicos> ListaDePacotes = new List<PacotesTuristicos>();

            String Query = "SELECT * FROM PacotesTuristicos";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            

            MySqlDataReader Reader = Comando.ExecuteReader();

            while (Reader.Read())
            {

                PacotesTuristicos PacotesEncontrados = new PacotesTuristicos();

                PacotesEncontrados.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    PacotesEncontrados.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                {
                    PacotesEncontrados.Origem = Reader.GetString("Origem");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                {
                    PacotesEncontrados.Destino = Reader.GetString("Destino");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                {
                    PacotesEncontrados.Atrativos = Reader.GetString("Atrativos");
                }

                PacotesEncontrados.Saida = Reader.GetDateTime("Saida");

                PacotesEncontrados.Retorno = Reader.GetDateTime("Retorno");

                PacotesEncontrados.Usuario = Reader.GetInt32("Usuario");

                ListaDePacotes.Add(PacotesEncontrados);
            }

            Conexao.Close();

            return ListaDePacotes;

        }

        public PacotesTuristicos BuscarPacotesPorId(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(ConexaoPacotes);
            Conexao.Open();

            PacotesTuristicos PacotesEncontrados = new PacotesTuristicos();
            String Query = "SELECT * FROM PacotesTuristicos WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            if (Reader.Read())
            {

                PacotesEncontrados.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    PacotesEncontrados.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                {
                    PacotesEncontrados.Origem = Reader.GetString("Origem");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                {
                    PacotesEncontrados.Destino = Reader.GetString("Destino");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                {
                    PacotesEncontrados.Atrativos = Reader.GetString("Atrativos");
                }

                PacotesEncontrados.Saida = Reader.GetDateTime("Saida");

                PacotesEncontrados.Retorno = Reader.GetDateTime("Retorno");

                PacotesEncontrados.Usuario = Reader.GetInt32("Usuario");

            }

            Conexao.Close();
            return PacotesEncontrados;
        }

        public void RemoverPacotes(PacotesTuristicos Pacotes)
        {

            MySqlConnection Conexao = new MySqlConnection(ConexaoPacotes);
            Conexao.Open();

            String Query = "DELETE FROM PacotesTuristicos WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", Pacotes.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public void InserirPacotes(PacotesTuristicos Pacotes)
        {

            MySqlConnection Conexao = new MySqlConnection(ConexaoPacotes);
            Conexao.Open();

            String Query = "INSERT INTO PacotesTuristicos(Nome,Origem,Destino,Atrativos,Saida,Retorno,Usuario)  Values(@Nome,@Origem,@Destino,@Atrativos,@Saida,@Retorno,@Usuario)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", Pacotes.Nome);
            Comando.Parameters.AddWithValue("@Origem", Pacotes.Origem);
            Comando.Parameters.AddWithValue("@Destino", Pacotes.Destino);
            Comando.Parameters.AddWithValue("@Atrativos", Pacotes.Atrativos);
            Comando.Parameters.AddWithValue("@Saida", Pacotes.Saida);
            Comando.Parameters.AddWithValue("@Retorno", Pacotes.Retorno);
            Comando.Parameters.AddWithValue("@Usuario", Pacotes.Usuario);

            Comando.ExecuteNonQuery();

            Conexao.Close();

        }

        public void AterarPacotes(PacotesTuristicos NovoPacote)
        {

            MySqlConnection Conexao = new MySqlConnection(ConexaoPacotes);
            Conexao.Open();

            String Query = "UPDATE PacotesTuristicos SET Nome=@Nome, Origem=@Origem, Destino=@Destino, Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);


            Comando.Parameters.AddWithValue("@Nome", NovoPacote.Nome);
            Comando.Parameters.AddWithValue("@Origem", NovoPacote.Origem);
            Comando.Parameters.AddWithValue("@Destino", NovoPacote.Destino);
            Comando.Parameters.AddWithValue("@Atrativos", NovoPacote.Atrativos);
            Comando.Parameters.AddWithValue("@Saida", NovoPacote.Saida);
            Comando.Parameters.AddWithValue("@Retorno", NovoPacote.Retorno);
            Comando.Parameters.AddWithValue("@Usuario", NovoPacote.Usuario);
            Comando.Parameters.AddWithValue("@Id", NovoPacote.Id);


            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
    }
}