using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atvdd2_Uc04.Models
{
    public class UsuarioRepository
    {
        // Metodos de manipulação da classe usuario

        // Testar a conexao com banco de dados

        private const string DadosConexao = "Database=AgTurismo;Data Source=localhost;User Id=root;"; // obs de id maiusculo pode ser necessario alterar

        public void TestarConexao()
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();// Conectando com banco de dados
            Console.WriteLine("Banco de dados conectado com sucesso!!!");
            Conexao.Close();// Encerrando conexao com banco de dados
        }

        // 
        public Usuario ValidarLogin(Usuario usuario)
        {

            // Abrir conexao
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Criar usuario null
            Usuario UsuarioEncontrado = null;

            // Preparar a query
            String Query = "SELECT * FROM Usuario WHERE Login=@Login and Senha=@Senha";

            // Preparando comando que executa e salva os dados em mysqldatareader
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // Trata o sql injection
            Comando.Parameters.AddWithValue("@Login", usuario.Login);
            Comando.Parameters.AddWithValue("@Senha", usuario.Senha);

            // Executando comando que executa e salva os dados em mysqldatareader
            MySqlDataReader Reader = Comando.ExecuteReader();

            // Percurso de registros
            if (Reader.Read())
            {

                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }


            // Fechando conexao
            Conexao.Close();

            //retornando o usuario encontrado, se nao localizado retorna null.
            return UsuarioEncontrado;


        }

        //CRUD de usuario
        public void Remover(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public List<Usuario> Listar( int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();//Abrindo conexao


            //criando lista para ser retornada
            List<Usuario> ListaDeUsuarios = new List<Usuario>();


            // Condicao a ser executada atraves do metodo dentro de uma variavel que guarda o comando sql a ser executado
            String Query = " SELECT * FROM Usuario";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            


            // Executando o comando e guardando as informacoes executadas no objeto da classe MySqlDatareader
            MySqlDataReader Reader = Comando.ExecuteReader();


            //percorrer registros
            while (Reader.Read())
            {

                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                ListaDeUsuarios.Add(UsuarioEncontrado);
            }

            Conexao.Close();//Encerrando conexao

            //retornando a lista criada
            return ListaDeUsuarios;

        }

        public Usuario BuscarPorId(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            Usuario UsuarioEncontrado = new Usuario();

            String Query = "SELECT * FROM Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            if (Reader.Read())
            {

                UsuarioEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            Conexao.Close();

            return UsuarioEncontrado;
        }

        public void Inserir(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "INSERT INTO Usuario(Nome,Login,Senha,DataNascimento) VALUES(@Nome,@Login,@Senha,@DataNascimento)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }


        public void Atualizar(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "UPDATE Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);
            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }
    }
}