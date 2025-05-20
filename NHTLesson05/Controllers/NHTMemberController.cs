using NHTLesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using NHTLesson05.Models.DataModels;
using System;

namespace NHTLesson05.Controllers
{
    public class NHTMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NHTGetMember()
        {
            // tạo đối tượng sử dụng Model Member
            var nhtMember = new NHTMember();
            // khởi tạo dữ liệu cho đối tượng
            nhtMember.NHTMemberId = Guid.NewGuid().ToString();
            nhtMember.NHTMemberUsername = "Ngyn";
            nhtMember.NHTMemberFullname = "Nguyễn Hương Trà";
            nhtMember.NHTMemberPassword = "123456";
            nhtMember.NHTMemberEmail = "nguyentra8704@gmail.com";
            ViewBag.nhtMember = nhtMember;

            return View();
        }
    }
}
