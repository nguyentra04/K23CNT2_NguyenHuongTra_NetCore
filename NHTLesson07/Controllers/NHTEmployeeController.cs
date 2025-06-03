using Microsoft.AspNetCore.Mvc;
using NHTLesson07.Models;

namespace NHTLesson07.Controllers
{
    public class NHTEmployeeController : Controller
    {
        private List<NHTEmployee> nhtlistemployee = new List<NHTEmployee>
{
    new NHTEmployee
    {
        NHTId = 1,
        NHTName = "Nguyen Van A",
        NHTBirthDay = new DateTime(1990, 5, 12),
        NHTEmail = "nguyenvana@example.com",
        NHTPhone = "0901234567",
        NHTSalary = 15000000m,
        NHTStatus = true
    },
    new NHTEmployee
    {
        NHTId = 2,
        NHTName = "Tran Thi B",
        NHTBirthDay = new DateTime(1988, 8, 23),
        NHTEmail = "tranthib@example.com",
        NHTPhone = "0912345678",
        NHTSalary = 18000000m,
        NHTStatus = false
    },
    new NHTEmployee
    {
        NHTId = 3,
        NHTName = "Le Van C",
        NHTBirthDay = new DateTime(1995, 12, 1),
        NHTEmail = "levanc@example.com",
        NHTPhone = "0923456789",
        NHTSalary = 12000000m,
        NHTStatus = true
    },
    new NHTEmployee
    {
        NHTId = 4,
        NHTName = "Pham Thi D",
        NHTBirthDay = new DateTime(1992, 3, 19),
        NHTEmail = "phamthid@example.com",
        NHTPhone = "0934567890",
        NHTSalary = 20000000m,
        NHTStatus = true
    },
    new NHTEmployee
    {
        NHTId = 5,
        NHTName = "Hoang Van E",
        NHTBirthDay = new DateTime(1985, 7, 30),
        NHTEmail = "hoangvane@example.com",
        NHTPhone = "0945678901",
        NHTSalary = 17000000m,
        NHTStatus = false
    }
};

        public ActionResult NHTIndex()
        {
            return View(nhtlistemployee);
        }
        // GET: /NHTEmployee/NHTDetails/1
        public ActionResult NHTDetails(int id)
        {
            var nhtEmployee = nhtlistemployee.FirstOrDefault(x => x.NHTId == id);
            return View(nhtEmployee);
        }

        // GET: /NHTEmployee/NHTCreate
        public ActionResult NHTCreate()
        {
            var nhtEmployee = new NHTEmployee();
            return View(nhtEmployee);
        }

        // POST: /NHTEmployee/NHTCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NHTCreate(NHTEmployee NHTModel)
        {
            try
            {
                NHTModel.NHTId = nhtlistemployee.Max(x => x.NHTId);
                    nhtlistemployee.Add(NHTModel);
                return RedirectToAction(nameof(NHTIndex));

            }
            catch
            {
                return View();
            }

        }
        public ActionResult NHTEdit(int id)
        {
            var nhtEmployee = nhtlistemployee.FirstOrDefault(x => x.NHTId == id);
            return View(nhtEmployee);
        }

        // POST: NHTEmployeeController/NHTEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NHTEdit(int id, NHTEmployee NHTModel)
        {
            try
            {
                for (int i = 0; i < nhtlistemployee.Count(); i++)
                {
                    if (nhtlistemployee[i].NHTId == id)
                    {
                        nhtlistemployee[i] = NHTModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(NHTIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NHTEmployeeController/Delete/5
        public ActionResult NHTDelete(int id)
        {
            return View();
        }

        // POST: NHTEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NHTDelete(int id, IFormCollection collection)
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
    
