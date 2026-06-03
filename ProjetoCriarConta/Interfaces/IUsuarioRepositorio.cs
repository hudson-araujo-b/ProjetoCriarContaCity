using ProjetoCriarConta.Models;

namespace ProjetoCriarConta.Interfaces
{
    public interface IUsuarioRepositorio
    {
        void CriarConta(UsuarioModel usuario);
    }
}
