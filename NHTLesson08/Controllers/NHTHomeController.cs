using Microsoft.AspNetCore.Mvc;
using NHTLesson08.Models;
using System.Diagnostics;

namespace NHTLesson08.Controllers
{
    public class NHTHomeController : Controller
    {
        private readonly ILogger<NHTHomeController> _logger;

        public NHTHomeController(ILogger<NHTHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NHTIndex()
        {
            return View();
        }

        public IActionResult NHTAbout()
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
