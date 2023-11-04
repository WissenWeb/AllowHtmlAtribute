using AllowHtmlAtribute.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllowHtmlAtribute.Controllers
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

            HomeViewModel model = new HomeViewModel();
            model.HtmlData = "<h1>Deneme</h1><br><p>Raw deneme</p>";
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return View();

            if (ModelState.IsValid)
            { 
            
            
            
            
            
            }
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