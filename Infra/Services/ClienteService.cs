using WebApiTest.Domain.Entities;
using WebApiTest.Domain.Interfaces.Services;

namespace WebApiTest.Infra.Services
{
    public class ClienteService : IClienteService
    {
        public Cliente AdicionarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente AlterarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
