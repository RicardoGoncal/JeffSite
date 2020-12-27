using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JeffSite.Models;
using JeffSite.Services;

namespace JeffSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserService _userService;
        private readonly ConfiguracaoService _configuracaoService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserService userService, ConfiguracaoService configuracaoService)
        {
            _logger = logger;
            _userService = userService;
            _configuracaoService = configuracaoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BioCompleta()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult SendEmail(string NameContact){
            string email = _configuracaoService.FindAdminEmail();
            return View("Contato");
        }
    }
}
