using Microsoft.AspNetCore.Mvc;

namespace NHTLesson02.Controllers
{
    public class NHTProductController : Controller
    {
        public IActionResult NHTIndex()
        {
            ViewData["messageData"] = "dữ liệu từ view data";
            ViewBag.messageData = "dữ liệu từ viewbag";
            TempData["messageData"] = "dữ liệu từ tempdata";
            return View();

        }
    }
}

