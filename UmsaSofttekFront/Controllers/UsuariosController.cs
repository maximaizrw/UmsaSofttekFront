using Data.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UmsaSofttekFront.ViewModels;

namespace UmsaSofttekFront.Controllers
{
    public class UsuariosController : Controller
    {
        [Authorize]
        public IActionResult Usuarios()
        {
            return View();
        }

        public async Task<IActionResult> UsuariosAddPartial([FromBody] UsuarioDto usuario)
        {
            var usuariosViewModel = new UsuariosViewModel();
            if (usuario != null)
            {
                usuariosViewModel = usuario;
            }

            return PartialView("~/Views/Usuarios/Partial/UsuariosAddPartial.cshtml", usuariosViewModel);
        }
    }
}
