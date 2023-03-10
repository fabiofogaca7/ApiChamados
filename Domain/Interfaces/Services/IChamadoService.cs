using WebApiTest.Domain.Entities;

namespace WebApiTest.Domain.Interfaces.Services
{
    public interface IChamadoService
    {
        public Chamado BuscarPorNumeroChamado(int NumeroChamado);
        public List<Chamado> BuscarPorDataAbertura(DateTime DataAbertura);
        public List<Chamado> BuscarPorDataEncerramento(DateTime DataEncerramento);
        public List<Chamado> BuscarPorCliente(Cliente cliente);
        public Chamado CadastrarChamado(Chamado chamado);
        public Chamado AlterarChamado(Chamado chamado);
        public bool EncerrarChamado(Chamado chamado);
        public bool CancelarChamado(Chamado chamado);
    }
}
