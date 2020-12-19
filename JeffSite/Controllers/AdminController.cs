using JeffSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JeffSite.Services;

namespace JeffSite.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserService _userService;

        public AdminController(UserService userService){
            _userService = userService;
        }


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
        public IActionResult ValidarUsuario(User userLogged)
        {
            bool validUser = _userService.ValidateUser(userLogged);
            if (validUser)
            {
                HttpContext.Session.SetString("userLogged", userLogged.user);
                return RedirectToAction(nameof(AdminHome), userLogged);
            }
            HttpContext.Session.SetString("userLogged", "");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deslogar()
        {
            HttpContext.Session.SetString("userLogged", "");
            return RedirectToAction(nameof(Index));
        }

    }
}
