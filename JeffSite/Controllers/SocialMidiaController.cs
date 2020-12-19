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

        public SocialMidiaController(UserService userService, SocialMidiaService socialMidiaService){
            _userService = userService;
            _socialMidiaService = socialMidiaService;
        }

        public IActionResult Index()
        {
            var userLogged = HttpContext.Session.GetString("userLogged");
            if (userLogged == "" || userLogged == null)
            {
                return RedirectToAction("Index","Admin");
            }
            var socialMidias = _socialMidiaService.FindAll();
            return View(socialMidias);
        }

    }
}
