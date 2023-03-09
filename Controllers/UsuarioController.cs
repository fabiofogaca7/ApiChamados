using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        List<String> usuarios = new List<String>();

        [HttpGet]
        [Route("get-usuarios")]
        public IActionResult GetUsuarios()
        {

            usuarios.Add("fabio");
            usuarios.Add("raphael");
            usuarios.Add("vaguinho");

            return Ok(usuarios);
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
