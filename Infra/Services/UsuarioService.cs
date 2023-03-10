using WebApiTest.Domain.Entities;
using WebApiTest.Domain.Interfaces.Services;

namespace WebApiTest.Infra.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Usuario AdicionarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario AlterarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
