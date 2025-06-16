using Microsoft.AspNetCore.Mvc;
using NHTLesson09.Models;
using System.Diagnostics;

namespace NHTLesson09.Controllers
{
    public class nHTHomeController : Controller
    {
        private readonly ILogger<nHTHomeController> _logger;

        public nHTHomeController(ILogger<nHTHomeController> logger)
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
