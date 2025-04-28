using Microsoft.AspNetCore.Mvc;

namespace MyAppNHT.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
