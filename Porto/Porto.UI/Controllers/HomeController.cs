using Microsoft.AspNetCore.Mvc;
using Porto.MODEL;
using Porto.UI.Models;
using System.Diagnostics;

namespace Porto.UI.Controllers
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
			ViewBag.SayfaAdi = "Anasayfaya hoşgeldiniz";
            return View();
		}

		public IActionResult Product()
		{
			return View();
		}

        public IActionResult Product2()
        {
            return View();
        }

		public IActionResult ProductDetail()
		{
			return View();
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

        public IActionResult About()
        {
            return View();
        }
    }
}