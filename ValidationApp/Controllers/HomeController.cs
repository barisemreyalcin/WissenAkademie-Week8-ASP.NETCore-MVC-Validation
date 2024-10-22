using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidationApp.Models;

namespace ValidationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SystemUser user)
        {
            // tüm validationlardan geçti mi diye kontrol amaçlý kullanýyorum alttakini
            if (ModelState.IsValid)
                return RedirectToAction("SystemUser", user); // action, model

            return View();
        }

        public IActionResult SystemUser(SystemUser user)
        {
            return View(user);
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
