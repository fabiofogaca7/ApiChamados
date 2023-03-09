namespace WebApiTest.Domain.Entities
{
    public class Chamado
    {
        public int Id { get; set; }
        public int numeroChamado { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEncerramento { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }


    }
}
