using WebApiTest.Domain.Entities;
using WebApiTest.Domain.Interfaces.Repositories;
using WebApiTest.Domain.Interfaces.Services;

namespace WebApiTest.Infra.Services
{
    public class ChamadoService : IChamadoService
    {
        private readonly IChamadoRepository _chamadoRepository;

        public ChamadoService(IChamadoRepository chamadoRepository)
        {
            _chamadoRepository = chamadoRepository;
        }

        public Chamado AlterarChamado(Chamado chamado)
        {
            throw new NotImplementedException();
        }

        public List<Chamado> BuscarPorCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Chamado> BuscarPorDataAbertura(DateTime DataAbertura)
        {
            throw new NotImplementedException();
        }

        public List<Chamado> BuscarPorDataEncerramento(DateTime DataEncerramento)
        {
            throw new NotImplementedException();
        }

        public Chamado BuscarPorNumeroChamado(int NumeroChamado)
        {
            throw new NotImplementedException();
        }

        public Chamado CadastrarChamado(Chamado chamado)
        {
            _chamadoRepository.CadastrarChamado(chamado);
            return chamado;
        }

        public bool CancelarChamado(Chamado chamado)
        {
            throw new NotImplementedException();
        }

        public bool EncerrarChamado(Chamado chamado)
        {
            throw new NotImplementedException();
        }
    }
}
