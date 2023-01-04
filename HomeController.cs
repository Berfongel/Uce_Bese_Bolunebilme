using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UceBeseTamBölünmeWebApplication.Models;

namespace UceBeseTamBölünmeWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(UceBeseBölünme uceBeseBölünme)
        {
            var bolum_ = uceBeseBölünme.Sayi;
            var message = string.Empty;
            if (bolum_ % 3 == 0 && bolum_ % 5 == 0)
            {
                message = "Sayı 3 e ve 5 e tam bölünüyor";

            }

            else
            {
                message = "Sayı 3 e ve 5 e tam bölünmüyor";
            }

            ViewBag.Message = message;
            return View("uceBeseBölünme");
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