using WebApiTest.Domain.Entities;

namespace WebApiTest.Domain.Interfaces.Services
{
    public interface IUsuarioService
    {
        public Usuario BuscarPorId(int id);
        public List<Usuario> BuscarPorNome(string nome);
        public Usuario BuscarPorEmail(string email);
        public Usuario AdicionarUsuario(Usuario usuario);
        public Usuario AlterarUsuario(Usuario usuario);
        public bool ExcluirUsuario(Usuario usuario);
    }
}
