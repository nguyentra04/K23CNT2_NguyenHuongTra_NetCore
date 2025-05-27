using Microsoft.AspNetCore.Mvc;
using NHTLesson06.Models;

namespace NHTLesson06.Controllers
{
    public class NHTEmployeeController : Controller
    {
        private static List<NHTEmployee> NHTListEmployee = new List<NHTEmployee>
        {
            new NHTEmployee { NHTId = "EMP001", NHTName = "Nguyen Van A", NHTBirthDay = new DateTime(1985, 1, 15), NHTEmail = "a.nguyen@example.com", NHTPhone = "0901000001", NHTSalary = 15000000, NHTStatus = true },
            new NHTEmployee { NHTId = "EMP002", NHTName = "Tran Thi B", NHTBirthDay = new DateTime(1990, 3, 22), NHTEmail = "b.tran@example.com", NHTPhone = "0902000002", NHTSalary = 12000000, NHTStatus = true },
            new NHTEmployee { NHTId = "EMP003", NHTName = "Le Van C", NHTBirthDay = new DateTime(1992, 7, 30), NHTEmail = "c.le@example.com", NHTPhone = "0903000003", NHTSalary = 10000000, NHTStatus = false },
            new NHTEmployee { NHTId = "EMP004", NHTName = "Pham Thi D", NHTBirthDay = new DateTime(1988, 5, 10), NHTEmail = "d.pham@example.com", NHTPhone = "0904000004", NHTSalary = 18000000, NHTStatus = true },
            new NHTEmployee { NHTId = "EMP005", NHTName = "Sinh Vien E", NHTBirthDay = new DateTime(2002, 11, 25), NHTEmail = "e.sinhvien@example.com", NHTPhone = "0905000005", NHTSalary = 3000000, NHTStatus = false },
            new NHTEmployee { NHTId = "EMP006", NHTName = "Doan Van F", NHTBirthDay = new DateTime(1991, 9, 18), NHTEmail = "f.doan@example.com", NHTPhone = "0906000006", NHTSalary = 14000000, NHTStatus = true },
            new NHTEmployee { NHTId = "EMP007", NHTName = "Ngo Thi G", NHTBirthDay = new DateTime(1989, 12, 9), NHTEmail = "g.ngo@example.com", NHTPhone = "0907000007", NHTSalary = 16000000, NHTStatus = true },
            new NHTEmployee { NHTId = "EMP008", NHTName = "Bui Van H", NHTBirthDay = new DateTime(1994, 6, 3), NHTEmail = "h.bui@example.com", NHTPhone = "0908000008", NHTSalary = 11000000, NHTStatus = false },
            new NHTEmployee { NHTId = "EMP009", NHTName = "Hoang Thi I", NHTBirthDay = new DateTime(1996, 4, 28), NHTEmail = "i.hoang@example.com", NHTPhone = "0909000009", NHTSalary = 9500000, NHTStatus = true },
            new NHTEmployee { NHTId = "EMP010", NHTName = "Dang Van J", NHTBirthDay = new DateTime(1987, 2, 14), NHTEmail = "j.dang@example.com", NHTPhone = "0910000010", NHTSalary = 17000000, NHTStatus = true }
        };

        public IActionResult NHTIndex()
        {
            return View(NHTListEmployee);
        }

        public IActionResult NHTCreate()
        {
            return View();
        }

        public IActionResult NHTCreateSubmit(NHTEmployee newEmployee)
        {
            if (ModelState.IsValid)
            {
                NHTListEmployee.Add(newEmployee);
                return RedirectToAction("NHTIndex");
            }
            return View("NHTCreate", newEmployee);
        }

        public IActionResult NHTEdit(string id)
        {
            var employee = NHTListEmployee.FirstOrDefault(e => e.NHTId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult NHTEditSubmit(NHTEmployee updatedEmployee)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = NHTListEmployee.FirstOrDefault(e => e.NHTId == updatedEmployee.NHTId);
                if (existingEmployee == null)
                {
                    return NotFound();
                }

                existingEmployee.NHTName = updatedEmployee.NHTName;
                existingEmployee.NHTBirthDay = updatedEmployee.NHTBirthDay;
                existingEmployee.NHTEmail = updatedEmployee.NHTEmail;
                existingEmployee.NHTPhone = updatedEmployee.NHTPhone;
                existingEmployee.NHTSalary = updatedEmployee.NHTSalary;
                existingEmployee.NHTStatus = updatedEmployee.NHTStatus;

                return RedirectToAction("NHTIndex");
            }
            return View("NHTEdit", updatedEmployee);
        }

        public IActionResult NHTDelete(string id)
        {
            var emp = NHTListEmployee.FirstOrDefault(e => e.NHTId == id);
            if (emp == null)
            {
                return NotFound();
            }

            NHTListEmployee.Remove(emp);
            return RedirectToAction("NHTIndex");
        }
    }
}