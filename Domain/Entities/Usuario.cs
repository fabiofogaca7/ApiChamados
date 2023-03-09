namespace WebApiTest.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }




    }
}
