using JeffSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JeffSite.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JeffSite.Controllers
{
    public class ConfiguracaoController : Controller
    {
        private readonly UserService _userService;
        private readonly ConfiguracaoService _configuracaoService;

        public ConfiguracaoController(UserService userService, ConfiguracaoService configuracaoService)
        {
            _userService = userService;
            _configuracaoService = configuracaoService;
        }

        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            ViewData["Title"] = "Configurações do site";
            var configs = _configuracaoService.Find();
            return View(configs);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Configuracao configuracao)
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            _configuracaoService.Edit(configuracao);
            TempData["message"] = "Alterado com sucesso!";
            return RedirectToAction("Index");
        }

    }
}
