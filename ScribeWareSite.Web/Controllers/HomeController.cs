using Microsoft.AspNetCore.Mvc;
using ScribeWareSite.Web.Models;
using ScribewareSite.Lib.Models;
using System.Diagnostics;

namespace ScribeWareSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();

        public IActionResult About() => View();
        [HttpGet]
        public IActionResult Contact() => View();

        [HttpPost]
        public IActionResult Contact(User user)
        {
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
