using MySql.Data.MySqlClient;
using ProjetoCriarConta.Interfaces;
using ProjetoCriarConta.Models;

namespace ProjetoCriarConta.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly string _connectionString;

        public UsuarioRepositorio(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Conexao")!;
        }

        public void CriarConta(UsuarioModel usuario)
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string senhaHash = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                var sql = "INSERT INTO tbUsuario(Nome,Email,Senha) VALUES (@nome,@email,@senha)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@senha", senhaHash);
                cmd.ExecuteNonQuery();

            }

        }
    }
}
