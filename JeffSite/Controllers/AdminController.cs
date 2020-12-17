using JeffSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JeffSite.Controllers
{
    public class AdminController : Controller
    {
        


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminHome()
        {
            var usuarioLogado = HttpContext.Session.GetString("UsuarioLogado");
            if (usuarioLogado == "" || usuarioLogado == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidarUsuario(Usuario usuarioLogado)
        {
            bool testausuario = new Usuario().VerificaUsuario(usuarioLogado);
            if (testausuario)
            {
                HttpContext.Session.SetString("UsuarioLogado", usuarioLogado.usuario);
                return RedirectToAction(nameof(AdminHome), usuarioLogado);
            }
            HttpContext.Session.SetString("UsuarioLogado", "");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deslogar()
        {
            HttpContext.Session.SetString("UsuarioLogado", "");
            return RedirectToAction(nameof(Index));
        }

    }
}
