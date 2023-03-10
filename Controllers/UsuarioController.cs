using Microsoft.AspNetCore.Mvc;
using WebApiTest.Domain.Entities;
using WebApiTest.Domain.Interfaces.Services;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        List<String> usuarios = new List<String>();

        private readonly IChamadoService _chamadoService;

        public UsuarioController(IChamadoService chamadoService)
        {
            _chamadoService = chamadoService;
        }

        [HttpGet]
        [Route("get-usuarios")]
        public IActionResult GetUsuarios()
        {

            usuarios.Add("fabio");
            usuarios.Add("raphael");
            usuarios.Add("vaguinho");

            return Ok(usuarios);
        }

        [HttpPost]
        [Route("cadastro")]
        public IActionResult Cadastro(Chamado chamado)
        {
            _chamadoService.CadastrarChamado(chamado);
            return Ok(chamado);
        }

        [HttpDelete]
        [Route("delete-usuario")]
        public IActionResult DeleteUsuario() 
        {
            usuarios.Add("fabio");
            usuarios.Add("raphael");
            usuarios.Add("vaguinho");
            usuarios.Add("jose");

            usuarios.Remove("jose");

            return Ok(usuarios);
        }
    }


}
