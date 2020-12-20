using JeffSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JeffSite.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JeffSite.Controllers
{
    public class SocialMidiaController : Controller
    {
        private readonly UserService _userService;
        private readonly SocialMidiaService _socialMidiaService;

        public SocialMidiaController(UserService userService, SocialMidiaService socialMidiaService)
        {
            _userService = userService;
            _socialMidiaService = socialMidiaService;
        }

        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            var socialMidias = _socialMidiaService.FindAll();
            return View(socialMidias);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Criar";
                return View();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SocialMidia socialMidia)
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            if (ModelState.IsValid)
            {
                _socialMidiaService.Create(socialMidia);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            ViewData["Title"] = "Deletar";
            var social = _socialMidiaService.FindByName(name);
            return View(social);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(SocialMidia socialMidia)
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index", "Admin");
            }
            _socialMidiaService.Delete(socialMidia);
            return RedirectToAction("Index");
        }

    }
}
