using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHTLesson08.Models;
using System.Security.Principal;

namespace NHTLesson08.Controllers
{
    public class NHTAccountController : Controller
    {
        private static List<NHTAccount> nhtAccounts = new List<NHTAccount> { 
        new NHTAccount{
        NHTId = 1,
        NHTFullName = "Nguyễn Văn A",
        NHTEmail = "nguyenvana@example.com",
        NHTPhone = "0912345678",
        NHTAddress = "123 Lê Lợi, Hà Nội",
        NHTAvatar = "avatar1.jpg",
        NHTBirthday = new DateTime(1995, 5, 10),
        NHTGender = "Nam",
        NHTPassword = "Password123!",
        NHTFacebook = "https://facebook.com/nguyenvana"
        },
        new NHTAccount
    {
        NHTId = 2,
        NHTFullName = "Trần Thị B",
        NHTEmail = "tranthib@example.com",
        NHTPhone = "0987654321",
        NHTAddress = "456 Trần Hưng Đạo, TP.HCM",
        NHTAvatar = "avatar2.jpg",
        NHTBirthday = new DateTime(1998, 3, 22),
        NHTGender = "Nữ",
        NHTPassword = "Abc@123456",
        NHTFacebook = "https://facebook.com/tranthib"
    },
    new NHTAccount
    {
        NHTId = 3,
        NHTFullName = "Lê Văn C",
        NHTEmail = "levanc@example.com",
        NHTPhone = "0909123456",
        NHTAddress = "789 Lý Thường Kiệt, Đà Nẵng",
        NHTAvatar = "avatar3.jpg",
        NHTBirthday = new DateTime(1990, 12, 5),
        NHTGender = "Nam",
        NHTPassword = "SecureP@ss1",
        NHTFacebook = "https://facebook.com/levanc"
    },
    new NHTAccount
    {
        NHTId = 4,
        NHTFullName = "Phạm Thị D",
        NHTEmail = "phamthid@example.com",
        NHTPhone = "0938123123",
        NHTAddress = "321 Nguyễn Huệ, Huế",
        NHTAvatar = "avatar4.png",
        NHTBirthday = new DateTime(1997, 9, 17),
        NHTGender = "Nữ",
        NHTPassword = "Pass!45678",
        NHTFacebook = "https://facebook.com/phamthid"
    },
    new NHTAccount
    {
        NHTId = 5,
        NHTFullName = "Đỗ Văn E",
        NHTEmail = "dovane@example.com",
        NHTPhone = "0968123456",
        NHTAddress = "12 Hai Bà Trưng, Cần Thơ",
        NHTAvatar = "avatar5.jpg",
        NHTBirthday = new DateTime(1992, 11, 30),
        NHTGender = "Nam",
        NHTPassword = "Epassword#1",
        NHTFacebook = "https://facebook.com/dovane"
    }
    };
        // GET: NHTAccountController
        public ActionResult NHTIndex()
        {
            return View(nhtAccounts); // Truyền danh sách vào View
        }


        // GET: NHTAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NHTAccountController/Create
        public ActionResult NHTCreate()
        {
            return View(nhtAccounts);
        }

        // POST: NHTAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NHTIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NHTAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NHTAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NHTIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NHTAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NHTAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(NHTIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
