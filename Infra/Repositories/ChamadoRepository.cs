using WebApiTest.Domain.Entities;
using WebApiTest.Domain.Interfaces.Repositories;
using WebApiTest.Infra.Context;

namespace WebApiTest.Infra.Repositories
{
    public class ChamadoRepository : IChamadoRepository
    {
        private readonly SuporteContext _context;

        public ChamadoRepository(SuporteContext context)
        {
            _context = context;
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
            _context.Chamados.Add(chamado);
            _context.SaveChanges();
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
