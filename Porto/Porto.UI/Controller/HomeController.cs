using Microsoft.AspNetCore.Mvc;

namespace Porto.UI.Controller
{
	public class HomeController : ControllerBase
	{
		[Route("home/index")]
		public IActionResult Index()
		{
			return Ok("Hello World from a controller");
		}

		[Route("home/product")]
		public IActionResult Product()
		{
			return Ok("Product Calisti");
		}
	}
}
