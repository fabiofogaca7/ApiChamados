using WebApiTest.Domain.Entities;
using WebApiTest.Domain.Interfaces.Repositories;

namespace WebApiTest.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
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
