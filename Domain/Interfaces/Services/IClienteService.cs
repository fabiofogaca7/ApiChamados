using WebApiTest.Domain.Entities;

namespace WebApiTest.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        public Cliente BuscarPorId(int id);
        public List<Cliente> BuscarPorNome(string nome);
        public Cliente BuscarPorEmail(string email);
        public Cliente AdicionarCliente(Cliente cliente);
        public Cliente AlterarCliente(Cliente cliente);
        public bool ExcluirCliente(Cliente cliente);
    }
}
